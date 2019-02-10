Imports System.IO

Public Class frmlistout

    Public pluginstr As String

    Private Sub frmpsexec_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim volcommand As String = profile & " -f " & dumppath & " " & pluginstr
        txtvcommand.Text = volcommand
        Me.Text = pluginstr & " Plugin"
        Label1.Text = pluginstr & " Output"
        Dim outputarr As String() = volengine(volcommand)
        Dim headarr() As String = outputarr(2).Split(" ".ToCharArray, StringSplitOptions.RemoveEmptyEntries)
            For x = 0 To headarr.Length - 1
                ListView1.Columns.Add(headarr(x))
            Next

        For x = 3 To outputarr.Length - 1

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

    Private Sub MemmapToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MemmapToolStripMenuItem.Click
        Dim pid As String = ListView1.SelectedItems(0).SubItems(2).Text
        Dim memmapfrm As New frmlistout
        memmapfrm.MdiParent = frmmain
        memmapfrm.pluginstr = "memmap -p " & pid
        memmapfrm.Show()
    End Sub

    Private Sub context_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles context.Opening

    End Sub

    Private Sub DlllistToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DlllistToolStripMenuItem.Click
        Dim pid As String = ListView1.SelectedItems(0).SubItems(2).Text
        Dim dlllistfrm As New frmtxtout
        dlllistfrm.MdiParent = frmmain
        dlllistfrm.pluginstr = "dlllist -p " & pid
        dlllistfrm.Show()
    End Sub

    Private Sub MalfindToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MalfindToolStripMenuItem.Click
        Dim pid As String = ListView1.SelectedItems(0).SubItems(2).Text
        Dim malfindfrm As New frmtxtout
        malfindfrm.MdiParent = frmmain
        malfindfrm.pluginstr = "malfind -p " & pid
        malfindfrm.Show()
    End Sub

    Private Sub HandlesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HandlesToolStripMenuItem.Click
        Dim pid As String = ListView1.SelectedItems(0).SubItems(2).Text
        Dim handlesfrm As New frmtxtout
        handlesfrm.MdiParent = frmmain
        handlesfrm.pluginstr = "handles -p " & pid
        handlesfrm.Show()
    End Sub

    Private Sub VadwalkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VadwalkToolStripMenuItem.Click
        Dim pid As String = ListView1.SelectedItems(0).SubItems(2).Text
        Dim vadwalkfrm As New frmlistout
        vadwalkfrm.MdiParent = frmmain
        vadwalkfrm.pluginstr = "vadwalk -p " & pid
        vadwalkfrm.Show()
    End Sub

    Private Sub VadinfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VadinfoToolStripMenuItem.Click
        Dim pid As String = ListView1.SelectedItems(0).SubItems(2).Text
        Dim vadinfofrm As New frmtxtout
        vadinfofrm.MdiParent = frmmain
        vadinfofrm.pluginstr = "vadinfo -p " & pid
        vadinfofrm.Show()
    End Sub

    Private Sub VadtreeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VadtreeToolStripMenuItem.Click
        Dim pid As String = ListView1.SelectedItems(0).SubItems(2).Text
        Dim vadtreefrm As New frmtxtout
        vadtreefrm.MdiParent = frmmain
        vadtreefrm.pluginstr = "vadtree -p " & pid
        vadtreefrm.Show()
    End Sub
End Class
