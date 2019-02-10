Imports System.Windows.Forms

Public Class frmmain

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewWindowToolStripMenuItem.Click
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber
        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        Dim loadfrm As New frmload
        loadfrm.MdiParent = Me
        loadfrm.Show()
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub frmmain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim loadfrm As New frminitial
        loadfrm.MdiParent = Me
        loadfrm.Show()
       
    End Sub



    Private Sub PsexecToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PsexecToolStripMenuItem.Click
        Dim psexecfrm As New frmlistout
        psexecfrm.MdiParent = Me
        psexecfrm.pluginstr = "pslist"
        psexecfrm.Show()

    End Sub

    Private Sub DLLLISTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DLLLISTToolStripMenuItem.Click
        Dim dlllstfrm As New frmtxtout
        dlllstfrm.MdiParent = Me
        dlllstfrm.pluginstr = "dlllist"
        dlllstfrm.Show()

    End Sub

    Private Sub ConnscanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConnscanToolStripMenuItem.Click
        Dim connscanfrm As New frmtxtout
        connscanfrm.MdiParent = Me
        connscanfrm.pluginstr = "connscan"
        connscanfrm.Show()
    End Sub

    Private Sub NetscanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NetscanToolStripMenuItem.Click
        Dim netscanfrm As New frmlistout
        netscanfrm.MdiParent = Me
        netscanfrm.pluginstr = "netscan"
        netscanfrm.Show()
    End Sub

    Private Sub HASHDUMPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HASHDUMPToolStripMenuItem.Click
        Dim hashdumpfrm As New frmtxtout
        hashdumpfrm.MdiParent = Me
        hashdumpfrm.pluginstr = "hashdump"
        hashdumpfrm.Show()
    End Sub

    Private Sub PsscanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PsscanToolStripMenuItem.Click
        Dim hashdumpfrm As New frmlistout
        hashdumpfrm.MdiParent = Me
        hashdumpfrm.pluginstr = "psscan"
        hashdumpfrm.Show()
    End Sub

    Private Sub SockscanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SockscanToolStripMenuItem.Click
        Dim hashdumpfrm As New frmlistout
        hashdumpfrm.MdiParent = Me
        hashdumpfrm.pluginstr = "sockscan"
        hashdumpfrm.Show()
    End Sub

    Private Sub GetsidsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetsidsToolStripMenuItem.Click
        Dim getsidfrm As New frmtxtout
        getsidfrm.MdiParent = Me
        getsidfrm.pluginstr = "getsid"
        getsidfrm.Show()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        frminitial.Show()
    End Sub

    Private Sub HandlesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HandlesToolStripMenuItem.Click
        Dim handlesfrm As New frmlistout
        handlesfrm.MdiParent = Me
        handlesfrm.pluginstr = "handles"
        handlesfrm.Show()
    End Sub

    Private Sub PsxviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PsxviewToolStripMenuItem.Click
        Dim psxviewfrm As New frmlistout
        psxviewfrm.MdiParent = Me
        psxviewfrm.pluginstr = "psxview"
        psxviewfrm.Show()
    End Sub

    Private Sub CmdscanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdscanToolStripMenuItem.Click
        Dim cmdscanfrm As New frmtxtout
        cmdscanfrm.MdiParent = Me
        cmdscanfrm.pluginstr = "cmdscan"
        cmdscanfrm.Show()
    End Sub

    Private Sub ConsolesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsolesToolStripMenuItem.Click
        Dim consolesfrm As New frmtxtout

        consolesfrm.MdiParent = Me
        consolesfrm.pluginstr = "consoles"
        consolesfrm.Show()
    End Sub

    Private Sub PstreeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PstreeToolStripMenuItem.Click
        Dim pstreefrm As New frmtxtout
        pstreefrm.MdiParent = Me
        pstreefrm.pluginstr = "pstree"
        pstreefrm.Show()
    End Sub

    Private Sub VadwalkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VadwalkToolStripMenuItem.Click
        Dim vadwalkfrm As New frmlistout
        vadwalkfrm.MdiParent = Me
        vadwalkfrm.pluginstr = "vadwalk"
        vadwalkfrm.Show()
    End Sub

    Private Sub IehistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IehistoryToolStripMenuItem.Click
        Dim iehistoryfrm As New frmtxtout
        iehistoryfrm.MdiParent = Me
        iehistoryfrm.pluginstr = "iehistory"
        iehistoryfrm.Show()
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
        End If

    End Sub
End Class
