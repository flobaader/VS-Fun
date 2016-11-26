<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTest
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
        Me.ButtonTestMail = New System.Windows.Forms.Button()
        Me.ButtonTestSMS = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonTestMail
        '
        Me.ButtonTestMail.Location = New System.Drawing.Point(20, 32)
        Me.ButtonTestMail.Name = "ButtonTestMail"
        Me.ButtonTestMail.Size = New System.Drawing.Size(96, 23)
        Me.ButtonTestMail.TabIndex = 0
        Me.ButtonTestMail.Text = "Send Test-Mail!"
        Me.ButtonTestMail.UseVisualStyleBackColor = True
        '
        'ButtonTestSMS
        '
        Me.ButtonTestSMS.Location = New System.Drawing.Point(20, 108)
        Me.ButtonTestSMS.Name = "ButtonTestSMS"
        Me.ButtonTestSMS.Size = New System.Drawing.Size(96, 23)
        Me.ButtonTestSMS.TabIndex = 1
        Me.ButtonTestSMS.Text = "Send Test-SMS!"
        Me.ButtonTestSMS.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ButtonExit)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.LabelStatus)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ButtonTestMail)
        Me.GroupBox1.Controls.Add(Me.ButtonTestSMS)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(532, 157)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Test your Config"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(476, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStatus.Location = New System.Drawing.Point(410, 72)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(60, 20)
        Me.LabelStatus.TabIndex = 9
        Me.LabelStatus.Text = "Status:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(122, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(344, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sendet eine Test-SMS, um zu prüfen, ob alles richtig konfiguriert wurde."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(122, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Sendet eine Test-E-Mail, um zu prüfen, ob alles richtig konfiguriert wurde."
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(451, 134)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonExit.TabIndex = 11
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'FormTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = Global.E_LetterBox_Control_Software.My.Resources.Resources.Default_Background_ac
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(566, 181)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Name = "FormTest"
        Me.Text = "Test your Configuration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonTestMail As System.Windows.Forms.Button
    Friend WithEvents ButtonTestSMS As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelStatus As System.Windows.Forms.Label
    Friend WithEvents ButtonExit As System.Windows.Forms.Button
End Class
