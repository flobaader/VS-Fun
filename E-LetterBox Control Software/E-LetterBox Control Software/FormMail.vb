Imports System.Text.RegularExpressions
Public Class FormMail


    Private Sub FormMail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

      
        'Anfangswerte
        LabelEmailStatus.Text = ""
        LabelNameStatus.Text = ""

        'Picturebox Settings
        PictureBoxName.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxEMail.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxText.SizeMode = PictureBoxSizeMode.Zoom

        'Dauer Bild wird definiert
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.Image = My.Resources.info

        'Daten werden geladen
        If MainForm.Connection.isConnected Then
            TextBoxMail.Text = MainForm.Connection.Send_Command("send_email")
            TextBoxName.Text = MainForm.Connection.Send_Command("send_name")
            TextBoxSubject.Text = MainForm.Connection.Send_Command("send_subject")
            RichTextBoxText.Text = ConvertText_Receive(MainForm.Connection.Send_Command("send_text"))
        Else
            MsgBox("Please connect to the Box first.", MsgBoxStyle.Critical)
        End If



    End Sub

    Private Sub ButtonChangeName_Click(sender As Object, e As EventArgs) Handles ButtonChangeName.Click
        'Hier wird falls der Button noch auf Change steht das Feld writeable gemacht!
        If ButtonChangeName.Text = "Change!" Then
            'Die Anzeigen (Erfolgreich/nicht erflogreich) werden zurückgesetzt
            LabelNameStatus.Text = ""
            PictureBoxName.Image = Nothing

            TextBoxName.ReadOnly = False
            ButtonChangeName.Text = "Do it!"
        Else
            'Falls der Button vorher schon gedrückt wurde wird das Commando zum senden geschickt

            'Der Input darf nicht null sein 
            If TextBoxName.Text <> "" Then
                Dim answ As String = MainForm.Connection.Send_Command("change_name")
                'Der Button wird in den Anfangszustand gebracht
                TextBoxName.ReadOnly = True
                ButtonChangeName.Text = "Change!"

                'Falls die Box Korrekt antwortet wird der name gesendet
                If answ = "Waiting for the name to be sent..." Then
                    answ = MainForm.Connection.Send_Command(TextBoxName.Text)
                    MsgBox(answ)
                    If answ = "Changed name to: " + TextBoxName.Text Then
                        'Falls die Antwort nochmals korrekt war wird der Status auf Erfolgreich gesetzt
                        PictureBoxName.Image = My.Resources.checkmark3_colored
                        PictureBoxName.Refresh()

                        LabelNameStatus.Text = "Succesful!"
                    Else
                        'Wenn sie nicht erfolgreich war wird das angezeigt
                        PictureBoxName.Image = My.Resources.blocked_colored
                        PictureBoxName.Refresh()

                        LabelNameStatus.Text = "Error!"
                    End If
                End If
            Else
                MsgBox("The Input must not be nothing!")
            End If
        End If



    End Sub



    Private Sub ButtonChangeEmail_Click(sender As Object, e As EventArgs) Handles ButtonChangeEmail.Click
        'Hier wird falls der Button noch auf Change steht das Feld writeable gemacht!
        If ButtonChangeEmail.Text = "Change!" Then
            'Die Anzeigen (Erfolgreich/nicht erflogreich) werden zurückgesetzt
            LabelEmailStatus.Text = ""
            PictureBoxEMail.Image = Nothing

            TextBoxMail.ReadOnly = False
            ButtonChangeEmail.Text = "Done!"
        Else
            'Falls der Button vorher schon gedrückt wurde wird das Commando zum senden geschickt

            'Der Input darf nicht null sein 
            If TextBoxMail.Text <> "" Then
                Dim answ As String = MainForm.Connection.Send_Command("change_email")
                'Der Button wird in den Anfangszustand gebracht
                TextBoxMail.ReadOnly = True
                ButtonChangeEmail.Text = "Change!"

                'Falls die Box Korrekt antwortet wird der name gesendet
                If answ = "Waiting for the email to be sent..." Then
                    answ = MainForm.Connection.Send_Command(TextBoxMail.Text)
                    If answ = "Changed email to: " + TextBoxMail.Text Then
                        'Falls die Antwort nochmals korrekt war wird der Status auf Erfolgreich gesetzt
                        PictureBoxEMail.Image = My.Resources.checkmark3_colored
                        PictureBoxEMail.Refresh()

                        LabelEmailStatus.Text = "Succesful!"
                    Else
                        'Wenn sie nicht erfolgreich war wird das angezeigt
                        PictureBoxEMail.Image = My.Resources.blocked_colored
                        PictureBoxEMail.Refresh()

                        LabelEmailStatus.Text = "Error!"
                    End If
                End If
            Else
                MsgBox("The Input must not be nothing!")
            End If
        End If
    End Sub

    Private Function ConvertText_Send(raw_text As String)
        Dim text As String
        text = Replace(raw_text, ControlChars.Lf, "$&nl")

        Return text

    End Function
    Private Function ConvertText_Receive(raw_text As String)
        Dim text As String
        'MsgBox(raw_text)
        text = Replace(raw_text, "$&nl", vbNewLine)
        Return text
    End Function


    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub TextBoxSubject_TextChanged(sender As Object, e As EventArgs) Handles ButtonChangeSubject.Click
        'Erst wird geprüft ob die Software connected ist
        If MainForm.Connection.isConnected Then
            Dim answ As String = MainForm.Connection.Send_Command("change_subject")
            'Bei richtiger antwort wird der Text gesendet
            If answ = "Waiting for the subject to be sent..." Then
                answ = MainForm.Connection.Send_Command(TextBoxSubject.Text)
                If answ = "Changed subject to: " & TextBoxSubject.Text Then
                    PictureBoxText.Image = My.Resources.checkmark3_colored
                    PictureBoxText.Refresh()

                    LabelTextStatus.Text = "Successful!"
                Else
                    PictureBoxText.Image = My.Resources.blocked_colored
                    PictureBoxText.Refresh()
                    LabelTextStatus.Text = "Error!"

                End If

            Else
                PictureBoxText.Image = My.Resources.blocked_colored
                PictureBoxText.Refresh()
                LabelTextStatus.Text = "Error!"
            End If

        Else
            MsgBox("Please connect first", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Text_Changed(sender As Object, e As EventArgs) Handles ButtonChangeText.Click
        If MainForm.Connection.isConnected Then
            Dim answ As String = MainForm.Connection.Send_Command("change_text")
            If answ = "Waiting for the text to be sent..." Then
                answ = MainForm.Connection.Send_Command(ConvertText_Send(RichTextBoxText.Text))
                If answ = "Changed text to: " + ConvertText_Send(RichTextBoxText.Text) Then
                    PictureBoxText.Image = My.Resources.checkmark3_colored
                    PictureBoxText.Refresh()
                    LabelTextStatus.Text = "Successful!"
                Else
                    PictureBoxText.Image = My.Resources.blocked_colored
                    PictureBoxText.Refresh()
                    LabelTextStatus.Text = "Error!"
                End If
            Else
                PictureBoxText.Image = My.Resources.blocked_colored
                PictureBoxText.Refresh()
                LabelTextStatus.Text = "Error!"
            End If
        Else
            MsgBox("Please connect first", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub ButtonChangeText_Click(sender As Object, e As EventArgs)
        MsgBox(RichTextBoxText.Text)
    End Sub
End Class