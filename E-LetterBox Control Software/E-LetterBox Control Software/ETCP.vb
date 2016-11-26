Imports System.IO
Imports System.Net.Sockets

Public Class ETCP
    'TCP VARIABLEN
    Dim stream As NetworkStream
    Dim streamwriter As StreamWriter
    Dim streamreader As StreamReader
    Dim client As New TcpClient

    'VARIABLE ZUM PRÜFEN DER VERBINDUNG
    Public Connected As Boolean

    'VARIABLE FÜR DIE ANTWORT
    Dim Received_Answer As String

    'DER 2te Thread für das Listen der Connection
    Private t As New Threading.Thread(AddressOf Listen)

    'Timer für den Stream checker
    Dim WithEvents Timer_Listen As New Timer

    Public Function Connect(ByVal Picturebox As PictureBox, ByVal StatusLabel As Label) As Boolean
        Dim hostname As String = My.Settings.hostname
        Dim port As Integer = My.Settings.port

        'DER TCP CLIENT WIRD NEU DEFINIERT

        'Timer zum Zuhören wird gestartet
        Timer_Listen.Interval = 100
        Timer_Listen.Start()

        client = New TcpClient
        StatusLabel.Text = "Connecting..."
        Application.DoEvents()

        If My.Settings.animations_enabled Then
            Picturebox.Image = My.Resources.spinner_animated
        Else
            Picturebox.Image = My.Resources.earth
        End If

        Try
            client.Connect(hostname, port)
        Catch ex As Exception
            StatusLabel.Text = "Couldn't reach host"
            MainForm.Update()

            MsgBox("Verbindung zu " & hostname & " konnte nicht hergestellt werden!" + vbNewLine + "Error Code:" + vbNewLine + ex.Message, MsgBoxStyle.Critical)

        End Try

        If client.Connected = True Then
            'TCP ACTIONS
            stream = client.GetStream
            streamwriter = New StreamWriter(stream)
            streamreader = New StreamReader(stream)

            'STATUS WIRD GESETZT
            Connected = True


            'UI WIRD GEUPDATET
            MainForm.UI_Connected()

        End If

        Return Connected

    End Function


    Public Sub Disconnect(ByVal Picturebox As PictureBox, ByVal StatusLabel As Label)

        If My.Settings.animations_enabled Then

            Picturebox.Image = My.Resources.spinner_animated

        Else
            Picturebox.Image = My.Resources.earth
        End If

        StatusLabel.Text = "Disconnecting...80%"


        ' TCP ACTIONS
        Send_Command("exit")
        client.Close()
        streamwriter.Close()
        streamreader.Close()

        'STATUS WIRD GESETZT
        Connected = False
        Timer_Listen.Stop()




        'INTERFACE ACTIONS
        MainForm.UI_Disconnected()
    End Sub
    Public Function Send_Command(ByVal command As String, Optional time As Integer = 400) As String
        If Connected = True Then
            Received_Answer = ""
            Send(command)
            Dim stp As New Stopwatch
            stp.Start()


            While Received_Answer = "" And stp.ElapsedMilliseconds < time
                Application.DoEvents()


            End While

            If Received_Answer <> "" Then
                Return Received_Answer
            Else
                Return "The Server didn't answer."
            End If


            stp.Stop()
            stp.Reset()


        End If

        Return ""

    End Function
    Private Sub Listen() Handles Timer_Listen.Tick
        'Wenn keine Daten bereitstehen, wird das Program sonst geblockt
        If Connected Then
            'Sonst kann auf den Stream nicht zugegriffen werden
            If stream.DataAvailable Then
                Received_Answer = streamreader.ReadLine

            End If
        End If

    End Sub
    Private Sub Send(ByVal sendtext As String)
        'DER STREAMWRITER SCHREIBT EINE ZEILE IN DEN STREAM
        Try
            streamwriter.WriteLine(sendtext)
            streamwriter.Flush()
        Catch
            MsgBox("E-Letterbox has disconnected!", MsgBoxStyle.Critical)
        End Try

    End Sub
    'DIE FUNKTION FINDET DIE IP ADRESSE DER E-LETTERBOX UND GIBT AN, OB SIE GEFUNDEN WURDE
    Public Function GetIP() As Boolean

        Dim IP As String
        Dim hostname As String = "e-letterbox"
        MainForm.Update()

        Try

            IP = System.Net.Dns.GetHostEntry(hostname).AddressList.ElementAt(0).ToString
            My.Settings.hostname = IP

            Application.DoEvents()

            Return True

        Catch ex As Exception
            MsgBox("Couldn't find E-letterbox. Please Contact the Adminastrator" + vbNewLine + "ErrorCode:" + vbNewLine + ex.Message, MsgBoxStyle.Critical)
            Application.DoEvents()

            Return False

        End Try



    End Function

    Private Sub Wait(time As Integer)
        Dim stp As New Stopwatch
        stp.Start()

        While stp.ElapsedMilliseconds < time

            Application.DoEvents()
        End While
        stp.Stop()

    End Sub

    Public Function isConnected() As Boolean
        Return Connected
    End Function
End Class



