<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TableManagement
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
        Me.btn_table = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_main
        '
        Me.lbl_main.AutoSize = True
        Me.lbl_main.BackColor = System.Drawing.SystemColors.Menu
        Me.lbl_main.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_main.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_main.Location = New System.Drawing.Point(268, 22)
        Me.lbl_main.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_main.Name = "lbl_main"
        Me.lbl_main.Size = New System.Drawing.Size(441, 54)
        Me.lbl_main.TabIndex = 2
        Me.lbl_main.Text = "Table Management"
        '
        'btn_table
        '
        Me.btn_table.BackColor = System.Drawing.Color.Green
        Me.btn_table.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_table.Location = New System.Drawing.Point(123, 164)
        Me.btn_table.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_table.Name = "btn_table"
        Me.btn_table.Size = New System.Drawing.Size(229, 49)
        Me.btn_table.TabIndex = 14
        Me.btn_table.Text = "Table 1"
        Me.btn_table.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(123, 266)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(229, 49)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Table 2"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Green
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(402, 164)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(229, 49)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Table 3"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Green
        Me.Button3.ForeColor = System.Drawing.SystemColors.Control
        Me.Button3.Location = New System.Drawing.Point(402, 266)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(229, 49)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Table 4"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Green
        Me.Button4.ForeColor = System.Drawing.SystemColors.Control
        Me.Button4.Location = New System.Drawing.Point(678, 164)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(229, 49)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Table 5"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Green
        Me.Button5.ForeColor = System.Drawing.SystemColors.Control
        Me.Button5.Location = New System.Drawing.Point(678, 266)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(229, 49)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "Table 6"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Green
        Me.btn_back.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_back.Location = New System.Drawing.Point(402, 491)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(229, 49)
        Me.btn_back.TabIndex = 20
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'TableManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BilliardManagement.My.Resources.Resources.billiards_balls_triangle_on_pool_table_v61n0c1xivpttxq5
        Me.ClientSize = New System.Drawing.Size(982, 553)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_table)
        Me.Controls.Add(Me.lbl_main)
        Me.Name = "TableManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TableManagement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lbl_main As Label
    Private WithEvents btn_table As Button
    Private WithEvents Button1 As Button
    Private WithEvents Button2 As Button
    Private WithEvents Button3 As Button
    Private WithEvents Button4 As Button
    Private WithEvents Button5 As Button
    Private WithEvents btn_back As Button
End Class
