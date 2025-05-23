Imports System.ComponentModel
Imports System.Drawing.Imaging
Imports System.Drawing.Text
Imports System.IO
Imports System.Runtime.CompilerServices.RuntimeHelpers
Imports System.Runtime.DesignerServices
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Security.Cryptography.X509Certificates
Imports System.Security.Principal
Imports System.Text
Imports System.Threading
Imports System.Windows
Imports System.Windows.Forms.DataFormats
Imports System.Windows.Forms.Design
Imports System.Windows.Forms.VisualStyles
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Data
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports Microsoft.VisualBasic.Devices
''' <summary>
''' Primary Objective: Get it to work in background for multitasking, first for keyboard, second for mouse
''' </summary>
Public Class MainForm
#Region "Privated MainForm Variables"

    Dim intProcID = 0 'process id for window desired
    Public Shared boolBoxLoop As Boolean 'boolean to see if u want loop to stop (Can be used to stop loops in other subs)
#End Region

#Region "Selecting Window"
    'For selecting macro window
    Private Declare Function SetForegroundWindow Lib "user32" Alias "SetForegroundWindow" (ByVal hwnd As IntPtr) As Integer


    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        'Grabs window caption
        txtWindowCaption.Text = "Scanning for 2 seconds... (Will beep when window is captured, Open Desired Window!)" 'Friendly notification saying looking for window
        'Grabs window handle
        hwnd = classGetWindow.Capture_hWnd() 'waits five seconds before setting focused window as desired window
        strWindowCaption = classGetWindow.Capture_Caption(hwnd) 'returns hwnd
        txtWindowCaption.Text = strWindowCaption 'sets textbox text as window caption
        'should play a sound when done
        My.Computer.Audio.PlaySystemSound(
        System.Media.SystemSounds.Beep)
    End Sub
#End Region

#Region "Macro"
    'Main Macro
    Private Declare Function VkKeyScanEx Lib "user32.dll" Alias "VkKeyScanExA" (ByVal ch As Char, ByVal hkl As Long) As Integer
    Public Function KeyFromString(theKey As String) As Keys
        Dim kc As KeysConverter = New KeysConverter()
        Return CType(kc.ConvertFrom(theKey), Keys)
    End Function
    Private Sub MoveCursorToMonitor(screenIndex As Integer)
        'Grabs all screens
        Dim screens As Screen() = Screen.AllScreens
        'If to find if focused screen is not main
        If screenIndex >= 0 AndAlso screenIndex < screens.Length Then
            Dim targetScreen As Screen = screens(screenIndex)
            'Sets cursor to new screen
            Cursor.Position = New Point(targetScreen.Bounds.Left + targetScreen.Bounds.Width \ 2,
                                        targetScreen.Bounds.Top + targetScreen.Bounds.Height \ 2)
        End If
    End Sub

    Public Sub spu_macro(ByVal Macrodirectory0 As String, ByRef intStopMacroF As Integer)
        Dim boolContinue As Boolean
        Dim chrAMacro0() As Char

        If hwnd > 0 Then

            'SetForegroundWindow(hwnd) 'sets window as active and to front

            If txtInput.Text = String.Empty And intStopMacroF = 0 Then 'Checks if directory exists then Declares and savesmacro file with variable above as its file directory
                MsgBox("Nothing in text box, maybe no file loaded?")

                'if for slot macros, if its a slot macro, read file from directory provided and input into chramacro0
            ElseIf intStopMacroF > 0 Then
                Dim infile As IO.StreamReader
                If IO.File.Exists(Macrodirectory0) Then
                    infile = IO.File.OpenText(Macrodirectory0)
                End If
                chrAMacro0 = infile.ReadToEnd
                boolContinue = True

                'if main macro
            Else
                chrAMacro0 = txtInput.Text.ToCharArray

                boolContinue = True
            End If
        Else
            MsgBox("No window selected!")
        End If

        If boolContinue = True Then

            Dim boolParanthesis = False 'boolean to see if input has paranethesis
            Dim boolBrackets = False 'Boolean to see if input has brackets
            Dim boolholddownislooping As Boolean 'boolean for holddown check from previous if check
            Dim boolCurlyBrackets As Boolean
            Dim boolXCurly As Boolean
            Dim boolYCurly As Boolean

            Dim strInterval0 As String = String.Empty 'declares str for interval input
            Dim strCharacter As New StringBuilder() 'as for each continues, it makes a string to see what key it needs to see pressed
            Dim strXMouse As New StringBuilder()
            Dim strYMouse As New StringBuilder()

            Dim intCharCount As Integer
            Dim intXMouse As Double
            Dim intYMouse As Double


            'Core for each loop that fires macro per char in txtinput
            For Each i In chrAMacro0 'For each loop, that checks each character in chararray for if statements for Paranthesis, brackets, 

                'Stop for each if desire is to stop
                If boolStopMacro = True AndAlso intStopMacroF > 0 And intStopMacroF = intStopMacro Then
                    'turns back to false for next program desire
                    boolStopMacro = False
                    Exit For
                End If

                Dim VK As Integer = VkKeyScanEx(i, vbNull)
                intCharCount += 1
                '(D)A[5](U)A is hold A down, wait five seconds, stop holding A down

                'For appending string if not start of statement
                If i = "(" Then
                    boolParanthesis = True

                ElseIf i = ")" Then
                    boolParanthesis = False

                    'If brackets in char
                ElseIf i = "[" Then
                    boolBrackets = True

                ElseIf i = "]" Then
                    boolBrackets = False
                    Dim interval As Integer = Integer.Parse(strInterval0)
                    Sleep.wait(interval) 'Interval Code, gets string from txt, times it by 1000, turning it into a seconds
                    strInterval0 = String.Empty
                    'If curly brackets in char
                ElseIf i = "{" Then
                    '{X=2034,Y=498}
                    boolCurlyBrackets = True

                    'Starts interval
                ElseIf i = "}" Then
                    boolCurlyBrackets = False
                    Try
                        intXMouse = CInt(strXMouse.ToString)
                        intYMouse = CInt(strYMouse.ToString)

                        Cursor.Position = New Point(intXMouse, intYMouse)
                        strXMouse.Clear()
                        strYMouse.Clear()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try

                    'If i is for key to be pressed
                ElseIf boolBrackets = False And boolParanthesis = False And boolCurlyBrackets = False Then
                    strCharacter.Append(i)
                End If

                'If to see if not at end of chr array, then sends input
                If boolBrackets = False And boolParanthesis = False And boolCurlyBrackets = False _ 'not in a statement
                        And strCharacter.ToString IsNot String.Empty _ 'Makes sure string is valid
                        And intCharCount = chrAMacro0.Length Then 'the chrarray is at its limit
                    'Sends input based on string
                    If boolholddownislooping = False Then 'Hold Key Down
                        'Only issue is that it needs to be typed the exact way
                        Try
                            'Doesnt part lower case letters for converting to key variable well
                            Dim mykey As Keys = DirectCast([Enum].Parse(GetType(Keys), strCharacter.ToString), Keys)

                            classInput.SendKeystrokeUp(hwnd, KeyEventType.WM_KEYUP, mykey, vbNull, vbNull)
                        Catch ex As Exception 'If key is unrecognizable
                            classInput.SendText(strCharacter.ToString)
                        End Try
                        strCharacter.Clear()
                    ElseIf boolholddownislooping = True Then 'Let Key Go or press key
                        Try
                            Dim mykey As Keys = DirectCast([Enum].Parse(GetType(Keys), strCharacter.ToString), Keys)
                            classInput.SendKeystrokeDown(hwnd, KeyEventType.WM_KEYDOWN, mykey, vbNull, vbNull)
                        Catch ex As Exception 'If key is unrecognizable
                            classInput.SendText(strCharacter.ToString)
                        End Try
                        boolholddownislooping = False 'resets hold down for variable
                        strCharacter.Clear()
                    End If

                    'If to check if code input starts with parenthesis or brackets or whatever, so if the first desire is to say its to hold the key down
                ElseIf i = "(" Or i = "[" Or i = "{" AndAlso
                    strCharacter IsNot Nothing And
                    intCharCount <> chrAMacro0.Length Then 'Makes sure string is valid
                    'Sends input based on string
                    If boolholddownislooping = False Then 'Hold Key Down
                        Try
                            'For some reason this part of the code is trying to input (?

                            Dim mykey As Keys = DirectCast([Enum].Parse(GetType(Keys), strCharacter.ToString), Keys)
                            classInput.SendKeystrokeUp(hwnd, KeyEventType.WM_KEYUP, mykey, vbNull, vbNull)

                        Catch ex As Exception 'If key is unrecognizable
                            classInput.SendText(strCharacter.ToString)
                        End Try
                        strCharacter.Clear()
                    ElseIf boolholddownislooping = True Then 'Let Key Go or press key
                        Try
                            Dim mykey As Keys = DirectCast([Enum].Parse(GetType(Keys), strCharacter.ToString), Keys)
                            classInput.SendKeystrokeDown(hwnd, KeyEventType.WM_KEYDOWN, mykey, vbNull, vbNull)
                        Catch ex As Exception 'If key is unrecognizable
                            classInput.SendText(strCharacter.ToString)
                        End Try
                        boolholddownislooping = False 'resets hold down for variable
                        strCharacter.Clear()
                    End If
                End If


                'For interval between presses
                If boolBrackets = True Then
                    Try
                        If IsNumeric(i) Then 'checks if number, if so it inputs it (Issue with double or triple digit numbers)
                            strInterval0 &= i 'Reads the number, not adds
                        End If
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If

                'For Hold down button
                If boolParanthesis = True Then
                    If i = "D" Then 'if to press down
                        boolholddownislooping = True
                    ElseIf i = "U" Then
                        boolholddownislooping = False
                    End If
                End If
                'for setting mouse position
                If boolCurlyBrackets = True Then
                    '{X=2014,Y=586}
                    'need to read for x value
                    If i = "X" Then
                        boolXCurly = True
                        boolYCurly = False
                    End If
                    If boolXCurly = True Then
                        If IsNumeric(i) Or i = "-" Then
                            strXMouse.Append(i)
                        End If
                    End If
                    'need to read for y value
                    If i = "Y" Then
                        boolYCurly = True
                        boolXCurly = False
                    End If
                    If boolYCurly = True Then
                        If IsNumeric(i) Or i = "-" Then
                            strYMouse.Append(i)
                        End If
                    End If
                End If

            Next
        End If
    End Sub
    'Loop macro
    Public Sub macroLoop(ByVal macroLocation As String, ByRef intSlotValue As Integer)
        If hwnd > 0 Then
            'if for main macro or main macro
            If boolBoxLoop = True And intSlotValue = 0 Then
                Do While boolBoxLoop = True  'actual loop to loop main function until a stop command is entered, might have to add stop command to EVERY loop in here
                    spu_macro(macroLocation, intSlotValue)
                Loop

                'if inslotvalue is greater than 0, meaning its for a slotted macro
            ElseIf intSlotValue > 0 Then
                Do 'loop for slots
                    'Indicates macro is running
                    gridSlotMacros.Rows(intSlotValue - 1).Cells(2).Value = "R"
                    spu_macro(macroLocation, intSlotValue)
                Loop Until intSlotValue = intStopMacro
                'Indicates macro is paused
                gridSlotMacros.Rows(intSlotValue - 1).Cells(2).Value = "P"
                intStopMacro = 0
            ElseIf intSlotValue = 0 Then
                spu_macro(macroLocation, intSlotValue)
            End If
        Else
            MsgBox("No Window Selected!")
        End If
    End Sub
    'button start
#End Region

#Region "Basic Form Tools"
    Public Sub btnStart0_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        macroLoop(strFileLocation, 0) 'Starts macro by checking if loop is checked
    End Sub
    'button stop
    Public Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        boolBoxLoop = False
    End Sub
    'loop checkbox
    Private Sub chkLoop_CheckedChanged(sender As Object, e As EventArgs) Handles chkLoop.CheckedChanged
        If chkLoop.Checked = True Then 'if loop for looping macro
            boolBoxLoop = True
        Else
            boolBoxLoop = False
        End If
    End Sub
    'exit button
    Private Sub btnExit_Click(sender As Object, e As EventArgs) 
        'declares new var as dialogresult type
        Dim dlgButton As DialogResult
        'sets new var as message box for dialog
        dlgButton =
            MessageBox.Show("Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If dlgButton = DialogResult.Yes Then 'if statement to see if return value for dialog is yes, if yes than close program
            Hotkey.unregisterHotkeys(Me)
            Me.Close()
        End If
    End Sub

#End Region

#Region "On Form Start and end"
    'System wide hotkey event handling
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = Hotkey.WM_HOTKEY Then
            Hotkey.handleHotKeyEvent(m.WParam)
        End If
        MyBase.WndProc(m)
    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        strDebugPath = Application.StartupPath.ToString
        classLoad.loadEverything("\settings.txt")
    End Sub

    Private Sub MainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = False
        boolStopMacro = True
        'declares new var as dialogresult type
        Dim dlgButton As DialogResult
        'sets new var as message box for dialog
        dlgButton =
            MessageBox.Show("Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)

        If dlgButton = DialogResult.Yes Then 'if statement to see if return value for dialog is yes, if yes than close program
            Hotkey.unregisterHotkeys(Me)
        Else
            e.Cancel = True
        End If
    End Sub

#End Region

#Region "Main Macro Tab Tools/stuff"
    Private Sub btnLoadSelectedMacro_Click(sender As Object, e As EventArgs) Handles btnLoadSelectedMacro.Click
        filedialogLoadMacroMain.ShowDialog()
        strFileLocation = filedialogLoadMacroMain.FileName
        lblMacroname.Text = filedialogLoadMacroMain.FileName

        If IO.File.Exists(strFileLocation) Then 'Checks if directory exists then Declares and savesmacro file with variable above as its file directory
            Dim Macro0 As IO.StreamReader
            Macro0 = IO.File.OpenText(strFileLocation)
            txtInput.Text = Macro0.ReadToEnd 'Reads Macro text file that is "loaded" (D)A[5](U)A is hold A down, wait five seconds, stop holding A down
            Macro0.Close()
        End If
    End Sub

    'Save main macro in macro tab
    Private Sub btnSaveSelectedMacro_Click(sender As Object, e As EventArgs) Handles btnSaveSelectedMacro.Click
        filedialogSaveMacroMain.ShowDialog()
        Dim writetxtfile As New StreamWriter(filedialogSaveMacroMain.FileName)
        writetxtfile.WriteLine(txtInput.Text)
        writetxtfile.Close()
    End Sub
#End Region

#Region "Macro Pages Tab tools/stuff"
    Dim strLoadMacroList As New List(Of String)
#Region "Slot System for macro page tab"

#Region "Slotted Macros Datagrid View"
    'Add Macros by double clicking in macro pages datagridview's
    Private Sub gridSavedMacros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridSavedMacros.CellContentClick
        'adds macro to loaded macros into available slot
        gridSlotMacros.Rows.Add(gridSavedMacros.CurrentRow.Cells(0).Value.ToString, gridSavedMacros.CurrentRow.Cells(1).Value.ToString, "P")
    End Sub
    Private Sub gridFavMacros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridFavMacros.CellContentClick
        gridSlotMacros.Rows.Add(gridFavMacros.CurrentRow.Cells(0).Value.ToString, gridFavMacros.CurrentRow.Cells(1).Value.ToString, "P")
    End Sub
    'Remove Macros by double clicking in slotted macro datagridview
    Private Sub gridSlotMacros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridSlotMacros.CellContentClick
        'if to see if user wants to remove from slot
        'Message Prompt if user wants to remove macro to double check
        Dim dlgButton As DialogResult = MessageBox.Show("Delete Row?", "Remove Slot", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Beep)
        If dlgButton = DialogResult.Yes Then 'if statement to see if return value for dialog is yes
            'Macro is removed from text box
            gridSlotMacros.Rows.RemoveAt(gridSlotMacros.CurrentCell.RowIndex)
        End If
    End Sub
    'To start loop for said macro'd slot

#End Region

#Region "Slots"
    'register hotkey functions for each slots hotkeys for start and stop

#Region "Clicking button start"
    'Click button to get hotkey
    Private Sub btnstart1_click(sender As Object, e As EventArgs) Handles btnStart1.Click 'Edit twice
        boolGetHotkey = True
        btnStart1.Text = "Press Key" 'Edit
        intHotkeyGetModifier = 0
        Hotkey.unregisterHotkey(Me, 2000) 'Edit
    End Sub
    Private Sub btnstart2_click(sender As Object, e As EventArgs) Handles btnStart2.Click 'Edit twice
        boolGetHotkey = True
        btnStart2.Text = "Press Key" 'Edit
        intHotkeyGetModifier = 0
        Hotkey.unregisterHotkey(Me, 2002) 'Edit
    End Sub
    Private Sub btnstart3_click(sender As Object, e As EventArgs) Handles btnStart3.Click 'Edit twice
        boolGetHotkey = True
        btnStart3.Text = "Press Key" 'Edit
        intHotkeyGetModifier = 0
        Hotkey.unregisterHotkey(Me, 2004) 'Edit
    End Sub
    Private Sub btnstart4_click(sender As Object, e As EventArgs) Handles btnStart4.Click 'Edit twice
        boolGetHotkey = True
        btnStart4.Text = "Press Key" 'Edit
        intHotkeyGetModifier = 0
        Hotkey.unregisterHotkey(Me, 2006) 'Edit
    End Sub
    Private Sub btnstart5_click(sender As Object, e As EventArgs) Handles btnStart5.Click 'Edit twice
        boolGetHotkey = True
        btnStart5.Text = "Press Key" 'Edit
        intHotkeyGetModifier = 0
        Hotkey.unregisterHotkey(Me, 2008) 'Edit
    End Sub
    Private Sub btnstart6_click(sender As Object, e As EventArgs) Handles btnStart6.Click 'Edit twice
        boolGetHotkey = True
        btnStart6.Text = "Press Key" 'Edit
        intHotkeyGetModifier = 0
        Hotkey.unregisterHotkey(Me, 2010) 'Edit
    End Sub
    Private Sub btnstart7_click(sender As Object, e As EventArgs) Handles btnStart7.Click 'Edit twice
        boolGetHotkey = True
        btnStart7.Text = "Press Key" 'Edit
        intHotkeyGetModifier = 0
        Hotkey.unregisterHotkey(Me, 2012) 'Edit
    End Sub
#End Region

#Region "Clicking button stop"
    Private Sub btnstop1_Click(sender As Object, e As EventArgs) Handles btnStop1.Click 'Edit twice
        boolGetHotkey = True
        btnStop1.Text = "Press Key" 'Edit
        intHotkeyGetModifier = 0
        Hotkey.unregisterHotkey(Me, 2001) 'Edit
    End Sub
    Private Sub btnstop2_Click(sender As Object, e As EventArgs) Handles btnStop2.Click 'Edit twice
        boolGetHotkey = True
        btnStop2.Text = "Press Key" 'Edit
        intHotkeyGetModifier = 0
        Hotkey.unregisterHotkey(Me, 2003) 'Edit
    End Sub
    Private Sub btnstop3_Click(sender As Object, e As EventArgs) Handles btnStop3.Click 'Edit twice
        boolGetHotkey = True
        btnStop3.Text = "Press Key" 'Edit
        intHotkeyGetModifier = 0
        Hotkey.unregisterHotkey(Me, 2005) 'Edit
    End Sub
    Private Sub btnstop4_Click(sender As Object, e As EventArgs) Handles btnStop4.Click 'Edit twice
        boolGetHotkey = True
        btnStop4.Text = "Press Key" 'Edit
        intHotkeyGetModifier = 0
        Hotkey.unregisterHotkey(Me, 2007) 'Edit
    End Sub
    Private Sub btnstop5_Click(sender As Object, e As EventArgs) Handles btnStop5.Click 'Edit twice
        boolGetHotkey = True
        btnStop5.Text = "Press Key" 'Edit
        intHotkeyGetModifier = 0
        Hotkey.unregisterHotkey(Me, 2009) 'Edit
    End Sub
    Private Sub btnstop6_Click(sender As Object, e As EventArgs) Handles btnStop6.Click 'Edit twice
        boolGetHotkey = True
        btnStop6.Text = "Press Key" 'Edit
        intHotkeyGetModifier = 0
        Hotkey.unregisterHotkey(Me, 2011) 'Edit
    End Sub
    Private Sub btnstop7_Click(sender As Object, e As EventArgs) Handles btnStop7.Click 'Edit twice
        boolGetHotkey = True
        btnStop7.Text = "Press Key" 'Edit
        intHotkeyGetModifier = 0
        Hotkey.unregisterHotkey(Me, 2013) 'Edit
    End Sub
#End Region

#Region "Key down"
    'slot 1
    Private Sub btnstart1_KeyDown(sender As Object, e As KeyEventArgs) Handles btnStart1.KeyDown 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyDown(e) 'edit
            btnStart1.Text = btnText 'edit
        End If
    End Sub
    Private Sub btnstop1_KeyDown(sender As Object, e As KeyEventArgs) Handles btnStop1.KeyDown 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyDown(e)
            btnStop1.Text = btnText 'edit
        End If
    End Sub

    'slot 2
    Private Sub btnstart2_KeyDown(sender As Object, e As KeyEventArgs) Handles btnStart2.KeyDown 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyDown(e)
            btnStart2.Text = btnText 'edit
        End If
    End Sub
    Private Sub btnstop2_KeyDown(sender As Object, e As KeyEventArgs) Handles btnStop2.KeyDown 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyDown(e)
            btnStop2.Text = btnText 'edit
        End If
    End Sub

    'slot 3
    Private Sub btnstart3_KeyDown(sender As Object, e As KeyEventArgs) Handles btnStart3.KeyDown 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyDown(e)
            btnStart3.Text = btnText 'edit
        End If
    End Sub
    Private Sub btnstop3_KeyDown(sender As Object, e As KeyEventArgs) Handles btnStop3.KeyDown 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyDown(e)
            btnStop3.Text = btnText 'edit
        End If
    End Sub

    'slot 4
    Private Sub btnstart4_KeyDown(sender As Object, e As KeyEventArgs) Handles btnStart4.KeyDown 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyDown(e)
            btnStart4.Text = btnText 'edit
        End If
    End Sub
    Private Sub btnstop4_KeyDown(sender As Object, e As KeyEventArgs) Handles btnStop4.KeyDown 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyDown(e)
            btnStop4.Text = btnText 'edit
        End If
    End Sub

    'slot 5
    Private Sub btnstart5_KeyDown(sender As Object, e As KeyEventArgs) Handles btnStart5.KeyDown 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyDown(e)
            btnStart5.Text = btnText 'edit
        End If
    End Sub
    Private Sub btnstop5_KeyDown(sender As Object, e As KeyEventArgs) Handles btnStop5.KeyDown 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyDown(e)
            btnStop5.Text = btnText 'edit
        End If
    End Sub

    'slot 6
    Private Sub btnstart6_KeyDown(sender As Object, e As KeyEventArgs) Handles btnStart6.KeyDown 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyDown(e)
            btnStart6.Text = btnText 'edit
        End If
    End Sub
    Private Sub btnstop6_KeyDown(sender As Object, e As KeyEventArgs) Handles btnStop6.KeyDown 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyDown(e)
            btnStop6.Text = btnText 'edit
        End If
    End Sub

    'slot 7
    Private Sub btnstart7_KeyDown(sender As Object, e As KeyEventArgs) Handles btnStart7.KeyDown 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyDown(e)
            btnStart7.Text = btnText 'edit
        End If
    End Sub
    Private Sub btnstop7_KeyDown(sender As Object, e As KeyEventArgs) Handles btnStop7.KeyDown 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyDown(e)
            btnStop7.Text = btnText 'edit
        End If
    End Sub
#End Region

#Region "Key up"
    'slot 1
    Private Sub btnstart1_KeyUp(sender As Object, e As KeyEventArgs) Handles btnStart1.KeyUp 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyUp(e, Me, 2000) 'edit
            btnStart1.Text = btnText 'edit
        End If
    End Sub
    Private Sub btnstop1_KeyUp(sender As Object, e As KeyEventArgs) Handles btnStop1.KeyUp 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyUp(e, Me, 2001) 'edit
            btnStop1.Text = btnText 'edit
        End If
    End Sub

    'slot 2
    Private Sub btnstart2_KeyUp(sender As Object, e As KeyEventArgs) Handles btnStart2.KeyUp 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyUp(e, Me, 2002) 'edit
            btnStart2.Text = btnText 'edit
        End If
    End Sub
    Private Sub btnstop2_KeyUp(sender As Object, e As KeyEventArgs) Handles btnStop2.KeyUp 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyUp(e, Me, 2003) 'edit
            btnStop2.Text = btnText 'edit
        End If
    End Sub

    'slot 3
    Private Sub btnstart3_KeyUp(sender As Object, e As KeyEventArgs) Handles btnStart3.KeyUp 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyUp(e, Me, 2004) 'edit
            btnStart3.Text = btnText 'edit
        End If
    End Sub
    Private Sub btnstop3_KeyUp(sender As Object, e As KeyEventArgs) Handles btnStop3.KeyUp 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyUp(e, Me, 2005) 'edit
            btnStop3.Text = btnText 'edit
        End If
    End Sub

    'slot 4
    Private Sub btnstart4_KeyUp(sender As Object, e As KeyEventArgs) Handles btnStart4.KeyUp 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyUp(e, Me, 2006) 'edit
            btnStart4.Text = btnText 'edit
        End If
    End Sub
    Private Sub btnstop4_KeyUp(sender As Object, e As KeyEventArgs) Handles btnStop4.KeyUp 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyUp(e, Me, 2007) 'edit
            btnStop4.Text = btnText 'edit
        End If
    End Sub

    'slot 5
    Private Sub btnstart5_KeyUp(sender As Object, e As KeyEventArgs) Handles btnStart5.KeyUp 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyUp(e, Me, 2008) 'edit
            btnStart5.Text = btnText 'edit
        End If
    End Sub
    Private Sub btnstop5_KeyUp(sender As Object, e As KeyEventArgs) Handles btnStop5.KeyUp 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyUp(e, Me, 2009) 'edit
            btnStop5.Text = btnText 'edit
        End If
    End Sub

    'slot 6
    Private Sub btnstart6_KeyUp(sender As Object, e As KeyEventArgs) Handles btnStart6.KeyUp 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyUp(e, Me, 2010) 'edit
            btnStart6.Text = btnText 'edit
        End If
    End Sub
    Private Sub btnstop6_KeyUp(sender As Object, e As KeyEventArgs) Handles btnStop6.KeyUp 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyUp(e, Me, 2011) 'edit
            btnStop6.Text = btnText 'edit
        End If
    End Sub

    'slot 7
    Private Sub btnstart7_KeyUp(sender As Object, e As KeyEventArgs) Handles btnStart7.KeyUp 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyUp(e, Me, 2012) 'edit
            btnStart7.Text = btnText 'edit
        End If
    End Sub
    Private Sub btnstop7_KeyUp(sender As Object, e As KeyEventArgs) Handles btnStop7.KeyUp 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyUp(e, Me, 2013) 'edit
            btnStop7.Text = btnText 'edit
        End If
    End Sub
#End Region

#Region "Loop chkboxes"

#End Region

#End Region
#End Region

#Region "saved Macros stuff"
    Private Sub btnRemoveSavedMacro_Click(sender As Object, e As EventArgs) Handles btnRemoveSavedMacro.Click
        'Message Prompt if user wants to remove macro to double check
        Dim dlgButton As DialogResult = MessageBox.Show("Remove Row?", "Remove Row", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Beep)
        If dlgButton = DialogResult.Yes Then 'if statement to see if return value for dialog is yes
            'Macro is removed from text box
            Dim intRow As Integer = gridSavedMacros.CurrentCell.RowIndex
            gridSavedMacros.Rows.RemoveAt(intRow)
        End If
        'What ever is in the text box is then saved for future use

    End Sub
    Private Sub btnLoadSavedMacro_Click(sender As Object, e As EventArgs) Handles btnLoadSavedMacro.Click
        'Opens file browser to select which macro you wanna add
        filedialogLoadMacroMain.ShowDialog()
        'need to find a way to save whats in the data grid table to the database
        gridSavedMacros.Rows.Add(filedialogLoadMacroMain.SafeFileName, filedialogLoadMacroMain.FileName)
    End Sub
    'Saving Changes
    Private Sub btnSaveLoadout_Click(sender As Object, e As EventArgs)
        'Message Prompt if user wants to save to double check
        Dim dlgButton As DialogResult = MessageBox.Show("Save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Beep)
        If dlgButton = DialogResult.Yes Then 'if statement to see if return value for dialog is yes
            'Save everything in datagridviews to database, overwriting previous save

            'Database way: Overwrite data in database with data in griddataview

            'CLUELESS on how to save persistently
        End If
    End Sub
    'Favorite Tabs
    Private Sub btnFav_Click(sender As Object, e As EventArgs) Handles btnFav.Click
        If gridSavedMacros.SelectedCells.Count >= 1 Then
            'Moves selected macro in macro load list to favorites
            gridFavMacros.Rows.Add(gridSavedMacros.CurrentRow.Cells(0).Value, gridSavedMacros.CurrentRow.Cells(1).Value)
            'removes row from load grid
            Dim intRow As Integer = gridSavedMacros.CurrentCell.RowIndex
            'removes selected macro in macro load list
            gridSavedMacros.Rows.RemoveAt(intRow)
        End If
    End Sub

    Private Sub btnUnFav_Click(sender As Object, e As EventArgs) Handles btnUnFav.Click
        If gridFavMacros.SelectedCells.Count >= 1 Then
            'Moves selected macro in macro load list to favorites
            gridSavedMacros.Rows.Add(gridFavMacros.CurrentRow.Cells(0).Value, gridFavMacros.CurrentRow.Cells(1).Value)
            'removes row from laod grid
            Dim intRow As Integer = gridFavMacros.CurrentCell.RowIndex
            'removes selected macro in macro load list
            gridFavMacros.Rows.RemoveAt(intRow)
        End If
    End Sub
    'Load saved macro to main macro tab
    Private Sub btnLoadMacro_Click(sender As Object, e As EventArgs)
        'See if macro is in saved tab or favorite tab

        'Msgbox to see if user wants to overwrite any macro in macro tab

        'move current cell to main macro tab

    End Sub
#End Region

#End Region

#Region "Settings Tab Tools/stuff"


#Region "Hotkey Settings"
    'to set hotkey for start
#Region "Hotkey Start Macro ALL"
    'Click button to get hotkey
    Private Sub btnHotkeyStart_Click(sender As Object, e As EventArgs) Handles btnHotkeyStart.Click 'Edit
        boolGetHotkey = True
        btnHotkeyStart.Text = "Press Key" 'Edit
        intHotkeyGetModifier = 0
        Hotkey.unregisterHotkey(Me, 1) 'Edit
    End Sub

    '1 Gets modifier
    Private Sub btnHotkeyStart_KeyDown(sender As Object, e As KeyEventArgs) Handles btnHotkeyStart.KeyDown 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyDown(e)
            btnHotkeyStart.Text = btnText 'edit
            btnStart.Text = btnText 'edit
        End If
    End Sub
    '2 Gets key
    Private Sub btnHotkeyStart_KeyUp(sender As Object, e As KeyEventArgs) Handles btnHotkeyStart.KeyUp 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyUp(e, Me, 1) 'edit
            btnHotkeyStart.Text = btnText 'edit
            btnStart.Text = btnText 'edit
        End If
    End Sub
#End Region
    'to set hotkey to stop
#Region "Stop Macro ALL"
    'Click button to get hotkey
    Private Sub btnHotkeyStop_Click(sender As Object, e As EventArgs) Handles btnHotkeyStop.Click 'Edit
        boolGetHotkey = True
        btnHotkeyStop.Text = "Press Key" 'Edit
        intHotkeyGetModifier = 0
        Hotkey.unregisterHotkey(Me, 2) 'Edit
    End Sub

    '1 Gets modifier
    Private Sub btnHotkeyStop_KeyDown(sender As Object, e As KeyEventArgs) Handles btnHotkeyStop.KeyDown 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyDown(e)
            btnHotkeyStop.Text = btnText 'edit
            btnStop.Text = btnText 'edit
        End If
    End Sub
    '2 Gets key
    Private Sub btnHotkeyStop_KeyUp(sender As Object, e As KeyEventArgs) Handles btnHotkeyStop.KeyUp 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyUp(e, Me, 2) 'edit
            btnHotkeyStop.Text = btnText 'edit
            btnStop.Text = btnText 'edit
        End If
    End Sub
#End Region

#Region "Get Mouse Position"
    '21 Gets mouse position

    Private Sub btngetmouseposition_click(sender As Object, e As EventArgs) Handles btnGetMousePosition.Click 'Edit
        boolGetHotkey = True
        btnGetMousePosition.Text = "Press Key" 'Edit
        intHotkeyGetModifier = 0
        Hotkey.unregisterHotkey(Me, 21) 'Edit
    End Sub

    Private Sub btngetmouseposition_KeyDown(sender As Object, e As KeyEventArgs) Handles btnGetMousePosition.KeyDown 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyDown(e)
            btnGetMousePosition.Text = btnText 'edit
        End If
    End Sub

    Private Sub btngetmouseposition_KeyUp(sender As Object, e As KeyEventArgs) Handles btnGetMousePosition.KeyUp 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyUp(e, Me, 21) 'edit
            btnGetMousePosition.Text = btnText 'edit
        End If
    End Sub
#End Region

#Region "Get Window Hotkey"
    Private Sub btnHotkeyGetWindow_Click(sender As Object, e As EventArgs) Handles btnHotkeyGetWindow.Click
        boolGetHotkey = True
        btnHotkeyGetWindow.Text = "Press Key" 'Edit
        intHotkeyGetModifier = 0
        Hotkey.unregisterHotkey(Me, 22) 'Edit
    End Sub

    Private Sub btnHotkeyGetWindow_keydown(sender As Object, e As KeyEventArgs) Handles btnHotkeyGetWindow.KeyDown 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyDown(e)
            btnHotkeyGetWindow.Text = btnText 'edit
        End If
    End Sub

    Private Sub btnHotkeyGetWindow_KeyUp(sender As Object, e As KeyEventArgs) Handles btnHotkeyGetWindow.KeyUp 'Edit
        If boolGetHotkey = True Then
            Hotkey.getHotkeyButtonKeyUp(e, Me, 22) 'edit
            btnHotkeyGetWindow.Text = btnText 'edit
        End If
    End Sub
#End Region

#End Region

#Region "Dark Mode"
    Private Sub chkDarkmode_CheckedChanged(sender As Object, e As EventArgs) Handles chkDarkmode.CheckedChanged
        If chkDarkmode.Checked = True Then
            ToggleDarkMode(chkDarkmode.Checked, Color.Black, Color.White)
        Else
            ToggleDarkMode(chkDarkmode.Checked, Color.White, Color.Black)
        End If
    End Sub
    Private Sub ToggleDarkMode(ByRef boolDm As Boolean, ByRef bgcolor As Color, ByRef fgcolor As Color)
        Me.BackColor = bgcolor
        Me.ForeColor = fgcolor
        For Each control As Control In Me.Controls
            control.BackColor = bgcolor
            control.ForeColor = fgcolor
            For Each control1 As Control In control.Controls
                control1.BackColor = bgcolor
                control1.ForeColor = fgcolor
                For Each control2 As Control In control1.Controls
                    control2.BackColor = bgcolor
                    control2.ForeColor = fgcolor
                    For Each control3 As Control In control2.Controls
                        control3.BackColor = bgcolor
                        control3.ForeColor = fgcolor
                        For Each control4 As Control In control3.Controls
                            control4.BackColor = bgcolor
                            control4.ForeColor = fgcolor
                            For Each control5 As Control In control4.Controls
                                control5.BackColor = bgcolor
                                control5.ForeColor = fgcolor
                            Next
                        Next
                    Next
                Next
            Next
        Next

    End Sub
#End Region
#End Region

#Region "Saving and Loading"
    'save button
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'declares new var as dialogresult type
        Dim dlgButton As DialogResult
        'sets new var as message box for dialog
        dlgButton =
            MessageBox.Show("Save Everything on every tab?", "Save", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If dlgButton = DialogResult.Yes Then 'if statement to see if return value for dialog is yes,
            'if yes than save
            classSave.saveButton()
        End If

    End Sub

    Private Sub btnDefault_Click(sender As Object, e As EventArgs) Handles btnDefault.Click
        'declares new var as dialogresult type
        Dim dlgButton As DialogResult
        'sets new var as message box for dialog
        dlgButton =
            MessageBox.Show("Set EVERYTHING to default?", "Default?", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If dlgButton = DialogResult.Yes Then 'if statement to see if return value for dialog is yes,
            'if yes than set defau.t
            classLoad.loadEverything("\Defaultsettings.txt") 'For defaults button
        End If

    End Sub

#End Region

#Region "Help Page Tab"
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'declares new var as dialogresult type
        Dim dlgButton As DialogResult
        'sets new var as message box for dialog
        dlgButton =
            MessageBox.Show("Open browser to: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.keys?view=windowsdesktop-7.0 ?", "Open?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        My.Computer.Audio.PlaySystemSound(
        System.Media.SystemSounds.Beep)
        If dlgButton = DialogResult.Yes Then 'if statement to see if return value for dialog is yes, if yes than close program
            Try
                Process.Start("https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.keys?view=windowsdesktop-7.0")
            Catch ex As Exception
                MsgBox("Couldnt open link!" + ex.ToString)
            End Try
        Else

        End If
    End Sub
#End Region

#Region " Testing Tools"


    'Post message and send message have heavy restricts to sending input to windows
    'using PostMessage to send keyboard input may not always work as expected. It depends on the target window and how it handles messages.
    Private Declare Auto Function GetHotKey Lib "user32.dll" (ByVal id As Integer, ByRef fsModifiers As Integer, ByRef vk As Integer) As Boolean
    'send input may be where the money is, gotta mess with it
    Public Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal duFlags As Long)
    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Dim fsModifiers As Integer = 0
        Dim vk As Integer = 0
        Dim hotkeyID As Integer = 1

        ' Retrieve the hotkey information using the stored hotkeyID
        If GetHotKey(hotkeyID, fsModifiers, vk) Then
            MessageBox.Show($"Modifier: {fsModifiers}, Virtual Key Code: {vk}")
        Else
            MessageBox.Show("Failed to retrieve the hotkey information!")
        End If

    End Sub
#End Region
End Class