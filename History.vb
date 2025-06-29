Public Class History

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim main As New MainMenu()
        main.Show()
        Hide()
    End Sub

    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView_history.Columns.Clear()

        DataGridView_history.DataSource = Nothing
        DataGridView_history.DataSource = SessionStore.HistoryList
    End Sub


End Class
