<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_login
        '
        Me.lbl_login.AccessibleName = ""
        Me.lbl_login.AutoSize = True
        Me.lbl_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_login.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_login.Location = New System.Drawing.Point(283, 55)
        Me.lbl_login.Name = "lbl_login"
        Me.lbl_login.Size = New System.Drawing.Size(229, 37)
        Me.lbl_login.TabIndex = 1
        Me.lbl_login.Text = "LOGIN FORM"
        '
        'lbl_username
        '
        Me.lbl_username.AccessibleName = ""
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.lbl_username.ForeColor = System.Drawing.Color.Indigo
        Me.lbl_username.Location = New System.Drawing.Point(92, 135)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(136, 29)
        Me.lbl_username.TabIndex = 2
        Me.lbl_username.Text = "Username: "
        '
        'lbl_pass
        '
        Me.lbl_pass.AccessibleName = ""
        Me.lbl_pass.AutoSize = True
        Me.lbl_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.lbl_pass.ForeColor = System.Drawing.Color.Indigo
        Me.lbl_pass.Location = New System.Drawing.Point(92, 229)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(132, 29)
        Me.lbl_pass.TabIndex = 3
        Me.lbl_pass.Text = "Password: "
        '
        'tbx_user
        '
        Me.tbx_user.AccessibleName = ""
        Me.tbx_user.Location = New System.Drawing.Point(290, 144)
        Me.tbx_user.Name = "tbx_user"
        Me.tbx_user.Size = New System.Drawing.Size(311, 20)
        Me.tbx_user.TabIndex = 4
        '
        'tbx_pass
        '
        Me.tbx_pass.AccessibleName = ""
        Me.tbx_pass.Location = New System.Drawing.Point(290, 229)
        Me.tbx_pass.Name = "tbx_pass"
        Me.tbx_pass.Size = New System.Drawing.Size(311, 20)
        Me.tbx_pass.TabIndex = 5
        '
        'btn_login
        '
        Me.btn_login.AccessibleName = ""
        Me.btn_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btn_login.ForeColor = System.Drawing.Color.DarkGreen
        Me.btn_login.Location = New System.Drawing.Point(364, 306)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(168, 36)
        Me.btn_login.TabIndex = 6
        Me.btn_login.Text = "LOGIN"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BilliardManagement.My.Resources.Resources.american_pool
        Me.PictureBox1.Location = New System.Drawing.Point(-75, -193)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1543, 913)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.tbx_pass)
        Me.Controls.Add(Me.tbx_user)
        Me.Controls.Add(Me.lbl_pass)
        Me.Controls.Add(Me.lbl_username)
        Me.Controls.Add(Me.lbl_login)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
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
End Class
