Public Class FormulirDataDiriPelanggan
    Public id_pembeli_database As Double
    Private Sub FormulirDataDiriPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rn As New Random
        Dim x As Double
        Dim y As DateTime = Now
        Dim z As String
        Dim formatdatetime As String = "yyyyMMdd"
        Dim id As String
        z = y.ToString(formatdatetime)
        x = rn.Next(9999, 99999)
        id = Convert.ToString(z & x)
        TextBox4.Text = id
        id_pembeli_database = z & x
        'MessageBox.Show(id_pembeli_database) ujirandom number
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a = New LoginPembeli
        a.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Dim h = New FormPilihPakaian
        h.Show()
    End Sub
End Class