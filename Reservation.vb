Public Class Reservation
    Private Sub dtp_time_ValueChanged(sender As Object, e As EventArgs) Handles dtp_time.ValueChanged
        dtp_time.Format = DateTimePickerFormat.Custom
        dtp_time.CustomFormat = "hh:mm tt"

        dtp_time.Value = DateTime.Now
    End Sub

    Private Sub dtp_date_ValueChanged(sender As Object, e As EventArgs) Handles dtp_date.ValueChanged
        dtp_date.Value = DateTime.Now
    End Sub

    Private Sub Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim main As New MainMenu()
        main.Show()

        Hide()
    End Sub
End Class