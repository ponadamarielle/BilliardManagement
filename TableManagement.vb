Public Class TableManagement

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
        Dim assignForm As New Assign()
        assignForm.SelectedTable = tableNumber
        assignForm.Show()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        ' Optional: Navigate to MainMenu
        Dim mainMenu As New MainMenu()
        mainMenu.Show()
        Me.Close()
    End Sub
End Class
