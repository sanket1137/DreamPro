Imports System.Data.SqlClient
Public Class Form3
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Form1.Show()
        Me.Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ch8 = 0 Then
            GroupBox1.Visible = False
            DataGridView1.Visible = False
            AxWindowsMediaPlayer2.Visible = True
            ch8 = 1
        ElseIf ch8 = 1 Then
            AxWindowsMediaPlayer2.Visible = False
        End If
    End Sub

    Private Sub Tdmenu_Click(sender As Object, e As EventArgs) Handles Tdmenu.Click
        GroupBox1.Visible = True


    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        ch9 = 1
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        ch10 = 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ch11 = 0 Then


            If ch9 = 1 Then
                AxWindowsMediaPlayer2.Visible = False
                DataGridView1.Visible = True
                ' DataGridView1.Location = New System.Drawing.Point(500, 70)
                'DataGridView1.Size = New System.Drawing.Size(445, 445)

                Dim connection As New SqlConnection("server=KOMAL-HP\SQLEXPRESS;database=DreamHotel;integrated security=true")
                connection.Open()
                Dim cmd1 As New SqlCommand("	select * from Veg_Menu ", connection)
                Dim adapter As New SqlDataAdapter(cmd1)
                Dim table As New DataTable
                adapter.Fill(table)
                DataGridView1.DataSource = table
                connection.Close()
                ch9 = 0
            ElseIf ch10 = 1 Then
                AxWindowsMediaPlayer2.Visible = False
                DataGridView1.Visible = True
                ' DataGridView1.Location = New System.Drawing.Point(500, 70)
                'DataGridView1.Size = New System.Drawing.Size(445, 445)

                Dim connection As New SqlConnection("server=KOMAL-HP\SQLEXPRESS;database=DreamHotel;integrated security=true")
                connection.Open()
                Dim cmd1 As New SqlCommand("	select * from Non_Veg_Menu ", connection)
                Dim adapter As New SqlDataAdapter(cmd1)
                Dim table As New DataTable
                adapter.Fill(table)
                DataGridView1.DataSource = table
                connection.Close()
                ch10 = 0
                ch11 = 1
            End If
        ElseIf ch11 = 1 Then
            GroupBox1.Visible = False
            DataGridView1.Visible = False
            ch11 = 0
        End If
    End Sub
End Class