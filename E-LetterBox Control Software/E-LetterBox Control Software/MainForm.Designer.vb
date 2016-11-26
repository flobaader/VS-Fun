<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.PictureBoxStatus = New System.Windows.Forms.PictureBox()
        Me.GroupBoxActions = New System.Windows.Forms.GroupBox()
        Me.ButtonTest = New System.Windows.Forms.Button()
        Me.ButtonSMS = New System.Windows.Forms.Button()
        Me.ButtonLogFiles = New System.Windows.Forms.Button()
        Me.ButtonSettings = New System.Windows.Forms.Button()
        Me.ButtonCommand = New System.Windows.Forms.Button()
        Me.ButtonMail = New System.Windows.Forms.Button()
        Me.CheckBoxSendSMS = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSendMail = New System.Windows.Forms.CheckBox()
        Me.LabelSettings = New System.Windows.Forms.Label()
        Me.LabelLogFiles = New System.Windows.Forms.Label()
        Me.LabelCommand = New System.Windows.Forms.Label()
        Me.LabelMail = New System.Windows.Forms.Label()
        Me.LabelClock = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.LabelCPU = New System.Windows.Forms.Label()
        Me.ButtonPutty = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonCoDisco = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonStandby = New System.Windows.Forms.Button()
        Me.LabelETime = New System.Windows.Forms.Label()
        Me.LabelSTime = New System.Windows.Forms.Label()
        Me.ETimePicker = New System.Windows.Forms.DateTimePicker()
        Me.STimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CheckBoxStandby = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBoxStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxActions.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonExit
        '
        Me.ButtonExit.BackColor = System.Drawing.Color.Transparent
        Me.ButtonExit.BackgroundImage = Global.E_LetterBox_Control_Software.My.Resources.Resources.button_exit
        Me.ButtonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonExit.FlatAppearance.BorderSize = 0
        Me.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonExit.Location = New System.Drawing.Point(916, 12)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(69, 23)
        Me.ButtonExit.TabIndex = 13
        Me.ButtonExit.UseCompatibleTextRendering = True
        Me.ButtonExit.UseVisualStyleBackColor = False
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.BackColor = System.Drawing.Color.Transparent
        Me.LabelStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.LabelStatus.Location = New System.Drawing.Point(786, 315)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(122, 25)
        Me.LabelStatus.TabIndex = 24
        Me.LabelStatus.Text = "Connecting.."
        Me.LabelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBoxStatus
        '
        Me.PictureBoxStatus.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBoxStatus.Location = New System.Drawing.Point(760, 99)
        Me.PictureBoxStatus.Name = "PictureBoxStatus"
        Me.PictureBoxStatus.Size = New System.Drawing.Size(180, 180)
        Me.PictureBoxStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxStatus.TabIndex = 27
        Me.PictureBoxStatus.TabStop = False
        '
        'GroupBoxActions
        '
        Me.GroupBoxActions.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxActions.Controls.Add(Me.ButtonTest)
        Me.GroupBoxActions.Controls.Add(Me.ButtonSMS)
        Me.GroupBoxActions.Controls.Add(Me.ButtonLogFiles)
        Me.GroupBoxActions.Controls.Add(Me.ButtonSettings)
        Me.GroupBoxActions.Controls.Add(Me.ButtonCommand)
        Me.GroupBoxActions.Controls.Add(Me.ButtonMail)
        Me.GroupBoxActions.Location = New System.Drawing.Point(66, 94)
        Me.GroupBoxActions.Name = "GroupBoxActions"
        Me.GroupBoxActions.Size = New System.Drawing.Size(379, 257)
        Me.GroupBoxActions.TabIndex = 29
        Me.GroupBoxActions.TabStop = False
        '
        'ButtonTest
        '
        Me.ButtonTest.BackColor = System.Drawing.Color.White
        Me.ButtonTest.BackgroundImage = Global.E_LetterBox_Control_Software.My.Resources.Resources.notification
        Me.ButtonTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonTest.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTest.Location = New System.Drawing.Point(128, 5)
        Me.ButtonTest.Name = "ButtonTest"
        Me.ButtonTest.Size = New System.Drawing.Size(120, 120)
        Me.ButtonTest.TabIndex = 37
        Me.ButtonTest.UseVisualStyleBackColor = False
        '
        'ButtonSMS
        '
        Me.ButtonSMS.BackColor = System.Drawing.Color.White
        Me.ButtonSMS.BackgroundImage = Global.E_LetterBox_Control_Software.My.Resources.Resources.mail3
        Me.ButtonSMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonSMS.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonSMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSMS.Location = New System.Drawing.Point(254, 134)
        Me.ButtonSMS.Name = "ButtonSMS"
        Me.ButtonSMS.Size = New System.Drawing.Size(120, 120)
        Me.ButtonSMS.TabIndex = 36
        Me.ButtonSMS.UseVisualStyleBackColor = False
        '
        'ButtonLogFiles
        '
        Me.ButtonLogFiles.BackColor = System.Drawing.Color.White
        Me.ButtonLogFiles.BackgroundImage = Global.E_LetterBox_Control_Software.My.Resources.Resources.drawer2
        Me.ButtonLogFiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonLogFiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLogFiles.Location = New System.Drawing.Point(0, 134)
        Me.ButtonLogFiles.Name = "ButtonLogFiles"
        Me.ButtonLogFiles.Size = New System.Drawing.Size(120, 120)
        Me.ButtonLogFiles.TabIndex = 34
        Me.ButtonLogFiles.UseVisualStyleBackColor = False
        '
        'ButtonSettings
        '
        Me.ButtonSettings.BackColor = System.Drawing.Color.White
        Me.ButtonSettings.BackgroundImage = Global.E_LetterBox_Control_Software.My.Resources.Resources.wrench
        Me.ButtonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSettings.Location = New System.Drawing.Point(2, 5)
        Me.ButtonSettings.Name = "ButtonSettings"
        Me.ButtonSettings.Size = New System.Drawing.Size(120, 120)
        Me.ButtonSettings.TabIndex = 31
        Me.ButtonSettings.UseVisualStyleBackColor = False
        '
        'ButtonCommand
        '
        Me.ButtonCommand.BackColor = System.Drawing.Color.White
        Me.ButtonCommand.BackgroundImage = Global.E_LetterBox_Control_Software.My.Resources.Resources.code
        Me.ButtonCommand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonCommand.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCommand.Location = New System.Drawing.Point(128, 134)
        Me.ButtonCommand.Name = "ButtonCommand"
        Me.ButtonCommand.Size = New System.Drawing.Size(120, 120)
        Me.ButtonCommand.TabIndex = 30
        Me.ButtonCommand.UseVisualStyleBackColor = False
        '
        'ButtonMail
        '
        Me.ButtonMail.BackColor = System.Drawing.Color.White
        Me.ButtonMail.BackgroundImage = Global.E_LetterBox_Control_Software.My.Resources.Resources.envelope
        Me.ButtonMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonMail.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMail.Location = New System.Drawing.Point(254, 5)
        Me.ButtonMail.Name = "ButtonMail"
        Me.ButtonMail.Size = New System.Drawing.Size(120, 120)
        Me.ButtonMail.TabIndex = 29
        Me.ButtonMail.UseVisualStyleBackColor = False
        '
        'CheckBoxSendSMS
        '
        Me.CheckBoxSendSMS.AutoSize = True
        Me.CheckBoxSendSMS.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxSendSMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxSendSMS.Location = New System.Drawing.Point(5, 70)
        Me.CheckBoxSendSMS.Name = "CheckBoxSendSMS"
        Me.CheckBoxSendSMS.Size = New System.Drawing.Size(180, 20)
        Me.CheckBoxSendSMS.TabIndex = 39
        Me.CheckBoxSendSMS.Text = "Activate SMS Sending"
        Me.CheckBoxSendSMS.UseVisualStyleBackColor = False
        '
        'CheckBoxSendMail
        '
        Me.CheckBoxSendMail.AutoSize = True
        Me.CheckBoxSendMail.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxSendMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxSendMail.Location = New System.Drawing.Point(6, 34)
        Me.CheckBoxSendMail.Name = "CheckBoxSendMail"
        Me.CheckBoxSendMail.Size = New System.Drawing.Size(177, 20)
        Me.CheckBoxSendMail.TabIndex = 38
        Me.CheckBoxSendMail.Text = "Activate Mail Sending"
        Me.CheckBoxSendMail.UseVisualStyleBackColor = False
        '
        'LabelSettings
        '
        Me.LabelSettings.AutoSize = True
        Me.LabelSettings.BackColor = System.Drawing.Color.Transparent
        Me.LabelSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSettings.Location = New System.Drawing.Point(89, 76)
        Me.LabelSettings.Name = "LabelSettings"
        Me.LabelSettings.Size = New System.Drawing.Size(68, 20)
        Me.LabelSettings.TabIndex = 33
        Me.LabelSettings.Text = "Settings"
        Me.LabelSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelLogFiles
        '
        Me.LabelLogFiles.AutoSize = True
        Me.LabelLogFiles.BackColor = System.Drawing.Color.Transparent
        Me.LabelLogFiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLogFiles.Location = New System.Drawing.Point(84, 354)
        Me.LabelLogFiles.Name = "LabelLogFiles"
        Me.LabelLogFiles.Size = New System.Drawing.Size(73, 20)
        Me.LabelLogFiles.TabIndex = 35
        Me.LabelLogFiles.Text = "Log Files"
        Me.LabelLogFiles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelCommand
        '
        Me.LabelCommand.AutoSize = True
        Me.LabelCommand.BackColor = System.Drawing.Color.Transparent
        Me.LabelCommand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCommand.Location = New System.Drawing.Point(213, 354)
        Me.LabelCommand.Name = "LabelCommand"
        Me.LabelCommand.Size = New System.Drawing.Size(82, 20)
        Me.LabelCommand.TabIndex = 32
        Me.LabelCommand.Text = "Command"
        Me.LabelCommand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelMail
        '
        Me.LabelMail.AutoSize = True
        Me.LabelMail.BackColor = System.Drawing.Color.Transparent
        Me.LabelMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMail.Location = New System.Drawing.Point(366, 76)
        Me.LabelMail.Name = "LabelMail"
        Me.LabelMail.Size = New System.Drawing.Size(37, 20)
        Me.LabelMail.TabIndex = 30
        Me.LabelMail.Text = "Mail"
        Me.LabelMail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelClock
        '
        Me.LabelClock.AutoSize = True
        Me.LabelClock.BackColor = System.Drawing.Color.Transparent
        Me.LabelClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.LabelClock.Location = New System.Drawing.Point(924, 54)
        Me.LabelClock.Name = "LabelClock"
        Me.LabelClock.Size = New System.Drawing.Size(36, 18)
        Me.LabelClock.TabIndex = 30
        Me.LabelClock.Text = "time"
        Me.LabelClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.BackColor = System.Drawing.Color.Transparent
        Me.LabelVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVersion.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelVersion.Location = New System.Drawing.Point(12, 476)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(41, 13)
        Me.LabelVersion.TabIndex = 31
        Me.LabelVersion.Text = "version"
        Me.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelCPU
        '
        Me.LabelCPU.AutoSize = True
        Me.LabelCPU.BackColor = System.Drawing.Color.Transparent
        Me.LabelCPU.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCPU.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelCPU.Location = New System.Drawing.Point(74, 476)
        Me.LabelCPU.Name = "LabelCPU"
        Me.LabelCPU.Size = New System.Drawing.Size(29, 13)
        Me.LabelCPU.TabIndex = 32
        Me.LabelCPU.Text = "CPU"
        Me.LabelCPU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonPutty
        '
        Me.ButtonPutty.BackColor = System.Drawing.Color.Transparent
        Me.ButtonPutty.BackgroundImage = Global.E_LetterBox_Control_Software.My.Resources.Resources.console
        Me.ButtonPutty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonPutty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPutty.Location = New System.Drawing.Point(12, 443)
        Me.ButtonPutty.Name = "ButtonPutty"
        Me.ButtonPutty.Size = New System.Drawing.Size(30, 30)
        Me.ButtonPutty.TabIndex = 36
        Me.ButtonPutty.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(359, 354)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "SMS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(235, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 20)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Test"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonCoDisco
        '
        Me.ButtonCoDisco.BackColor = System.Drawing.Color.Transparent
        Me.ButtonCoDisco.BackgroundImage = Global.E_LetterBox_Control_Software.My.Resources.Resources.button_connect_no
        Me.ButtonCoDisco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonCoDisco.FlatAppearance.BorderSize = 0
        Me.ButtonCoDisco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCoDisco.Location = New System.Drawing.Point(791, 432)
        Me.ButtonCoDisco.Name = "ButtonCoDisco"
        Me.ButtonCoDisco.Size = New System.Drawing.Size(142, 53)
        Me.ButtonCoDisco.TabIndex = 40
        Me.ButtonCoDisco.UseCompatibleTextRendering = True
        Me.ButtonCoDisco.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(48, 41)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(217, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "by Florian Baader, Stephan Le, Jakob Unger"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(438, 41)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Jugend Forscht 2015"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CheckBoxSendMail)
        Me.GroupBox1.Controls.Add(Me.CheckBoxSendSMS)
        Me.GroupBox1.Location = New System.Drawing.Point(446, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 120)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Way of Message"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.ButtonStandby)
        Me.GroupBox2.Controls.Add(Me.LabelETime)
        Me.GroupBox2.Controls.Add(Me.LabelSTime)
        Me.GroupBox2.Controls.Add(Me.ETimePicker)
        Me.GroupBox2.Controls.Add(Me.STimePicker)
        Me.GroupBox2.Controls.Add(Me.CheckBoxStandby)
        Me.GroupBox2.Location = New System.Drawing.Point(451, 228)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(195, 120)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Standby"
        '
        'ButtonStandby
        '
        Me.ButtonStandby.Location = New System.Drawing.Point(1, 91)
        Me.ButtonStandby.Name = "ButtonStandby"
        Me.ButtonStandby.Size = New System.Drawing.Size(75, 23)
        Me.ButtonStandby.TabIndex = 5
        Me.ButtonStandby.Text = "Change!"
        Me.ButtonStandby.UseVisualStyleBackColor = True
        Me.ButtonStandby.Visible = False
        '
        'LabelETime
        '
        Me.LabelETime.AutoSize = True
        Me.LabelETime.Location = New System.Drawing.Point(36, 74)
        Me.LabelETime.Name = "LabelETime"
        Me.LabelETime.Size = New System.Drawing.Size(55, 13)
        Me.LabelETime.TabIndex = 4
        Me.LabelETime.Text = "End Time:"
        '
        'LabelSTime
        '
        Me.LabelSTime.AutoSize = True
        Me.LabelSTime.Location = New System.Drawing.Point(36, 48)
        Me.LabelSTime.Name = "LabelSTime"
        Me.LabelSTime.Size = New System.Drawing.Size(58, 13)
        Me.LabelSTime.TabIndex = 3
        Me.LabelSTime.Text = "Start Time:"
        '
        'ETimePicker
        '
        Me.ETimePicker.CustomFormat = "HH: mm"
        Me.ETimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ETimePicker.Location = New System.Drawing.Point(97, 74)
        Me.ETimePicker.Name = "ETimePicker"
        Me.ETimePicker.ShowUpDown = True
        Me.ETimePicker.Size = New System.Drawing.Size(71, 20)
        Me.ETimePicker.TabIndex = 2
        '
        'STimePicker
        '
        Me.STimePicker.CustomFormat = "HH: mm"
        Me.STimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.STimePicker.Location = New System.Drawing.Point(97, 42)
        Me.STimePicker.Name = "STimePicker"
        Me.STimePicker.ShowUpDown = True
        Me.STimePicker.Size = New System.Drawing.Size(71, 20)
        Me.STimePicker.TabIndex = 1
        '
        'CheckBoxStandby
        '
        Me.CheckBoxStandby.AutoSize = True
        Me.CheckBoxStandby.Location = New System.Drawing.Point(13, 19)
        Me.CheckBoxStandby.Name = "CheckBoxStandby"
        Me.CheckBoxStandby.Size = New System.Drawing.Size(107, 17)
        Me.CheckBoxStandby.TabIndex = 0
        Me.CheckBoxStandby.Text = "Activate Standby"
        Me.CheckBoxStandby.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 500)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonCoDisco)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelLogFiles)
        Me.Controls.Add(Me.LabelSettings)
        Me.Controls.Add(Me.ButtonPutty)
        Me.Controls.Add(Me.LabelCommand)
        Me.Controls.Add(Me.LabelMail)
        Me.Controls.Add(Me.LabelCPU)
        Me.Controls.Add(Me.LabelVersion)
        Me.Controls.Add(Me.LabelClock)
        Me.Controls.Add(Me.GroupBoxActions)
        Me.Controls.Add(Me.PictureBoxStatus)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.ButtonExit)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBoxStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxActions.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonExit As System.Windows.Forms.Button
    Friend WithEvents LabelStatus As System.Windows.Forms.Label
    Friend WithEvents PictureBoxStatus As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBoxActions As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonSettings As System.Windows.Forms.Button
    Friend WithEvents ButtonCommand As System.Windows.Forms.Button
    Friend WithEvents ButtonMail As System.Windows.Forms.Button
    Friend WithEvents LabelSettings As System.Windows.Forms.Label
    Friend WithEvents LabelCommand As System.Windows.Forms.Label
    Friend WithEvents LabelMail As System.Windows.Forms.Label
    Friend WithEvents LabelClock As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents LabelVersion As System.Windows.Forms.Label
    Friend WithEvents LabelCPU As System.Windows.Forms.Label
    Friend WithEvents LabelLogFiles As System.Windows.Forms.Label
    Friend WithEvents ButtonLogFiles As System.Windows.Forms.Button
    Friend WithEvents ButtonPutty As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonSMS As System.Windows.Forms.Button
    Friend WithEvents ButtonTest As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxSendSMS As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxSendMail As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonCoDisco As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents STimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CheckBoxStandby As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelETime As System.Windows.Forms.Label
    Friend WithEvents LabelSTime As System.Windows.Forms.Label
    Friend WithEvents ETimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonStandby As System.Windows.Forms.Button
End Class
