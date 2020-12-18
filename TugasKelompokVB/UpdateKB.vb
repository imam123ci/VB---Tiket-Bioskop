Imports System.IO
Imports System.Data.SqlClient
Public Class UpdateKB
    Private Conn As SqlConnection
    Private Cmd As SqlCommand
    Private Reader As SqlDataReader
    Private results As String
    Private varbinary As Byte()
    Private photoStream As New MemoryStream()
    Private Sub UpdateKB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SirkusdbDataSet.waktu_sirkus' table. You can move, or remove it, as needed.
        Me.Waktu_sirkusTableAdapter.Fill(Me.SirkusdbDataSet.waktu_sirkus)
        'TODO: This line of code loads data into the 'SirkusdbDataSet.detail_sirkus' table. You can move, or remove it, as needed.
        Me.Detail_sirkusTableAdapter.Fill(Me.SirkusdbDataSet.detail_sirkus)
        'TODO: This line of code loads data into the 'SirkusdbDataSet.sirkus' table. You can move, or remove it, as needed.
        Me.SirkusTableAdapter.Fill(Me.SirkusdbDataSet.sirkus)


        Conn = New SqlConnection("Data Source=62.171.164.73;Initial Catalog=sirkusdb;Persist Security Info=True;User ID=bigpho;Password=bigphovera")
        Conn.Open()

        Cmd = Conn.CreateCommand()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.Hide()
        DashboardKB.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SirkusTableAdapter.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text, photoStream.GetBuffer())
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        photoStream.SetLength(0)
        PictureBox1.Image = Nothing
        Me.SirkusTableAdapter.Fill(Me.SirkusdbDataSet.sirkus)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"

        ' Generate SQL Query
        'Cmd.CommandText = ("INSERT INTO sirkusdb.dbo.sirkus ([poster]) VALUES(@IMG);")

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            ' Create new memory stream
            Dim ms As New MemoryStream()
            ' Create new image variable
            Dim img As Image
            ' Get image from path and store in in img variable
            img = Image.FromFile(OpenFileDialog1.FileName)
            ' Store image to memory stream
            img.Save(photoStream, img.RawFormat)
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)

            ' add memory stream buffer(byte value) to query
            'Cmd.Parameters.Add("@IMG", SqlDbType.Image).Value = ms.GetBuffer()

            ' Execute query
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SirkusTableAdapter.Update(SirkusdbDataSet.sirkus)
        Me.SirkusTableAdapter.Fill(Me.SirkusdbDataSet.sirkus)
    End Sub

    Private Sub UpdateKB_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.SirkusTableAdapter.Fill(Me.SirkusdbDataSet.sirkus)

        Conn.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Waktu_sirkusTableAdapter.Insert(TextBox6.Text, TimeSpan.Parse(TextBox5.Text), TimeSpan.Parse(TextBox4.Text), TextBox7.Text)
        Me.Waktu_sirkusTableAdapter.Fill(Me.SirkusdbDataSet.waktu_sirkus)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Waktu_sirkusTableAdapter.Update(SirkusdbDataSet.waktu_sirkus)
        Me.Waktu_sirkusTableAdapter.Fill(Me.SirkusdbDataSet.waktu_sirkus)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Detail_sirkusTableAdapter.Insert(TextBox10.Text, TextBox9.Text, photoStream.GetBuffer())
        TextBox10.Clear()
        TextBox9.Clear()
        photoStream.SetLength(0)
        PictureBox2.Image = Nothing
        Me.Detail_sirkusTableAdapter.Fill(Me.SirkusdbDataSet.detail_sirkus)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Detail_sirkusTableAdapter.Update(SirkusdbDataSet.detail_sirkus)
        Me.Detail_sirkusTableAdapter.Fill(Me.SirkusdbDataSet.detail_sirkus)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        OpenFileDialog2.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"

        ' Generate SQL Query
        'Cmd.CommandText = ("INSERT INTO sirkusdb.dbo.sirkus ([poster]) VALUES(@IMG);")

        If OpenFileDialog2.ShowDialog = Windows.Forms.DialogResult.OK Then
            ' Create new memory stream
            Dim ms As New MemoryStream()
            ' Create new image variable
            Dim img As Image
            ' Get image from path and store in in img variable
            img = Image.FromFile(OpenFileDialog2.FileName)
            ' Store image to memory stream
            img.Save(photoStream, img.RawFormat)
            PictureBox2.Image = Image.FromFile(OpenFileDialog2.FileName)

            ' add memory stream buffer(byte value) to query
            'Cmd.Parameters.Add("@IMG", SqlDbType.Image).Value = ms.GetBuffer()

            ' Execute query
        End If
    End Sub
End Class