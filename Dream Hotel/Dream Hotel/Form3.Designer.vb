<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Back = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Tdmenu = New System.Windows.Forms.Button()
        Me.AxWindowsMediaPlayer2 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(1050, 139)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(282, 466)
        Me.AxWindowsMediaPlayer1.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Modern No. 20", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Aqua
        Me.Label11.Location = New System.Drawing.Point(1087, 66)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(205, 50)
        Me.Label11.TabIndex = 69
        Me.Label11.Text = "Welcome"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(1079, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 22)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "To  Your  Second  Home ..."
        '
        'Back
        '
        Me.Back.BackColor = System.Drawing.Color.Maroon
        Me.Back.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.ForeColor = System.Drawing.Color.Cyan
        Me.Back.Location = New System.Drawing.Point(12, 12)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(57, 31)
        Me.Back.TabIndex = 71
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Cyan
        Me.Button1.Location = New System.Drawing.Point(306, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 41)
        Me.Button1.TabIndex = 72
        Me.Button1.Text = "Visit Hotel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Tdmenu
        '
        Me.Tdmenu.BackColor = System.Drawing.Color.Maroon
        Me.Tdmenu.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tdmenu.ForeColor = System.Drawing.Color.Cyan
        Me.Tdmenu.Location = New System.Drawing.Point(683, 12)
        Me.Tdmenu.Name = "Tdmenu"
        Me.Tdmenu.Size = New System.Drawing.Size(110, 41)
        Me.Tdmenu.TabIndex = 73
        Me.Tdmenu.Text = "Todays Menu"
        Me.Tdmenu.UseVisualStyleBackColor = False
        '
        'AxWindowsMediaPlayer2
        '
        Me.AxWindowsMediaPlayer2.Enabled = True
        Me.AxWindowsMediaPlayer2.Location = New System.Drawing.Point(95, 131)
        Me.AxWindowsMediaPlayer2.Name = "AxWindowsMediaPlayer2"
        Me.AxWindowsMediaPlayer2.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer2.Size = New System.Drawing.Size(931, 474)
        Me.AxWindowsMediaPlayer2.TabIndex = 76
        Me.AxWindowsMediaPlayer2.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(154, 211)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(813, 343)
        Me.DataGridView1.TabIndex = 77
        Me.DataGridView1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(154, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(813, 100)
        Me.GroupBox1.TabIndex = 78
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.Red
        Me.RadioButton2.Location = New System.Drawing.Point(638, 36)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(106, 28)
        Me.RadioButton2.TabIndex = 72
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Non-Veg"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.Lime
        Me.RadioButton1.Location = New System.Drawing.Point(68, 36)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(62, 28)
        Me.RadioButton1.TabIndex = 71
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Veg"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Maroon
        Me.Button2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Cyan
        Me.Button2.Location = New System.Drawing.Point(340, 53)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 41)
        Me.Button2.TabIndex = 79
        Me.Button2.Text = "Show Menu"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1344, 729)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.AxWindowsMediaPlayer2)
        Me.Controls.Add(Me.Tdmenu)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Label11 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Back As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Tdmenu As Button
    Friend WithEvents AxWindowsMediaPlayer2 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
End Class
