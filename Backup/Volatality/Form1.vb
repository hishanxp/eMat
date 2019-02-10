Imports System.IO

Public Class frmpsexec

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngetprocess.Click

        Dim myProcess As New Process()
        Dim line As String


        ListView1.View = View.Details



        myProcess.StartInfo.FileName = "volrun.exe"
        myProcess.StartInfo.Arguments = "--profile=WinXPSP3x86 -f C:\Vol\Dump\sality.vmem pslist"
        myProcess.StartInfo.CreateNoWindow = True
        myProcess.StartInfo.UseShellExecute = False
        myProcess.StartInfo.RedirectStandardOutput = True
        Me.btngetprocess.Enabled = False
        myProcess.Start()


        'get the headings dynamically
        line = myProcess.StandardOutput.ReadLine

        If line <> "" Then
            Dim headarr() As String = line.Split(" ".ToCharArray, StringSplitOptions.RemoveEmptyEntries)
            For x = 0 To headarr.Length - 1
                'MsgBox())

                ListView1.Columns.Add(headarr(x))
                
            Next


        End If

        'getiing process list in to the listbox 

        'Dim offset As String
        'Dim psname As String
        'Dim PID As String
        'Dim ppid As String
        'Dim thds As String
        'Dim hnds As String
        'Dim sess As String
        'Dim wow64 As String
        'Dim start As String
        'Dim memexit As String
        line = myProcess.StandardOutput.ReadLine
        Do

            line = myProcess.StandardOutput.ReadLine
            If Not line Is Nothing Then
                Dim linearr(14) As String
                linearr = line.Split(" ".ToCharArray, StringSplitOptions.RemoveEmptyEntries)
                ReDim Preserve linearr(14)
                Dim itm As ListViewItem

                Dim lineitems As String() = {linearr(0), linearr(1), linearr(2), linearr(3), linearr(4), linearr(5), linearr(6), linearr(7), linearr(8) & " " & linearr(9) & " " & linearr(10), linearr(11) & " " & linearr(12) & " " & linearr(13)}
                itm = New ListViewItem(lineitems)


                ListView1.Items.Add(itm)

            End If
        Loop Until line Is Nothing
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

        ListView1.Refresh()

        Me.btngetprocess.Enabled = True






    End Sub

    

 

 
   

    
End Class
