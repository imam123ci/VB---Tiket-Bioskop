Public Class FormPesan
    Private Sub FormPesan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SirkusdbDataSet.pesan' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'SirkusdbDataSet.waktu_sirkus' table. You can move, or remove it, as needed.
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now.ToString("dd MMM yyy   hh:mm:ss")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "KÀ" Then
            PictureBox1.Image = My.Resources._5ka

            Label3.Text = "KÀ"
            Label4.Text = My.Resources.String1
            Label6.Text = "Saturday – Wednesday 10:00 AM – 10:00 PM" & vbCrLf & "Thursday – Friday 10:00 AM – 5:00 PM"
        End If

        If ComboBox1.SelectedItem = "Michael Jackson ONE" Then
            PictureBox1.Image = My.Resources._4mj

            Label3.Text = "Michael Jackson ONE"
            Label4.Text = My.Resources.String2
            Label6.Text = "Friday - Tuesday 10:00 AM – 10:00 PM" & vbCrLf & "Wednesday and Thursday 12:30 PM – 6:00 PM"
        End If

        If ComboBox1.SelectedItem = "The Beatles LOVE" Then
            PictureBox1.Image = My.Resources._3thebeatles

            Label3.Text = "The Beatles LOVE"
            Label4.Text = My.Resources.String3
            Label6.Text = "Tuesday – Saturday 10AM – 10PM" & vbCrLf & "Sunday – Monday 10AM – 5PM"
        End If

        If ComboBox1.SelectedItem = "KOOZA" Then
            PictureBox1.Image = My.Resources._1kooza

            Label3.Text = "KOOZA"
            Label4.Text = My.Resources.String4
            Label6.Text = "Thursday 12:00 PM to 6:00 PM" & vbCrLf & "Friday 10:00 AM to 6:00 PM"
        End If

        If ComboBox1.SelectedItem = "Corteo" Then
            PictureBox1.Image = My.Resources._2corteo

            Label3.Text = "Corteo"
            Label4.Text = My.Resources.String5
            Label6.Text = "Saturday - Wednesday 10:00 AM – 10:00 PM"
        End If

        If ComboBox1.SelectedItem = "O" Then
            PictureBox1.Image = My.Resources._7o

            Label3.Text = "O"
            Label4.Text = My.Resources.String6
            Label6.Text = "Wednesday - Sunday 9:00 AM – 10:00 PM" & vbCrLf & "Monday - Tuesday 9:00 AM – 5:00 PM"
        End If

        If ComboBox1.SelectedItem = "Alegria" Then
            PictureBox1.Image = My.Resources._6alegria

            Label3.Text = "Alegria"
            Label4.Text = My.Resources.String7
            Label6.Text = "Friday - Tuesday 10:00 AM - 10:30 PM"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem = "KÀ" Then
            Dim form2 As New Video("KÀ")
            form2.Text = "Trailer Video KÀ"
            Call form2.Show()
        End If
        If ComboBox1.SelectedItem = "Michael Jackson ONE" Then
            Dim form2 As New Video("Michael Jackson ONE")
            form2.Text = "Trailer Video Michael Jackson ONE"
            Call form2.Show()
        End If

        If ComboBox1.SelectedItem = "The Beatles LOVE" Then
            Dim form2 As New Video("The Beatles LOVE")
            form2.Text = "Trailer Video The Beatles LOVE"
            Call form2.Show()
        End If

        If ComboBox1.SelectedItem = "Alegria" Then
            Dim form2 As New Video("Alegria")
            form2.Text = "Trailer Video Alegria"
            Call form2.Show()
        End If

        If ComboBox1.SelectedItem = "KOOZA" Then
            Dim form2 As New Video("KOOZA")
            form2.Text = "Trailer Video KOOZA"
            Call form2.Show()
        End If

        If ComboBox1.SelectedItem = "Corteo" Then
            Dim form2 As New Video("Corteo")
            form2.Text = "Trailer Video Corteo"
            Call form2.Show()
        End If

        If ComboBox1.SelectedItem = "O" Then
            Dim form2 As New Video("O")
            form2.Text = "Trailer Video O"
            Call form2.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.SelectedItem = "KÀ" Then
            Dim form3 As New details("KÀ")
            form3.Text = "Details for KÀ"
            Call form3.Show()
        End If

        If ComboBox1.SelectedItem = "Michael Jackson ONE" Then
            Dim form3 As New details("Michael Jackson ONE")
            form3.Text = "Details for Michael Jackson ONE"
            Call form3.Show()
        End If

        If ComboBox1.SelectedItem = "The Beatles LOVE" Then
            Dim form3 As New details("The Beatles LOVE")
            form3.Text = "Details for The Beatles LOVE"
            Call form3.Show()
        End If

        If ComboBox1.SelectedItem = "Alegria" Then
            Dim form3 As New details("Alegria")
            form3.Text = "Details for Alegria"
            Call form3.Show()
        End If

        If ComboBox1.SelectedItem = "KOOZA" Then
            Dim form3 As New details("KOOZA")
            form3.Text = "Details for KOOZA"
            Call form3.Show()
        End If

        If ComboBox1.SelectedItem = "Corteo" Then
            Dim form3 As New details("Corteo")
            form3.Text = "Details for Corteo"
            Call form3.Show()
        End If

        If ComboBox1.SelectedItem = "O" Then
            Dim form3 As New details("O")
            form3.Text = "Details for O"
            Call form3.Show()
        End If
    End Sub
End Class

