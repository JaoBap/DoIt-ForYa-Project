Imports System.Diagnostics.PerformanceData

Public Class classLoad
    Public Shared Sub loadEverything(ByVal path As String)
        Dim strFileString As String = (strDebugPath + path)
        Dim inFile As IO.StreamReader
        Dim intcount As Integer = 0
#Region "Main Macro Tab"
        If IO.File.Exists(strFileString) Then
            inFile = IO.File.OpenText(strFileString) 'sets outfile to read
            Dim keycode As Integer
            Do Until inFile.Peek = -1
                intcount += 1
                'for some reason, every case needs a readline, or else its an overflow ex
                Select Case intcount
                    Case 1 '1 load macro directory
                        MainForm.lblMacroname.Text = inFile.ReadLine
                        Dim Macro0 As IO.StreamReader
                        If IO.File.Exists(MainForm.lblMacroname.Text.ToString) Then
                            Macro0 = IO.File.OpenText(MainForm.lblMacroname.Text.ToString)
                            MainForm.txtInput.Text = Macro0.ReadToEnd 'Reads Macro text file that is "loaded" (D)A[5](U)A is hold A down, wait five seconds, stop holding A down
                            Macro0.Close()
                        Else
                            MainForm.txtInput.Text = String.Empty
                        End If'2 window name
                    Case 2
                        MainForm.txtWindowCaption.Text = inFile.ReadLine
                    Case 3 '3 window hwnd
                        Try
                            hwnd = inFile.ReadLine
                        Catch ex As Exception

                        End Try
#End Region
#Region "Settings Tab"
                    Case 4 '4 dark mode
                        If inFile.ReadLine.ToString = "True" Then
                            MainForm.chkDarkmode.Checked = True
                        Else
                            MainForm.chkDarkmode.Checked = False
                        End If

                    Case 5 '5 Get start macro keycode
                        Dim theline As String = inFile.ReadLine
                        If IsNumeric(theline) Then
                            'Convert keycode to keydata for button text
                            keycode = theline
                        End If
                    Case 6 '6 Get start macro modifier and set hotkey
                        Dim theline As String = inFile.ReadLine
                        If IsNumeric(theline) Then
                            Hotkey.registerVirtualHotkey(MainForm, 1, keycode, theline) 'Edit
                            intArrayHotkeys(1, 0) = keycode
                            intArrayHotkeys(1, 1) = theline
                        End If
                    Case 7 '7 Get start macro keydata
                        Dim theline As String = inFile.ReadLine
                        MainForm.btnStart.Text = (theline) 'Edit
                        MainForm.btnHotkeyStart.Text = (theline)

                    Case 8 '8 Stop Key
                        Dim theline As String = inFile.ReadLine
                        If IsNumeric(theline) Then
                            'Convert keycode to keydata for button text
                            keycode = theline
                        End If
                    Case 9 '9 Stop Modifier
                        Dim theline As String = inFile.ReadLine
                        If IsNumeric(theline) Then
                            Hotkey.registerVirtualHotkey(MainForm, 2, keycode, theline) 'Edit

                            intArrayHotkeys(2, 0) = keycode
                            intArrayHotkeys(2, 1) = theline
                        End If
                    Case 10 '10 stop btn text
                        Dim theline As String = inFile.ReadLine
                        MainForm.btnStop.Text = (theline) 'Edit
                        MainForm.btnHotkeyStop.Text = (theline)

                    Case 11 '11 Mouse Key
                        Dim theline As String = inFile.ReadLine
                        If IsNumeric(theline) Then
                            'Convert keycode to keydata for button text
                            keycode = theline
                        End If
                    Case 12 '12 Mouse Modifier
                        Dim theline As String = inFile.ReadLine
                        If IsNumeric(theline) Then
                            Hotkey.registerVirtualHotkey(MainForm, 21, keycode, theline) 'Edit

                            intArrayHotkeys(21, 0) = keycode
                            intArrayHotkeys(21, 1) = theline
                        End If
                    Case 13 '13 mouse btn text
                        Dim theline As String = inFile.ReadLine
                        MainForm.btnGetMousePosition.Text = (theline) 'Edit
