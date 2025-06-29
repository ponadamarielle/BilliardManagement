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
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Total
        '
        Me.lbl_Total.AutoSize = True
        Me.lbl_Total.Location = New System.Drawing.Point(36, 273)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(100, 16)
        Me.lbl_Total.TabIndex = 0
        Me.lbl_Total.Text = "Total Payment :"
        '
        'cmb_Mode
        '
        Me.cmb_Mode.FormattingEnabled = True
        Me.cmb_Mode.Items.AddRange(New Object() {"Cash", "GCash", "Card"})
        Me.cmb_Mode.Location = New System.Drawing.Point(172, 135)
        Me.cmb_Mode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_Mode.Name = "cmb_Mode"
        Me.cmb_Mode.Size = New System.Drawing.Size(121, 24)
        Me.cmb_Mode.TabIndex = 1
        Me.cmb_Mode.Text = "Select"
        '
        'lbl_Mode
        '
        Me.lbl_Mode.AutoSize = True
        Me.lbl_Mode.Location = New System.Drawing.Point(36, 139)
        Me.lbl_Mode.Name = "lbl_Mode"
        Me.lbl_Mode.Size = New System.Drawing.Size(118, 16)
        Me.lbl_Mode.TabIndex = 2
        Me.lbl_Mode.Text = "Mode of Payment: "
        '
        'lbl_Discount
        '
        Me.lbl_Discount.AutoSize = True
        Me.lbl_Discount.Location = New System.Drawing.Point(36, 207)
        Me.lbl_Discount.Name = "lbl_Discount"
        Me.lbl_Discount.Size = New System.Drawing.Size(65, 16)
        Me.lbl_Discount.TabIndex = 3
        Me.lbl_Discount.Text = "Discount: "
        '
        'cmb_discount
        '
        Me.cmb_discount.FormattingEnabled = True
        Me.cmb_discount.Items.AddRange(New Object() {"Senior Citizen", "Student ", "Loyalty"})
        Me.cmb_discount.Location = New System.Drawing.Point(172, 199)
        Me.cmb_discount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_discount.Name = "cmb_discount"
        Me.cmb_discount.Size = New System.Drawing.Size(121, 24)
        Me.cmb_discount.TabIndex = 4
        Me.cmb_discount.Text = "Select"
        '
        'lbl_Pay
        '
        Me.lbl_Pay.AutoSize = True
        Me.lbl_Pay.Location = New System.Drawing.Point(36, 84)
        Me.lbl_Pay.Name = "lbl_Pay"
        Me.lbl_Pay.Size = New System.Drawing.Size(79, 16)
        Me.lbl_Pay.TabIndex = 5
        Me.lbl_Pay.Text = "PAYMENT: "
        '
        'btn_confirm
        '
        Me.btn_confirm.Location = New System.Drawing.Point(205, 362)
        Me.btn_confirm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(88, 23)
        Me.btn_confirm.TabIndex = 7
        Me.btn_confirm.Text = "CONFIRM"
        Me.btn_confirm.UseVisualStyleBackColor = True
        '
        'payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 462)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.lbl_Pay)
        Me.Controls.Add(Me.cmb_discount)
        Me.Controls.Add(Me.lbl_Discount)
        Me.Controls.Add(Me.lbl_Mode)
        Me.Controls.Add(Me.cmb_Mode)
        Me.Controls.Add(Me.lbl_Total)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "payment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Total As Label
    Friend WithEvents cmb_Mode As ComboBox
    Friend WithEvents lbl_Mode As Label
    Friend WithEvents lbl_Discount As Label
    Friend WithEvents cmb_discount As ComboBox
    Friend WithEvents lbl_Pay As Label
    Friend WithEvents btn_confirm As Button
End Class
