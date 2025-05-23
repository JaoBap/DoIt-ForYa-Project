Imports System.IO
Imports System.Runtime.InteropServices

Module moduleVariables
    'module is used to share variables/code across all items/classes
    Public Enum KeyEventType As Int32
        WM_SETTEXT = &HC
        WM_KEYDOWN = &H100
        WM_KEYUP = &H101
    End Enum 'For keydown, keyup, stuff
    Public Enum MouseEventType As Int32
        LEFTDOWN = &H2
        LEFTUP = &H4
        RIGHTDOWN = &H8
        RIGHTUP = &H10
        MIDDLEUP = &H40
        MIDDLEDOWN = &H20
    End Enum
    Public intHotkeyGetModifier As Integer = 0
    Public boolGetHotkey As Boolean 'boolean to get hotkey
    Public btnText As String 'string to set button text
    Public strFileLocation As String  'string for file location
    Public boolStopMacro As Boolean 'boolean to stop all macros
    Public intStopMacro As Integer 'Integer that represents which slot macro to stop 0 to not stop. EX: if its 2, then it stops slot 2 macro
    Public strDebugPath As String 'debug folder directory
    Public fileSettingstxt As IO.File
    Public hwnd As Integer 'for window handle
    Public intArrayHotkeys(2013, 2013) As Integer 'two dimmensional array for saving hotkeys
    Public strWindowName As String 'string for window name
    Public strWindowCaption As String = "No window!"

End Module
