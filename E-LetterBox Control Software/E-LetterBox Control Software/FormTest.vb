Public Class FormTest

    Private Sub FormTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

    Private Sub ButtonTestMail_Click(sender As Object, e As EventArgs) Handles ButtonTestMail.Click
        If MainForm.Connection.Connected Then
            Dim i As String
            i = MainForm.Connection.Send_Command("test_email")
            If i = "done" Then
                PictureBox1.Image = My.Resources.checkmark3_colored
                LabelStatus.Text = "Successfull!"
            Else
                PictureBox1.Image = My.Resources.blocked_colored
                LabelStatus.Text = "Error!"
            End If
        Else
            MsgBox("Please connect first!", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub ButtonTestSMS_Click(sender As Object, e As EventArgs) Handles ButtonTestSMS.Click
        If MainForm.Connection.Connected Then
            Dim i As String
            i = MainForm.Connection.Send_Command("test_sms")
            If i = "done" Then
                PictureBox1.Image = My.Resources.checkmark3_colored
                LabelStatus.Text = "Successfull!"
            Else
                PictureBox1.Image = My.Resources.blocked_colored
                LabelStatus.Text = "Error!"
            End If
        Else
            MsgBox("Please connect first!", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()

    End Sub
End Class