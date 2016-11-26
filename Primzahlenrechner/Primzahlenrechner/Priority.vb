Option Explicit On
Module Priority


    ' Benötigte API-Deklarationen
    Private Const PROCESS_DUP_HANDLE = &H40
    Private Const PROCESS_SET_INFORMATION = &H200

    Private Declare Function GetCurrentProcessId Lib "kernel32" () As Long

    Private Declare Function OpenProcess Lib "kernel32" ( _
      ByVal dwDesiredAccess As Long, _
      ByVal bInheritHandle As Long, _
      ByVal dwProcessId As Long) As Long

    Private Declare Function SetPriorityClass Lib "kernel32" ( _
      ByVal hProcess As Long, _
      ByVal dwPriorityClass As Long) As Long

    Private Declare Function CloseHandle Lib "kernel32" ( _
      ByVal hObject As Long) As Long

    ' Prioritätsstufen
    Public Enum PriorityClass
        IDLE_PRIORITY_CLASS = &H40
        NORMAL_PRIORITY_CLASS = &H20
        HIGH_PRIORITY_CLASS = &H80
        REALTIME_PRIORITY_CLASS = &H100
    End Enum
    ' Prozess-Priorität ändern
    Public Sub SetPriority(ByVal nPriority As PriorityClass)
        Dim nPID As Long
        Dim hProcess As Long

        ' ProzessID ermitteln
        nPID = GetCurrentProcessId()

        ' Prozess-Handle
        hProcess = OpenProcess(PROCESS_DUP_HANDLE + PROCESS_SET_INFORMATION, 1, nPID)
        If hProcess <> 0 Then
            ' Prozess-Priorität setzen
            SetPriorityClass(hProcess, nPriority)
        End If

        ' Handle wieder freigeben
        CloseHandle(hProcess)
    End Sub
End Module
