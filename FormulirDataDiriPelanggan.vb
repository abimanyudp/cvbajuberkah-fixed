Public Class FormulirDataDiriPelanggan
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a = New LoginPembeli
        a.Show()
        Me.Close()
    End Sub
End Class