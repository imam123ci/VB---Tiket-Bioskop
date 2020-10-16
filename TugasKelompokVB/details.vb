Public Class details
    Public Sub New(ByVal item As String)
        InitializeComponent()

        If item = "KÀ" Then
            Label5.Text = item
            PictureBox1.Image = My.Resources.KA1
            PictureBox2.Image = My.Resources.KA2
            PictureBox3.Image = My.Resources.KA3
            Label1.Text = My.Resources.String8
            Label2.Text = My.Resources.String9
            Label3.Text = My.Resources.String10
        End If

        If item = "Michael Jackson ONE" Then
            Label5.Text = item
            PictureBox1.Image = My.Resources.MJ1
            PictureBox2.Image = My.Resources.MJ2
            PictureBox3.Image = My.Resources.MJ3
            Label1.Text = My.Resources.String11
            Label2.Text = My.Resources.String12
            Label3.Text = My.Resources.String13
        End If

        If item = "The Beatles LOVE" Then
            Label5.Text = item
            PictureBox1.Image = My.Resources.beatles1
            PictureBox2.Image = My.Resources.beatles2
            PictureBox3.Image = My.Resources.beatles3
            Label1.Text = My.Resources.String14
            Label2.Text = My.Resources.String15
            Label3.Text = My.Resources.String16
        End If

        If item = "Alegria" Then
            Label5.Text = item
            PictureBox1.Image = My.Resources.alegria1
            PictureBox2.Image = My.Resources.alegria2
            PictureBox3.Image = My.Resources.alegria3
            Label1.Text = My.Resources.String26
            Label2.Text = My.Resources.String27
            Label3.Text = My.Resources.String28
        End If

        If item = "KOOZA" Then
            Label5.Text = item
            PictureBox1.Image = My.Resources.kooza1
            PictureBox2.Image = My.Resources.kooza2
            PictureBox3.Image = My.Resources.kooza3
            Label1.Text = My.Resources.String17
            Label2.Text = My.Resources.String18
            Label3.Text = My.Resources.String19
        End If

        If item = "Corteo" Then
            Label5.Text = item
            PictureBox1.Image = My.Resources.corteo1
            PictureBox2.Image = My.Resources.corteo2
            PictureBox3.Image = My.Resources.corteo3
            Label1.Text = My.Resources.String20
            Label2.Text = My.Resources.String21
            Label3.Text = My.Resources.String22
        End If

        If item = "O" Then
            Label5.Text = item
            PictureBox1.Image = My.Resources.O1
            PictureBox2.Image = My.Resources.O2
            PictureBox3.Image = My.Resources.O3
            Label1.Text = My.Resources.String23
            Label2.Text = My.Resources.String24
            Label3.Text = My.Resources.String25
        End If
    End Sub
End Class