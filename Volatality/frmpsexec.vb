Imports System.IO

Public Class frmpsexec

    Public pluginstr As String
    Public start As Integer
    Private Sub frmpsexec_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        Dim volcommand As String = "--profile=" & profile & " -f " & dumppath & " " & pluginstr
        txtvcommand.Text = volcommand
        Me.Text = pluginstr & " Plugin"
        Label1.Text = pluginstr & " Output"
        Dim outputarr As String() = volengine(volcommand)
        Dim headarr() As String = outputarr(0).Split(" ".ToCharArray, StringSplitOptions.RemoveEmptyEntries)
        For x = 0 To headarr.Length - 1
            ListView1.Columns.Add(headarr(x))
        Next

        For x = 1 To outputarr.Length - 1

            Dim linearr() As String = outputarr(x).Split(" ".ToCharArray, StringSplitOptions.RemoveEmptyEntries)
            ReDim Preserve linearr(14)
            Dim itm As ListViewItem

            Dim lineitems As String() = {linearr(0), linearr(1), linearr(2), linearr(3), linearr(4), linearr(5), linearr(6), linearr(7), linearr(8) & " " & linearr(9) & " " & linearr(10), linearr(11) & " " & linearr(12) & " " & linearr(13)}
            itm = New ListViewItem(lineitems)
            ListView1.Items.Add(itm)

        Next

        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        ListView1.Refresh()
    End Sub
End Class
