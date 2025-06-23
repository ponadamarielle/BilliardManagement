<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payment
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
        Me.lbl_Total = New System.Windows.Forms.Label()
        Me.cmb_Mode = New System.Windows.Forms.ComboBox()
        Me.lbl_Mode = New System.Windows.Forms.Label()
        Me.lbl_Discount = New System.Windows.Forms.Label()
        Me.cmb_discount = New System.Windows.Forms.ComboBox()
        Me.lbl_Pay = New System.Windows.Forms.Label()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Total
        '
        Me.lbl_Total.AutoSize = True
        Me.lbl_Total.Location = New System.Drawing.Point(27, 222)
        Me.lbl_Total.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(81, 13)
        Me.lbl_Total.TabIndex = 0
        Me.lbl_Total.Text = "Total Payment :"
        '
        'cmb_Mode
        '
        Me.cmb_Mode.FormattingEnabled = True
        Me.cmb_Mode.Items.AddRange(New Object() {"Cash", "GCash", "Card"})
        Me.cmb_Mode.Location = New System.Drawing.Point(129, 110)
        Me.cmb_Mode.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_Mode.Name = "cmb_Mode"
        Me.cmb_Mode.Size = New System.Drawing.Size(92, 21)
        Me.cmb_Mode.TabIndex = 1
        '
        'lbl_Mode
        '
        Me.lbl_Mode.AutoSize = True
        Me.lbl_Mode.Location = New System.Drawing.Point(27, 113)
        Me.lbl_Mode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Mode.Name = "lbl_Mode"
        Me.lbl_Mode.Size = New System.Drawing.Size(96, 13)
        Me.lbl_Mode.TabIndex = 2
        Me.lbl_Mode.Text = "Mode of Payment: "
        '
        'lbl_Discount
        '
        Me.lbl_Discount.AutoSize = True
        Me.lbl_Discount.Location = New System.Drawing.Point(27, 168)
        Me.lbl_Discount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Discount.Name = "lbl_Discount"
        Me.lbl_Discount.Size = New System.Drawing.Size(55, 13)
        Me.lbl_Discount.TabIndex = 3
        Me.lbl_Discount.Text = "Discount: "
        '
        'cmb_discount
        '
        Me.cmb_discount.FormattingEnabled = True
        Me.cmb_discount.Items.AddRange(New Object() {"Select", "Senior Citizen", "Student ", "Loyalty"})
        Me.cmb_discount.Location = New System.Drawing.Point(129, 162)
        Me.cmb_discount.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_discount.Name = "cmb_discount"
        Me.cmb_discount.Size = New System.Drawing.Size(92, 21)
        Me.cmb_discount.TabIndex = 4
        '
        'lbl_Pay
        '
        Me.lbl_Pay.AutoSize = True
        Me.lbl_Pay.Location = New System.Drawing.Point(27, 68)
        Me.lbl_Pay.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Pay.Name = "lbl_Pay"
        Me.lbl_Pay.Size = New System.Drawing.Size(65, 13)
        Me.lbl_Pay.TabIndex = 5
        Me.lbl_Pay.Text = "PAYMENT: "
        '
        'btn_Exit
        '
        Me.btn_Exit.Location = New System.Drawing.Point(30, 294)
        Me.btn_Exit.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(56, 19)
        Me.btn_Exit.TabIndex = 6
        Me.btn_Exit.Text = "EXIT"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 375)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.lbl_Pay)
        Me.Controls.Add(Me.cmb_discount)
        Me.Controls.Add(Me.lbl_Discount)
        Me.Controls.Add(Me.lbl_Mode)
        Me.Controls.Add(Me.cmb_Mode)
        Me.Controls.Add(Me.lbl_Total)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "payment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Total As Label
    Friend WithEvents cmb_Mode As ComboBox
    Friend WithEvents lbl_Mode As Label
    Friend WithEvents lbl_Discount As Label
    Friend WithEvents cmb_discount As ComboBox
    Friend WithEvents lbl_Pay As Label
    Friend WithEvents btn_Exit As Button
End Class
