Public Class Form1
    Dim Labels(8, 8) As Integer
    Dim OLabels(8, 8) As Label
    Dim TryCounter As Integer
    Dim WithEvents bw1 As New System.ComponentModel.BackgroundWorker With {.WorkerReportsProgress = True}
    Dim stp As New Stopwatch
    Dim History As New List(Of Sudoku)
    Dim finished As Boolean = True
    Dim perfCounter As New System.Diagnostics.PerformanceCounter With {.CategoryName = "Processor", .CounterName = "% Processor Time", .InstanceName = "_Total"}
    Dim WithEvents CPUTimer As New Timer With {.Interval = 1000}
    Dim WithEvents UpdateTimer As New Timer With {.Interval = 100}



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TryCounter = 0
        Create_Labels()
        CPUTimer.Start()
        CPUAuslastung()
        UpdateTimer.Start()
        ButtonCancel.Enabled = False
        GroupBoxSchw.Enabled = False
        GroupBoxSave.Enabled = False
        SetStatus("Loading .... 100%")

        TrackBarHZOO.Enabled = False
        TrackBarQUOO.Enabled = False
        TrackBarVTOO.Enabled = False
        CheckBoxMAS.Enabled = False
    End Sub

    Dim LastMousePosition As New Point
    Private Sub ToolTip(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles GroupBoxSodoku.MouseMove
        If (e.Location = LastMousePosition) = False Then

            ToolTipSudoku.Show(LevelInfo, GroupBoxSodoku, e.Location, 1000000)
            LastMousePosition = e.Location
        End If

        Try
            If Me.GetChildAtPoint(e.Location).Name <> GroupBoxSodoku.Name Then
                ToolTipSudoku.Hide(GroupBoxSodoku)
            End If
        Catch
            ToolTipSudoku.Hide(GroupBoxSodoku)
        End Try

    End Sub

    Private Sub Start() Handles ButtonGenerate.Click, ToolStripGenerate.Click

        SetStatus("Starting Operation")
        While finished = False
            System.Threading.Thread.Sleep(1)
            Application.DoEvents()
            SetStatus("Waiting for Process To Complete...")
        End While

        If Not bw1.IsBusy Then
            finished = False
            TSClear()
            stp.Reset()
            stp.Start()
            Me.UseWaitCursor = True
            bw1.RunWorkerAsync()
            ButtonGenerate.Enabled = False
            ButtonCancel.Enabled = True
            GroupBoxSchw.Enabled = False
            GroupBoxSave.Enabled = False
        End If

        While finished = False
            System.Threading.Thread.Sleep(1)
            Application.DoEvents()
            SetStatus("Waiting for Process To Complete...")
        End While

        SetStatus()

    End Sub


    Private Sub Completed() Handles bw1.RunWorkerCompleted
        SetStatus("Process Completed!")
        bw1.Dispose()
        Me.UseWaitCursor = False
        For a = 0 To 8
            For b = 0 To 8
                OLabels(a, b).Text = Labels(a, b)
            Next
        Next
        ButtonCancel.Enabled = False
        ButtonGenerate.Enabled = True
        GroupBoxSchw.Enabled = True
        GroupBoxSave.Enabled = True


        'Prüft, ob in dieser Instanz der Anwendung schon einmal das selbe Sudoku generiert wurde.
        Dim already_created As Boolean = False
        For Each l As Sudoku In History
            Dim counter As Integer = 0
            For y = 0 To 8
                For x = 0 To 8
                    If l.ReturnField(y, x) = Labels(y, x) Then
                        counter = counter + 1
                    End If
                Next
            Next

            If counter = 64 Then
                already_created = True
            End If
        Next
        If Not already_created Then
            History.Add(New Sudoku(Labels))
            SchwierigkeitGesamt()
        Else
            SetStatus("Already created that Sudoku. Restart.")
            Start()
        End If

        finished = True

    End Sub


    Private Sub write(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bw1.ProgressChanged
        ProgressBarGenerate.Value = e.ProgressPercentage
        LabelPrg.Text = Str(e.ProgressPercentage) + "%"
        LabelTries.Text = ConvertNumber(TryCounter)

        UpdateLabels()

        LabelTime.Text = CStr(stp.ElapsedMilliseconds / 1000) + "s"
        SetStatus("Writing Progress")

    End Sub

    Private Sub UpdateLabels()
        For a = 0 To 8
            For b = 0 To 8
                OLabels(a, b).Text = Labels(a, b)
            Next
        Next
    End Sub

    Private Sub Generate() Handles bw1.DoWork
        Dim restart As Boolean = True
        TryCounter = 0

        Clear()


        While restart = True

            For y = 0 To 8

                restart = True
                Dim tries_row As Integer = 0

                'Die Reihe wird bis zu 99 Mal neu generiert, bis sie aufgegeben wird und das ganze Sodoku neu angefangen wird
                While restart = True
                    tries_row = tries_row + 1

                    If tries_row > 100 Then
                        Clear()
                        Exit For
                    End If


                    'DIe aktuelle Reihe wird  vorbereitet
                    Clear(y, y)
                    restart = False
                    TryCounter = TryCounter + 1

                    'Für jedes Feld wird ausgeführt
                    For x = 0 To 8


                        'Die Liste mit allen Zahlen, die nicht dran kommen dürfen
                        Dim l As New List(Of Integer)

                        'Alle vor der Zahl in horizontaler Richtung

                        For a = 0 To x - 1
                            l.Add(Labels(y, a))
                        Next

                        'Die Vertikale Richtung wird geprüft

                        For a = 0 To y - 1
                            l.Add(Labels(a, x))
                        Next


                        'Die kleinen Quadrate werden geprüft
                        For a = xPosToRectNum(x) * 3 To xPosToRectNum(x) * 3 + 2
                            If y = 0 Or y = 3 Or y = 6 Then
                                'Die Reihe fängt gerade ein vertikales Quadrat an
                                l.Add(Labels(y, a))
                                l.Add(Labels(y + 1, a))
                                l.Add(Labels(y + 2, a))

                            ElseIf y = 1 Or y = 4 Or y = 7 Then
                                'Die Reihe ist in der Mitte eines vertikalen Quadrates
                                l.Add(Labels(y - 1, a))
                                l.Add(Labels(y, a))
                                l.Add(Labels(y + 1, a))

                            ElseIf y = 2 Or y = 5 Or y = 8 Then

                                'Die Reihe ist am Ende eines vertikalen Quadrates
                                l.Add(Labels(y, a))
                                l.Add(Labels(y - 1, a))
                                l.Add(Labels(y - 2, a))

                            End If

                        Next


                        'Rdm () wird ausgeführt 
                        Dim i As Integer = Rdm(l)
                        If i <> Nothing And i < 10 Then
                            Labels(y, x) = i
                            bw1.ReportProgress(((y / 8) * 100))
                            Application.DoEvents()
                            restart = False
                        ElseIf i = 403 Then
                            restart = True
                            Exit For
                        End If
                    Next
                End While

            Next
        End While
        stp.Stop()



    End Sub

    Private Function xPosToRectNum(xPos As Integer)
        'Gibt zurück, in welchem Horizontalen Bereich sich die Angegebene X-Pos befindet
        If 0 <= xPos And 2 >= xPos Then
            Return 0
        ElseIf 2 < xPos And 5 >= xPos Then
            Return 1
        Else
            Return 2
        End If
    End Function

    Private Function Rdm(Optional l As List(Of Integer) = Nothing) As Integer
        Dim PossibleNumb As New List(Of Integer)({1, 2, 3, 4, 5, 6, 7, 8, 9})

        'Aus der Liste der Möglichkeiten wird jedes Element aus der Liste der nicht möglichen gelöscht
        For b = 1 To 9
            If l.Contains(b) Then
                If PossibleNumb.Contains(b) Then
                    PossibleNumb.Remove(b)
                End If
            End If
        Next


        'Generiert die Zufallszahl
        Dim a As Integer = Int(PossibleNumb.Count * Rnd())

        'Wenn es keine Möglichkeiten mehr gibt dann wird der Fehldercode 403 zurückgegeben
        If PossibleNumb.Count = 0 Then
            Return 403
        End If

        Return PossibleNumb(a)
    End Function

    Private Sub Create_Labels()
        Dim f As New Font("Microsoft Sans Serif", 18, FontStyle.Bold)
        'Alle 81 Labels werden definiert
        For y = 0 To 8
            For x = 0 To 8
                'Label Eingenschaften werden definiert
                OLabels(y, x) = New Label
                OLabels(y, x).Font = f
                OLabels(y, x).Size = New Size(21, 24)
                OLabels(y, x).BackColor = Color.Transparent
                OLabels(y, x).Location = New Point(65 * x + 30, 65 * y + 30)
                OLabels(y, x).Parent = GroupBoxSodoku
                OLabels(y, x).Text = ""

            Next
        Next
    End Sub



    'Alle Labels werden zurückgesetzt und die Datenbank gelöscht
    Private Sub TSClear() Handles ToolStripClear.Click
        For a = 0 To 8
            For b = 0 To 8
                OLabels(a, b).Text = ""
                Labels(a, b) = 0
            Next
        Next
        GroupBoxSave.Enabled = False
        GroupBoxSchw.Enabled = False
        LabelPrg.Text = ""
        ProgressBarGenerate.Value = 0
        LabelTime.Text = ""
        LabelTries.Text = ""
        SetStatus("Clearing...")
        For Each l As Label In AllHidingNumbers()
            l.Visible = True


        Next
    End Sub

    Private Sub Clear(Optional Start As Integer = 0, Optional Ende As Integer = 8)
        For a = Start To Ende
            For b = 0 To 8
                Labels(a, b) = 0

            Next
        Next


    End Sub


    Public Function ConvertNumber(numb As Integer) As String
        Dim Einheiten As New List(Of String)
        Einheiten.Add("")
        Einheiten.Add("K")
        Einheiten.Add("Mio.")
        Einheiten.Add("Mrd.")

        Dim Einheit As Integer = Math.Floor((CStr(numb).Length - 1) / 3)
        Dim t As String = (CStr((numb / (Math.Pow(1000, Einheit)))) + "    ").Substring(0, 3) + Einheiten.Item(Einheit)

        Return t
    End Function



    Private Sub Save(sender As Object, e As EventArgs) Handles Button1.Click

        Dim dlg As New System.Windows.Forms.SaveFileDialog
        dlg.AddExtension = True
        dlg.DefaultExt = ".png"
        dlg.Title = "Select Save Location"
        dlg.Filter = ".png | *.png"
        dlg.FileName = "Sodoku.png"
        Dim r As New Windows.Forms.DialogResult
        r = dlg.ShowDialog()

        If r = Windows.Forms.DialogResult.OK Then

            MsgBox(dlg.FileName)
            Dim btm As New Bitmap(GroupBoxSodoku.Size.Width + 5, GroupBoxSodoku.Size.Height + 8)
            GroupBoxSodoku.DrawToBitmap(btm, New Rectangle(GroupBoxSodoku.Location, GroupBoxSodoku.Size))
            btm.Save(dlg.FileName)
        End If
        SetStatus("Saved Sudoku to: " + dlg.FileName)

    End Sub

    Dim HZOO_Labels As New List(Of Windows.Forms.Label)

    Private Sub HZOO()


        'Alter Zustand wird wiederhergestellt
        For Each e As Label In HZOO_Labels
            e.Visible = True
        Next


        HZOO_Labels.Clear()


        'HZOO --> Horizontal Only-One Algo
        'In jeder Horizontalen Reihe kann ein Feld gelöscht werden --> Es ist klar, welche Zahl da hin kommt
        'For g = 0 To TrackBarHZOO.Value * 4
        For y = 0 To 8
            Dim x As Integer = Int(9 * Rnd())

            Dim Counter As Integer = 0
            Dim numbers As New List(Of Integer)({1, 2, 3, 4, 5, 6, 7, 8, 9})
            For a = 0 To 8
                If numbers.Contains(Int(OLabels(y, a).Text)) And HZOO_Labels.Contains(OLabels(y, a)) = False Then
                    numbers.Remove(Labels(y, a))
                End If

            Next

            If numbers.Count = 0 And Not QUOO_Labels.Contains(OLabels(x, y)) And Not MAS_Labels.Contains(OLabels(x, y)) And Not VTOO_Labels.Contains(OLabels(x, y)) Then
                HZOO_Labels.Add(OLabels(y, x))
            End If

            Me.Update()
        Next

        SetStatus("Finished HZOO Algo")
        For Each l As Label In HZOO_Labels
            l.Visible = False

        Next
        'Next


    End Sub


    Dim VTOO_Labels As New List(Of Windows.Forms.Label)

    Private Sub VTOO()


        'Alter Zustand wird wiederhergestellt
        For Each e As Label In VTOO_Labels
            e.Visible = True
        Next


        VTOO_Labels.Clear()


        'HZOO --> Horizontal Only-One Algo
        'In jeder Horizontalen Reihe kann ein Feld gelöscht werden --> Es ist klar, welche Zahl da hin kommt
        'For i = 1 To Math.Pow(TrackBarVTOO.Value, 3)
        For y = 0 To 8
            Dim x As Integer = Int(9 * Rnd())

            Dim Counter As Integer = 0
            Dim numbers As New List(Of Integer)({1, 2, 3, 4, 5, 6, 7, 8, 9})
            For a = 0 To 8
                If numbers.Contains(OLabels(a, x).Text) And VTOO_Labels.Contains(OLabels(a, x)) = False Then
                    numbers.Remove(Labels(a, x))
                End If

            Next

            If numbers.Count = 0 And Not QUOO_Labels.Contains(OLabels(x, y)) And Not HZOO_Labels.Contains(OLabels(x, y)) And Not MAS_Labels.Contains(OLabels(x, y)) Then
                VTOO_Labels.Add(OLabels(y, x))
            End If


        Next

        For Each l As Label In VTOO_Labels
            l.Visible = False

        Next

        'Next
        SetStatus("Finished VTOO Algo")





    End Sub

    Dim QUOO_Labels As New List(Of Windows.Forms.Label)
    Private Sub QUOO()

        'Alter Zustand wird wiederhergestellt
        For Each e As Label In QUOO_Labels
            e.Visible = True
        Next


        QUOO_Labels.Clear()


        'HZOO --> Horizontal Only-One Algo
        'In jeder Horizontalen Reihe kann ein Feld gelöscht werden --> Es ist klar, welche Zahl da hin kommt
        For i = 1 To Math.Pow(TrackBarQUOO.Value, 4)
            Dim x As Integer = Int(9 * Rnd())
            Dim y As Integer = Int(9 * Rnd())
            Dim Counter As Integer = 0
            Dim numbers As New List(Of Integer)({1, 2, 3, 4, 5, 6, 7, 8, 9})


            'Die kleinen Quadrate werden geprüft
            For a = xPosToRectNum(x) * 3 To xPosToRectNum(x) * 3 + 2
                If y = 0 Or y = 3 Or y = 6 Then
                    'Die Reihe fängt gerade ein vertikales Quadrat an

                    If Not QUOO_Labels.Contains(OLabels(y, a)) Then
                        numbers.Remove(Labels(y, a))
                    End If

                    If Not QUOO_Labels.Contains(OLabels(y + 1, a)) Then
                        numbers.Remove(Labels(y + 1, a))
                    End If

                    If Not QUOO_Labels.Contains(OLabels(y + 2, a)) Then
                        numbers.Remove(Labels(y + 2, a))
                    End If


                ElseIf y = 1 Or y = 4 Or y = 7 Then
                    'Die Reihe ist in der Mitte eines vertikalen Quadrates
                    If Not QUOO_Labels.Contains(OLabels(y - 1, a)) Then
                        numbers.Remove(Labels(y - 1, a))
                    End If

                    If Not QUOO_Labels.Contains(OLabels(y, a)) Then
                        numbers.Remove(Labels(y, a))
                    End If

                    If Not QUOO_Labels.Contains(OLabels(y + 1, a)) Then
                        numbers.Remove(Labels(y + 1, a))
                    End If

                ElseIf y = 2 Or y = 5 Or y = 8 Then

                    'Die Reihe ist am Ende eines vertikalen Quadrates

                    If Not QUOO_Labels.Contains(OLabels(y, a)) Then
                        numbers.Remove(Labels(y, a))
                    End If

                    If Not QUOO_Labels.Contains(OLabels(y - 1, a)) Then
                        numbers.Remove(Labels(y - 1, a))
                    End If

                    If Not QUOO_Labels.Contains(OLabels(y - 2, a)) Then
                        numbers.Remove(Labels(y - 2, a))
                    End If

                End If

            Next

            SetStatus("Finished QUOO Algo")

            If numbers.Count = 0 And Not MAS_Labels.Contains(OLabels(x, y)) And Not HZOO_Labels.Contains(OLabels(x, y)) And Not VTOO_Labels.Contains(OLabels(x, y)) Then
                QUOO_Labels.Add(OLabels(y, x))
            End If

            Me.Update()
        Next



        For Each l As Label In QUOO_Labels
            l.Visible = False

        Next
    End Sub

    Dim MAS_Labels As New List(Of Windows.Forms.Label)
    Private Sub MasterAlgo()
        If CheckBoxMAS.Checked = False Then
            Exit Sub

        End If

        For Each l As Label In MAS_Labels
            l.Visible = True
        Next
        MAS_Labels.Clear()

        If TrackBarGes.Value = 6 Then
            Exit Sub
        End If



        For y = 0 To 8
            For x1 = 0 To 8

                'Sucht ein Feld aus, dass noch sichbar ist

                If OLabels(y, x1).Visible = True Then

                    Dim zahl As Integer = Labels(y, x1)
                    Dim Lücken As Integer = 0
                    Dim Lücken_With_zahl = 0
                    'Prüft, wie viele Lücken in  Reihe sind
                    For x2 = 0 To 8

                        If OLabels(y, x2).Visible = False Then
                            Lücken = Lücken + 1
                            'Bei der x-Position von der Lücke werden alle y-Positionen auf die Zahl durchsucht, d.h. diese Lücke kommt für das Einsetzen der Zahl nicht in Frage
                            For y2 = 0 To 8
                                If OLabels(y2, x2).Visible And Labels(y2, x2) = zahl Then
                                    Lücken_With_zahl = Lücken_With_zahl + 1
                                End If
                            Next

                        End If

                    Next

                    If Lücken = Lücken_With_zahl And Lücken > 0 Then

                        If Not QUOO_Labels.Contains(OLabels(y, x1)) And Not HZOO_Labels.Contains(OLabels(y, x1)) And Not VTOO_Labels.Contains(OLabels(y, x1)) Then
                            MAS_Labels.Add(OLabels(y, x1))
                        End If

                        For Each l As Label In MAS_Labels
                            l.Visible = False
                        Next

                        Me.Update()

                    End If

                End If

            Next
        Next


        SetStatus("Finished MasterAlgo")


    End Sub



    Private Sub SchwierigkeitGesamt() Handles TrackBarGes.ValueChanged

        Dim einfach As Integer = TrackBarGes.Value * 2
        If einfach > 10 Then
            einfach = 10
        End If

        SetStatus("Processing...")
        TrackBarHZOO.Value = einfach
        HZOO()
        TrackBarVTOO.Value = einfach
        VTOO()

        TrackBarQUOO.Value = einfach
        If TrackBarGes.Value > 5 Then
            QUOO()
        End If
         


        If TrackBarGes.Value = 9 Then
            CheckBoxMAS.Checked = True
            MasterAlgo()
        Else
            CheckBoxMAS.Checked = False
        End If

        If TrackBarGes.Value = 0 Then
            For Each l As Label In AllHidingNumbers()
                l.Visible = True
            Next
        End If
        SetStatus("Done")

    End Sub




    Private Sub GroupBoxSodoku_MouseDown(sender As Object, e As EventArgs) Handles GroupBoxSodoku.MouseDown
        Dim f As New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

        For Each l As Label In VTOO_Labels
            l.ForeColor = Color.Blue
            LabelVT.ForeColor = Color.Blue
        Next
        For Each l As Label In HZOO_Labels
            l.ForeColor = Color.Red
            LabelHZ.ForeColor = Color.Red
        Next
        For Each l As Label In QUOO_Labels
            l.ForeColor = Color.Green
            LabelQU.ForeColor = Color.Green
        Next
        For Each l As Label In MAS_Labels
            l.ForeColor = Color.Gold
            LabelMAS.ForeColor = Color.Gold
        Next
        For Each l As Label In AllHidingNumbers()
            l.Font = f

            l.Visible = True

        Next


    End Sub

    



    Private Sub GroupBoxSodoku_MouseUp(sender As Object, e As EventArgs) Handles GroupBoxSodoku.MouseUp
        Dim f As New Font("Microsoft Sans Serif", 18, FontStyle.Bold)

        For Each l As Label In AllHidingNumbers()
            l.Font = f
            l.Visible = False
            l.ForeColor = Color.Black

        Next

        LabelQU.ForeColor = Color.Black
        LabelVT.ForeColor = Color.Black
        LabelHZ.ForeColor = Color.Black
        LabelMAS.ForeColor = Color.Black

    End Sub

    Private Function LevelInfo() As String
        Dim text As String = ""
        Dim hiding_numbers As Integer
        

        For Each l As Label In AllHidingNumbers()
            If l.Visible = False Then
                hiding_numbers = hiding_numbers + 1
            End If
        Next

        text = "Level: " + CStr(TrackBarGes.Value) + vbNewLine + "Hiding Numbers: " + CStr(hiding_numbers) + " (" + CStr(Math.Round((hiding_numbers / 81) * 100)) + "%)"

        Return text
    End Function

    Private Function AllHidingNumbers() As List(Of Windows.Forms.Label)
        Dim all_out As New List(Of Label)

        all_out.AddRange(QUOO_Labels)
        all_out.AddRange(VTOO_Labels)
        all_out.AddRange(HZOO_Labels)
        all_out.AddRange(MAS_Labels)
        Return all_out
    End Function


    Private Sub ButtonSaveMulti_Click(sender As Object, e As EventArgs) Handles ButtonSaveMulti.Click
        Dim dlg As New System.Windows.Forms.FolderBrowserDialog
        dlg.Description = "Please select the folder, where the files should be saved in."
        dlg.ShowNewFolderButton = True

        Dim r As New Windows.Forms.DialogResult
        r = dlg.ShowDialog()
        ProgressBarSaveMulti.Value = 0
        If r = Windows.Forms.DialogResult.OK Then
            Me.UseWaitCursor = True
            GroupBoxSave.Enabled = False
            For x = 0 To NumericUpDownSaveMulti.Value
                While bw1.IsBusy
                    System.Threading.Thread.Sleep(100)
                    Application.DoEvents()
                End While
                Dim btm As New Bitmap(GroupBoxSodoku.Size.Width + 5, GroupBoxSodoku.Size.Height + 8)
                GroupBoxSodoku.DrawToBitmap(btm, New Rectangle(GroupBoxSodoku.Location, GroupBoxSodoku.Size))
                btm.Save(dlg.SelectedPath + "\Sudoku" + CStr(x) + ".png")
                ProgressBarSaveMulti.Value = Int(x / NumericUpDownSaveMulti.Value * 100)
                Me.Update()
                Start()
            Next

        End If
        GroupBoxSave.Enabled = True
        Me.UseWaitCursor = False
        MsgBox("Saved " + CStr(NumericUpDownSaveMulti.Value) + " Sudokus in " + dlg.SelectedPath, MsgBoxStyle.OkOnly, "Saving Coompleted")
        SetStatus("Saved " + CStr(NumericUpDownSaveMulti.Value) + " Sudokus in " + dlg.SelectedPath)
    End Sub

    Private Sub SetStatus(Optional txt As String = "Ready.")
        ToolTipLabelStatus.Text = txt
    End Sub


    Private Sub CPUAuslastung() Handles CPUTimer.Tick
        Dim auslastung As Integer = Integer.Parse(Format(perfCounter.NextValue, "##0"))
        If auslastung > 30 Then
            ToolStripStatusLabelCPU.Font = New Font(ToolStripStatusLabelCPU.Font.Name, ToolStripStatusLabelCPU.Font.Size, FontStyle.Bold)
        Else
            ToolStripStatusLabelCPU.Font = New Font(ToolStripStatusLabelCPU.Font.Name, ToolStripStatusLabelCPU.Font.Size)
        End If
        ToolStripStatusLabelCPU.Text = "CPU Auslastung: " + CStr(auslastung) + "%"
    End Sub

    Private Sub UpdateForm() Handles UpdateTimer.Tick
        Me.Update()
    End Sub

End Class

Public Class Sudoku
    Dim Fields(8, 8) As Integer
    Public Function ReturnField() As Array
        Return Fields
    End Function

    Public Sub New(f As Array)
        Fields = f
    End Sub
End Class





