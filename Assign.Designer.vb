<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Assign
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
        Me.txb_playerOne = New System.Windows.Forms.TextBox()
        Me.lbl_playerTwo = New System.Windows.Forms.Label()
        Me.txb_PlayerTwo = New System.Windows.Forms.TextBox()
        Me.lbl_hours = New System.Windows.Forms.Label()
        Me.lbl_From = New System.Windows.Forms.Label()
        Me.lbl_To = New System.Windows.Forms.Label()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Payment = New System.Windows.Forms.Button()
        Me.lbl_playerOne = New System.Windows.Forms.Label()
        Me.lblTableNumber = New System.Windows.Forms.Label()
        Me.dtp_to = New System.Windows.Forms.DateTimePicker()
        Me.dtp_from = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'txb_playerOne
        '
        Me.txb_playerOne.Location = New System.Drawing.Point(9, 62)
        Me.txb_playerOne.Margin = New System.Windows.Forms.Padding(2)
        Me.txb_playerOne.Name = "txb_playerOne"
        Me.txb_playerOne.Size = New System.Drawing.Size(120, 20)
        Me.txb_playerOne.TabIndex = 1
        '
        'lbl_playerTwo
        '
        Me.lbl_playerTwo.AutoSize = True
        Me.lbl_playerTwo.Location = New System.Drawing.Point(253, 35)
        Me.lbl_playerTwo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_playerTwo.Name = "lbl_playerTwo"
        Me.lbl_playerTwo.Size = New System.Drawing.Size(45, 13)
        Me.lbl_playerTwo.TabIndex = 2
        Me.lbl_playerTwo.Text = "Player 2"
        '
        'txb_PlayerTwo
        '
        Me.txb_PlayerTwo.Location = New System.Drawing.Point(240, 62)
        Me.txb_PlayerTwo.Margin = New System.Windows.Forms.Padding(2)
        Me.txb_PlayerTwo.Name = "txb_PlayerTwo"
        Me.txb_PlayerTwo.Size = New System.Drawing.Size(129, 20)
        Me.txb_PlayerTwo.TabIndex = 3
        '
        'lbl_hours
        '
        Me.lbl_hours.AutoSize = True
        Me.lbl_hours.Location = New System.Drawing.Point(18, 122)
        Me.lbl_hours.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_hours.Name = "lbl_hours"
        Me.lbl_hours.Size = New System.Drawing.Size(72, 13)
        Me.lbl_hours.TabIndex = 4
        Me.lbl_hours.Text = "Playing Hours"
        '
        'lbl_From
        '
        Me.lbl_From.AutoSize = True
        Me.lbl_From.Location = New System.Drawing.Point(18, 170)
        Me.lbl_From.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_From.Name = "lbl_From"
        Me.lbl_From.Size = New System.Drawing.Size(41, 13)
        Me.lbl_From.TabIndex = 6
        Me.lbl_From.Text = "FROM:"
        '
        'lbl_To
        '
        Me.lbl_To.AutoSize = True
        Me.lbl_To.Location = New System.Drawing.Point(18, 219)
        Me.lbl_To.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_To.Name = "lbl_To"
        Me.lbl_To.Size = New System.Drawing.Size(25, 13)
        Me.lbl_To.TabIndex = 7
        Me.lbl_To.Text = "TO:"
        '
        'btn_Add
        '
        Me.btn_Add.Location = New System.Drawing.Point(122, 278)
        Me.btn_Add.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(86, 19)
        Me.btn_Add.TabIndex = 9
        Me.btn_Add.Text = "Add Player"
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(20, 278)
        Me.btn_Clear.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(86, 19)
        Me.btn_Clear.TabIndex = 10
        Me.btn_Clear.Text = "Clear Player"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Location = New System.Drawing.Point(226, 122)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(183, 202)
        Me.Panel1.TabIndex = 11
        '
        'btn_Payment
        '
        Me.btn_Payment.Location = New System.Drawing.Point(275, 336)
        Me.btn_Payment.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Payment.Name = "btn_Payment"
        Me.btn_Payment.Size = New System.Drawing.Size(86, 19)
        Me.btn_Payment.TabIndex = 12
        Me.btn_Payment.Text = "Payment"
        Me.btn_Payment.UseVisualStyleBackColor = True
        '
        'lbl_playerOne
        '
        Me.lbl_playerOne.AutoSize = True
        Me.lbl_playerOne.Location = New System.Drawing.Point(18, 35)
        Me.lbl_playerOne.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_playerOne.Name = "lbl_playerOne"
        Me.lbl_playerOne.Size = New System.Drawing.Size(45, 13)
        Me.lbl_playerOne.TabIndex = 0
        Me.lbl_playerOne.Text = "Player 1"
        '
        'lblTableNumber
        '
        Me.lblTableNumber.AutoSize = True
        Me.lblTableNumber.Location = New System.Drawing.Point(18, 11)
        Me.lblTableNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTableNumber.Name = "lblTableNumber"
        Me.lblTableNumber.Size = New System.Drawing.Size(86, 13)
        Me.lblTableNumber.TabIndex = 13
        Me.lblTableNumber.Text = "Assigned Table: "
        '
        'dtp_to
        '
        Me.dtp_to.CustomFormat = "hh:mm tt"
        Me.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_to.Location = New System.Drawing.Point(82, 215)
        Me.dtp_to.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_to.Name = "dtp_to"
        Me.dtp_to.ShowUpDown = True
        Me.dtp_to.Size = New System.Drawing.Size(126, 20)
        Me.dtp_to.TabIndex = 15
        '
        'dtp_from
        '
        Me.dtp_from.CustomFormat = "hh:mm tt"
        Me.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_from.Location = New System.Drawing.Point(82, 167)
        Me.dtp_from.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_from.Name = "dtp_from"
        Me.dtp_from.ShowUpDown = True
        Me.dtp_from.Size = New System.Drawing.Size(126, 20)
        Me.dtp_from.TabIndex = 16
        '
        'Assign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 375)
        Me.Controls.Add(Me.dtp_from)
        Me.Controls.Add(Me.dtp_to)
        Me.Controls.Add(Me.lblTableNumber)
        Me.Controls.Add(Me.btn_Payment)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Add)
        Me.Controls.Add(Me.lbl_To)
        Me.Controls.Add(Me.lbl_From)
        Me.Controls.Add(Me.lbl_hours)
        Me.Controls.Add(Me.txb_PlayerTwo)
        Me.Controls.Add(Me.lbl_playerTwo)
        Me.Controls.Add(Me.txb_playerOne)
        Me.Controls.Add(Me.lbl_playerOne)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Assign"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assign"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txb_playerOne As TextBox
    Friend WithEvents lbl_playerTwo As Label
    Friend WithEvents txb_PlayerTwo As TextBox
    Friend WithEvents lbl_hours As Label
    Friend WithEvents lbl_From As Label
    Friend WithEvents lbl_To As Label
    Friend WithEvents btn_Add As Button
    Friend WithEvents btn_Clear As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_Payment As Button
    Friend WithEvents lbl_playerOne As Label
    Friend WithEvents lblTableNumber As Label
    Friend WithEvents dtp_to As DateTimePicker
    Friend WithEvents dtp_from As DateTimePicker
End Class
