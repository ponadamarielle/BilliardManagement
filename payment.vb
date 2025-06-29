Public Class payment

    Public Property TotalPayment As Decimal
    Private originalPayment As Decimal

    Private Sub payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        originalPayment = TotalPayment

        cmb_discount.Items.Clear()
        cmb_discount.Items.AddRange(New String() {"Senior Citizen", "Student", "Loyalty"})
        cmb_discount.SelectedIndex = -1

        lbl_Total.Text = $"Total Payment: ₱{originalPayment:F2}"
        lbl_Pay.Text = $"Payment: ₱{originalPayment:F2}"
    End Sub

    Private Sub cmb_discount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_discount.SelectedIndexChanged
        ApplyDiscount()
    End Sub

    Private Sub ApplyDiscount()
        If cmb_discount.SelectedItem Is Nothing Then

            lbl_Total.Text = $"Total Payment: ₱{originalPayment:F2}"
            TotalPayment = originalPayment
            Exit Sub
        End If

        Dim discountPercent As Decimal = 0D

        Select Case cmb_discount.SelectedItem.ToString()
            Case "Student"
                discountPercent = 0.05D
            Case "Senior Citizen"
                discountPercent = 0.1D
            Case "Loyalty"
                discountPercent = 0.2D
        End Select

        Dim discountAmount As Decimal = originalPayment * discountPercent
        Dim discountedTotal As Decimal = originalPayment - discountAmount

        TotalPayment = discountedTotal

        lbl_Total.Text = $"Total Payment: ₱{discountedTotal:F2}"

    End Sub

    Private Sub btn_Confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click
        MessageBox.Show($"Payment of ₱{TotalPayment:F2} completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If Owner IsNot Nothing AndAlso TypeOf Owner Is Assign Then
            Dim assignForm = DirectCast(Owner, Assign)

            If SessionStore.TableAssignments.ContainsKey(assignForm.SelectedTable) Then
                Dim session = SessionStore.TableAssignments(assignForm.SelectedTable)
                Dim totalHours As Decimal = CDec((session.ToTime - session.FromTime).TotalHours)

                SessionStore.HistoryList.Add(New HistoryRecord With {
                    .DateCompleted = DateTime.Now,
                    .TableNumber = assignForm.SelectedTable,
                    .TotalHours = Math.Round(totalHours, 2),
                    .Payment = TotalPayment
                })

                session.PaymentDone = True
            End If

            assignForm.PaymentDone = True
            assignForm.btn_Payment.Enabled = False
            assignForm.btn_Clear.Enabled = True
        End If

        Close()
    End Sub

End Class
