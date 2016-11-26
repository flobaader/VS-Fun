Public Class FormLogFiles

    Private Sub FormLogFiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Einstellungen zur Picturebox
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.Image = My.Resources.folder_open


        'Settings for Information 
        LabelIP.Text = "IP: " + My.Settings.hostname
        LabelPort.Text = "Port: 22"
        GroupBox2.Text = "FTP Connection to " & My.Settings.hostname + " @user"
        Me.Text = "FTP Connection - " + My.Settings.hostname

        Try
            'Die Url wird aufgerufen
            WebBrowser1.Url = New System.Uri("ftp://" + My.Settings.hostname)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Me.Close()

        End Try




    End Sub

    
   

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GroupBox2.Text = "FTP Connection to " & My.Settings.hostname + " @pi"
        WebBrowser1.Url = New System.Uri("ftp://pi@" + My.Settings.hostname)
    End Sub

    Private Sub Form_Settings_Close() Handles ButtonOK.Click
        Me.Close()
    End Sub


    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        WebBrowser1.Url = New System.Uri("ftp://" + My.Settings.hostname)
    End Sub
End Class