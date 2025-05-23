Imports System.Threading

Public Class Sleep
    Public Shared Sub wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 50
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
        'System.Threading.Thread.Sleep(seconds * 1000)
        'Application.DoEvents()
    End Sub
End Class
