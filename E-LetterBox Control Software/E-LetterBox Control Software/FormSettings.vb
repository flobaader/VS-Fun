Imports System.Net.NetworkInformation

Public Class FormSettings
    Dim WithEvents t As New Timer
    Private perfCounter As System.Diagnostics.PerformanceCounter


    Private Sub FormSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Infos werden geladen
        TextBoxIP.Text = My.Settings.hostname
        TextBoxPort.Text = My.Settings.port
        CheckBox_Enable_Animations.Checked = My.Settings.animations_enabled
        CheckBoxCPU.Checked = My.Settings.show_cpu_usage
        CheckBoxTime.Checked = My.Settings.show_time
        CheckBox_connect.Checked = My.Settings.connect_on_start
        CheckBoxSearchIP.Checked = My.Settings.search_ip

        LabelMyIP.Text = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName()).AddressList.ElementAt(0).ToString




        'Timer wird gestartet
        t.Interval = 500
        t.Start()

        'Konfiguration für die CPU Auslastung
        perfCounter = New System.Diagnostics.PerformanceCounter
        perfCounter.CategoryName = "Processor"
        perfCounter.CounterName = "% Processor Time"
        perfCounter.InstanceName = "_Total"

    End Sub

    Private Sub SaveIp() Handles TextBoxIP.TextChanged
        My.Settings.hostname = TextBoxIP.Text
        My.Settings.Save()

    End Sub

    Private Sub Ping() Handles ButtonPing.Click
        If My.Computer.Network.Ping(My.Settings.hostname) Then
            MsgBox("Server pinged successfully.")
        Else
            MsgBox("Ping request timed out.")
        End If

    End Sub

    Private Sub Send_a_command() Handles ButtonSend_a_command.Click
        Send_Command_Form.ShowDialog()
    End Sub

    

    Public Sub Timer_Tick() Handles t.Tick
        Label_CPU_Usage.Text = Integer.Parse(Format(perfCounter.NextValue, "##0")).ToString & "%"
        Label_Time.Text = DateAndTime.TimeString

    End Sub


    Private Sub CheckBox_Enable_Animations_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Enable_Animations.CheckedChanged
        My.Settings.animations_enabled = CheckBox_Enable_Animations.Checked

    End Sub

    Private Sub CheckBoxCPU_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCPU.CheckedChanged
        My.Settings.show_cpu_usage = CheckBoxCPU.Checked

    End Sub


    Private Sub CheckBoxTime_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxTime.CheckedChanged
        My.Settings.show_time = CheckBoxTime.Checked

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.Save()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_connect.CheckedChanged
        My.Settings.connect_on_start = CheckBox_connect.Checked
    End Sub

    Private Sub CheckBoxSearchIP_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSearchIP.CheckedChanged
        My.Settings.search_ip = CheckBoxSearchIP.Checked

    End Sub
End Class