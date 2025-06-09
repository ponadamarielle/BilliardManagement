Public Class Form1

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim username As String = tbx_user.Text
        Dim password As String = tbx_pass.Text

        If tbx_user.Text = "admin" And tbx_pass.Text = "admin123" Then
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim mainMenu As New MainMenu()
            mainMenu.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbx_user.Text = ""
            tbx_pass.Text = ""

        End If

    End Sub

    Private Sub lbl_username_Click(sender As Object, e As EventArgs) Handles lbl_username.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
