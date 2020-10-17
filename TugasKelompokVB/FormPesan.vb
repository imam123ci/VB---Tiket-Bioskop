Public Class FormPesan

    Private Sub FormPesan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    'Tab Page 1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now.ToString("dd MMM yyy   hh:mm:ss")
    End Sub
    Private Sub ComboBoxNamaSirkus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxNamaSirkus.SelectedIndexChanged
        Module1.NamaSirkus = ComboBoxNamaSirkus.SelectedItem
        If Module1.NamaSirkus = "KÀ" Then
            PictureBox1.Image = My.Resources._5ka

            Label3.Text = "KÀ"
            Label4.Text = My.Resources.String1
            Module1.Waktu = "Saturday 02:00 PM – 5:00 PM"
        End If

        If Module1.NamaSirkus = "Michael Jackson ONE" Then
            PictureBox1.Image = My.Resources._4mj

            Label3.Text = "Michael Jackson ONE"
            Label4.Text = My.Resources.String2
            Module1.Waktu = "Friday 12:30 PM – 04:00 PM"
        End If

        If Module1.NamaSirkus = "The Beatles LOVE" Then
            PictureBox1.Image = My.Resources._3thebeatles

            Label3.Text = "The Beatles LOVE"
            Label4.Text = My.Resources.String3
            Module1.Waktu = "Sunday  10:30 AM – 01:00 PM"
        End If

        If Module1.NamaSirkus = "KOOZA" Then
            PictureBox1.Image = My.Resources._1kooza

            Label3.Text = "KOOZA"
            Label4.Text = My.Resources.String4
            Module1.Waktu = "Thursday 02:00 PM to 05:30 PM"
        End If

        If Module1.NamaSirkus = "Corteo" Then
            PictureBox1.Image = My.Resources._2corteo

            Label3.Text = "Corteo"
            Label4.Text = My.Resources.String5
            Module1.Waktu = "Wednesday 02:00 PM – 5:00 PM"
        End If

        If Module1.NamaSirkus = "O" Then
            PictureBox1.Image = My.Resources._7o

            Label3.Text = "O"
            Label4.Text = My.Resources.String6
            Module1.Waktu = "Tuesday 12:30 PM – 04:00 PM"
        End If

        If Module1.NamaSirkus = "Alegria" Then
            PictureBox1.Image = My.Resources._6alegria

            Label3.Text = "Alegria"
            Label4.Text = My.Resources.String7
            Module1.Waktu = "Monday 02:00 PM – 5:00 PM"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Module1.NamaSirkus = "KÀ" Then
            Dim form2 As New Video("KÀ")
            form2.Text = "Trailer Video KÀ"
            Call form2.Show()
        End If
        If Module1.NamaSirkus = "Michael Jackson ONE" Then
            Dim form2 As New Video("Michael Jackson ONE")
            form2.Text = "Trailer Video Michael Jackson ONE"
            Call form2.Show()
        End If

        If Module1.NamaSirkus = "The Beatles LOVE" Then
            Dim form2 As New Video("The Beatles LOVE")
            form2.Text = "Trailer Video The Beatles LOVE"
            Call form2.Show()
        End If

        If Module1.NamaSirkus = "Alegria" Then
            Dim form2 As New Video("Alegria")
            form2.Text = "Trailer Video Alegria"
            Call form2.Show()
        End If

        If Module1.NamaSirkus = "KOOZA" Then
            Dim form2 As New Video("KOOZA")
            form2.Text = "Trailer Video KOOZA"
            Call form2.Show()
        End If

        If Module1.NamaSirkus = "Corteo" Then
            Dim form2 As New Video("Corteo")
            form2.Text = "Trailer Video Corteo"
            Call form2.Show()
        End If

        If Module1.NamaSirkus = "O" Then
            Dim form2 As New Video("O")
            form2.Text = "Trailer Video O"
            Call form2.Show()
        End If
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
        If Module1.JenisTiket = "VIP" Then
            Module1.TotalHarga = Val(2000000) * Module1.BanyakTiket
        End If
        If Module1.JenisTiket = "CAT1" Then
            Module1.TotalHarga = Val(1500000) * Module1.BanyakTiket
        End If
        If Module1.JenisTiket = "CAT2" Then
            Module1.TotalHarga = Val(1000000) * Module1.BanyakTiket
        End If
        If Module1.JenisTiket = "CAT3" Then
            Module1.TotalHarga = Val(800000) * Module1.BanyakTiket
        End If
        If Module1.JenisTiket = "CAT4" Then
            Module1.TotalHarga = Val(600000) * Module1.BanyakTiket
        End If
        Return (Module1.TotalHarga)
    End Function

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub JenisTiket_Click(sender As Object, e As EventArgs) Handles LabelTotalHarga.Click

    End Sub

    Private Sub JenisTiket_SelectedIndexChanged(sender As Object, e As EventArgs) Handles JenisTiket.SelectedIndexChanged
        Module1.JenisTiket = JenisTiket.SelectedItem
        LabelTotalHarga.Text = Hitung_Harga()
    End Sub

    Private Sub BanyakTiket_ValueChanged(sender As Object, e As EventArgs) Handles BanyakTiket.ValueChanged
        Module1.BanyakTiket = BanyakTiket.Value
        LabelTotalHarga.Text = Hitung_Harga()
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
End Class

