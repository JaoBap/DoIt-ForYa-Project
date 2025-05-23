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

    Public Shared Function PostMessage(hWnd As IntPtr, msg As Integer, wParam As IntPtr, lParam As IntPtr) As IntPtr
    End Function
    'In the future, send text needs to just send input of every character rather than just send text, 
    Public Shared Sub SendText(ByRef Text As String) 'extra
        Try
            If Text <> String.Empty Then
                Dim isim As New InputSimulator
                isim.Keyboard.TextEntry(Text)
            End If
        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try
    End Sub

    Public Sub WriteLog(logEntry As String)
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
                    'Dim isim As New InputSimulator 'to instantiate input for window

                    'the desire is to send input to a window even if it's not focused or "in the background".
                    'to achieve this, we need to use send or post message, similar to auto hotkey
                    'or find a plugin that achieves the functions of send or post message


                    'Post message for some reason is only sending key on up key and on anywindow thats focused. Which is weird
                    PostMessage(hWnd, WM_Keyaction, VirtualKeyMessage, IntPtr.Zero)
                    Debug.Print(VirtualKeyMessage)

                    'LogSendMessage(hWnd, WM_Keyaction, New IntPtr(VirtualKeyMessage))
                    'LogResult (WM_Keyaction, SendMessage(hWnd, WM_Keyaction , New IntPtr(VirtualKeyMessage), IntPtr.Zero))



                    ''Old which is not desired
                    ''isim.Keyboard.KeyDown(VirtualKeyMessage)

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
                PostMessage(hWnd, WM_Keyaction, VirtualKeyMessage, IntPtr.Zero)
                Debug.Print(VirtualKeyMessage)
            End If
        Catch ex As Exception
            MsgBox("Probably wrong key:"(ex.ToString))
        End Try
    End Sub
End Class
