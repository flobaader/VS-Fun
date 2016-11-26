<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSMS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSMS))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNumber = New System.Windows.Forms.TextBox()
        Me.ButtonChangeNumber = New System.Windows.Forms.Button()
        Me.LabelNameStatus = New System.Windows.Forms.Label()
        Me.RichTextBoxText = New System.Windows.Forms.RichTextBox()
        Me.LabelTextStatus = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBoxName = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelWords = New System.Windows.Forms.Label()
        Me.ButtonChangeText = New System.Windows.Forms.Button()
        Me.PictureBoxText = New System.Windows.Forms.PictureBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBoxText, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-1, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Telefonnummer:"
        '
        'TextBoxNumber
        '
        Me.TextBoxNumber.Location = New System.Drawing.Point(131, 28)
        Me.TextBoxNumber.Name = "TextBoxNumber"
        Me.TextBoxNumber.Size = New System.Drawing.Size(165, 20)
        Me.TextBoxNumber.TabIndex = 2
        '
        'ButtonChangeNumber
        '
        Me.ButtonChangeNumber.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonChangeNumber.Location = New System.Drawing.Point(302, 27)
        Me.ButtonChangeNumber.Name = "ButtonChangeNumber"
        Me.ButtonChangeNumber.Size = New System.Drawing.Size(75, 23)
        Me.ButtonChangeNumber.TabIndex = 4
        Me.ButtonChangeNumber.Text = "Change!"
        Me.ButtonChangeNumber.UseVisualStyleBackColor = True
        '
        'LabelNameStatus
        '
        Me.LabelNameStatus.AutoSize = True
        Me.LabelNameStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNameStatus.Location = New System.Drawing.Point(468, 29)
        Me.LabelNameStatus.Name = "LabelNameStatus"
        Me.LabelNameStatus.Size = New System.Drawing.Size(56, 20)
        Me.LabelNameStatus.TabIndex = 8
        Me.LabelNameStatus.Text = "Status"
        '
        'RichTextBoxText
        '
        Me.RichTextBoxText.Location = New System.Drawing.Point(6, 32)
        Me.RichTextBoxText.Name = "RichTextBoxText"
        Me.RichTextBoxText.Size = New System.Drawing.Size(423, 230)
        Me.RichTextBoxText.TabIndex = 11
        Me.RichTextBoxText.Text = ""
        '
        'LabelTextStatus
        '
        Me.LabelTextStatus.AutoSize = True
        Me.LabelTextStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTextStatus.Location = New System.Drawing.Point(435, 84)
        Me.LabelTextStatus.Name = "LabelTextStatus"
        Me.LabelTextStatus.Size = New System.Drawing.Size(56, 20)
        Me.LabelTextStatus.TabIndex = 14
        Me.LabelTextStatus.Text = "Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "SMS Text:"
        '
        'ButtonClose
        '
        Me.ButtonClose.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ButtonClose.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClose.Location = New System.Drawing.Point(624, 463)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(80, 23)
        Me.ButtonClose.TabIndex = 18
        Me.ButtonClose.Text = "Okay"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxNumber)
        Me.GroupBox1.Controls.Add(Me.ButtonChangeNumber)
        Me.GroupBox1.Controls.Add(Me.PictureBoxName)
        Me.GroupBox1.Controls.Add(Me.LabelNameStatus)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(31, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(524, 68)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Einstellungen für den Versand"
        '
        'PictureBoxName
        '
        Me.PictureBoxName.Location = New System.Drawing.Point(420, 21)
        Me.PictureBoxName.Name = "PictureBoxName"
        Me.PictureBoxName.Size = New System.Drawing.Size(40, 40)
        Me.PictureBoxName.TabIndex = 6
        Me.PictureBoxName.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(239, 31)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "SMS Konfiguration"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.LabelWords)
        Me.GroupBox2.Controls.Add(Me.ButtonChangeText)
        Me.GroupBox2.Controls.Add(Me.RichTextBoxText)
        Me.GroupBox2.Controls.Add(Me.PictureBoxText)
        Me.GroupBox2.Controls.Add(Me.LabelTextStatus)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(31, 161)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(518, 296)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SMS Text einstellen"
        '
        'LabelWords
        '
        Me.LabelWords.AutoSize = True
        Me.LabelWords.Location = New System.Drawing.Point(9, 269)
        Me.LabelWords.Name = "LabelWords"
        Me.LabelWords.Size = New System.Drawing.Size(36, 13)
        Me.LabelWords.TabIndex = 19
        Me.LabelWords.Text = "0/100"
        '
        'ButtonChangeText
        '
        Me.ButtonChangeText.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonChangeText.Location = New System.Drawing.Point(438, 103)
        Me.ButtonChangeText.Name = "ButtonChangeText"
        Me.ButtonChangeText.Size = New System.Drawing.Size(75, 23)
        Me.ButtonChangeText.TabIndex = 18
        Me.ButtonChangeText.Text = "Change!"
        Me.ButtonChangeText.UseVisualStyleBackColor = True
        '
        'PictureBoxText
        '
        Me.PictureBoxText.Location = New System.Drawing.Point(438, 32)
        Me.PictureBoxText.Name = "PictureBoxText"
        Me.PictureBoxText.Size = New System.Drawing.Size(40, 40)
        Me.PictureBoxText.TabIndex = 13
        Me.PictureBoxText.TabStop = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Eras Demi ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(7, 29)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(182, 208)
        Me.RichTextBox1.TabIndex = 22
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.RichTextBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(561, 220)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(189, 237)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Information"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(561, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 188)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'FormSMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BackgroundImage = Global.E_LetterBox_Control_Software.My.Resources.Resources.Default_Background_ac
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(771, 510)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonClose)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormSMS"
        Me.Text = "Mail Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBoxName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBoxText, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNumber As System.Windows.Forms.TextBox
    Friend WithEvents ButtonChangeNumber As System.Windows.Forms.Button
    Friend WithEvents PictureBoxName As System.Windows.Forms.PictureBox
    Friend WithEvents LabelNameStatus As System.Windows.Forms.Label
    Friend WithEvents RichTextBoxText As System.Windows.Forms.RichTextBox
    Friend WithEvents LabelTextStatus As System.Windows.Forms.Label
    Friend WithEvents PictureBoxText As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonChangeText As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelWords As System.Windows.Forms.Label
End Class
