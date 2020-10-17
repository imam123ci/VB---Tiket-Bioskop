Public Class FormPembayaran

    Private Sub FormPembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Rows.Add(Module1.NamaSirkus, Module1.JenisTiket, Module1.BanyakTiket, Module1.TotalHarga)
        LabelTotalHarga.Text = Module1.TotalHarga

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        FormCetakTiket.Show()
    End Sub
End Class