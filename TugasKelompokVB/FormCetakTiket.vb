Public Class FormCetakTiket
    Private Sub FormCetakTiket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelJudul.Text = NamaSirkus
        LabelTipe.Text = JenisTiket
        LabelWaktu.Text = Waktu
        LabelAmount.Text = BanyakTiket

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormLogin.Show()
        Me.Close()
    End Sub
End Class