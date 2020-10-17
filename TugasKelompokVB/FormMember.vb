Imports System.Text
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
Imports System.IO

Public Class FormMember
    Dim DrawingFont As New Font("Arial", 25)
    Dim CaptchaImage As New Bitmap(140, 40)
    Dim CaptchaGraf As Graphics = Graphics.FromImage(CaptchaImage)
    Dim Alphabet As String = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz"
    Dim CaptchaString, TickRandom As String
    Dim ProcessNumber As Integer

    Dim sFileName As String = Application.StartupPath & "\createmember.txt"

    Private Sub GenerateCaptcha()
        ProcessNumber = My.Computer.Clock.LocalTime.Millisecond
        If ProcessNumber < 521 Then
            ProcessNumber = ProcessNumber \ 10
            CaptchaString = Alphabet.Substring(ProcessNumber, 1)
        Else
            CaptchaString = CStr(My.Computer.Clock.LocalTime.Second \ 6)
        End If
        ProcessNumber = My.Computer.Clock.LocalTime.Second
        If ProcessNumber < 30 Then
            ProcessNumber = Math.Abs(ProcessNumber - 8)
            CaptchaString += Alphabet.Substring(ProcessNumber, 1)
        Else
            CaptchaString += CStr(My.Computer.Clock.LocalTime.Minute \ 6)
        End If
        ProcessNumber = My.Computer.Clock.LocalTime.DayOfYear
        If ProcessNumber Mod 2 = 0 Then
            ProcessNumber = ProcessNumber \ 8
            CaptchaString += Alphabet.Substring(ProcessNumber, 1)
        Else
            CaptchaString += CStr(ProcessNumber \ 37)
        End If
        TickRandom = My.Computer.Clock.TickCount.ToString
        ProcessNumber = Val(TickRandom.Substring(TickRandom.Length - 1, 1))
        If ProcessNumber Mod 2 = 0 Then
            CaptchaString += CStr(ProcessNumber)
        Else
            ProcessNumber = Math.Abs(Int(Math.Cos(Val(TickRandom)) * 51))
            CaptchaString += Alphabet.Substring(ProcessNumber, 1)
        End If
        ProcessNumber = My.Computer.Clock.LocalTime.Hour
        If ProcessNumber Mod 2 = 0 Then
            ProcessNumber = Math.Abs(Int(Math.Sin(Val(My.Computer.Clock.LocalTime.Year)) * 51))
            CaptchaString += Alphabet.Substring(ProcessNumber, 1)
        Else
            CaptchaString += CStr(ProcessNumber \ 3)
        End If
        ProcessNumber = My.Computer.Clock.LocalTime.Millisecond
        If ProcessNumber > 521 Then
            ProcessNumber = Math.Abs((ProcessNumber \ 10) - 52)
            CaptchaString += Alphabet.Substring(ProcessNumber, 1)
        Else
            CaptchaString += CStr(My.Computer.Clock.LocalTime.Second \ 6)
        End If
        CaptchaGraf.Clear(Color.White)

        For hasher As Integer = 0 To 5
            CaptchaGraf.DrawString(CaptchaString.Substring(hasher, 1), DrawingFont, Brushes.Black, hasher * 20 + hasher + ProcessNumber \ 200, (hasher Mod 3) * (ProcessNumber \ 200))
        Next
        PictureBox1.Image = CaptchaImage
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox4.Text = CaptchaString Then
            MsgBox("Captcha Correct", MsgBoxStyle.Information)
            TextBox4.Clear()
            GenerateCaptcha()
        Else
            MsgBox("Captcha Incorrect", MsgBoxStyle.Exclamation)
            TextBox4.Clear()
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GenerateCaptcha()
    End Sub

    Private Sub FormMember(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GenerateCaptcha()
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

