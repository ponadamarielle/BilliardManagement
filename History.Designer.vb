<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class History
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView_history = New System.Windows.Forms.DataGridView()
        Me.column_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalHours = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Payment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_back = New System.Windows.Forms.Button()
        CType(Me.DataGridView_history, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(385, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HISTORY"
        '
        'DataGridView_history
        '
        Me.DataGridView_history.AllowUserToAddRows = False
        Me.DataGridView_history.AllowUserToOrderColumns = True
        Me.DataGridView_history.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_history.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_history.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.column_date, Me.Table, Me.totalHours, Me.Payment})
        Me.DataGridView_history.Location = New System.Drawing.Point(23, 73)
        Me.DataGridView_history.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView_history.Name = "DataGridView_history"
        Me.DataGridView_history.RowHeadersWidth = 51
        Me.DataGridView_history.RowTemplate.Height = 24
        Me.DataGridView_history.Size = New System.Drawing.Size(936, 407)
        Me.DataGridView_history.TabIndex = 1
        '
        'column_date
        '
        Me.column_date.HeaderText = "Date"
        Me.column_date.MinimumWidth = 6
        Me.column_date.Name = "column_date"
        '
        'Table
        '
        Me.Table.HeaderText = "Table"
        Me.Table.MinimumWidth = 6
        Me.Table.Name = "Table"
        '
        'totalHours
        '
        Me.totalHours.HeaderText = "Total Hours"
        Me.totalHours.MinimumWidth = 6
        Me.totalHours.Name = "totalHours"
        '
        'Payment
        '
        Me.Payment.HeaderText = "Payment"
        Me.Payment.MinimumWidth = 6
        Me.Payment.Name = "Payment"
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(864, 501)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(107, 39)
        Me.btn_back.TabIndex = 15
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 553)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.DataGridView_history)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "History"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGridView_history, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView_history As DataGridView
    Friend WithEvents btn_back As Button
    Friend WithEvents column_date As DataGridViewTextBoxColumn
    Friend WithEvents Table As DataGridViewTextBoxColumn
    Friend WithEvents totalHours As DataGridViewTextBoxColumn
    Friend WithEvents Payment As DataGridViewTextBoxColumn
End Class
