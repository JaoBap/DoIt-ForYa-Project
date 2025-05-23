Imports System.Data.SqlClient

Public Class Hotkey
#Region "Declarations - WinAPI, Hotkey constant and Modifier Enum"
    ''' <summary>
    ''' Declaration of winAPI function wrappers. The winAPI functions are used to register / unregister a hotkey
    ''' </summary>
    Private Declare Function RegisterHotKey Lib "user32" _
        (ByVal hwnd As IntPtr, ByVal id As Integer, ByVal fsModifiers As Integer, ByVal vk As Integer) As Integer

    Private Declare Function UnregisterHotKey Lib "user32" (ByVal hwnd As IntPtr, ByVal id As Integer) As Integer

    Public Const WM_HOTKEY As Integer = &H312

    Enum KeyModifier
        None = 0
        Alt = &H1
        Control = &H2
        Shift = &H4
        Winkey = &H8
    End Enum 'This enum is just to make it easier to call the registerHotKey function: The modifier integer codes are replaced by a friendly "Alt","Shift" etc.
#End Region


#Region "Hotkey registration, unregistration and handling"
    Public Shared Sub registerHotkey(ByRef sourceForm As Form, ByVal hotkeyID As Integer, ByVal triggerKey As String, ByVal modifier As KeyModifier)
        RegisterHotKey(sourceForm.Handle, hotkeyID, modifier, Asc(triggerKey.ToUpper))
    End Sub
    'For virtual Keys
    Public Shared Sub registerVirtualHotkey(ByRef sourceForm As Form, ByVal hotkeyID As Integer, ByVal triggerKey As Integer, ByVal modifier As KeyModifier)
        RegisterHotKey(sourceForm.Handle, hotkeyID, modifier, triggerKey)

    End Sub
    Public Shared Sub unregisterHotkeys(ByRef sourceForm As Form)
        UnregisterHotKey(sourceForm.Handle, 1)  'Remember to call unregisterHotkeys() when closing your application.\
        UnregisterHotKey(sourceForm.Handle, 2)
        UnregisterHotKey(sourceForm.Handle, 21)
        UnregisterHotKey(sourceForm.Handle, 22)
        UnregisterHotKey(sourceForm.Handle, 2000)
        UnregisterHotKey(sourceForm.Handle, 2001)
        UnregisterHotKey(sourceForm.Handle, 2002)
        UnregisterHotKey(sourceForm.Handle, 2003)
        UnregisterHotKey(sourceForm.Handle, 2004)
        UnregisterHotKey(sourceForm.Handle, 2005)
        UnregisterHotKey(sourceForm.Handle, 2006)
        UnregisterHotKey(sourceForm.Handle, 2007)
        UnregisterHotKey(sourceForm.Handle, 2008)
        UnregisterHotKey(sourceForm.Handle, 2009)
        UnregisterHotKey(sourceForm.Handle, 2010)
        UnregisterHotKey(sourceForm.Handle, 2011)
        UnregisterHotKey(sourceForm.Handle, 2012)
        UnregisterHotKey(sourceForm.Handle, 2013)
    End Sub

    Public Shared Sub unregisterHotkey(ByRef sourceForm As Form, ByRef id As Integer)
        UnregisterHotKey(sourceForm.Handle, id)
    End Sub
    'The first parameter is the sourceform, essentially your main form.
    'The second parameter is a number ID for the hotkey registration, this can be any integer though with some limitations.
    'Next parameter is the key that needs to be pressed,
    'and the fourth and final is the modifier (alt, shift, control, winkey) if any.

#End Region

#Region "Cases for hotkey ID's"
    'Variabled Macros for slots
    Public Shared Sub handleHotKeyEvent(ByVal hotkeyID As IntPtr)
        Try


            Select Case hotkeyID
#Region "Main Macro Stuff"
                Case 1 ' hotkey that Starts macro by checking if loop is checked
                    MainForm.macroLoop(strFileLocation, 0)
                Case 2 'hotkey that stops loop
                    'says that program shouldnt loop
                    MainForm.boolBoxLoop = False
                    'says that macro should stop
                    boolStopMacro = True
#End Region
                Case 21 'For copying current mouse position to clip board
                    My.Computer.Clipboard.SetText(Cursor.Position.ToString)
                    MsgBox("Cursor Position copied: " + Cursor.Position.ToString)

                Case 22 'For getting window hwnd
                    hwnd = classGetWindow.Capture_hWnd_NOW() 'captures window through class
                    strWindowCaption = classGetWindow.Capture_Caption(hwnd) 'returns hwnd
                    MainForm.txtWindowCaption.Text = strWindowCaption 'sets textbox text as window caption
                    'should play a sound when done
                    My.Computer.Audio.PlaySystemSound(
                    System.Media.SystemSounds.Beep)
#Region "Slotted Macros"
                'stop isnt working for loop
                Case 2000 'Start slot 1
                    If MainForm.chkLoop1.Checked = True Then
                        MainForm.macroLoop(MainForm.gridSlotMacros.CurrentRow.Cells(1).Value.ToString, 1) 'EDIT loops if loop is checked
                    Else
                        MainForm.spu_macro(MainForm.gridSlotMacros.CurrentRow.Cells(1).Value.ToString, 1) ' EDIT needs to be a check if looping
                    End If
                Case 2001 'Stop Slot 1
                    intStopMacro = 1

                Case 2002 'start slot 2
                    If MainForm.chkLoop2.Checked = True Then
                        MainForm.macroLoop(MainForm.gridSlotMacros.CurrentRow.Cells(2).Value.ToString, 2) 'EDIT loops if loop is checked
                    Else
                        MainForm.spu_macro(MainForm.gridSlotMacros.CurrentRow.Cells(2).Value.ToString, 2) ' EDIT needs to be a check if looping
                    End If
                Case 2003 'stop slot 2
                    intStopMacro = 2

                Case 2004 'start slot 3
                    If MainForm.chkLoop3.Checked = True Then
                        MainForm.macroLoop(MainForm.gridSlotMacros.CurrentRow.Cells(3).Value.ToString, 3) 'EDIT loops if loop is checked
                    Else
                        MainForm.spu_macro(MainForm.gridSlotMacros.CurrentRow.Cells(3).Value.ToString, 3) ' EDIT needs to be a check if looping
                    End If
                Case 2005 'stop slot 3
                    intStopMacro = 3

                Case 2006 'start slot 4
                    If MainForm.chkLoop4.Checked = True Then
                        MainForm.macroLoop(MainForm.gridSlotMacros.CurrentRow.Cells(4).Value.ToString, 4) 'EDIT loops if loop is checked
                    Else
                        MainForm.spu_macro(MainForm.gridSlotMacros.CurrentRow.Cells(4).Value.ToString, 4) ' EDIT needs to be a check if looping
                    End If
                Case 2007 'stop slot 4
                    intStopMacro = 4

                Case 2008 'start slot 5
                    If MainForm.chkLoop5.Checked = True Then
                        MainForm.macroLoop(MainForm.gridSlotMacros.CurrentRow.Cells(5).Value.ToString, 5) 'EDIT loops if loop is checked
                    Else
                        MainForm.spu_macro(MainForm.gridSlotMacros.CurrentRow.Cells(5).Value.ToString, 5) ' EDIT needs to be a check if looping
                    End If
                Case 2009 'stop slot 5
                    intStopMacro = 5

                Case 2010 'start slot 6
                    If MainForm.chkLoop6.Checked = True Then
                        MainForm.macroLoop(MainForm.gridSlotMacros.CurrentRow.Cells(6).Value.ToString, 6) 'EDIT loops if loop is checked
                    Else
                        MainForm.spu_macro(MainForm.gridSlotMacros.CurrentRow.Cells(6).Value.ToString, 6) ' EDIT needs to be a check if looping
                    End If
                Case 2011 'stop slot 6
                    intStopMacro = 6

                Case 2012 'start slot 7
                    If MainForm.chkLoop7.Checked = True Then
                        MainForm.macroLoop(MainForm.gridSlotMacros.CurrentRow.Cells(7).Value.ToString, 7) 'EDIT loops if loop is checked
                    Else
                        MainForm.spu_macro(MainForm.gridSlotMacros.CurrentRow.Cells(7).Value.ToString, 7) ' EDIT needs to be a check if looping
                    End If
                Case 2013 'stop slot 7
                    intStopMacro = 7
#End Region
            End Select
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Hotkey Button Function"
    '1 Gets modifier
    'Only issue is some keys arent displaying correctly in keydata.tostring
    Public Shared Sub getHotkeyButtonKeyDown(e As KeyEventArgs)
        'Need modifier to get processed IF it's detected
        If e.Modifiers = Keys.Control Then
            intHotkeyGetModifier = &H2
        ElseIf e.Modifiers = Keys.Alt Then
            intHotkeyGetModifier = &H1
        ElseIf e.Modifiers = Keys.Shift Then
            intHotkeyGetModifier = &H4
        ElseIf e.Modifiers = Keys.None Then
            intHotkeyGetModifier = 0
        End If

    End Sub
    '2 Gets key
    Public Shared Sub getHotkeyButtonKeyUp(e As KeyEventArgs, MyForm As Form, ID As Integer)
        'if to see if esc is pressed
        If e.KeyCode = Keys.Escape Then
            boolGetHotkey = False
            btnText = "No Key" 'Edit
            intHotkeyGetModifier = 0
            Hotkey.unregisterHotkey(MyForm, ID) 'Edit
        Else
            'Changes Button Text
            btnText = (e.KeyData.ToString) 'Edit
            'Sets register Key
            Hotkey.registerVirtualHotkey(MyForm, ID, e.KeyCode, intHotkeyGetModifier) 'Edit
            'Stops hotkey get
            boolGetHotkey = False
            'Store key and modifer based on ID
            'Key
            intArrayHotkeys(ID, 0) = e.KeyCode
            'Modifier 
            intArrayHotkeys(ID, 1) = intHotkeyGetModifier

        End If
    End Sub

#End Region
End Class
