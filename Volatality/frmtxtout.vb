Imports System.IO

Public Class frmtxtout

    Public pluginstr As String
    Private Sub frmpsexec_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        Dim volcommand As String = profile & " -f " & dumppath & " " & pluginstr
        txtvcommand.Text = volcommand
        Me.Text = pluginstr & " Plugin"
        Label1.Text = pluginstr & " Output"
        Dim outputarr As String() = volengine(volcommand)

        Dim txtout As String = ""

        For x = 0 To outputarr.Length - 1

            txtout = txtout + outputarr(x) + Chr(13)

        Next
        rtbout.Text = txtout

    End Sub

End Class
