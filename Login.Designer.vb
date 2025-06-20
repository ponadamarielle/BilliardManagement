<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.lbl_login = New System.Windows.Forms.Label()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.lbl_pass = New System.Windows.Forms.Label()
        Me.tbx_user = New System.Windows.Forms.TextBox()
        Me.tbx_pass = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_login
        '
        Me.lbl_login.AccessibleName = ""
        Me.lbl_login.AutoSize = True
        Me.lbl_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_login.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_login.Location = New System.Drawing.Point(304, 63)
        Me.lbl_login.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_login.Name = "lbl_login"
        Me.lbl_login.Size = New System.Drawing.Size(281, 46)
        Me.lbl_login.TabIndex = 1
        Me.lbl_login.Text = "LOGIN FORM"
        '
        'lbl_username
        '
        Me.lbl_username.AccessibleName = ""
        Me.lbl_username.AutoSize = True
        Me.lbl_username.BackColor = System.Drawing.Color.White
        Me.lbl_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_username.Location = New System.Drawing.Point(128, 190)
        Me.lbl_username.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(166, 36)
        Me.lbl_username.TabIndex = 2
        Me.lbl_username.Text = "Username: "
        '
        'lbl_pass
        '
        Me.lbl_pass.AccessibleName = ""
        Me.lbl_pass.AutoSize = True
        Me.lbl_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.lbl_pass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_pass.Location = New System.Drawing.Point(131, 256)
        Me.lbl_pass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(163, 36)
        Me.lbl_pass.TabIndex = 3
        Me.lbl_pass.Text = "Password: "
        '
        'tbx_user
        '
        Me.tbx_user.AccessibleName = ""
        Me.tbx_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_user.Location = New System.Drawing.Point(320, 190)
        Me.tbx_user.Margin = New System.Windows.Forms.Padding(4)
        Me.tbx_user.Multiline = True
        Me.tbx_user.Name = "tbx_user"
        Me.tbx_user.Size = New System.Drawing.Size(296, 36)
        Me.tbx_user.TabIndex = 4
        '
        'tbx_pass
        '
        Me.tbx_pass.AccessibleName = ""
        Me.tbx_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_pass.Location = New System.Drawing.Point(319, 256)
        Me.tbx_pass.Margin = New System.Windows.Forms.Padding(4)
        Me.tbx_pass.Multiline = True
        Me.tbx_pass.Name = "tbx_pass"
        Me.tbx_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.tbx_pass.Size = New System.Drawing.Size(296, 36)
        Me.tbx_pass.TabIndex = 5
        '
        'btn_login
        '
        Me.btn_login.AccessibleName = ""
        Me.btn_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btn_login.ForeColor = System.Drawing.Color.DarkGreen
        Me.btn_login.Location = New System.Drawing.Point(335, 369)
        Me.btn_login.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(224, 44)
        Me.btn_login.TabIndex = 6
        Me.btn_login.Text = "LOGIN"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(45, 44)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(0, 0)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.BilliardManagement.My.Resources.Resources.billiards_balls_triangle_on_pool_table_v61n0c1xivpttxq5
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(882, 554)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 554)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.tbx_pass)
        Me.Controls.Add(Me.tbx_user)
        Me.Controls.Add(Me.lbl_pass)
        Me.Controls.Add(Me.lbl_username)
        Me.Controls.Add(Me.lbl_login)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lbl_login As Label
    Private WithEvents lbl_username As Label
    Private WithEvents lbl_pass As Label
    Private WithEvents tbx_user As TextBox
    Private WithEvents tbx_pass As TextBox
    Private WithEvents btn_login As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
