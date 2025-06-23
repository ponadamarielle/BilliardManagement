Public Class payment

    Public Property TotalPayment As Decimal
    Private originalPayment As Decimal

    Private Sub payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        originalPayment = TotalPayment

        lbl_Total.Text = "Total Payment: ₱" & originalPayment.ToString("F2")
        lbl_Pay.Text = "Payment: ₱" & originalPayment.ToString("F2")
    End Sub

    Private Sub cmb_Discount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_discount.SelectedIndexChanged
        Dim discountPercent As Decimal = 0D

        Select Case cmb_discount.SelectedItem.ToString()
            Case "Student"
                discountPercent = 0.05D
            Case "Senior"
                discountPercent = 0.15D
            Case "Loyalty"
                discountPercent = 0.2D
            Case Else
                discountPercent = 0D
        End Select

        Dim discountedTotal As Decimal = originalPayment - (originalPayment * discountPercent)
        lbl_Total.Text = "Total Payment: ₱" & discountedTotal.ToString("F2")
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Hide()
    End Sub

End Class
