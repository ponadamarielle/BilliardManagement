<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservation
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
        Me.lbl_tr = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_contact = New System.Windows.Forms.Label()
        Me.lbl_tb = New System.Windows.Forms.Label()
        Me.lbl_dt = New System.Windows.Forms.Label()
        Me.lbl_tm = New System.Windows.Forms.Label()
        Me.txtbox_name = New System.Windows.Forms.TextBox()
        Me.txtbox_contact = New System.Windows.Forms.TextBox()
        Me.cmb_table = New System.Windows.Forms.ComboBox()
        Me.dtp_date = New System.Windows.Forms.DateTimePicker()
        Me.dtp_time = New System.Windows.Forms.DateTimePicker()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_reservations = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_tr
        '
        Me.lbl_tr.AutoSize = True
        Me.lbl_tr.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tr.Location = New System.Drawing.Point(227, 27)
        Me.lbl_tr.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_tr.Name = "lbl_tr"
        Me.lbl_tr.Size = New System.Drawing.Size(320, 31)
        Me.lbl_tr.TabIndex = 0
        Me.lbl_tr.Text = "TABLE RESERVATION"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(181, 110)
        Me.lbl_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(55, 20)
        Me.lbl_name.TabIndex = 1
        Me.lbl_name.Text = "Name:"
        '
        'lbl_contact
        '
        Me.lbl_contact.AutoSize = True
        Me.lbl_contact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contact.Location = New System.Drawing.Point(178, 158)
        Me.lbl_contact.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_contact.Name = "lbl_contact"
        Me.lbl_contact.Size = New System.Drawing.Size(69, 20)
        Me.lbl_contact.TabIndex = 2
        Me.lbl_contact.Text = "Contact:"
        '
        'lbl_tb
        '
        Me.lbl_tb.AutoSize = True
        Me.lbl_tb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tb.Location = New System.Drawing.Point(178, 203)
        Me.lbl_tb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_tb.Name = "lbl_tb"
        Me.lbl_tb.Size = New System.Drawing.Size(52, 20)
        Me.lbl_tb.TabIndex = 3
        Me.lbl_tb.Text = "Table:"
        '
        'lbl_dt
        '
        Me.lbl_dt.AutoSize = True
        Me.lbl_dt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dt.Location = New System.Drawing.Point(178, 249)
        Me.lbl_dt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_dt.Name = "lbl_dt"
        Me.lbl_dt.Size = New System.Drawing.Size(48, 20)
        Me.lbl_dt.TabIndex = 4
        Me.lbl_dt.Text = "Date:"
        '
        'lbl_tm
        '
        Me.lbl_tm.AutoSize = True
        Me.lbl_tm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tm.Location = New System.Drawing.Point(176, 296)
        Me.lbl_tm.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_tm.Name = "lbl_tm"
        Me.lbl_tm.Size = New System.Drawing.Size(47, 20)
        Me.lbl_tm.TabIndex = 5
        Me.lbl_tm.Text = "Time:"
        '
        'txtbox_name
        '
        Me.txtbox_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_name.Location = New System.Drawing.Point(257, 106)
        Me.txtbox_name.Margin = New System.Windows.Forms.Padding(2)
        Me.txtbox_name.Multiline = True
        Me.txtbox_name.Name = "txtbox_name"
        Me.txtbox_name.Size = New System.Drawing.Size(279, 34)
        Me.txtbox_name.TabIndex = 6
        '
        'txtbox_contact
        '
        Me.txtbox_contact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_contact.Location = New System.Drawing.Point(257, 153)
        Me.txtbox_contact.Margin = New System.Windows.Forms.Padding(2)
        Me.txtbox_contact.Multiline = True
        Me.txtbox_contact.Name = "txtbox_contact"
        Me.txtbox_contact.Size = New System.Drawing.Size(279, 34)
        Me.txtbox_contact.TabIndex = 7
        '
        'cmb_table
        '
        Me.cmb_table.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_table.FormattingEnabled = True
        Me.cmb_table.Items.AddRange(New Object() {"Select a Table", "Table 1", "Table 2", "Table 3", "Table 4", "Table 5", "Table 6"})
        Me.cmb_table.Location = New System.Drawing.Point(257, 206)
        Me.cmb_table.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_table.Name = "cmb_table"
        Me.cmb_table.Size = New System.Drawing.Size(279, 28)
        Me.cmb_table.TabIndex = 11
        Me.cmb_table.Text = "Select a Table"
        '
        'dtp_date
        '
        Me.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_date.Location = New System.Drawing.Point(257, 251)
        Me.dtp_date.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_date.Name = "dtp_date"
        Me.dtp_date.Size = New System.Drawing.Size(279, 20)
        Me.dtp_date.TabIndex = 12
        '
        'dtp_time
        '
        Me.dtp_time.CustomFormat = "hh:mm tt"
        Me.dtp_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_time.Location = New System.Drawing.Point(257, 297)
        Me.dtp_time.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_time.Name = "dtp_time"
        Me.dtp_time.ShowUpDown = True
        Me.dtp_time.Size = New System.Drawing.Size(279, 20)
        Me.dtp_time.TabIndex = 13
        '
        'btn_confirm
        '
        Me.btn_confirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirm.Location = New System.Drawing.Point(330, 356)
        Me.btn_confirm.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(80, 32)
        Me.btn_confirm.TabIndex = 14
        Me.btn_confirm.Text = "Confirm"
        Me.btn_confirm.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(648, 407)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(80, 32)
        Me.btn_back.TabIndex = 15
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_reservations
        '
        Me.btn_reservations.Location = New System.Drawing.Point(546, 407)
        Me.btn_reservations.Name = "btn_reservations"
        Me.btn_reservations.Size = New System.Drawing.Size(84, 32)
        Me.btn_reservations.TabIndex = 17
        Me.btn_reservations.Text = "Reservations"
        Me.btn_reservations.UseVisualStyleBackColor = True
        '
        'Reservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 449)
        Me.Controls.Add(Me.btn_reservations)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.dtp_time)
        Me.Controls.Add(Me.dtp_date)
        Me.Controls.Add(Me.cmb_table)
        Me.Controls.Add(Me.txtbox_contact)
        Me.Controls.Add(Me.txtbox_name)
        Me.Controls.Add(Me.lbl_tm)
        Me.Controls.Add(Me.lbl_dt)
        Me.Controls.Add(Me.lbl_tb)
        Me.Controls.Add(Me.lbl_contact)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_tr)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Reservation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_tr As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_contact As Label
    Friend WithEvents lbl_tb As Label
    Friend WithEvents lbl_dt As Label
    Friend WithEvents lbl_tm As Label
    Friend WithEvents txtbox_name As TextBox
    Friend WithEvents txtbox_contact As TextBox
    Friend WithEvents cmb_table As ComboBox
    Friend WithEvents dtp_date As DateTimePicker
    Friend WithEvents dtp_time As DateTimePicker
    Friend WithEvents btn_confirm As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_reservations As Button
End Class
