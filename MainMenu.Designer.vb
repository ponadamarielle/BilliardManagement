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
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
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
        Me.lbl_main.Location = New System.Drawing.Point(263, 32)
        Me.lbl_main.Name = "lbl_main"
        Me.lbl_main.Size = New System.Drawing.Size(239, 42)
        Me.lbl_main.TabIndex = 1
        Me.lbl_main.Text = "MAIN MENU"
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.Green
        Me.btn1.ForeColor = System.Drawing.SystemColors.Control
        Me.btn1.Location = New System.Drawing.Point(52, 87)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(172, 36)
        Me.btn1.TabIndex = 2
        Me.btn1.Text = "1.Check Table Availability"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.Green
        Me.btn2.ForeColor = System.Drawing.SystemColors.Control
        Me.btn2.Location = New System.Drawing.Point(52, 129)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(172, 34)
        Me.btn2.TabIndex = 3
        Me.btn2.Text = "2. Choose Table and Time"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.Green
        Me.btn3.ForeColor = System.Drawing.SystemColors.Control
        Me.btn3.Location = New System.Drawing.Point(52, 169)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(172, 38)
        Me.btn3.TabIndex = 4
        Me.btn3.Text = "3. Approve Reservation"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.Color.Green
        Me.btn4.ForeColor = System.Drawing.SystemColors.Control
        Me.btn4.Location = New System.Drawing.Point(52, 213)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(172, 40)
        Me.btn4.TabIndex = 5
        Me.btn4.Text = "4. Record Reservation Details"
        Me.btn4.UseVisualStyleBackColor = False
        '
        'btn5
        '
        Me.btn5.BackColor = System.Drawing.Color.Green
        Me.btn5.ForeColor = System.Drawing.SystemColors.Control
        Me.btn5.Location = New System.Drawing.Point(52, 259)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(172, 40)
        Me.btn5.TabIndex = 6
        Me.btn5.Text = "5. View Sales History"
        Me.btn5.UseVisualStyleBackColor = False
        '
        'btn6
        '
        Me.btn6.BackColor = System.Drawing.Color.Green
        Me.btn6.ForeColor = System.Drawing.SystemColors.Control
        Me.btn6.Location = New System.Drawing.Point(52, 305)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(172, 40)
        Me.btn6.TabIndex = 7
        Me.btn6.Text = "6. Calculate Payment"
        Me.btn6.UseVisualStyleBackColor = False
        '
        'btn7
        '
        Me.btn7.BackColor = System.Drawing.Color.Green
        Me.btn7.ForeColor = System.Drawing.SystemColors.Control
        Me.btn7.Location = New System.Drawing.Point(52, 351)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(172, 40)
        Me.btn7.TabIndex = 8
        Me.btn7.Text = "7. Exit"
        Me.btn7.UseVisualStyleBackColor = False
        '
        'pic1
        '
        Me.pic1.Image = Global.BilliardManagement.My.Resources.Resources.billiards_balls_triangle_on_pool_table_v61n0c1xivpttxq5
        Me.pic1.Location = New System.Drawing.Point(-693, -472)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(1642, 1300)
        Me.pic1.TabIndex = 9
        Me.pic1.TabStop = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.lbl_main)
        Me.Controls.Add(Me.pic1)
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lbl_main As Label
    Private WithEvents btn1 As Button
    Private WithEvents btn2 As Button
    Private WithEvents btn3 As Button
    Private WithEvents btn4 As Button
    Private WithEvents btn5 As Button
    Private WithEvents btn6 As Button
    Private WithEvents btn7 As Button
    Friend WithEvents pic1 As PictureBox
End Class
