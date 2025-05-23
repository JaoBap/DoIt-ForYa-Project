Imports System.Runtime.InteropServices
Imports System.Text

Public Class classGetWindow
    Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    Private Declare Function FindWindowEx Lib "user32" Alias "FindWindowExA" (ByVal parentHandle As IntPtr, ByVal childAfter As IntPtr, ByVal lclassName As String, ByVal windowTitle As String) As Integer
    Private Declare Function GetClassName Lib "user32" Alias "GetClassNameA" (ByVal hwnd As Long, ByVal lpClassName As String, ByVal nMaxCount As Long) As Long
    Public Declare Function GetWindowText Lib "user32" Alias "GetWindowTextA" (ByVal hwnd As IntPtr, ByVal lpString As System.Text.StringBuilder, ByVal cch As Integer) As Integer
    Private Declare Function GetForegroundWindow Lib "user32.dll" () As Long

    Public Shared Function Capture_hWnd()
        'Captures current window
        Sleep.wait(2)
        Dim hwnd As Integer = GetForegroundWindow() 'returning active handle in decimal
        Return hwnd
    End Function
    Public Shared Function Capture_hWnd_NOW()
        'Captures current window no delay
        Dim hwnd As Integer = GetForegroundWindow() 'returning active handle in decimal
        Return hwnd
    End Function
    Public Shared Function Capture_Caption(ByRef hwnd As Integer) As String
        ' Create a buffer of 256 characters
        Dim Caption As New System.Text.StringBuilder(256)
        Dim strCaption As String = GetWindowText(hwnd, Caption, 256)
        Return Caption.ToString
    End Function
End Class