Imports System.IO

Public Class classSave
    'For getting hotkey

    Public Shared Sub saveButton()
        Dim strFileString As String = (strDebugPath + "\settings.txt")
        Dim outFile As IO.StreamWriter
        outFile = IO.File.CreateText(strFileString) 'sets outfile to add new text
#Region "Main Macro Tab"
        'First Save what is in main macro tab
        '1
        outFile.WriteLine(MainForm.lblMacroname.Text.ToString) 'macro file drectory
        '2
        outFile.WriteLine(MainForm.txtWindowCaption.Text.ToString) 'Window name
        '3
        outFile.WriteLine(hwnd.ToString) 'window hwnd

#End Region
#Region "Settings Tab"
        '4
        outFile.WriteLine(MainForm.chkDarkmode.Checked.ToString) 'Save dark mode first
        '5 Start Hotkey Key
        outFile.WriteLine(intArrayHotkeys(1, 0))
        '6 Start Hotkey Modifier
        outFile.WriteLine(intArrayHotkeys(1, 1))
        '7 Start Btn Text
        outFile.WriteLine(MainForm.btnStart.Text)

        '8 Stop Hotkey Key
        outFile.WriteLine(intArrayHotkeys(2, 0))
        '9 Stop Hotkey Modifier
        outFile.WriteLine(intArrayHotkeys(2, 1))
        '10 Stop Hotkey Button Text
        outFile.WriteLine(MainForm.btnStop.Text)

        '11 Mouse Hotkey Key
        outFile.WriteLine(intArrayHotkeys(21, 0))
        '12 Mouse Hotkey Modifier
        outFile.WriteLine(intArrayHotkeys(21, 1))
        '13 Mouse Hotkey Button Text
        outFile.WriteLine(MainForm.btnGetMousePosition.Text)
#End Region

#Region "Macro Pages Hotkeys"
        '14 Macro Page 1 Start Key
        outFile.WriteLine(intArrayHotkeys(2000, 0))
        '15 Macro Page 1 Start Modifier
        outFile.WriteLine(intArrayHotkeys(2000, 1))
        '16 Macro Page 1 btntext
        outFile.WriteLine(MainForm.btnStart1.Text)

        '17 Macro Page 1 Stop Key
        outFile.WriteLine(intArrayHotkeys(2001, 0))
        '18 Macro Page 1 Stop Modifier
        outFile.WriteLine(intArrayHotkeys(2001, 1))
        '19 Macro Page 1 btntext
        outFile.WriteLine(MainForm.btnStop1.Text)

        '20 Macro Page 2 Start Key
        outFile.WriteLine(intArrayHotkeys(2002, 0))
        '21 Macro Page 2 Start Modifier
        outFile.WriteLine(intArrayHotkeys(2002, 1))
        '22 Macro Page 2 btntext
        outFile.WriteLine(MainForm.btnStart2.Text)

        '23 Macro Page 2 Stop Key
        outFile.WriteLine(intArrayHotkeys(2003, 0))
        '24 Macro Page 2 Stop Modifier
        outFile.WriteLine(intArrayHotkeys(2003, 1))
        '25 Macro Page 2 btntext
        outFile.WriteLine(MainForm.btnStop2.Text)

        '26 Macro Page 3 Start Key
        outFile.WriteLine(intArrayHotkeys(2004, 0))
        '27 Macro Page 3 Start Modifier
        outFile.WriteLine(intArrayHotkeys(2004, 1))
        '29 Macro Page 3 btntext
        outFile.WriteLine(MainForm.btnStart3.Text)

        '29 Macro Page 3 Stop Key
        outFile.WriteLine(intArrayHotkeys(2005, 0))
        '30 Macro Page 3 Stop Modifier
        outFile.WriteLine(intArrayHotkeys(2005, 1))
        '31 Macro Page 3 btntext
        outFile.WriteLine(MainForm.btnStop3.Text)

        '32 Macro Page 4 Start Key
        outFile.WriteLine(intArrayHotkeys(2006, 0))
        '33 Macro Page 4 Start Modifier
        outFile.WriteLine(intArrayHotkeys(2006, 1))
        '34 Macro Page 4 btntext
        outFile.WriteLine(MainForm.btnStart4.Text)

        '35 Macro Page 4 Stop Key
        outFile.WriteLine(intArrayHotkeys(2007, 0))
        '36 Macro Page 4 Stop Modifier
        outFile.WriteLine(intArrayHotkeys(2007, 1))
        '37 Macro Page 4 btntext
        outFile.WriteLine(MainForm.btnStop4.Text)

        '38 Macro Page 5 Start Key
        outFile.WriteLine(intArrayHotkeys(2008, 0))
        '39 Macro Page 5 Start Modifier
        outFile.WriteLine(intArrayHotkeys(2008, 1))
        '40 Macro Page 5 btntext
        outFile.WriteLine(MainForm.btnStart5.Text)

        '40 Macro Page 5 Stop Key
        outFile.WriteLine(intArrayHotkeys(2009, 0))
        '42 Macro Page 5 Stop Modifier
        outFile.WriteLine(intArrayHotkeys(2009, 1))
        '43 Macro Page 5 btntext
        outFile.WriteLine(MainForm.btnStop5.Text)

        '44 Macro Page 6 Start Key
        outFile.WriteLine(intArrayHotkeys(2010, 0))
        '45 Macro Page 6 Start Modifier
        outFile.WriteLine(intArrayHotkeys(2010, 1))
        '46 Macro Page 6 btntext
        outFile.WriteLine(MainForm.btnStart6.Text)

        '47 Macro Page 6 Stop Key
        outFile.WriteLine(intArrayHotkeys(2011, 0))
        '48 Macro Page 6 Stop Modifier
        outFile.WriteLine(intArrayHotkeys(2011, 1))
        '49 Macro Page 6 btntext
        outFile.WriteLine(MainForm.btnStop6.Text)

        '50 Macro Page 7 Start Key
        outFile.WriteLine(intArrayHotkeys(2012, 0))
        '51 Macro Page 7 Start Modifier
        outFile.WriteLine(intArrayHotkeys(2012, 1))
        '52 Macro Page 7 btntext
        outFile.WriteLine(MainForm.btnStart7.Text)

        '53 Macro Page 7 Stop Key
        outFile.WriteLine(intArrayHotkeys(2013, 0))
        '54 Macro Page 7 Stop Modifier
        outFile.WriteLine(intArrayHotkeys(2013, 1))
        '55 Macro Page 7 btntext
        outFile.WriteLine(MainForm.btnStop7.Text)
#End Region
        outFile.Close()
#Region "Macro Pages"
        'First for saved macros
        strFileString = (strDebugPath + "\SavedMacros.txt")
        outFile = IO.File.CreateText(strFileString) 'sets outfile to add new text
        For Each row As DataGridViewRow In MainForm.gridSavedMacros.Rows
            'Writes macro name
            outFile.WriteLine(row.Cells(0).Value)
            'writes macro directory
            outFile.WriteLine(row.Cells(1).Value)
        Next
        outFile.Close()
        'Then favorited Macros
        strFileString = (strDebugPath + "\FavoriteMacros.txt")
        outFile = IO.File.CreateText(strFileString) 'sets outfile to add new text
        For Each row As DataGridViewRow In MainForm.gridFavMacros.Rows
            'Writes macro name
            outFile.WriteLine(row.Cells(0).Value)
            'writes macro directory
            outFile.WriteLine(row.Cells(1).Value)
        Next
        outFile.Close()
#End Region
    End Sub
End Class
