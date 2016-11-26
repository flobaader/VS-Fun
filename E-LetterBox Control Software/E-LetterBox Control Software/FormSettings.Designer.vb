<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSettings
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxPort = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxIP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox_connect = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTime = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCPU = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBox_Enable_Animations = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LabelMyIP = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label_Time = New System.Windows.Forms.Label()
        Me.Label_CPU_Usage = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonSend_a_command = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonPing = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CheckBoxSearchIP = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBoxPort)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxIP)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 183)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TCP Settings"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(219, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "(NOTE: (Can only be changed by the admin!)"
        '
        'TextBoxPort
        '
        Me.TextBoxPort.Location = New System.Drawing.Point(9, 128)
        Me.TextBoxPort.Name = "TextBoxPort"
        Me.TextBoxPort.ReadOnly = True
        Me.TextBoxPort.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPort.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Port:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "(NOTE: Applications searches automatically)"
        '
        'TextBoxIP
        '
        Me.TextBoxIP.Location = New System.Drawing.Point(9, 49)
        Me.TextBoxIP.Name = "TextBoxIP"
        Me.TextBoxIP.Size = New System.Drawing.Size(139, 20)
        Me.TextBoxIP.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IP-Adress of the E-Letterbox: "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBoxSearchIP)
        Me.GroupBox2.Controls.Add(Me.CheckBox_connect)
        Me.GroupBox2.Controls.Add(Me.CheckBoxTime)
        Me.GroupBox2.Controls.Add(Me.CheckBoxCPU)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.CheckBox_Enable_Animations)
        Me.GroupBox2.Location = New System.Drawing.Point(270, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(289, 183)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Application Settings"
        '
        'CheckBox_connect
        '
        Me.CheckBox_connect.AutoSize = True
        Me.CheckBox_connect.Location = New System.Drawing.Point(37, 28)
        Me.CheckBox_connect.Name = "CheckBox_connect"
        Me.CheckBox_connect.Size = New System.Drawing.Size(106, 17)
        Me.CheckBox_connect.TabIndex = 6
        Me.CheckBox_connect.Text = "Connect on Start"
        Me.CheckBox_connect.UseVisualStyleBackColor = True
        '
        'CheckBoxTime
        '
        Me.CheckBoxTime.AutoSize = True
        Me.CheckBoxTime.Location = New System.Drawing.Point(37, 158)
        Me.CheckBoxTime.Name = "CheckBoxTime"
        Me.CheckBoxTime.Size = New System.Drawing.Size(79, 17)
        Me.CheckBoxTime.TabIndex = 5
        Me.CheckBoxTime.Text = "Show Time"
        Me.CheckBoxTime.UseVisualStyleBackColor = True
        '
        'CheckBoxCPU
        '
        Me.CheckBoxCPU.AutoSize = True
        Me.CheckBoxCPU.Location = New System.Drawing.Point(37, 135)
        Me.CheckBoxCPU.Name = "CheckBoxCPU"
        Me.CheckBoxCPU.Size = New System.Drawing.Size(112, 17)
        Me.CheckBoxCPU.TabIndex = 4
        Me.CheckBoxCPU.Text = "Show CPU Usage"
        Me.CheckBoxCPU.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Animation:"
        '
        'CheckBox_Enable_Animations
        '
        Me.CheckBox_Enable_Animations.AutoSize = True
        Me.CheckBox_Enable_Animations.Location = New System.Drawing.Point(37, 112)
        Me.CheckBox_Enable_Animations.Name = "CheckBox_Enable_Animations"
        Me.CheckBox_Enable_Animations.Size = New System.Drawing.Size(113, 17)
        Me.CheckBox_Enable_Animations.TabIndex = 2
        Me.CheckBox_Enable_Animations.Text = "Enable Animations"
        Me.CheckBox_Enable_Animations.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LabelMyIP)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label_Time)
        Me.GroupBox3.Controls.Add(Me.Label_CPU_Usage)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 202)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(251, 100)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Information"
        '
        'LabelMyIP
        '
        Me.LabelMyIP.AutoSize = True
        Me.LabelMyIP.Location = New System.Drawing.Point(99, 61)
        Me.LabelMyIP.Name = "LabelMyIP"
        Me.LabelMyIP.Size = New System.Drawing.Size(21, 13)
        Me.LabelMyIP.TabIndex = 6
        Me.LabelMyIP.Text = "##"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "My IP:"
        '
        'Label_Time
        '
        Me.Label_Time.AutoSize = True
        Me.Label_Time.Location = New System.Drawing.Point(99, 39)
        Me.Label_Time.Name = "Label_Time"
        Me.Label_Time.Size = New System.Drawing.Size(21, 13)
        Me.Label_Time.TabIndex = 3
        Me.Label_Time.Text = "##"
        '
        'Label_CPU_Usage
        '
        Me.Label_CPU_Usage.AutoSize = True
        Me.Label_CPU_Usage.Location = New System.Drawing.Point(99, 20)
        Me.Label_CPU_Usage.Name = "Label_CPU_Usage"
        Me.Label_CPU_Usage.Size = New System.Drawing.Size(21, 13)
        Me.Label_CPU_Usage.TabIndex = 2
        Me.Label_CPU_Usage.Text = "##"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Systemtime:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "CPU-Usage:"
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button1.Location = New System.Drawing.Point(484, 326)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonSend_a_command
        '
        Me.ButtonSend_a_command.Location = New System.Drawing.Point(133, 29)
        Me.ButtonSend_a_command.Name = "ButtonSend_a_command"
        Me.ButtonSend_a_command.Size = New System.Drawing.Size(102, 23)
        Me.ButtonSend_a_command.TabIndex = 6
        Me.ButtonSend_a_command.Text = "Send a command"
        Me.ButtonSend_a_command.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.Location = New System.Drawing.Point(403, 326)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 5
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonPing
        '
        Me.ButtonPing.Location = New System.Drawing.Point(6, 29)
        Me.ButtonPing.Name = "ButtonPing"
        Me.ButtonPing.Size = New System.Drawing.Size(98, 23)
        Me.ButtonPing.TabIndex = 4
        Me.ButtonPing.Text = "Ping E-Letterbox"
        Me.ButtonPing.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ButtonPing)
        Me.GroupBox4.Controls.Add(Me.ButtonSend_a_command)
        Me.GroupBox4.Location = New System.Drawing.Point(270, 202)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(289, 100)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Functions"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 335)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(216, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "(For applying changes a restart is necessary)"
        '
        'CheckBoxSearchIP
        '
        Me.CheckBoxSearchIP.AutoSize = True
        Me.CheckBoxSearchIP.Location = New System.Drawing.Point(37, 51)
        Me.CheckBoxSearchIP.Name = "CheckBoxSearchIP"
        Me.CheckBoxSearchIP.Size = New System.Drawing.Size(73, 17)
        Me.CheckBoxSearchIP.TabIndex = 7
        Me.CheckBoxSearchIP.Text = "Search IP"
        Me.CheckBoxSearchIP.UseVisualStyleBackColor = True
        '
        'FormSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 360)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPort As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxIP As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CheckBox_Enable_Animations As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxTime As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxCPU As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonSend_a_command As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonPing As System.Windows.Forms.Button
    Friend WithEvents Label_Time As System.Windows.Forms.Label
    Friend WithEvents Label_CPU_Usage As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CheckBox_connect As System.Windows.Forms.CheckBox
    Friend WithEvents LabelMyIP As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxSearchIP As System.Windows.Forms.CheckBox
End Class
