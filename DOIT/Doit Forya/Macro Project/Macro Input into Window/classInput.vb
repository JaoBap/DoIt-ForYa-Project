Imports System.IO
Imports System.Runtime.CompilerServices.RuntimeHelpers
Imports System.Runtime.InteropServices
Imports GregsStack.InputSimulatorStandard
Imports GregsStack.InputSimulatorStandard.Native

Public Class classInput
    '(D)A[5](U)A
    Public Declare Sub mouse_event Lib "user32" (ByVal dwFlags As UInteger,
                                                 ByVal dx As UInteger, ByVal dy As UInteger,
                                                 ByVal dwData As UInteger, ByVal dwExtraInfo As Integer)

    Public Shared Function SendMessage(hWnd As IntPtr, msg As Integer, wParam As IntPtr, lParam As IntPtr) As IntPtr
    End Function
    Public Shared Sub SendText(ByRef Text As String) 'extra
        Try
            Dim isim As New InputSimulator
            isim.Keyboard.TextEntry(Text)
        Catch ex As Exception
            'MsgBox(Text + ex.ToString)
        End Try
    End Sub
    Public Sub LogSendMessage(hWnd As IntPtr, msg As Integer, wParam As IntPtr)
        WriteLog($"Sending Message: hWnd={hWnd}, msg={msg}, wParam={wParam}")
    End Sub

    Public Sub LogResult(msg As Integer, result As IntPtr)
        WriteLog($"Message {msg} Result: {result}")
    End Sub

    Public Sub WriteLog(logEntry As String)2
        Using writer As New StreamWriter("SendMessageLog.txt", True)
            writer.WriteLine($"{DateTime.Now}: {logEntry}")
        End Using
    End Sub

    Public Shared Sub SendKeystrokeDown(ByRef hWnd As Integer, 'window handle
                                        ByRef WM_Keyaction As Integer,  'keydown or keyup
                                        ByRef VirtualKeyMessage As Integer, 'message like W or S
                                        ByRef lparam As Long, 'for send message window title
                                        ByRef wparam As Long) 'extra message requirement
        Try
            If hWnd = 0 Then
                MsgBox("No Window!")
            Else
                'If to see if its for mouse input cause input program dont work for mouse input on most elements
                If VirtualKeyMessage = 1 Then
                    mouse_event(&H2, 0, 0, 0, 0)
                Else
                    Dim isim As New InputSimulator 'to instantiate input for window
                    'sends input but its as if pressing a key, does not work to any application
                    'to send input to a window thats not in focus, we have to use send message and post message
                    'however both dont work, heres some theories why

                    'Doesnt send key but for some reason changes window name to last parameter
                    SendMessage(hWnd, WM_Keyaction, VirtualKeyMessage, IntPtr.Zero)

                    'LogSendMessage(hWnd, WM_Keyaction, New IntPtr(VirtualKeyMessage))
                    'LogResult(WM_Keyaction, SendMessage(hWnd, WM_Keyaction, New IntPtr(VirtualKeyMessage), IntPtr.Zero))



                    ''Old which is not desired
                    isim.Keyboard.KeyDown(VirtualKeyMessage)

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    'Only issue here is that it cant send input into background process, or unfocused window for multitasking. 
    Public Shared Sub SendKeystrokeUp(ByRef hWnd As Integer, ByRef WM_Keyaction As Integer, ByRef VirtualKeyMessage As Integer, ByRef lparam As Long, ByRef wparam As Long)
        Try
            'If to see if its for mouse input cause input program dont work for mouse input on most elements
            If VirtualKeyMessage = 1 Then
                mouse_event(&H4, 0, 0, 0, 0)
            Else
                Dim isim As New InputSimulator 'to instantiate input for window
                isim.Keyboard.KeyUp(VirtualKeyMessage) 'keydown not working NOT WORKING IN NOTEPAD
            End If
        Catch ex As Exception
            MsgBox("Probably wrong key:"(ex.ToString))
        End Try
    End Sub
End Class
