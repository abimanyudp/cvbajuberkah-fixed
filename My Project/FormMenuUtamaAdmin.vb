Public Class FormMenuUtamaAdmin
    Private Sub StokBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StokBarangToolStripMenuItem.Click
        Me.Hide()
        Dim a = New FormStokBarang
        a.Show()
    End Sub
End Class