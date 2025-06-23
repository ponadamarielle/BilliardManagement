Public Class Assign

    Public Property SelectedTable As String

    Private WithEvents Timer1 As New Timer()
    Private sessionStarted As Boolean = False
    Private sessionToTime As DateTime
    Private sessionFromTime As DateTime
    Private player1Name As String
    Private player2Name As String
    Private currentSessionLabel As Label
    Private lastSessionPayment As Decimal = 0D

    Private Sub Assign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTableNumber.Text = "Assigned to: " & SelectedTable
        Panel1.AutoScroll = True
        Timer1.Interval = 1000 ' 1 second
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        player1Name = txb_playerOne.Text.Trim()
        player2Name = txb_PlayerTwo.Text.Trim()
        sessionFromTime = dtp_from.Value
        sessionToTime = dtp_to.Value
        Dim now As DateTime = DateTime.Now

        If player1Name = "" OrElse player2Name = "" Then
            MessageBox.Show("Please enter both player names.")
            Return
        End If

        If sessionToTime <= sessionFromTime Then
            MessageBox.Show("End time must be after start time.")
            Return
        End If

        Dim duration As TimeSpan = sessionToTime - sessionFromTime
        Dim hours As Decimal = CDec(duration.TotalHours)
        Dim payment As Decimal = hours * 100D
        lastSessionPayment = payment

        Dim baseText As String =
            $"Player 1: {player1Name}" & vbCrLf &
            $"Player 2: {player2Name}" & vbCrLf &
            $"Time: {sessionFromTime.ToShortTimeString()} - {sessionToTime.ToShortTimeString()} ({duration.TotalMinutes:F0} mins)" & vbCrLf &
            $"Payment: ₱{payment:F2} | {SelectedTable}"

        currentSessionLabel = New Label With {
            .AutoSize = False,
            .Width = Panel1.Width - 10,
            .Height = 100,
            .Left = 5,
            .Top = Panel1.Controls.Count * 105,
            .Font = New Font("Segoe UI", 9),
            .Tag = baseText,
            .Text = baseText & vbCrLf & "Time Remaining: calculating..."
        }

        Panel1.Controls.Add(currentSessionLabel)

        If now < sessionToTime Then
            sessionStarted = True
            Timer1.Start()
        Else
            currentSessionLabel.Text = baseText & vbCrLf & "Time Remaining: 00:00:00" & vbCrLf & "**Session complete**"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not sessionStarted Then Exit Sub

        Dim now As DateTime = DateTime.Now

        If now < sessionToTime Then
            Dim remaining As TimeSpan = sessionToTime - now
            Dim timeLeft As String = "Time Remaining: " & remaining.ToString("hh\:mm\:ss")
            currentSessionLabel.Text = currentSessionLabel.Tag.ToString() & vbCrLf & timeLeft
        Else
            Timer1.Stop()
            sessionStarted = False
            currentSessionLabel.Text = currentSessionLabel.Tag.ToString() & vbCrLf &
                "Time Remaining: 00:00:00" & vbCrLf &
                "**Session complete**"
        End If
    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        txb_playerOne.Clear()
        txb_PlayerTwo.Clear()
        dtp_from.Value = DateTime.Now
        dtp_to.Value = DateTime.Now
    End Sub

    Private Sub btn_Payment_Click(sender As Object, e As EventArgs) Handles btn_Payment.Click
        Dim payForm As New payment()
        payForm.TotalPayment = lastSessionPayment
        payForm.Show()
        Hide()
    End Sub

End Class
