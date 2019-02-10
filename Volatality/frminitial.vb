Public Class frminitial

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim loadfrm As New frmload
        loadfrm.MdiParent = frmmain
        loadfrm.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub Button6_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click


        Application.Exit()
    End Sub
End Class