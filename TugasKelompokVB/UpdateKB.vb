Imports System
Imports System.Data.SqlClient
Public Class UpdateKB
    Private Conn As SqlConnection
    Private Cmd As SqlCommand
    Private Reader As SqlDataReader
    Private results As String

    Sub Main(args As String())
        Conn = New SqlConnection("Data Source= 62.171.164.73; Initial Catalog= sirkusdb; Integrated Security= True")
        Conn.Open()

        Cmd = Conn.CreateCommand
        Cmd.CommandText = "SELECT * FROM sirkus"

        Reader = Cmd.ExecuteReader()

        Do While Reader.Read()
            Console.WriteLine(Reader.GetInt32(0))
            Console.WriteLine(Reader.GetString(1))
        Loop
    End Sub
    Private Sub UpdateKB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SirkusdbDataSet1.detail_sirkus' table. You can move, or remove it, as needed.
        Me.Detail_sirkusTableAdapter.Fill(Me.SirkusdbDataSet1.detail_sirkus)
        'TODO: This line of code loads data into the 'SirkusdbDataSet1.waktu_sirkus' table. You can move, or remove it, as needed.
        Me.Waktu_sirkusTableAdapter.Fill(Me.SirkusdbDataSet1.waktu_sirkus)
        'TODO: This line of code loads data into the 'SirkusdbDataSet1.waktu_sirkus' table. You can move, or remove it, as needed.
        Me.Waktu_sirkusTableAdapter.Fill(Me.SirkusdbDataSet1.waktu_sirkus)
        'TODO: This line of code loads data into the 'SirkusdbDataSet1.sirkus' table. You can move, or remove it, as needed.
        Me.SirkusTableAdapter.Fill(Me.SirkusdbDataSet1.sirkus)
        Conn = New SqlConnection("Data Source=62.171.164.73;Initial Catalog=sirkusdb;Persist Security Info=True;User ID=bigpho;Password=bigphovera")
        Conn.Open()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SirkusTableAdapter.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
        Me.SirkusTableAdapter.Fill(Me.SirkusdbDataSet1.sirkus)
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SirkusTableAdapter.Update(SirkusdbDataSet1.sirkus)
    End Sub

    Private Sub UpdateKB_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        SirkusTableAdapter.Update(SirkusdbDataSet1.sirkus)
        Waktu_sirkusTableAdapter.Update(SirkusdbDataSet1.waktu_sirkus)
        Detail_sirkusTableAdapter.Update(SirkusdbDataSet1.detail_sirkus)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        DashboardKB.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'cmd = conn.createcommand
        'cmd.commandtext = "select * from sirkus"

        'reader = cmd.executereader()

        'do while reader.read()
        '    console.writeline(reader.getint32(0))
        '    console.writeline(reader.getstring(1))
        'loop
        'aku rencananya mau bikin stored procedure delete kayak di video pak darius, cuman eror, trus aku kemarin dapet 
        'kodingan diatas tapi aku tidak mengerti :")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'Waktu_sirkusTableAdapter.Insert(TextBox8.Text, TextBox6.Text, TextBox5.Text)
        'TextBox6 sama TextBox5 nya eror karenan String cannot converted to timespan(?)
        'Me.Waktu_sirkusTableAdapter.Fill(Me.SirkusdbDataSet1.waktu_sirkus)
        'TextBox8.Clear()
        'TextBox6.Clear()
        'TextBox5.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Waktu_sirkusTableAdapter.Update(SirkusdbDataSet1.waktu_sirkus)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'aku rencananya mau bikin stored procedure delete kayak di video pak darius, cuman eror
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Detail_sirkusTableAdapter.Insert(TextBox10.Text, TextBox9.Text, TextBox7.Text)
        'pas diinsert kenapa ada conflict sama foreignkey katanya :")
        Me.Detail_sirkusTableAdapter.Fill(Me.SirkusdbDataSet1.detail_sirkus)
        TextBox10.Clear()
        TextBox9.Clear()
        TextBox7.Clear()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Detail_sirkusTableAdapter.Update(SirkusdbDataSet1.detail_sirkus)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'aku mau deleteeeeee tapi tidak bisaaaaa, toloooong
    End Sub
End Class