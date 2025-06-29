Public Class TableManagement
    Public tableForms As New Dictionary(Of String, Assign)

    Private Sub TableManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateTableStatuses()
    End Sub

    Private Sub btn_table1_Click(sender As Object, e As EventArgs) Handles btn_table1.Click
        OpenAssignForm("Table 1")
    End Sub

    Private Sub btn_table2_Click(sender As Object, e As EventArgs) Handles btn_table2.Click
        OpenAssignForm("Table 2")
    End Sub

    Private Sub btn_table3_Click(sender As Object, e As EventArgs) Handles btn_table3.Click
        OpenAssignForm("Table 3")
    End Sub

    Private Sub btn_table4_Click(sender As Object, e As EventArgs) Handles btn_table4.Click
        OpenAssignForm("Table 4")
    End Sub

    Private Sub btn_table5_Click(sender As Object, e As EventArgs) Handles btn_table5.Click
        OpenAssignForm("Table 5")
    End Sub

    Private Sub btn_table6_Click(sender As Object, e As EventArgs) Handles btn_table6.Click
        OpenAssignForm("Table 6")
    End Sub

    Private Sub OpenAssignForm(tableNumber As String)
        Dim assignForm As Assign = Nothing

        If tableForms.ContainsKey(tableNumber) Then
            assignForm = tableForms(tableNumber)
        Else
            assignForm = New Assign()
            assignForm.SelectedTable = tableNumber
            assignForm.ParentTableForm = Me

            tableForms(tableNumber) = assignForm
        End If

        assignForm.Show()
        assignForm.BringToFront()
    End Sub

    Public Sub SetStatusLabel(tableName As String, statusLabel As Label)
        If SessionStore.TableAssignments.ContainsKey(tableName) Then
            Dim session = SessionStore.TableAssignments(tableName)

            If DateTime.Now < session.ToTime Then
                statusLabel.Text = "OCCUPIED"
                statusLabel.ForeColor = Color.Red
            Else
                statusLabel.Text = "COMPLETED"
                statusLabel.ForeColor = Color.Orange
            End If
        Else
            statusLabel.Text = "AVAILABLE"
            statusLabel.ForeColor = Color.PowderBlue
        End If
    End Sub

    Public Sub UpdateTableStatuses()
        SetStatusLabel("Table 1", lbl_table1Status)
        SetStatusLabel("Table 2", lbl_table2Status)
        SetStatusLabel("Table 3", lbl_table3Status)
        SetStatusLabel("Table 4", lbl_table4Status)
        SetStatusLabel("Table 5", lbl_table5Status)
        SetStatusLabel("Table 6", lbl_table6Status)
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim mainMenu As New MainMenu()
        mainMenu.Show()
        Hide()
    End Sub
End Class
