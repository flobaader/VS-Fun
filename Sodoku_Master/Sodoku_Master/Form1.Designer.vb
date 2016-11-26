<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ConMenuSodoku = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripGenerate = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonGenerate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelTries = New System.Windows.Forms.Label()
        Me.ProgressBarGenerate = New System.Windows.Forms.ProgressBar()
        Me.LabelPrg = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.LabelTime = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBoxSave = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ProgressBarSaveMulti = New System.Windows.Forms.ProgressBar()
        Me.NumericUpDownSaveMulti = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonSaveMulti = New System.Windows.Forms.Button()
        Me.GroupBoxSchw = New System.Windows.Forms.GroupBox()
        Me.CheckBoxMAS = New System.Windows.Forms.CheckBox()
        Me.LabelMAS = New System.Windows.Forms.Label()
        Me.TrackBarGes = New System.Windows.Forms.TrackBar()
        Me.LabelQU = New System.Windows.Forms.Label()
        Me.TrackBarQUOO = New System.Windows.Forms.TrackBar()
        Me.LabelVT = New System.Windows.Forms.Label()
        Me.TrackBarVTOO = New System.Windows.Forms.TrackBar()
        Me.LabelHZ = New System.Windows.Forms.Label()
        Me.TrackBarHZOO = New System.Windows.Forms.TrackBar()
        Me.ToolTipSudoku = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolTipLabelStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabelCPU = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabelName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBoxSodoku = New System.Windows.Forms.GroupBox()
        Me.ConMenuSodoku.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxSave.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.NumericUpDownSaveMulti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxSchw.SuspendLayout()
        CType(Me.TrackBarGes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarQUOO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarVTOO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarHZOO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ConMenuSodoku
        '
        Me.ConMenuSodoku.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripGenerate, Me.ToolStripClear})
        Me.ConMenuSodoku.Name = "ConMenuSodoku"
        Me.ConMenuSodoku.Size = New System.Drawing.Size(122, 48)
        '
        'ToolStripGenerate
        '
        Me.ToolStripGenerate.AutoToolTip = True
        Me.ToolStripGenerate.Name = "ToolStripGenerate"
        Me.ToolStripGenerate.Size = New System.Drawing.Size(121, 22)
        Me.ToolStripGenerate.Text = "Generate"
        '
        'ToolStripClear
        '
        Me.ToolStripClear.Name = "ToolStripClear"
        Me.ToolStripClear.Size = New System.Drawing.Size(121, 22)
        Me.ToolStripClear.Text = "Reset"
        '
        'ButtonGenerate
        '
        Me.ButtonGenerate.Location = New System.Drawing.Point(19, 36)
        Me.ButtonGenerate.Name = "ButtonGenerate"
        Me.ButtonGenerate.Size = New System.Drawing.Size(75, 23)
        Me.ButtonGenerate.TabIndex = 1
        Me.ButtonGenerate.Text = "Generate"
        Me.ButtonGenerate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tries:"
        '
        'LabelTries
        '
        Me.LabelTries.AutoSize = True
        Me.LabelTries.Location = New System.Drawing.Point(105, 123)
        Me.LabelTries.Name = "LabelTries"
        Me.LabelTries.Size = New System.Drawing.Size(13, 13)
        Me.LabelTries.TabIndex = 3
        Me.LabelTries.Text = "0"
        '
        'ProgressBarGenerate
        '
        Me.ProgressBarGenerate.Location = New System.Drawing.Point(19, 65)
        Me.ProgressBarGenerate.Name = "ProgressBarGenerate"
        Me.ProgressBarGenerate.Size = New System.Drawing.Size(216, 23)
        Me.ProgressBarGenerate.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBarGenerate.TabIndex = 4
        '
        'LabelPrg
        '
        Me.LabelPrg.AutoSize = True
        Me.LabelPrg.Location = New System.Drawing.Point(118, 91)
        Me.LabelPrg.Name = "LabelPrg"
        Me.LabelPrg.Size = New System.Drawing.Size(21, 13)
        Me.LabelPrg.TabIndex = 5
        Me.LabelPrg.Text = "0%"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonCancel)
        Me.GroupBox1.Controls.Add(Me.LabelTime)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ButtonGenerate)
        Me.GroupBox1.Controls.Add(Me.LabelTries)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.LabelPrg)
        Me.GroupBox1.Controls.Add(Me.ProgressBarGenerate)
        Me.GroupBox1.Location = New System.Drawing.Point(618, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(241, 177)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Generiere Sodoku"
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(149, 36)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 8
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'LabelTime
        '
        Me.LabelTime.AutoSize = True
        Me.LabelTime.Location = New System.Drawing.Point(105, 149)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(18, 13)
        Me.LabelTime.TabIndex = 7
        Me.LabelTime.Text = "0s"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Elapsed Time:"
        '
        'GroupBoxSave
        '
        Me.GroupBoxSave.Controls.Add(Me.TabControl1)
        Me.GroupBoxSave.Location = New System.Drawing.Point(618, 479)
        Me.GroupBoxSave.Name = "GroupBoxSave"
        Me.GroupBoxSave.Size = New System.Drawing.Size(241, 133)
        Me.GroupBoxSave.TabIndex = 7
        Me.GroupBoxSave.TabStop = False
        Me.GroupBoxSave.Text = "Save Sodoku"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 19)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(235, 114)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(227, 88)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Save"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(223, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Click here to save current view of the Sudoku"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(69, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ProgressBarSaveMulti)
        Me.TabPage2.Controls.Add(Me.NumericUpDownSaveMulti)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.ButtonSaveMulti)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(227, 88)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Extended"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ProgressBarSaveMulti
        '
        Me.ProgressBarSaveMulti.Location = New System.Drawing.Point(9, 58)
        Me.ProgressBarSaveMulti.Name = "ProgressBarSaveMulti"
        Me.ProgressBarSaveMulti.Size = New System.Drawing.Size(205, 14)
        Me.ProgressBarSaveMulti.TabIndex = 5
        '
        'NumericUpDownSaveMulti
        '
        Me.NumericUpDownSaveMulti.Location = New System.Drawing.Point(48, 29)
        Me.NumericUpDownSaveMulti.Name = "NumericUpDownSaveMulti"
        Me.NumericUpDownSaveMulti.Size = New System.Drawing.Size(60, 20)
        Me.NumericUpDownSaveMulti.TabIndex = 4
        Me.NumericUpDownSaveMulti.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(2, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(220, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Click here to save more Sudokus of this type."
        '
        'ButtonSaveMulti
        '
        Me.ButtonSaveMulti.Location = New System.Drawing.Point(139, 29)
        Me.ButtonSaveMulti.Name = "ButtonSaveMulti"
        Me.ButtonSaveMulti.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSaveMulti.TabIndex = 2
        Me.ButtonSaveMulti.Text = "Save"
        Me.ButtonSaveMulti.UseVisualStyleBackColor = True
        '
        'GroupBoxSchw
        '
        Me.GroupBoxSchw.Controls.Add(Me.CheckBoxMAS)
        Me.GroupBoxSchw.Controls.Add(Me.LabelMAS)
        Me.GroupBoxSchw.Controls.Add(Me.TrackBarGes)
        Me.GroupBoxSchw.Controls.Add(Me.LabelQU)
        Me.GroupBoxSchw.Controls.Add(Me.TrackBarQUOO)
        Me.GroupBoxSchw.Controls.Add(Me.LabelVT)
        Me.GroupBoxSchw.Controls.Add(Me.TrackBarVTOO)
        Me.GroupBoxSchw.Controls.Add(Me.LabelHZ)
        Me.GroupBoxSchw.Controls.Add(Me.TrackBarHZOO)
        Me.GroupBoxSchw.Location = New System.Drawing.Point(619, 196)
        Me.GroupBoxSchw.Name = "GroupBoxSchw"
        Me.GroupBoxSchw.Size = New System.Drawing.Size(240, 277)
        Me.GroupBoxSchw.TabIndex = 8
        Me.GroupBoxSchw.TabStop = False
        Me.GroupBoxSchw.Text = "Schwierigkeit"
        '
        'CheckBoxMAS
        '
        Me.CheckBoxMAS.AutoSize = True
        Me.CheckBoxMAS.Location = New System.Drawing.Point(169, 34)
        Me.CheckBoxMAS.Name = "CheckBoxMAS"
        Me.CheckBoxMAS.Size = New System.Drawing.Size(65, 17)
        Me.CheckBoxMAS.TabIndex = 8
        Me.CheckBoxMAS.Text = "Enabled"
        Me.CheckBoxMAS.UseVisualStyleBackColor = True
        '
        'LabelMAS
        '
        Me.LabelMAS.AutoSize = True
        Me.LabelMAS.Location = New System.Drawing.Point(96, 34)
        Me.LabelMAS.Name = "LabelMAS"
        Me.LabelMAS.Size = New System.Drawing.Size(69, 13)
        Me.LabelMAS.TabIndex = 7
        Me.LabelMAS.Text = "Master Algo()"
        Me.ToolTipSudoku.SetToolTip(Me.LabelMAS, "Master Alogrithmus:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Wenn bei einer Zahl x in jeder Lücke in der horizontalen Rei" & _
        "he" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in der Vertikalen dieser Lücken ebenfalls x vorhanden ist, kann" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "die Zahl en" & _
        "tfernt werden.")
        '
        'TrackBarGes
        '
        Me.TrackBarGes.LargeChange = 3
        Me.TrackBarGes.Location = New System.Drawing.Point(45, 19)
        Me.TrackBarGes.Maximum = 9
        Me.TrackBarGes.Name = "TrackBarGes"
        Me.TrackBarGes.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBarGes.Size = New System.Drawing.Size(45, 235)
        Me.TrackBarGes.SmallChange = 3
        Me.TrackBarGes.TabIndex = 6
        Me.TrackBarGes.TickFrequency = 3
        '
        'LabelQU
        '
        Me.LabelQU.AutoSize = True
        Me.LabelQU.Location = New System.Drawing.Point(111, 61)
        Me.LabelQU.Name = "LabelQU"
        Me.LabelQU.Size = New System.Drawing.Size(42, 13)
        Me.LabelQU.TabIndex = 5
        Me.LabelQU.Text = "QU OO"
        Me.ToolTipSudoku.SetToolTip(Me.LabelQU, "Quadratischer Only-One Alogrithmus:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Wenn Alle Ziffer von 1 - 9 in einem Quadrat " & _
        "vorkommen," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "kann eine Ziffer entfert werden.")
        '
        'TrackBarQUOO
        '
        Me.TrackBarQUOO.Location = New System.Drawing.Point(107, 84)
        Me.TrackBarQUOO.Name = "TrackBarQUOO"
        Me.TrackBarQUOO.Size = New System.Drawing.Size(55, 45)
        Me.TrackBarQUOO.TabIndex = 4
        '
        'LabelVT
        '
        Me.LabelVT.AutoSize = True
        Me.LabelVT.Location = New System.Drawing.Point(113, 132)
        Me.LabelVT.Name = "LabelVT"
        Me.LabelVT.Size = New System.Drawing.Size(40, 13)
        Me.LabelVT.TabIndex = 3
        Me.LabelVT.Text = "VT OO"
        Me.ToolTipSudoku.SetToolTip(Me.LabelVT, "Vertikaler Only-One Alogrithmus:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Wenn Alle Ziffer von 1 - 9 in einer Reihe vorko" & _
        "mmen," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "kann eine Ziffer entfert werden.")
        '
        'TrackBarVTOO
        '
        Me.TrackBarVTOO.Location = New System.Drawing.Point(107, 148)
        Me.TrackBarVTOO.Name = "TrackBarVTOO"
        Me.TrackBarVTOO.Size = New System.Drawing.Size(55, 45)
        Me.TrackBarVTOO.TabIndex = 2
        '
        'LabelHZ
        '
        Me.LabelHZ.AutoSize = True
        Me.LabelHZ.Location = New System.Drawing.Point(117, 196)
        Me.LabelHZ.Name = "LabelHZ"
        Me.LabelHZ.Size = New System.Drawing.Size(41, 13)
        Me.LabelHZ.TabIndex = 1
        Me.LabelHZ.Text = "HZ OO"
        Me.ToolTipSudoku.SetToolTip(Me.LabelHZ, "Horizontaler Only-One Alogrithmus:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Wenn Alle Ziffer von 1 - 9 in einer Reihe vor" & _
        "kommen," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "kann eine Ziffer entfert werden.")
        '
        'TrackBarHZOO
        '
        Me.TrackBarHZOO.Location = New System.Drawing.Point(107, 212)
        Me.TrackBarHZOO.Name = "TrackBarHZOO"
        Me.TrackBarHZOO.Size = New System.Drawing.Size(58, 45)
        Me.TrackBarHZOO.TabIndex = 0
        '
        'ToolTipSudoku
        '
        Me.ToolTipSudoku.AutomaticDelay = 0
        Me.ToolTipSudoku.AutoPopDelay = 50000
        Me.ToolTipSudoku.InitialDelay = 0
        Me.ToolTipSudoku.ReshowDelay = 0
        Me.ToolTipSudoku.ShowAlways = True
        Me.ToolTipSudoku.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTipSudoku.ToolTipTitle = "Algorithmic Information"
        Me.ToolTipSudoku.UseAnimation = False
        Me.ToolTipSudoku.UseFading = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolTipLabelStatus, Me.ToolStripStatusLabelCPU, Me.ToolStripStatusLabelName})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 616)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(871, 24)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolTipLabelStatus
        '
        Me.ToolTipLabelStatus.Name = "ToolTipLabelStatus"
        Me.ToolTipLabelStatus.Size = New System.Drawing.Size(135, 19)
        Me.ToolTipLabelStatus.Text = "Status - CPU Auslastung"
        '
        'ToolStripStatusLabelCPU
        '
        Me.ToolStripStatusLabelCPU.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.ToolStripStatusLabelCPU.Name = "ToolStripStatusLabelCPU"
        Me.ToolStripStatusLabelCPU.Size = New System.Drawing.Size(518, 19)
        Me.ToolStripStatusLabelCPU.Spring = True
        Me.ToolStripStatusLabelCPU.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabelName
        '
        Me.ToolStripStatusLabelName.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.ToolStripStatusLabelName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabelName.Name = "ToolStripStatusLabelName"
        Me.ToolStripStatusLabelName.Size = New System.Drawing.Size(203, 19)
        Me.ToolStripStatusLabelName.Text = "Sudoku Master - Florian Baader 2015"
        Me.ToolStripStatusLabelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStripStatusLabelName.ToolTipText = "by Florian Baader"
        '
        'GroupBoxSodoku
        '
        Me.GroupBoxSodoku.BackgroundImage = Global.Sodoku_Master.My.Resources.Resources.Sodoku_Download_bearbeitet
        Me.GroupBoxSodoku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBoxSodoku.ContextMenuStrip = Me.ConMenuSodoku
        Me.GroupBoxSodoku.Cursor = System.Windows.Forms.Cursors.Cross
        Me.GroupBoxSodoku.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxSodoku.Name = "GroupBoxSodoku"
        Me.GroupBoxSodoku.Size = New System.Drawing.Size(600, 600)
        Me.GroupBoxSodoku.TabIndex = 0
        Me.GroupBoxSodoku.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 640)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBoxSchw)
        Me.Controls.Add(Me.GroupBoxSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBoxSodoku)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SodokuMaster - by Florian Baader"
        Me.ConMenuSodoku.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBoxSave.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.NumericUpDownSaveMulti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxSchw.ResumeLayout(False)
        Me.GroupBoxSchw.PerformLayout()
        CType(Me.TrackBarGes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarQUOO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarVTOO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarHZOO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBoxSodoku As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonGenerate As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelTries As System.Windows.Forms.Label
    Friend WithEvents ProgressBarGenerate As System.Windows.Forms.ProgressBar
    Friend WithEvents LabelPrg As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents LabelTime As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxSave As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ConMenuSodoku As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripGenerate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBoxSchw As System.Windows.Forms.GroupBox
    Friend WithEvents LabelHZ As System.Windows.Forms.Label
    Friend WithEvents TrackBarHZOO As System.Windows.Forms.TrackBar
    Friend WithEvents LabelVT As System.Windows.Forms.Label
    Friend WithEvents TrackBarVTOO As System.Windows.Forms.TrackBar
    Friend WithEvents LabelQU As System.Windows.Forms.Label
    Friend WithEvents TrackBarQUOO As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBarGes As System.Windows.Forms.TrackBar
    Friend WithEvents ToolTipSudoku As System.Windows.Forms.ToolTip
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents NumericUpDownSaveMulti As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ButtonSaveMulti As System.Windows.Forms.Button
    Friend WithEvents ProgressBarSaveMulti As System.Windows.Forms.ProgressBar
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolTipLabelStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents CheckBoxMAS As System.Windows.Forms.CheckBox
    Friend WithEvents LabelMAS As System.Windows.Forms.Label
    Friend WithEvents ToolStripStatusLabelName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabelCPU As System.Windows.Forms.ToolStripStatusLabel

End Class
