<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.lbl_main = New System.Windows.Forms.Label()
        Me.btn_history = New System.Windows.Forms.Button()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_reservation = New System.Windows.Forms.Button()
        Me.btn_table = New System.Windows.Forms.Button()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_main
        '
        Me.lbl_main.AutoSize = True
        Me.lbl_main.BackColor = System.Drawing.SystemColors.Menu
        Me.lbl_main.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_main.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_main.Location = New System.Drawing.Point(351, 39)
        Me.lbl_main.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_main.Name = "lbl_main"
        Me.lbl_main.Size = New System.Drawing.Size(299, 54)
        Me.lbl_main.TabIndex = 1
        Me.lbl_main.Text = "MAIN MENU"
        '
        'btn_history
        '
        Me.btn_history.BackColor = System.Drawing.Color.Green
        Me.btn_history.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_history.Location = New System.Drawing.Point(387, 320)
        Me.btn_history.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_history.Name = "btn_history"
        Me.btn_history.Size = New System.Drawing.Size(229, 49)
        Me.btn_history.TabIndex = 5
        Me.btn_history.Text = "History"
        Me.btn_history.UseVisualStyleBackColor = False
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.Green
        Me.btn_logout.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_logout.Location = New System.Drawing.Point(740, 492)
        Me.btn_logout.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(229, 49)
        Me.btn_logout.TabIndex = 10
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'btn_reservation
        '
        Me.btn_reservation.BackColor = System.Drawing.Color.Green
        Me.btn_reservation.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_reservation.Location = New System.Drawing.Point(387, 222)
        Me.btn_reservation.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_reservation.Name = "btn_reservation"
        Me.btn_reservation.Size = New System.Drawing.Size(229, 49)
        Me.btn_reservation.TabIndex = 12
        Me.btn_reservation.Text = "Reservation"
        Me.btn_reservation.UseVisualStyleBackColor = False
        '
        'btn_table
        '
        Me.btn_table.BackColor = System.Drawing.Color.Green
        Me.btn_table.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_table.Location = New System.Drawing.Point(387, 129)
        Me.btn_table.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_table.Name = "btn_table"
        Me.btn_table.Size = New System.Drawing.Size(229, 49)
        Me.btn_table.TabIndex = 13
        Me.btn_table.Text = "Table Management"
        Me.btn_table.UseVisualStyleBackColor = False
        '
        'pic1
        '
        Me.pic1.Image = Global.BilliardManagement.My.Resources.Resources.billiards_balls_triangle_on_pool_table_v61n0c1xivpttxq5
        Me.pic1.Location = New System.Drawing.Point(-924, -581)
        Me.pic1.Margin = New System.Windows.Forms.Padding(4)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(2337, 1486)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 9
        Me.pic1.TabStop = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 553)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_table)
        Me.Controls.Add(Me.btn_reservation)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.btn_history)
        Me.Controls.Add(Me.lbl_main)
        Me.Controls.Add(Me.pic1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lbl_main As Label
    Private WithEvents btn_history As Button
    Friend WithEvents pic1 As PictureBox
    Private WithEvents btn_logout As Button
    Private WithEvents btn_reservation As Button
    Private WithEvents btn_table As Button
End Class
