Public Class Reservation

    Private Shared _viewReservationInstance As ViewReservation = Nothing

    Public Shared ReadOnly Property ViewReservationInstance() As ViewReservation
        Get
            If _viewReservationInstance Is Nothing OrElse _viewReservationInstance.IsDisposed Then
                _viewReservationInstance = New ViewReservation()
                _viewReservationInstance.InitializeColumns()
            End If
            Return _viewReservationInstance
        End Get
    End Property

    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click
        If String.IsNullOrWhiteSpace(txtbox_name.Text) Then
            MessageBox.Show("Please enter the name.", "Missing Name", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtbox_contact.Text) Then
            MessageBox.Show("Please enter the contact number.", "Missing Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cmb_table.SelectedIndex = -1 OrElse String.IsNullOrWhiteSpace(cmb_table.Text) Then
            MessageBox.Show("Please select a table.", "Missing Table", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show(
        "Are you sure you want to confirm this reservation?",
        "Confirm Reservation",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    )

        If result = DialogResult.Yes Then
            ViewReservationInstance.AddReservation(
            txtbox_name.Text,
            txtbox_contact.Text,
            cmb_table.Text,
            dtp_date.Value.ToShortDateString(),
            dtp_time.Value.ToShortTimeString()
        )

            MessageBox.Show("Reservation successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txtbox_name.Clear()
            txtbox_contact.Clear()
            cmb_table.SelectedIndex = 0
            dtp_date.Value = DateTime.Now
            dtp_time.Value = DateTime.Now
        End If
    End Sub


    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim main As New MainMenu()
        main.Show()
        Hide()
    End Sub

    Private Sub btn_reservations_Click(sender As Object, e As EventArgs) Handles btn_reservations.Click

        Dim form As ViewReservation = ViewReservationInstance
        form.Show()
        Hide()
    End Sub

End Class