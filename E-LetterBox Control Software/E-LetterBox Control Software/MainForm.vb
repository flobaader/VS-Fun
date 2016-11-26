Imports System.Net.Sockets
Imports System.IO
Imports System.Drawing



Public Class MainForm
    
    Dim WithEvents Timer_Listen As New Timer
    'VARIABLE FÜR DEN DIALOG
    Dim Found_Ip As Boolean = False
    Dim Number_Tries As Integer = 0

    'TIMER FÜR DIE UHRZEIT
    Dim WithEvents Timer_Clock As New Timer

    'Performance Counter für die CPU Ausnutzung
    Dim perfCounter As New System.Diagnostics.PerformanceCounter

    'DIE TCP CONNECTION WIRD INSTANZIERT
    Public Connection As New ETCP


    Private Sub ButtonMail_MouseEnter() Handles ButtonMail.MouseEnter
        'Die Normale Größe beträgt 120 * 120
        ButtonMail.Size = New Size(125, 125)

    End Sub

    Private Sub ButtonMail_MouseLeave() Handles ButtonMail.MouseLeave
        ButtonMail.Size = New Size(120, 120)
    End Sub

    Private Sub ButtonCommand_MouseEnter() Handles ButtonCommand.MouseEnter
        ButtonCommand.Size = New Size(125, 125)
    End Sub

    Private Sub ButtonCommand_MouseLeave() Handles ButtonCommand.MouseLeave
        ButtonCommand.Size = New Size(120, 120)
    End Sub

    Private Sub ButtonSettings_MouseEnter() Handles ButtonSettings.MouseEnter
        ButtonSettings.Size = New Size(125, 125)

    End Sub

    Private Sub ButtonSettings_MouseLeave() Handles ButtonSettings.MouseLeave
        ButtonSettings.Size = New Size(120, 120)

    End Sub

    Private Sub ButtonFTP_MouseEnter() Handles ButtonLogFiles.MouseEnter
        ButtonLogFiles.Size = New Size(125, 125)

    End Sub

    Private Sub ButtonFTP_MouseLeave() Handles ButtonLogFiles.MouseLeave
        ButtonLogFiles.Size = New Size(120, 120)

    End Sub
    
    Private Sub Button_FTP_MouseLeave() Handles ButtonLogFiles.MouseLeave
        ButtonLogFiles.Size = New Size(120, 120)
    End Sub

    Private Sub Button_SMS_MouseEnter() Handles ButtonSMS.MouseEnter
        ButtonSMS.Size = New Size(125, 125)
    End Sub

    Private Sub ButtonSMS_MouseLeave() Handles ButtonSMS.MouseLeave
        ButtonSMS.Size = New Size(120, 120)
    End Sub
 
    Private Sub ButtonSMS_Click() Handles ButtonSMS.Click
        FormSMS.Show()

    End Sub

    Private Sub ButtonTest_MouseOver() Handles ButtonTest.MouseEnter
        ButtonTest.Size = New Size(125, 125)

    End Sub

    Private Sub ButtonTest_MouseLeave() Handles ButtonTest.MouseLeave
        ButtonTest.Size = New Size(120, 120)

    End Sub
    Private Sub ButtonTest_Click(sender As Object, e As EventArgs) Handles ButtonTest.Click
        FormTest.ShowDialog()

    End Sub



    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        If Connection.Connected = True Then
            Disconnect()
        End If
        Me.Close()
    End Sub

    'Checkbox State wird übertragen
    Private Sub CheckboxState_to_TCP() Handles CheckBoxSendMail.CheckedChanged, CheckBoxSendSMS.CheckedChanged
        Dim o As Integer
        If CheckBoxSendMail.Checked Then
            o = 0
        End If
        If CheckBoxSendSMS.Checked Then
            o = 1
        End If
        If CheckBoxSendSMS.Checked And CheckBoxSendMail.Checked Then
            o = 2
        End If

        If CheckBoxSendSMS.Checked = False And CheckBoxSendMail.Checked = False Then
            o = 3
            MsgBox("Sie sollten etwas auswählen, sonst bekommen sie keine Nachricht!", MsgBoxStyle.MsgBoxHelp)
        End If

        Dim answ As String = Connection.Send_Command("change_WOF")
        If answ = "Waiting for the WOF to be sent..." Then
            answ = Connection.Send_Command(o)
            If answ = "Changed WOF to: " + o.ToString Then

            Else
                MsgBox("Not succesfull!")
            End If
        Else
            MsgBox("Not succesfull!")
        End If
    End Sub



    Public Sub UI_Connected()
        LabelStatus.Text = "Connected"
        PictureBoxStatus.Image = My.Resources.bars_colored
        ButtonCommand.Enabled = True
        ButtonLogFiles.Enabled = True
        ButtonMail.Enabled = True
        ButtonSMS.Enabled = True
        ButtonTest.Enabled = True

        ButtonCommand.BackColor = Color.White
        ButtonLogFiles.BackColor = Color.White
        ButtonMail.BackColor = Color.White
        ButtonSMS.BackColor = Color.White
        ButtonTest.BackColor = Color.White

        CheckBoxSendMail.Enabled = True
        CheckBoxSendSMS.Enabled = True

        ButtonCoDisco.BackgroundImage = My.Resources.button_disconnect_no
        ButtonCoDisco.Size = New Size(174, 53)

        'Die Checkboxen für WOF werden gesetzt
        Dim o As Integer
        Try
            o = CInt(Connection.Send_Command("send_WOF"))
        Catch
            MsgBox("Programm couldn't get WOF State!", MsgBoxStyle.Critical)
        End Try

        If o = 0 Or o = 2 Then
            CheckBoxSendMail.Checked = True
        Else
            CheckBoxSendMail.Checked = False
        End If

        If o = 1 Or o = 2 Then
            CheckBoxSendSMS.Checked = True
        Else
            CheckBoxSendSMS.Checked = False

        End If

        'Der Ruhezustand wird abgefragt
        CheckBoxStandby.Enabled = True

        Dim a As Integer
        Dim b As Integer
        Try
            a = CInt(Connection.Send_Command("send_STime", 500))
            b = CInt(Connection.Send_Command("send_ETime", 500))
            SetTimePickers(a, b)
        Catch
            MsgBox("Programm couldn't get Standby Data!", MsgBoxStyle.Critical)
        End Try

        Me.Refresh()

    End Sub

    Private Sub SetTimePickers(ByRef start_time As Integer, ByRef end_time As Integer)
        If Not start_time = 1441 Then
            CheckBoxStandby.Checked = True
            'Start Time
            Dim SHour As Integer = Fix(start_time / 60)
            Dim SMinute As Integer = start_time - (SHour * 60)
            STimePicker.Value = New Date(1753, 1, 1, SHour, SMinute, 0) '1753 = Min Date

            'End Time
            Dim EHour As Integer = Fix(end_time / 60)
            Dim EMinute As Integer = end_time - (EHour * 60)
            ETimePicker.Value = New Date(1753, 1, 1, EHour, EMinute, 0)
        Else
            CheckBoxStandby.Checked = False
            STimePicker.Value = New Date(1753, 1, 1, 0, 0, 0) '1753 = Min Date
            ETimePicker.Value = New Date(1753, 1, 1, 0, 0, 0)
        End If

    End Sub

    Private Sub ShowStandbyButton() Handles STimePicker.ValueChanged, ETimePicker.ValueChanged
        If CheckBoxStandby.Checked And CheckBoxStandby.Enabled Then
            ButtonStandby.Visible = True
        End If

    End Sub

    Private Sub StandbyTimeChanged() Handles ButtonStandby.Click
        Dim STime As Integer = (STimePicker.Value.Hour * 60) + STimePicker.Value.Minute
        Dim ETime As Integer = (ETimePicker.Value.Hour * 60) + ETimePicker.Value.Minute
        Dim counter As Integer = 0

        If Connection.isConnected And CheckBoxStandby.Checked And STimePicker.Value.Hour <> 0 Then
            Dim answ As String

            'ETime wird gesendet
            answ = Connection.Send_Command("change_ETime")
            If answ = "Waiting for the ETime to be sent..." Then
                answ = Connection.Send_Command(CStr(ETime))
                If Not answ = "Changed ETime to: " + CStr(ETime) Then
                    counter += 1
                End If
            End If

            'STime wird gesendet
            answ = Connection.Send_Command("change_STime")
            If answ = "Waiting for the STime to be sent..." Then
                answ = Connection.Send_Command(CStr(STime))
                If Not answ = "Changed STime to: " + CStr(STime) Then
                    counter += 1
                End If
            End If

        End If

        If counter = 0 Then
            ButtonStandby.Visible = False
        Else
            MsgBox("Error Sending Standby Times!", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub StandbyActivated() Handles CheckBoxStandby.CheckedChanged
        Dim counter As Integer = 0
        If CheckBoxStandby.Checked Then
            STimePicker.Enabled = True
            ETimePicker.Enabled = True
            LabelSTime.Enabled = True
            LabelETime.Enabled = True
            ButtonStandby.Visible = True
        Else
            STimePicker.Enabled = False
            ETimePicker.Enabled = False
            LabelSTime.Enabled = False
            LabelETime.Enabled = False
            If Connection.isConnected Then
                'ETime wird gesendet
                Dim answ As String
                answ = Connection.Send_Command("change_ETime")
                If answ = "Waiting for the ETime to be sent..." Then
                    answ = Connection.Send_Command("1441")
                    If Not answ = "Changed ETime to: " + "1441" Then
                        counter += 1
                    End If
                End If

                answ = Connection.Send_Command("change_STime")
                If answ = "Waiting for the STime to be sent..." Then
                    answ = Connection.Send_Command("1441") 'Die Minute 1450 gibt es nicht!
                    If Not answ = "Changed STime to: " + "1441" Then
                        counter += 1
                    End If
                End If



            End If

            If counter = 0 Then
                ButtonStandby.Visible = False
            Else
                MsgBox("Error Sending Standby Times!", MsgBoxStyle.Critical)
            End If
        End If

    End Sub


    Public Sub UI_Disconnected()
        LabelStatus.Text = "Not Connected"
        PictureBoxStatus.Image = My.Resources.blocked_colored
        ButtonCommand.Enabled = False
        ButtonLogFiles.Enabled = False
        ButtonMail.Enabled = False
        ButtonSMS.Enabled = False
        ButtonTest.Enabled = False

        ButtonCommand.BackColor = Color.Transparent
        ButtonLogFiles.BackColor = Color.Transparent
        ButtonMail.BackColor = Color.Transparent
        ButtonSMS.BackColor = Color.Transparent
        ButtonTest.BackColor = Color.Transparent

        CheckBoxSendMail.Enabled = False
        CheckBoxSendSMS.Enabled = False

        CheckBoxStandby.Enabled = False
        STimePicker.Enabled = False
        ETimePicker.Enabled = False
        LabelSTime.Enabled = False
        LabelETime.Enabled = False


        ButtonCoDisco.Size = New Size(142, 53)
        ButtonCoDisco.BackgroundImage = My.Resources.button_connect_no
        Me.Refresh()

    End Sub

    Private Sub Display_Time() Handles Timer_Clock.Tick
        LabelClock.Text = DateAndTime.TimeString
        LabelCPU.Text = "CPU Usage: " + Integer.Parse(Format(perfCounter.NextValue, "##0")).ToString + "%"
    End Sub


    'MOVABLE FORM

    Private ptMouseDownLocation As Point

    Private Sub MainForm_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ptMouseDownLocation = e.Location
        End If
    End Sub
    Private Sub MainForm_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location = e.Location - ptMouseDownLocation + Me.Location
        End If
    End Sub

    'MAIN SUBS
    Private Sub OnStart() Handles Me.Load


        'Settings für die Controls
        PictureBoxStatus.SizeMode = PictureBoxSizeMode.StretchImage
        Timer_Clock.Interval = 1000
        Timer_Clock.Start()
        LabelClock.Text = DateAndTime.TimeString
        LabelVersion.Text = "V. " & My.Application.Info.Version.ToString

        'CPU Auslastung
        perfCounter = New System.Diagnostics.PerformanceCounter
        perfCounter.CategoryName = "Processor"
        perfCounter.CounterName = "% Processor Time"
        perfCounter.InstanceName = "_Total"

        'settings für die UI
        UI_Disconnected()

        'DIE FONT Einstellung wird angewandt



        If My.Settings.show_cpu_usage = False Then
            LabelCPU.Hide()
        Else
            LabelCPU.Show()

        End If

        If My.Settings.show_time = False Then
            LabelClock.Hide()
        Else
            LabelClock.Show()

        End If

        STimePicker.Format = DateTimePickerFormat.Custom
        STimePicker.CustomFormat = "HH : mm"

    End Sub

    Private Sub onShow() Handles Me.Shown
        Me.Update()

        If My.Settings.connect_on_start Then
            Connect()

        End If
    End Sub

    Private Sub ButtonCommand_Click(sender As Object, e As EventArgs) Handles ButtonCommand.Click

        Send_Command_Form.ShowDialog()

    End Sub

    Private Sub ButtonSettings_Click(sender As Object, e As EventArgs) Handles ButtonSettings.Click

        FormSettings.ShowDialog()

    End Sub

    Private Sub ButtonPutty_Click(sender As Object, e As EventArgs) Handles ButtonPutty.Click
        Try
            Dim setupPath As String = Application.StartupPath & "/putty.exe"
            Using sCreateMSIFile As New FileStream(setupPath, FileMode.Create)
                sCreateMSIFile.Write(My.Resources.putty_0_63, 0, My.Resources.putty_0_63.Length)
            End Using

            Process.Start(setupPath)
        Catch
            MsgBox(".EXE File could not be created!", MsgBoxStyle.Critical)
        End Try

    End Sub
    Private Sub ButtonMail_Click(sender As Object, e As EventArgs) Handles ButtonMail.Click
        FormMail.StartPosition = FormStartPosition.CenterScreen

        FormMail.ShowDialog()

    End Sub
    Private Sub ButtonLogFiles_Click(sender As Object, e As EventArgs) Handles ButtonLogFiles.Click
        FormLogFiles.ShowDialog()

    End Sub

    Private Sub Connect()
        'Falls die Verbindung nicht den Wert Truze zurückgibt
        If Not Connection.Connect(PictureBoxStatus, LabelStatus) Then
            'Falls die IP gesucht werden soll
            If My.Settings.search_ip Then

                If Connection.GetIP() Then
                    Connection.Connect(PictureBoxStatus, LabelStatus)
                End If
            End If
            'Wenn nicht ist der Versuch vorbei
        End If
    End Sub

    Private Sub Disconnect()
        Connection.Disconnect(PictureBoxStatus, LabelStatus)
    End Sub

    Private Sub ButtonCoDisco_Click(sender As Object, e As EventArgs) Handles ButtonCoDisco.Click
        If Connection.Connected = False Then
            Connect()
        Else
            Disconnect()

        End If


    End Sub

    Private Sub CheckBoxStandby_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxStandby.CheckedChanged
        If CheckBoxStandby.Checked Then
            STimePicker.Enabled = True
            ETimePicker.Enabled = True

        Else
            STimePicker.Enabled = False
            ETimePicker.Enabled = False
        End If
    End Sub
End Class


