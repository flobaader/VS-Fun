Public Class Form1
    Dim Answers As New List(Of String)
    Public Namen As String = ""


    Private Sub TextBox_TextChanged(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TextBoxInput.KeyDown
        If e.KeyData = Keys.Enter Then
            Dim i As Integer = CInt(Math.Ceiling(Rnd() * Answers.Count))
            LabelAnswer.Text = Answers.Item(i)

            rtf.AppendText(Namen + ":" + TextBoxInput.Text + vbNewLine)
            rtf.AppendText("KI: " + LabelAnswer.Text + vbNewLine)

            TextBoxInput.Text = ""
        End If

    End Sub

    Private Sub Add_Answers()
        With Answers
            .Add("ok")
            .Add("ja genau")
            .Add("Meine Meinung")
            .Add("hmm")
            .Add("du hast recht")
            .Add("ja")
            .Add("gut")
            .Add("richtig")
        End With
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DialogName.ShowDialog()

        Add_Answers()

    End Sub
End Class
