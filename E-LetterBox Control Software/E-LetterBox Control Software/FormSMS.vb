Imports System.Text.RegularExpressions
Public Class FormSMS


    Private Sub FormMail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Anfangswerte
        
        'Picturebox Settings
        PictureBoxName.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxText.SizeMode = PictureBoxSizeMode.Zoom

        'Dauer Bild wird definiert
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.Image = My.Resources.info

        'Daten werden geladen
        If MainForm.Connection.isConnected Then
            TextBoxNumber.Text = MainForm.Connection.Send_Command("send_number")
            RichTextBoxText.Text = ConvertText_Receive(MainForm.Connection.Send_Command("send_smstext"))
        Else
            MsgBox("Please connect to the Box first.", MsgBoxStyle.Critical)
        End If



    End Sub

    Private Sub ButtonChangeNumber_Click(sender As Object, e As EventArgs) Handles ButtonChangeNumber.Click
        'Der Input darf nicht null sein 
        If TextBoxNumber.Text <> "" Then
            Dim answ As String = MainForm.Connection.Send_Command("change_number")
            'Der Button wird in den Anfangszustand gebracht
            ButtonChangeNumber.Text = "Change!"

            'Falls die Box Korrekt antwortet wird der name gesendet
            If answ = "Waiting for the number to be sent..." Then
                answ = MainForm.Connection.Send_Command(TextBoxNumber.Text)
                MsgBox(answ)
                If answ = "Changed number to: " + TextBoxNumber.Text Then
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
            MsgBox("Die Eingabe darf nicht Null sein!")
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


    Private Sub Text_Changed(sender As Object, e As EventArgs) Handles ButtonChangeText.Click
        If MainForm.Connection.isConnected Then
            Dim answ As String = MainForm.Connection.Send_Command("change_smstext")
            If answ = "Waiting for the smstext to be sent..." Then
                answ = MainForm.Connection.Send_Command(ConvertText_Send(RichTextBoxText.Text))
                If answ = "Changed smstext to: " + ConvertText_Send(RichTextBoxText.Text) Then
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
    Private Sub Count_Length() Handles RichTextBoxText.TextChanged
        LabelWords.Text = CStr(RichTextBoxText.TextLength) + " / 160"
        If RichTextBoxText.TextLength = 160 Then
            'Das letzte Zeichen wird entfernt
            RichTextBoxText.Text = RichTextBoxText.Text.Substring(0, RichTextBoxText.TextLength - 1)
            MsgBox("Eine SMS hat maximal 160 Zeichen!", MsgBoxStyle.Critical)

        End If
    End Sub

    'Da nur eine SMS unterstützt wird, ist die Funktion erstmal deaktiviert
    'Private Sub RichTextBoxText_TextChanged(sender As Object, e As EventArgs) Handles RichTextBoxText.TextChanged
    'Zäher für das Label
    'Dim counter As Integer = RichTextBoxText.TextLength
    'Dim sms As Integer = Math.Ceiling(counter / 160)

    'Es wird nie 0 SMS angezeigt
    '   If sms = 0 Then
    '      sms = 1
    ' End If
    'Wenn es über eine SMS sind, dann wird der Text fett
    'If sms > 1 Then
    '   LabelWords.Font = New Font(LabelWords.Font.Name, LabelWords.Font.Size, FontStyle.Bold)
    'Else
    '   LabelWords.Font = New Font(LabelWords.Font.Name, LabelWords.Font.Size)

    '    End If


    '   LabelWords.Text = counter

    '    LabelWords.Text += "/ " + CStr(sms * 160) + " [" + CStr(sms) + " SMS]"

    'End Sub

End Class
