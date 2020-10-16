Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim frm2 As New FormPesan

        If frm2.ComboBox1.SelectedItem = "PENINSULA" Then
            Label1.Text = "Ketika wabah zombie melanda, Jung-seok (GANG Dong-won) nyaris tidak lolos dari Korea Selatan hidup-hidup. Ketika hidup dalam keputusasaan di Hong Kong, 
ia menerima tawaran yang menarik untuk kembali ke semenanjung yang dikarantina. Misinya adalah untuk mengambil truk yang ditinggalkan di 
tengah Seoul dalam batas waktu dan melarikan diri dari semenanjung dengan diam-diam. Tetapi operasinya menjadi kacau ketika seorang milisi
misterius yang dikenal sebagai Unit 631 menyergap tim kecil Jung-seok, dan bahkan gerombolan zombie yang lebih ganas. Dalam momen paling 
putus asa, keluarga Min-jung (LEE Jung-hyun) menyelamatkannya dan dia merencanakan satu kesempatan terakhir untuk melarikan diri dari 
semenanjung itu untuk selamanya."
        End If

    End Sub
End Class