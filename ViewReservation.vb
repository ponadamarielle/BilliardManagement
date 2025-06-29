Public Class ViewReservation

    Private initialized As Boolean = False
    Public Sub InitializeColumns()
        If Not initialized Then
            With DataGridView1
                .Columns.Clear()
                .Columns.Add("colName", "Name")
                .Columns.Add("colContact", "Contact")
                .Columns.Add("colTable", "Table")
                .Columns.Add("colDate", "Date")
                .Columns.Add("colTime", "Time")
            End With
            initialized = True
        End If
    End Sub

    Private Sub ViewReservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeColumns()
    End Sub

    Public Sub AddReservation(name As String, contact As String, tableNum As String, dateValue As String, timeValue As String)

        If Not initialized Then InitializeColumns()

        Dim row As String() = {name, contact, tableNum, dateValue, timeValue}
        DataGridView1.Rows.Add(row)
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim reservation As New Reservation()
        reservation.Show()
        Hide()
    End Sub
End Class