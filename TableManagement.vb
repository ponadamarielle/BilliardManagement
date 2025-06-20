Public Class TableManagement

    Private Sub btn_table_Click(sender As Object, e As EventArgs) Handles btn_table.Click
        Dim assign As New Assign()
        assign.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim assign As New Assign()
        assign.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim assign As New Assign()
        assign.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim assign As New Assign()
        assign.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim assign As New Assign()
        assign.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim assign As New Assign()
        assign.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim mainMenu As New MainMenu()
        mainMenu.Show()

        Close()

    End Sub
End Class