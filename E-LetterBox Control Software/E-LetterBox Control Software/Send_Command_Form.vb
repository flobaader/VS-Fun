Public Class Send_Command_Form


    Private Sub TextBoxComand_TextChanged(sender As Object, e As EventArgs) Handles TextBoxComand.TextChanged
        If TextBoxComand.Text = "" Then
            ButtonSend.Enabled = False
        Else
            ButtonSend.Enabled = True

        End If
    End Sub

    Private Sub Send_Command() Handles ButtonSend.Click
        If MainForm.Connection.Connected = True Then
            TextBoxAnswer.Text = MainForm.Connection.Send_Command(TextBoxComand.Text)
        Else
            MsgBox("Couldn't send message, because the Client is not connected", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Send_Command_Form_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxComand.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Bei Enter wird das Commando gesendet
            Send_Command()

        End If

        If e.KeyCode = Keys.Escape Then
            'Wenn ESC gedrückt wird, dann wird das Fenster geschlossen
            Me.Close()

        End If
    End Sub

    Private Sub Send_Command_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonSend.Enabled = False

        TextBoxComand.Text = ""
        TextBoxAnswer.Text = ""

        TextBoxComand.Focus()
        TextBoxComand.SelectionStart = TextBoxComand.TextLength
        TextBoxComand.ScrollToCaret()

        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.Image = My.Resources.console

    End Sub


   
End Class