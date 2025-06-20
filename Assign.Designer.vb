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
        Me.lbl_playerOne = New System.Windows.Forms.Label()
        Me.txb_playerOne = New System.Windows.Forms.TextBox()
        Me.lbl_playerTwo = New System.Windows.Forms.Label()
        Me.txb_PlayerTwo = New System.Windows.Forms.TextBox()
        Me.lbl_hours = New System.Windows.Forms.Label()
        Me.txb_From = New System.Windows.Forms.TextBox()
        Me.lbl_From = New System.Windows.Forms.Label()
        Me.lbl_To = New System.Windows.Forms.Label()
        Me.txb_To = New System.Windows.Forms.TextBox()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Payment = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_playerOne
        '
        Me.lbl_playerOne.AutoSize = True
        Me.lbl_playerOne.Location = New System.Drawing.Point(24, 43)
        Me.lbl_playerOne.Name = "lbl_playerOne"
        Me.lbl_playerOne.Size = New System.Drawing.Size(56, 16)
        Me.lbl_playerOne.TabIndex = 0
        Me.lbl_playerOne.Text = "Player 1"
        '
        'txb_playerOne
        '
        Me.txb_playerOne.Location = New System.Drawing.Point(12, 76)
        Me.txb_playerOne.Name = "txb_playerOne"
        Me.txb_playerOne.Size = New System.Drawing.Size(158, 22)
        Me.txb_playerOne.TabIndex = 1
        '
        'lbl_playerTwo
        '
        Me.lbl_playerTwo.AutoSize = True
        Me.lbl_playerTwo.Location = New System.Drawing.Point(337, 43)
        Me.lbl_playerTwo.Name = "lbl_playerTwo"
        Me.lbl_playerTwo.Size = New System.Drawing.Size(56, 16)
        Me.lbl_playerTwo.TabIndex = 2
        Me.lbl_playerTwo.Text = "Player 2"
        '
        'txb_PlayerTwo
        '
        Me.txb_PlayerTwo.Location = New System.Drawing.Point(320, 76)
        Me.txb_PlayerTwo.Name = "txb_PlayerTwo"
        Me.txb_PlayerTwo.Size = New System.Drawing.Size(171, 22)
        Me.txb_PlayerTwo.TabIndex = 3
        '
        'lbl_hours
        '
        Me.lbl_hours.AutoSize = True
        Me.lbl_hours.Location = New System.Drawing.Point(24, 150)
        Me.lbl_hours.Name = "lbl_hours"
        Me.lbl_hours.Size = New System.Drawing.Size(91, 16)
        Me.lbl_hours.TabIndex = 4
        Me.lbl_hours.Text = "Playing Hours"
        '
        'txb_From
        '
        Me.txb_From.Location = New System.Drawing.Point(110, 206)
        Me.txb_From.Name = "txb_From"
        Me.txb_From.Size = New System.Drawing.Size(168, 22)
        Me.txb_From.TabIndex = 5
        '
        'lbl_From
        '
        Me.lbl_From.AutoSize = True
        Me.lbl_From.Location = New System.Drawing.Point(24, 209)
        Me.lbl_From.Name = "lbl_From"
        Me.lbl_From.Size = New System.Drawing.Size(49, 16)
        Me.lbl_From.TabIndex = 6
        Me.lbl_From.Text = "FROM:"
        '
        'lbl_To
        '
        Me.lbl_To.AutoSize = True
        Me.lbl_To.Location = New System.Drawing.Point(24, 270)
        Me.lbl_To.Name = "lbl_To"
        Me.lbl_To.Size = New System.Drawing.Size(29, 16)
        Me.lbl_To.TabIndex = 7
        Me.lbl_To.Text = "TO:"
        '
        'txb_To
        '
        Me.txb_To.Location = New System.Drawing.Point(110, 264)
        Me.txb_To.Name = "txb_To"
        Me.txb_To.Size = New System.Drawing.Size(168, 22)
        Me.txb_To.TabIndex = 8
        '
        'btn_Add
        '
        Me.btn_Add.Location = New System.Drawing.Point(163, 342)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(115, 23)
        Me.btn_Add.TabIndex = 9
        Me.btn_Add.Text = "Add Player"
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(27, 342)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(115, 23)
        Me.btn_Clear.TabIndex = 10
        Me.btn_Clear.Text = "Clear Player"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Location = New System.Drawing.Point(302, 150)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(244, 248)
        Me.Panel1.TabIndex = 11
        '
        'btn_Payment
        '
        Me.btn_Payment.Location = New System.Drawing.Point(367, 414)
        Me.btn_Payment.Name = "btn_Payment"
        Me.btn_Payment.Size = New System.Drawing.Size(115, 23)
        Me.btn_Payment.TabIndex = 12
        Me.btn_Payment.Text = "Payment"
        Me.btn_Payment.UseVisualStyleBackColor = True
        '
        'Assign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 461)
        Me.Controls.Add(Me.btn_Payment)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Add)
        Me.Controls.Add(Me.txb_To)
        Me.Controls.Add(Me.lbl_To)
        Me.Controls.Add(Me.lbl_From)
        Me.Controls.Add(Me.txb_From)
        Me.Controls.Add(Me.lbl_hours)
        Me.Controls.Add(Me.txb_PlayerTwo)
        Me.Controls.Add(Me.lbl_playerTwo)
        Me.Controls.Add(Me.txb_playerOne)
        Me.Controls.Add(Me.lbl_playerOne)
        Me.Name = "Assign"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assign"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_playerOne As Label
    Friend WithEvents txb_playerOne As TextBox
    Friend WithEvents lbl_playerTwo As Label
    Friend WithEvents txb_PlayerTwo As TextBox
    Friend WithEvents lbl_hours As Label
    Friend WithEvents txb_From As TextBox
    Friend WithEvents lbl_From As Label
    Friend WithEvents lbl_To As Label
    Friend WithEvents txb_To As TextBox
    Friend WithEvents btn_Add As Button
    Friend WithEvents btn_Clear As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_Payment As Button
End Class
