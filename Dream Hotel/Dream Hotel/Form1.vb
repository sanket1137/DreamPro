Imports System.Data.SqlClient
Public Class Form1
    Dim p, u As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles MemButtom.Click
        If rs = 0 Then
            MemEnt.Visible = True
            rs = 1
        ElseIf rs = 1 Then
            MemEnt.Visible = False
            rs = 0
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_enter.Click

        Dim connection As New SqlConnection("server=DESKTOP-I0V1I2D;database=DreamHotel;integrated security=true")
        connection.Open()

        'Dim cmd As New SqlCommand("insert into Employee values('" & TextBox1.Text & "','" & TextBox2.Text & "')", connection)
        ' cmd.ExecuteNonQuery()
        Dim command As New SqlCommand("select * from Employee where Emp_name='" & TextBox1.Text & "' and Acc_Password='" & TextBox2.Text & "'", connection)
        Dim dr As SqlDataReader = command.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                p = dr("Acc_Password").ToString()
                u = dr("Emp_name").ToString()
            End While
        End If
        If u = TextBox1.Text And p = TextBox2.Text Then
            MessageBox.Show("login successful")
            Form2.Show()
        Else
            MessageBox.Show("login Fail")
            Fgp.Visible = True

        End If


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.UseSystemPasswordChar = False Then
            TextBox2.UseSystemPasswordChar = True
        ElseIf TextBox2.UseSystemPasswordChar = True Then
            TextBox2.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub Fgp_Click(sender As Object, e As EventArgs) Handles Fgp.Click
        If ch6 = 0 Then

            GroupBox1.Visible = True



            ch6 = 1
        ElseIf ch6 = 1 Then
            GroupBox1.Visible = False
            ch6 = 0
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If ch7 = 0 Then

            DataGridView1.Visible = True
            DataGridView1.Location = New System.Drawing.Point(500, 70)
            DataGridView1.Size = New System.Drawing.Size(445, 445)

            Dim connection As New SqlConnection("server=KOMAL-HP\SQLEXPRESS;database=DreamHotel;integrated security=true")
            connection.Open()
            Dim cmd1 As New SqlCommand("	SELECT Acc_Password FROM Employee where Adhar_No='" & TextBox3.Text & "' ", connection)
            Dim adapter As New SqlDataAdapter(cmd1)
            Dim table As New DataTable
            adapter.Fill(table)
            DataGridView1.DataSource = table
            connection.Close()
            ch7 = 1
        ElseIf ch7 = 1 Then
            DataGridView1.Visible = False
            ch7 = 0
        End If
    End Sub

    Private Sub Cqin_Click(sender As Object, e As EventArgs) Handles Cqin.Click
        Form3.Show()
    End Sub

    Private Sub MemEnt_Enter(sender As Object, e As EventArgs) Handles MemEnt.Enter

    End Sub
End Class
