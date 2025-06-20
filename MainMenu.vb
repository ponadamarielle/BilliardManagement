Public Class MainMenu

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Dim loginForm As New Login()
        loginForm.Show()

        Me.Close()
    End Sub

    Private Sub btn_table_Click(sender As Object, e As EventArgs) Handles btn_table.Click
        Dim tableManagement As New TableManagement()
        tableManagement.Show()
        Hide()
    End Sub

    Private Sub btn_reservation_Click(sender As Object, e As EventArgs) Handles btn_reservation.Click
        Dim reservationForm As New Reservation()
        reservationForm.Show()
        Hide()
    End Sub

    Private Sub btn_history_Click(sender As Object, e As EventArgs) Handles btn_history.Click
        Dim historyForm As New History()
        historyForm.Show()
        Hide()
    End Sub

End Class
