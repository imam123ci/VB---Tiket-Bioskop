Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class FormPembayaran
    Private conn As SqlConnection
    Private cmd As SqlCommand
    Private reader As SqlDataReader

    Private Sub FormPembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Rows.Add(Module1.NamaSirkus, Module1.JenisTiket, Module1.BanyakTiket, Module1.TotalHarga)
        LabelTotalHarga.Text = Module1.TotalHarga
        conn = New SqlConnection("Data Source=62.171.164.73;Initial Catalog=sirkusdb;Persist Security Info=True;User ID=bigpho;Password=bigphovera")
        conn.Open()
        'Make SQL Statement variable
        cmd = conn.CreateCommand()
    End Sub

    Private Sub FormPembayaran_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        conn.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cmd.CommandText = "INSERT INTO sirkusdb.dbo.pesan
                            (sirkusId, bangku_sirkusId, jumlahPesan)
                            VALUES(@sirkus, @bangku, @jumlah); "
        cmd.Parameters.AddWithValue("@sirkus", Module1.SirkusId)
        cmd.Parameters.AddWithValue("@bangku", Module1.BangkuId)
        cmd.Parameters.AddWithValue("@jumlah", Module1.BanyakTiket)
        cmd.ExecuteNonQuery()
        Me.Hide()
        FormCetakTiket.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Module1.MemberId = If(IsNumeric(TextBox1.Text), TextBox1.Text, Nothing)
    End Sub
End Class