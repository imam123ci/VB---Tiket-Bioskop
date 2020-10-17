Imports System.IO

Public Class FormMember
    Dim sFileName As String = Application.StartupPath & "\createmember.txt"

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox4.Text = "e3TJ6Jdp" Then
            MessageBox.Show("Captcha Benar!", "CAPTCHA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Captcha Salah! Ulangi! Case-sensitive!")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Tanggal Berhasil Dipilih!")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If RadioButton1.Checked Then
            Label8.Text = RadioButton1.Text
        End If
        If RadioButton2.Checked Then
            Label8.Text = RadioButton2.Text
        End If

        Dim myFileStream As New FileStream(sFileName,
          FileMode.Create, FileAccess.ReadWrite, FileShare.None) 'inisialisasi file
        Dim myWriter As New System.IO.StreamWriter(myFileStream) 'inisialisasi writer
        myWriter.WriteLine("DATA PEMBUATAN MEMBER")
        myWriter.WriteLine("===================================")
        myWriter.WriteLine("Nama: " + TextBox1.Text)
        myWriter.WriteLine("Jenis Kelamin: " + Label8.Text)
        myWriter.WriteLine("Email: " + TextBox2.Text)
        myWriter.WriteLine("Tanggal Lahir: " + Format(DateTimePicker1.Value, "d-MMMM-yyyy"))
        myWriter.WriteLine("Nomor Telepon: " + TextBox3.Text)
        myWriter.WriteLine("TERIMA KASIH & DATANG KEMBALI")
        myWriter.Flush()
        myWriter.Close()
        myFileStream.Close()

        NotifyIcon1.ShowBalloonTip(3000)
    End Sub

End Class