#End Region
#Region "Macro Pages Hotkeys"
                        'Start 1
                    Case 14
                        Dim theline As String = inFile.ReadLine
                        If IsNumeric(theline) Then
                            'Convert keycode to keydata for button text
                            keycode = theline
                        End If
                    Case 15
                        Dim theline As String = inFile.ReadLine
                        If IsNumeric(theline) Then
                            Hotkey.registerVirtualHotkey(MainForm, 2000, keycode, theline) 'Edit

                            intArrayHotkeys(2000, 0) = keycode
                            intArrayHotkeys(2000, 1) = theline
                        End If
                    Case 16
                        Dim theline As String = inFile.ReadLine
                        MainForm.btnStart1.Text = (theline) 'Edit
                        ' Stop 1
                    Case 17
                        Dim theline As String = inFile.ReadLine
                        If IsNumeric(theline) Then
                            'Convert keycode to keydata for button text
                            keycode = theline
                        End If
                    Case 18
                        Dim theline As String = inFile.ReadLine
                        If IsNumeric(theline) Then
                            Hotkey.registerVirtualHotkey(MainForm, 2001, keycode, theline) 'Edit

                            intArrayHotkeys(2001, 0) = keycode
                            intArrayHotkeys(2001, 1) = theline
                        End If
                    Case 19
                        Dim theline As String = inFile.ReadLine
                        MainForm.btnStop1.Text = (theline) 'Edit
                        ' Start 2
                    Case 20
                        Dim theline As String = inFile.ReadLine
                        If IsNumeric(theline) Then
                            'Convert keycode to keydata for button text
                            keycode = theline
                        End If
                    Case 21
                        Dim theline As String = inFile.ReadLine
                        If IsNumeric(theline) Then
                            Hotkey.registerVirtualHotkey(MainForm, 2002, keycode, theline) 'Edit

                            intArrayHotkeys(2002, 0) = keycode
                            intArrayHotkeys(2002, 1) = theline
                        End If
                    Case 22
                        Dim theline As String = inFile.ReadLine
                        MainForm.btnStart2.Text = (theline) 'Edit
                        ' Stop 2
                    Case 23
                        Dim theline As String = inFile.ReadLine
                        If IsNumeric(theline) Then
                            'Convert keycode to keydata for button text
                            keycode = theline
                        End If
                    Case 24
                        Dim theline As String = inFile.ReadLine
                        If IsNumeric(theline) Then
                            Hotkey.registerVirtualHotkey(MainForm, 2003, keycode, theline) 'Edit

                            intArrayHotkeys(2003, 0) = keycode
                            intArrayHotkeys(2003, 1) = theline
                        End If
                    Case 25
                        Dim theline As String = inFile.ReadLine
                        MainForm.btnStop2.Text = (theline) 'Edit
                        ' Start 3
                    Case 26
                        Dim theline As String = inFile.ReadLine
                        If IsNumeric(theline) Then
                            'Convert keycode to keydata for button text
                            keycode = theline
                        End If
                    Case 27
                        Dim theline As String = inFile.ReadLine
                        If IsNumeric(theline) Then
                            Hotkey.registerVirtualHotkey(MainForm, 2004, keycode, theline) 'Edit

                            intArrayHotkeys(2004, 0) = keycode
                            intArrayHotkeys(2004, 1) = theline
                        End If
                    Case 28
                        Dim theline As String = inFile.ReadLine
                        MainForm.btnStart3.Text = (theline) 'Edit
                        ' Stop 3
                    Case 29
                        Dim theline As String = inFile.ReadLine
                        If IsNumeric(theline) Then
                            'Convert keycode to keydata for button text
                            keycode = theline
                        End If
                    Case 30
                        Dim theline As String = inFile.ReadLine
                        If IsNumeric(theline) Then
                            Hotkey.registerVirtualHotkey(MainForm, 2005, keycode, theline) 'Edit

                            intArrayHotkeys(2005, 0) = keycode
                            intArrayHotkeys(2005, 1) = theline
                        End If
                    Case 31
                        Dim theline As String = inFile.ReadLine
                        MainForm.btnStop3.Text = (theline) 'Edit
                        ' Start 4
                    Case 32
                        Dim theline As String = inFile.ReadLine
                        If IsNumeric(theline) Then
                            'Convert keycode to keydata for button text
                            keycode = theline
                        End If
                    Case 33
                        Dim theline As String = inFile.ReadLine
                        If IsNumeric(theline) Then
                            Hotkey.registerVirtualHotkey(MainForm, 2006, keycode, theline) 'Edit

                            intArrayHotkeys(2006, 0) = keycode
                            intArrayHotkeys(2006, 1) = theline
                        End If
                    Case 34
                        Dim theline As String = inFile.ReadLine
                        MainForm.btnStart4.Text = (theline) 'Edit
                        ' Stop 4
                    Case 35
                        Dim theline As String = inFile.ReadLine
                        If IsNumeric(theline) Then
                            'Convert keycode to keydata for button text
                            keycode = theline
                        End If
                    Case 36
                        Dim theline As String = inFile.ReadLine
                        If IsNumeric(theline) Then
                            Hotkey.registerVirtualHotkey(MainForm, 2007, keycode, theline) 'Edit

                            intArrayHotkeys(2007, 0) = keycode
                            intArrayHotkeys(2007, 1) = theline
                        End If
                    Case 37
                        Dim theline As String = inFile.ReadLine
                        MainForm.btnStop4.Text = (theline) 'Edit
                        ' Start 5
                    Case 38
                        Dim theline As String = inFile.ReadLine
                        If IsNumeric(theline) Then
                            'Convert keycode to keydata for button text
                            keycode = theline
                        End If
                    Case 39
                        Dim theline As String = inFile.ReadLine
                        If IsNumeric(theline) Then
                            Hotkey.registerVirtualHotkey(MainForm, 2008, keycode, theline) 'Edit

                            intArrayHotkeys(2008, 0) = keycode
                            intArrayHotkeys(2008, 1) = theline
                        End If
                    Case 40
                        Dim theline As String = inFile.ReadLine
                        MainForm.btnStart5.Text = (theline) 'Edit
                        ' Stop 5
                    Case 41
                        Dim theline As String = inFile.ReadLine
                        If IsNumeric(theline) Then
                            'Convert keycode to keydata for button text
                            keycode = theline
                        End If
                    Case 42
                        Dim theline As String = inFile.ReadLine
                        If IsNumeric(theline) Then
                            Hotkey.registerVirtualHotkey(MainForm, 2009, keycode, theline) 'Edit

                            intArrayHotkeys(2009, 0) = keycode
                            intArrayHotkeys(2009, 1) = theline
                        End If
                    Case 43
                        Dim theline As String = inFile.ReadLine
                        MainForm.btnStop5.Text = (theline) 'Edit
                        ' Start 6
                    Case 44
                        Dim theline As String = inFile.ReadLine
                        If IsNumeric(theline) Then
                            'Convert keycode to keydata for button text
                            keycode = theline
                        End If
                    Case 45
                        Dim theline As String = inFile.ReadLine
                        If IsNumeric(theline) Then
                            Hotkey.registerVirtualHotkey(MainForm, 2010, keycode, theline) 'Edit

                            intArrayHotkeys(2010, 0) = keycode
                            intArrayHotkeys(2010, 1) = theline
                        End If
                    Case 46
                        Dim theline As String = inFile.ReadLine
                        MainForm.btnStart6.Text = (theline) 'Edit
                        ' Stop 6
                    Case 47
                        Dim theline As String = inFile.ReadLine
                        If IsNumeric(theline) Then
                            'Convert keycode to keydata for button text
                            keycode = theline
                        End If
                    Case 48
                        Dim theline As String = inFile.ReadLine
                        If IsNumeric(theline) Then
                            Hotkey.registerVirtualHotkey(MainForm, 2011, keycode, theline) 'Edit

                            intArrayHotkeys(2011, 0) = keycode
                            intArrayHotkeys(2011, 1) = theline
                        End If
                    Case 49
                        Dim theline As String = inFile.ReadLine
                        MainForm.btnStop6.Text = (theline) 'Edit
                        ' Start 7
                    Case 50
                        Dim theline As String = inFile.ReadLine
                        If IsNumeric(theline) Then
                            'Convert keycode to keydata for button text
                            keycode = theline
                        End If
                    Case 51
                        Dim theline As String = inFile.ReadLine
                        If IsNumeric(theline) Then
                            Hotkey.registerVirtualHotkey(MainForm, 2012, keycode, theline) 'Edit

                            intArrayHotkeys(2012, 0) = keycode
                            intArrayHotkeys(2012, 1) = theline
                        End If
                    Case 52
                        Dim theline As String = inFile.ReadLine
                        MainForm.btnStart7.Text = (theline) 'Edit
                        ' Stop 7
                    Case 53
                        Dim theline As String = inFile.ReadLine
                        If IsNumeric(theline) Then
                            'Convert keycode to keydata for button text
                            keycode = theline
                        End If
                    Case 54
                        Dim theline As String = inFile.ReadLine
                        If IsNumeric(theline) Then
                            Hotkey.registerVirtualHotkey(MainForm, 2013, keycode, theline) 'Edit

                            intArrayHotkeys(2013, 0) = keycode
                            intArrayHotkeys(2013, 1) = theline
                        End If
                    Case 55
                        Dim theline As String = inFile.ReadLine
                        MainForm.btnStop7.Text = (theline) 'Edit
