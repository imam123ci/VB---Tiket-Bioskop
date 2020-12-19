Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO
Public Class FormPesan

    Private conn As SqlConnection
    Private cmd As SqlCommand
    Private reader As SqlDataReader
    Private results As String
    Private varbinary As Byte()
    Private HargaTiket As Integer = 0

    Private Sub FormPesan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SirkusdbDataSet.sirkus' table. You can move, or remove it, as needed.
        Me.SirkusTableAdapter.Fill(Me.SirkusdbDataSet.sirkus)
        'TODO: This line of code loads data into the 'SirkusdbDataSet.bangku_sirkus' table. You can move, or remove it, as needed.
        Me.Bangku_sirkusTableAdapter.Fill(Me.SirkusdbDataSet.bangku_sirkus)
        'TODO: This line of code loads data into the 'SirkusdbDataSet.waktu_sirkus' table. You can move, or remove it, as needed.
        Me.Waktu_sirkusTableAdapter.Fill(Me.SirkusdbDataSet.waktu_sirkus)
        'TODO: This line of code loads data into the 'SirkusdbDataSet.pesan' table. You can move, or remove it, as needed.
        ' Me.PesanTableAdapter.Fill(Me.SirkusdbDataSet.pesan)
        Timer1.Enabled = True
        'initialize new connection
        'ganti connection string dengan yg ada
        conn = New SqlConnection("Data Source=62.171.164.73;Initial Catalog=sirkusdb;Persist Security Info=True;User ID=bigpho;Password=bigphovera")
        conn.Open()
        'Make SQL Statement variable
        cmd = conn.CreateCommand()
    End Sub

    Private Sub FormPesan_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'Close SQL Connection
        conn.Close()
    End Sub

    'Tab Page 1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now.ToString("dd MMM yyy   hh:mm:ss")
        Module1.Waktu = Label1.Text
    End Sub
    Private Sub ComboBoxNamaSirkus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxNamaSirkus.SelectedIndexChanged
        Module1.NamaSirkus = ComboBoxNamaSirkus.Text
        Module1.SirkusId = ComboBoxNamaSirkus.SelectedValue
        Label3.Text = ComboBoxNamaSirkus.Text

        cmd.CommandText = "SELECT poster from sirkus WHERE sirkusId = @id"
        cmd.Parameters.AddWithValue("@id", ComboBoxNamaSirkus.SelectedValue)
        Dim img As Image
        Dim ImageData As Byte()
        ImageData = DirectCast(cmd.ExecuteScalar(), Byte())
        cmd.Parameters.Clear()

        Using ms As New MemoryStream(ImageData)
            img = Image.FromStream(ms)
        End Using
        PictureBox1.Image = img

        cmd.Parameters.Clear()
        cmd.CommandText = "select * from sirkus where sirkusId = @id"
        cmd.Parameters.AddWithValue("@id", ComboBoxNamaSirkus.SelectedValue)
        reader = cmd.ExecuteReader()

        While reader.Read()
            If reader.HasRows = True Then
                Label4.Text = reader.GetString(2)
            End If
        End While
        reader.Close()

        cmd.Parameters.Clear()
        cmd.CommandText = "select concat(hari,', ',CONVERT(VARCHAR(8),jamMulai,108),'-',CONVERT(VARCHAR(8),jamSelesai,108)) from waktu_sirkus where sirkusId = @id"
        cmd.Parameters.AddWithValue("@id", ComboBoxNamaSirkus.SelectedValue)
        Dim jam As String = Convert.ToString(cmd.ExecuteScalar())
        Waktu.Text = jam

        reader.Close()

        'If Module1.NamaSirkus = "KÀ" Then
        '    PictureBox1.Image = My.Resources._5ka

        'End If

        'If Module1.NamaSirkus = "Michael Jackson ONE" Then
        '    PictureBox1.Image = My.Resources._4mj

        'End If

        'If Module1.NamaSirkus = "The Beatles LOVE" Then
        '    PictureBox1.Image = My.Resources._3thebeatles

        'End If

        'If Module1.NamaSirkus = "KOOZA" Then
        '    PictureBox1.Image = My.Resources._1kooza

        'End If

        'If Module1.NamaSirkus = "Corteo" Then
        '    PictureBox1.Image = My.Resources._2corteo

        'End If

        'If Module1.NamaSirkus = "O" Then
        '    PictureBox1.Image = My.Resources._7o

        'End If

        'If Module1.NamaSirkus = "Alegria" Then
        '    PictureBox1.Image = My.Resources._6alegria
        '    Waktu.Text = "Friday - Tuesday 10:00 AM - 10:30 PM"
        'End If


    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Module1.NamaSirkus = "KÀ" Then
            Dim form3 As New details("KÀ")
            form3.Text = "Details for KÀ"
            Call form3.Show()
        End If

        If Module1.NamaSirkus = "Michael Jackson ONE" Then
            Dim form3 As New details("Michael Jackson ONE")
            form3.Text = "Details for Michael Jackson ONE"
            Call form3.Show()
        End If

        If Module1.NamaSirkus = "The Beatles LOVE" Then
            Dim form3 As New details("The Beatles LOVE")
            form3.Text = "Details for The Beatles LOVE"
            Call form3.Show()
        End If

        If Module1.NamaSirkus = "Alegria" Then
            Dim form3 As New details("Alegria")
            form3.Text = "Details for Alegria"
            Call form3.Show()
        End If

        If Module1.NamaSirkus = "KOOZA" Then
            Dim form3 As New details("KOOZA")
            form3.Text = "Details for KOOZA"
            Call form3.Show()
        End If

        If Module1.NamaSirkus = "Corteo" Then
            Dim form3 As New details("Corteo")
            form3.Text = "Details for Corteo"
            Call form3.Show()
        End If

        If Module1.NamaSirkus = "O" Then
            Dim form3 As New details("O")
            form3.Text = "Details for O"
            Call form3.Show()
        End If
    End Sub


    'Tab Page 2
    Private Function Hitung_Harga() As Integer
        Dim harga As Integer
        cmd.CommandText = "select harga from bangku_sirkus where bangku_sirkusId = @bangku"
        cmd.Parameters.AddWithValue("@bangku", JenisTiket.SelectedValue)
        harga = Convert.ToInt32(cmd.ExecuteScalar())
        cmd.Parameters.Clear()
        HargaTiket = harga
        Return (harga)
    End Function



    Private Sub JenisTiket_SelectedIndexChanged(sender As Object, e As EventArgs) Handles JenisTiket.SelectedIndexChanged
        Dim Total = (Hitung_Harga() * BanyakTiket.Value)
        LabelTotalHarga.Text = Total.ToString
        Module1.TotalHarga = Total
        Module1.JenisTiket = JenisTiket.Text
        Module1.BangkuId = JenisTiket.SelectedValue
    End Sub

    Private Sub BanyakTiket_ValueChanged(sender As Object, e As EventArgs) Handles BanyakTiket.ValueChanged
        Dim Total = (HargaTiket * BanyakTiket.Value)
        LabelTotalHarga.Text = Total.ToString
        Module1.BanyakTiket = BanyakTiket.Value
        Module1.TotalHarga = Total
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Module1.NamaSirkus Is Nothing Then
            MessageBox.Show("Please Choose your circus")
        ElseIf Module1.NamaSirkus Is Nothing Then
            MessageBox.Show("Please Choose your ticket")
        ElseIf Module1.BanyakTiket <= 0 Then
            MessageBox.Show("Please add more ticket (at least 1 ticket)")
        Else
            Me.Hide()
            FormPembayaran.Show()
        End If


    End Sub

    Private Sub FormPesan_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        cmd.Cancel()
        conn.Close()
    End Sub


    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub
End Class

