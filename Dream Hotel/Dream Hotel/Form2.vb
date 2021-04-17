Imports System.Data.SqlClient
Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

    End Sub

    Private Sub Add_g_Click_1(sender As Object, e As EventArgs) Handles Add_g.Click
        If Addg.Visible = False Then
            Addm.Visible = False
            Addg.Visible = True
            Timer2.Enabled = True
            DataGridView1.Visible = False
            Rcharg.Visible = False
        ElseIf Addg.Visible = True Then
            Addg.Visible = False
            Timer2.Enabled = False
            DataGridView1.Visible = False

        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Form1.Close()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label10.Text = Date.Now.ToString("dd-MM-yyyy  hh:mm")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If Addg.Visible = True Then
            Din.Text = Date.Now.ToString("yyyy-MM-dd")
            'Dout.Text = Date.Now.ToString("yyyy-MM-dd")
        ElseIf Addm.Visible = True Then
            Jd.Text = Date.Now.ToString("yyyy-MM-dd")
        End If

    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub A_Rooms_Click(sender As Object, e As EventArgs) Handles A_Rooms.Click
        If Ac.Checked = True And ch = 1 Then
            DataGridView1.Visible = True
            Dim connection As New SqlConnection("server=KOMAL-HP\SQLEXPRESS;database=DreamHotel;integrated security=true")
            connection.Open()
            Dim cmd1 As New SqlCommand("	SELECT * FROM Arooms where G_name='NULL' and Class = 'AC'", connection)
            Dim adapter As New SqlDataAdapter(cmd1)
            Dim table As New DataTable
            adapter.Fill(table)
            DataGridView1.DataSource = table
            connection.Close()
        ElseIf ch = 0 And gr = 0 Then
            MessageBox.Show("Select the Room Class First")
            gr = 1
        End If
        If Nac.Checked = True And ch = 1 Then
            DataGridView1.Visible = True
            Dim connection As New SqlConnection("server=KOMAL-HP\SQLEXPRESS;database=DreamHotel;integrated security=true")
            connection.Open()
            Dim cmd1 As New SqlCommand("	SELECT * FROM Arooms where G_name='NULL' and Class = 'NonAc'", connection)
            Dim adapter As New SqlDataAdapter(cmd1)
            Dim table As New DataTable
            adapter.Fill(table)
            DataGridView1.DataSource = table
            connection.Close()
        ElseIf ch = 0 And gr = 0 Then
            MessageBox.Show("Select the Room Class First")
            gr = 1
        End If
        If Sweet.Checked = True And ch = 1 Then
            DataGridView1.Visible = True
            Dim connection As New SqlConnection("server=KOMAL-HP\SQLEXPRESS;database=DreamHotel;integrated security=true")
            connection.Open()
            Dim cmd1 As New SqlCommand("	SELECT * FROM Arooms where G_name='NULL' and Class = 'Suite'", connection)
            Dim adapter As New SqlDataAdapter(cmd1)
            Dim table As New DataTable
            adapter.Fill(table)
            DataGridView1.DataSource = table
            connection.Close()
        ElseIf ch = 0 And gr = 0 Then
            MessageBox.Show("Select the Room Class First")
            gr = 1
        End If
    End Sub

    Private Sub SignIn_Click(sender As Object, e As EventArgs) Handles SignIn.Click
        Dim connection As New SqlConnection("server=KOMAL-HP\SQLEXPRESS;database=DreamHotel;integrated security=true")
        connection.Open()
        'Dim in1, out As DateTime
        'in1 = DateTime.Parse(Din.Text)
        'out = DateTime.Parse(Dout.Text)
        'in1 = Convert.ToDateTime(Din.Text)
        'out = Convert.ToDateTime(Dout.Text)
        Dim cmd As New SqlCommand("insert into Guest values('" & Namet.Text & "','" & Nop.Text & "','" & Din.Text & "','" & Dout.Text & "','" & Charge.Text & "','" & RoomNo.Text & "','" & Addno.Text & "','" & Duration.Text & "')", connection)
        cmd.ExecuteNonQuery()
        Dim car1 As New SqlCommand("update Arooms set G_name='" & Namet.Text & "',Duration='" & Duration.Text & "'where RoomNo='" & RoomNo.Text & "' ", connection)
        car1.ExecuteNonQuery()

        MessageBox.Show("Data Saved")
        connection.Close()
        ch = 0
        DataGridView1.Visible = False
        Account = Charge.Text + 0
        Namet.Text = ""
        Nop.Text = ""
        Charge.Text = ""
        RoomNo.Text = ""
        Addno.Text = ""
        Duration.Text = ""


    End Sub

    Private Sub Ac_CheckedChanged_1(sender As Object, e As EventArgs) Handles Ac.CheckedChanged
        Nac.Visible = False
        Sweet.Visible = False
        ch = 1
    End Sub

    Private Sub Nac_CheckedChanged_1(sender As Object, e As EventArgs) Handles Nac.CheckedChanged
        Ac.Visible = False
        Sweet.Visible = False
        ch = 1
    End Sub

    Private Sub Sweet_CheckedChanged_1(sender As Object, e As EventArgs) Handles Sweet.CheckedChanged
        Nac.Visible = False
        Ac.Visible = False
        ch = 1
    End Sub

    Private Sub Add_m_Click(sender As Object, e As EventArgs)
        'Panel1.Visible = False
        Addg.Visible = True

        Timer2.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Add_m.Click
        If Addm.Visible = False Then
            Addg.Visible = False
            Addm.Visible = True
            Timer2.Enabled = True
            DataGridView1.Visible = False
            Rcharg.Visible = False
        ElseIf Addm.Visible = True Then
            Addm.Visible = False
            Timer2.Enabled = False

        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If pw1.Text = pw2.Text Then
            'Dim in2 As DateTime
            'in2 = DateTime.Parse(Jd.Text)
            Dim connection As New SqlConnection("server=KOMAL-HP\SQLEXPRESS;database=DreamHotel;integrated security=true")
            connection.Open()

            Dim car As New SqlCommand("insert into Employee values('" & Eid.Text & "','" & Ename.Text & "','" & Adno.Text & "','" & Sal.Text & "','" & Jd.Text & "','" & pw2.Text & "','" & Desig.Text & "')", connection)
            car.ExecuteNonQuery()

            MessageBox.Show("Welcome to Dream World Hotel")
            connection.Close()
            ch = 0
            DataGridView1.Visible = False
            Eid.Text = ""
            Ename.Text = ""
            Adno.Text = ""
            Sal.Text = ""
            pw1.Text = ""
            pw2.Text = ""
            Desig.Text = ""
        Else
            MessageBox.Show("Passward Does Matched")
        End If
    End Sub

    Private Sub Addgu_Paint(sender As Object, e As PaintEventArgs) Handles Addgu.Paint

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Dout_TextChanged(sender As Object, e As EventArgs) Handles Dout.TextChanged
        If Dout.Text = "" And ce = 0 Then
            Dout.Text = "YYYY-MM-DD"
        End If



    End Sub
    Private Sub Dout_Enter(sender As Object, e As EventArgs) Handles Dout.Enter
        Ce = 1
        Dout.Text = ""

    End Sub

    Private Sub vis1_Click(sender As Object, e As EventArgs) Handles vis1.Click
        If pw1.UseSystemPasswordChar = False Then
            pw1.UseSystemPasswordChar = True
        ElseIf pw1.UseSystemPasswordChar = True Then
            pw1.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If pw2.UseSystemPasswordChar = False Then
            pw2.UseSystemPasswordChar = True
        ElseIf pw2.UseSystemPasswordChar = True Then
            pw2.UseSystemPasswordChar = False
        End If
    End Sub
    Private Sub Charge_Enter(sender As Object, e As EventArgs) Handles Dout.Enter

        ' Durt = Format(Din.Text)
        'Dur = Format(Durt)
        'Duration.Text = Dur

    End Sub

    Private Sub Rc_Click(sender As Object, e As EventArgs) Handles Rc.Click
        If Rcharg.Visible = False Then
            Rcharg.Visible = True
            Addg.Visible = False
            Addm.Visible = False
            DataGridView1.Visible = False
            Dim connection As New SqlConnection("server=KOMAL-HP\SQLEXPRESS;database=DreamHotel;integrated security=true")
            connection.Open()
            Dim cmd1 As New SqlCommand("	SELECT * FROM Rcharges", connection)
            Dim adapter As New SqlDataAdapter(cmd1)
            Dim table As New DataTable
            adapter.Fill(table)
            DataGridView1.DataSource = table
            connection.Close()
        ElseIf Rcharg.Visible = True Then
            Rcharg.Visible = False
            DataGridView1.Visible = False
        End If

    End Sub

    Private Sub Rcharg_Enter(sender As Object, e As EventArgs) Handles Rcharg.Enter

    End Sub

    Private Sub Upch_Click(sender As Object, e As EventArgs) Handles Upch.Click

        Dim connection As New SqlConnection("server=KOMAL-HP\SQLEXPRESS;database=DreamHotel;integrated security=true")
            connection.Open()

        Dim car As New SqlCommand("update RCharges set Ac='" & TextBox1.Text & "',NonAc='" & TextBox2.Text & "',Suite='" & TextBox3.Text & "' ", connection)
        car.ExecuteNonQuery()

            MessageBox.Show("Charges Updated")
        connection.Close()
        DataGridView1.Visible = True

        Dim cmd1 As New SqlCommand("	SELECT * FROM RCharges", connection)
        Dim adapter As New SqlDataAdapter(cmd1)
        Dim table As New DataTable
        adapter.Fill(table)
        DataGridView1.DataSource = table
        connection.Close()

    End Sub

    Private Sub Ar_Click(sender As Object, e As EventArgs) Handles Ar.Click

        If ch1 = 0 Then
            Addg.Visible = False
            Addm.Visible = False
            Rcharg.Visible = False
            AMenu.Visible = False
            DataGridView1.Visible = True
            DataGridView1.Location = New System.Drawing.Point(500, 70)
            DataGridView1.Size = New System.Drawing.Size(445, 445)

            Dim connection As New SqlConnection("server=KOMAL-HP\SQLEXPRESS;database=DreamHotel;integrated security=true")
            connection.Open()
            Dim cmd1 As New SqlCommand("	SELECT * FROM Arooms where G_name='NULL' ", connection)
            Dim adapter As New SqlDataAdapter(cmd1)
            Dim table As New DataTable
            adapter.Fill(table)
            DataGridView1.DataSource = table
            connection.Close()
            ch1 = 1
        ElseIf ch1 = 1 Then
            DataGridView1.Visible = False
            ch1 = 0
        End If
    End Sub

    Private Sub Addmenu_Click(sender As Object, e As EventArgs) Handles Addmenu.Click
        If ch2 = 0 Then
            Addg.Visible = False
            Addm.Visible = False
            Rcharg.Visible = False
            DataGridView1.Visible = False
            AMenu.Visible = True

            ch2 = 1
        ElseIf ch2 = 1 Then
            AMenu.Visible = False
            ch2 = 0
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        v1 = 1
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        v2 = 1
    End Sub

    Private Sub Schange_Click(sender As Object, e As EventArgs) Handles Schange.Click

        If v1 = 1 Then
            Dim connection As New SqlConnection("server=KOMAL-HP\SQLEXPRESS;database=DreamHotel;integrated security=true")
            connection.Open()
            Dim car As New SqlCommand("update Veg_Menu set Break_Fast='" & Bfmenu.Text & "',Lunch='" & Lmenu.Text & "',Dinner='" & Dmenu.Text & "',Desserts='" & Desmenu.Text & "' ", connection)
            car.ExecuteNonQuery()
            MessageBox.Show("Saved")
            connection.Close()
            v1 = 0
        ElseIf v2 = 1 Then
            Dim connection As New SqlConnection("server=KOMAL-HP\SQLEXPRESS;database=DreamHotel;integrated security=true")
            connection.Open()
            Dim car As New SqlCommand("update Non_Veg_Menu set Break_Fast='" & Bfmenu.Text & "',Lunch='" & Lmenu.Text & "',Dinner='" & Dmenu.Text & "',Desserts='" & Desmenu.Text & "' ", connection)
            car.ExecuteNonQuery()
            MessageBox.Show("Saved")
            connection.Close()
            v2 = 0
        ElseIf v1 = 0 And v1 = 0 Then
            MessageBox.Show("Select the Food Category First")
        End If
    End Sub

    Private Sub Vguest_Click(sender As Object, e As EventArgs) Handles Vguest.Click
        If ch3 = 0 Then
            Addg.Visible = False
            Addm.Visible = False
            Rcharg.Visible = False
            AMenu.Visible = False
            DataGridView1.Visible = True
            DataGridView1.Location = New System.Drawing.Point(500, 70)
            DataGridView1.Size = New System.Drawing.Size(445, 445)

            Dim connection As New SqlConnection("server=KOMAL-HP\SQLEXPRESS;database=DreamHotel;integrated security=true")
            connection.Open()
            Dim cmd1 As New SqlCommand("	SELECT * FROM Arooms where G_name<>'NULL' ", connection)
            Dim adapter As New SqlDataAdapter(cmd1)
            Dim table As New DataTable
            adapter.Fill(table)
            DataGridView1.DataSource = table
            connection.Close()
            ch3 = 1
        ElseIf ch3 = 1 Then
            DataGridView1.Visible = False
            ch3 = 0
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Vemp.Click
        If ch4 = 0 Then
            Addg.Visible = False
            Addm.Visible = False
            Rcharg.Visible = False
            AMenu.Visible = False
            DataGridView1.Visible = True
            DataGridView1.Location = New System.Drawing.Point(450, 70)
            DataGridView1.Size = New System.Drawing.Size(650, 445)

            Dim connection As New SqlConnection("server=KOMAL-HP\SQLEXPRESS;database=DreamHotel;integrated security=true")
            connection.Open()
            Dim cmd1 As New SqlCommand("	SELECT Emp_id, Emp_name, Adhar_No, Salary, joining_Date, Designation FROM Employee  ", connection)
            Dim adapter As New SqlDataAdapter(cmd1)
            Dim table As New DataTable
            adapter.Fill(table)
            DataGridView1.DataSource = table
            connection.Close()
            ch4 = 1
        ElseIf ch4 = 1 Then
            DataGridView1.Visible = False
            ch4 = 0
        End If
    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer1.Enter

        If ch5 = 0 Then
            AxWindowsMediaPlayer1.Location = New System.Drawing.Point(232, 34)
            DataGridView1.Size = New System.Drawing.Size(1015, 436)
        ElseIf ch5 = 1 Then
            AxWindowsMediaPlayer1.Location = New System.Drawing.Point(3, 16)
            DataGridView1.Size = New System.Drawing.Size(366, 207)
        End If
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class