#End Region
                End Select
            Loop
            inFile.Close()
#Region "Default Settings"
            If path = "\Defaultsettings.txt" Then
                MainForm.gridSavedMacros.Rows.Clear()
                MainForm.gridFavMacros.Rows.Clear()
            Else
#End Region


#Region "Macro Pages Macro list"
                If IO.File.Exists(strDebugPath + "/savedmacros.txt") Then
                    inFile = IO.File.OpenText(strDebugPath + "/savedmacros.txt") 'sets infile to read
                    Dim boolalternate As Boolean
                    Dim intCurrentRow As Integer
                    'First Reads from saved macros
                    Do Until inFile.Peek = -1
                        'if for alternate, if 1 or 2
                        If boolalternate = False Then
                            '1 Reads Macro Name
                            MainForm.gridSavedMacros.Rows.Add(inFile.ReadLine, String.Empty)
                            boolalternate = True
                            intCurrentRow = MainForm.gridSavedMacros.RowCount - 1
                        ElseIf boolalternate = True Then
                            '2 Reads directory
                            MainForm.gridSavedMacros.Rows(intCurrentRow).Cells(1).Value = inFile.ReadLine
                            boolalternate = False
                            intCurrentRow = MainForm.gridSavedMacros.RowCount - 1
                        End If
                    Loop
                    inFile.Close()
                End If
                'seconds reads from favorited macros
                If IO.File.Exists(strDebugPath + "/favoritemacros.txt") Then
                    inFile = IO.File.OpenText(strDebugPath + "/favoritemacros.txt") 'sets infile to read
                    Dim boolalternate As Boolean
                    Dim intCurrentRow As Integer
                    'First Reads from saved macros
                    Do Until inFile.Peek = -1
                        'if for alternate, if 1 or 2
                        If boolalternate = False Then
                            '1 Reads Macro Name
                            MainForm.gridFavMacros.Rows.Add(inFile.ReadLine, String.Empty)
                            boolalternate = True
                            intCurrentRow = MainForm.gridFavMacros.RowCount - 1
                        ElseIf boolalternate = True Then
                            '2 Reads directory
                            MainForm.gridFavMacros.Rows(intCurrentRow).Cells(1).Value = inFile.ReadLine
                            boolalternate = False
                            intCurrentRow = MainForm.gridFavMacros.RowCount - 1
                        End If
                    Loop
                    inFile.Close()
                End If

            End If
        End If
#End Region
    End Sub
End Class
