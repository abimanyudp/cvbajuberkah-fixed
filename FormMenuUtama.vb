Public Class FormMenuUtama
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a = New FormLoginAdmin()
        a.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim b = New FormLoginWarehouse()
        b.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim c = New FormLoginSupplier()
        c.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim d = New LoginPembeli()
        d.Show()
        Me.Hide()
    End Sub
End Class