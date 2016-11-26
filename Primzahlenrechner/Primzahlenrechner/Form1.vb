Imports System.ComponentModel
Public Class Form1
    Dim start As Integer = 0
    Dim ende As Integer = 0
    Dim total As Integer = 0
    Dim progress As Integer = 0
    Dim WithEvents bw As New BackgroundWorker
    Dim sw As New Stopwatch
    



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxAnfang.Text = "1"
        TextBoxEnde.Text = "100"
    
        bw.WorkerSupportsCancellation = True
        bw.RunWorkerAsync()
        Chart1.Series.Add("Prime")


        ' Priorität der eigenen Anwendung auf "hoch" setzen
        SetPriority(PriorityClass.REALTIME_PRIORITY_CLASS)

    End Sub

    

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        If ButtonStart.Text = "Start" Then
            ButtonStart.Text = "Cancel"
            Reset()
            work_controller()

        Else
            bw.CancelAsync()
            ButtonStart.Text = "Start"
        End If




    End Sub

    Public Sub SetLabelTotal(ByVal Text As String)
        If LabelTotal.InvokeRequired Then


            LabelTotal.Invoke(New Action(Of String)(AddressOf SetLabelTotal), Text)

        Else
            LabelTotal.Text = Text
            LabelTotal.Update()


        End If
    End Sub

    Public Sub SetLabelCurrentNumber(ByVal Text As String)
        If LabelCurNum.InvokeRequired Then
            LabelCurNum.Invoke(New Action(Of String)(AddressOf SetLabelCurrentNumber), Text)

        Else
            LabelCurNum.Text = Text

        End If
    End Sub

    Public Sub SetLabelLastPrime(ByVal Text As String)
        If LabelLastPrime.InvokeRequired Then
            LabelLastPrime.Invoke(New Action(Of String)(AddressOf SetLabelLastPrime), Text)

        Else
            LabelLastPrime.Text = Text

        End If
    End Sub

    Public Sub SetLabelProgress(ByVal Text As String)
        If LabelProgress.InvokeRequired Then
            LabelProgress.Invoke(New Action(Of String)(AddressOf SetLabelProgress), Text)

        Else
            LabelProgress.Text = Text

        End If
    End Sub

    Public Sub SetProgressBar(ByVal value As Integer)
        If ProgressBar1.InvokeRequired Then
            ProgressBar1.Invoke(New Action(Of Integer)(AddressOf SetProgressBar), value)

        Else
            ProgressBar1.Value = value


        End If
    End Sub

    Public Sub Search(startz As Integer, endz As Integer)
        Dim counter As Integer = 0
        Dim progress As Integer = 0

        For counter = startz To endz

            If Check(counter) Then
                'Die Zahl ist eine Primzahl
                total = total + 1
                If CheckBoxSpeed.Checked = False Then
                    LabelLastPrime.Text = (Str(counter))
                    TextBoxPrime.AppendText(CStr(counter) + vbNewLine)
                    Chart1.Series.Item("Prime").Points.AddXY(counter, counter)
                End If

            End If

            If CheckBoxSpeed.Checked = False Then
                'Die Label werden gesetzt
                progress = Math.Floor((counter / (ende - start)) * 100)
                If progress < 0 Then
                    progress = 0
                ElseIf progress > 100 Then
                    progress = 100
                End If


                LabelTime.Text = Math.Round(sw.ElapsedMilliseconds / 1000, 4).ToString + "s"

                ProgressBar1.Value = progress

                LabelProgress.Text = Str(progress) + "%"
                'LabelProgress.Update()
                LabelCurNum.Text = counter

                LabelTotal.Text = total
                Me.Refresh()
            End If


            If bw.CancellationPending Then
                bw.Dispose()

                Return

            End If



        Next

        LabelTotal.Text = total
        LabelProgress.Text = "100%"
        ProgressBar1.Value = 100
        ButtonStart.Text = "Start"
        LabelTime.Text = Math.Round(sw.ElapsedMilliseconds / 1000, 4).ToString + "s"
        sw.Stop()

    End Sub


    Private Sub work_controller()

        start = Int(TextBoxAnfang.Text)
        ende = Int(TextBoxEnde.Text)


        Chart1.Series.Item("Prime").Points.Clear()

        Me.Size = New Size(660, 570)
        sw.Start()

        Search(start, ende)








    End Sub

    Private Sub Reset()
        LabelCurNum.Text = ""
        LabelLastPrime.Text = ""
        LabelProgress.Text = ""
        LabelTotal.Text = ""
        ProgressBar1.Value = 0
        TextBoxPrime.Text = ""
        sw.Reset()
        total = 0


    End Sub

    Public Sub RaiseTEvent(thread_result As Boolean)
        'Me.Invoke(New Action(Sub() RaiseTEvent(thread_result)))
        LabelTotal.Invoke(New Action(Of Boolean)(AddressOf RaiseTEvent), thread_result)
        If thread_result Then
            LabelTotal.Text = Int(LabelTotal.Text) + 1

        End If
    End Sub





    Public algo As New Action(Of Integer, Integer)(Sub(startz As Integer, endz As Integer)
                                                       Dim counter As Integer = startz
                                                       For counter = startz To endz

                                                           If Check(counter) Then
                                                               'Die Zahl ist eine Primzahl
                                                               total = total + 1
                                                               Me.SetLabelLastPrime(Str(counter))
                                                               TextBoxPrime.AppendText(CStr(counter) + vbNewLine)
                                                           End If

                                                           'Die Label werden gesetzt
                                                           SetProgressBar(Math.Floor((counter / (ende - start)) * 100))

                                                           Me.SetLabelProgress(Str(Math.Floor((counter / (ende - start) * 10)) + Int(LabelProgress.Text.Replace("%", ""))) + "%")
                                                           'LabelProgress.Update()
                                                           Me.SetLabelCurrentNumber(counter)
                                                           Me.SetLabelTotal(total)


                                                           'If bw.CancellationPending Then
                                                           'bw.Dispose()
                                                           '
                                                           'Return
                                                           '
                                                           'End If

                                                       Next

                                                   End Sub)

    Private Function Check(a As Integer) As Boolean
        Dim x As Integer = 1

        For x = 2 To a - 1
            If a Mod x = 0 Then
                Return False
            End If

        Next
        Return True

    End Function



End Class

Public Class Worker
    Dim startzahl As Integer
    Dim endzahl As Integer
    Dim counter As Integer
    Public total As Integer = 0
    Dim progress As Integer
    Public myTask0 As Task
    Public Event work_done(thread_result As Boolean)
    Public algo As New Action(Sub()
                                  counter = startzahl
                                  For Me.counter = startzahl To endzahl

                                      RaiseEvent work_done(Check(counter))



                                  Next

                              End Sub)


    Public Sub New(s As Integer, e As Integer)

        startzahl = s
        endzahl = e



        myTask0 = New Task(algo)




    End Sub

    Public Sub Start()
        myTask0.Start()
        myTask0.Wait()
        MsgBox(CStr("Finished! :" + myTask0.Status.ToString))
        MsgBox(total)

    End Sub

    

    Private Function Check(a As Integer) As Boolean
        Dim x As Integer = 1
        Dim result As Boolean = True
        For x = 2 To a - 1
            If a Mod x = 0 Then
                result = False
            End If

        Next
        Return result

    End Function


End Class
