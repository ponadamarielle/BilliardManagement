Public Class Assign

    Public Property SelectedTable As String
    Public Property ParentTableForm As TableManagement

    Public Property PaymentDone As Boolean = False

    Private WithEvents Timer1 As New Timer()
    Public ReadOnly Property SessionToTime As DateTime
        Get
            Return dtp_to.Value
        End Get
    End Property

    Private currentSessionLabel As Label
    Private lastSessionPayment As Decimal = 0D

    Private Sub Assign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTableNumber.Text = "Assigned to: " & SelectedTable
        Panel1.AutoScroll = True
        Timer1.Interval = 1000

        If SessionStore.TableAssignments.ContainsKey(SelectedTable) Then
            Dim session = SessionStore.TableAssignments(SelectedTable)

            If DateTime.Now >= session.ToTime Then
                Dim duration As TimeSpan = session.ToTime - session.FromTime
                Dim payment As Decimal = CDec(duration.TotalHours) * 100D
                lastSessionPayment = payment

                Dim displayText As String =
                            $"Player 1: {session.Player1}" & vbCrLf &
                            $"Player 2: {session.Player2}" & vbCrLf &
                            $"Time: {session.FromTime:hh\:mm tt} - {session.ToTime:hh\:mm tt} ({duration.TotalMinutes:F0} mins)" & vbCrLf &
                            $"Payment: ₱{payment:F2} | {SelectedTable}" & vbCrLf &
                            "Time Remaining: 00:00:00" & vbCrLf &
                            "**Session complete**"

                currentSessionLabel = New Label With {
                                    .AutoSize = False,
                                    .Width = Panel1.Width - 10,
                                    .Height = 100,
                                    .Left = 5,
                                    .Top = 0,
                                    .Font = New Font("Segoe UI", 9),
                                    .Text = displayText
                }
                Panel1.Controls.Add(currentSessionLabel)

                btn_Add.Enabled = False
                btn_Add.Text = "Occupied"

                txb_playerOne.Enabled = False
                txb_PlayerTwo.Enabled = False
                dtp_from.Enabled = False
                dtp_to.Enabled = False

                If session.PaymentDone Then
                    btn_Payment.Enabled = False
                    btn_Clear.Enabled = True
                Else
                    btn_Payment.Enabled = True
                    btn_Clear.Enabled = False
                End If

                Return
            End If


            If DateTime.Now < session.ToTime Then
                btn_Add.Enabled = False
                btn_Add.Text = "Occupied"

                txb_playerOne.Enabled = False
                txb_PlayerTwo.Enabled = False
                dtp_from.Enabled = False
                dtp_to.Enabled = False

                MessageBox.Show(
                $"This table is currently occupied by:" & vbCrLf &
                $"Player 1: {session.Player1}" & vbCrLf &
                $"Player 2: {session.Player2}" & vbCrLf &
                $"Time: {session.FromTime:hh\:mm tt} - {session.ToTime:hh\:mm tt}",
                "Table Occupied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

                Dim duration As TimeSpan = session.ToTime - session.FromTime
                Dim payment As Decimal = CDec(duration.TotalHours) * 100D

                Dim displayText As String =
                $"Player 1: {session.Player1}" & vbCrLf &
                $"Player 2: {session.Player2}" & vbCrLf &
                $"Time: {session.FromTime:hh\:mm tt} - {session.ToTime:hh\:mm tt} ({duration.TotalMinutes:F0} mins)" & vbCrLf &
                $"Payment: ₱{payment:F2} | {SelectedTable}"

                If Panel1.Controls.Count = 0 Then
                    currentSessionLabel = New Label With {
                    .AutoSize = False,
                    .Width = Panel1.Width - 10,
                    .Height = 100,
                    .Left = 5,
                    .Top = 0,
                    .Font = New Font("Segoe UI", 9),
                    .Tag = displayText,
                    .Text = displayText & vbCrLf & "Time Remaining: calculating..."
                }
                    Panel1.Controls.Add(currentSessionLabel)
                Else
                    currentSessionLabel = TryCast(Panel1.Controls(0), Label)
                End If

                Timer1.Start()
            Else
                btn_Add.Enabled = True
            End If
        Else
            btn_Add.Enabled = True
        End If

        If Panel1.Controls.Count > 0 Then
            btn_Add.Enabled = False
            btn_Add.Text = "Occupied"

            If Not Timer1.Enabled Then
                Timer1.Start()
            End If

            txb_playerOne.Enabled = False
            txb_PlayerTwo.Enabled = False
            dtp_from.Enabled = False
            dtp_to.Enabled = False
        End If

        If SessionStore.TableAssignments.ContainsKey(SelectedTable) Then
            Dim session = SessionStore.TableAssignments(SelectedTable)

            If session.PaymentDone Then
                btn_Payment.Enabled = False
                btn_Clear.Enabled = True
            End If
        End If
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click

        If SessionStore.TableAssignments.ContainsKey(SelectedTable) Then
            Dim session = SessionStore.TableAssignments(SelectedTable)
            If DateTime.Now < session.ToTime Then
                MessageBox.Show("This table is currently occupied. Please clear the session first.", "Cannot Add", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        End If

        Dim player1Name = txb_playerOne.Text.Trim()
        Dim player2Name = txb_PlayerTwo.Text.Trim()
        Dim sessionFromTime = dtp_from.Value
        Dim toTime = dtp_to.Value

        Dim now = DateTime.Now

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
            $"Time: {sessionFromTime:hh\:mm tt} - {sessionToTime:hh\:mm tt} ({duration.TotalMinutes:F0} mins)" & vbCrLf &
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

        Dim assignData As New AssignSession With {
            .Player1 = player1Name,
            .Player2 = player2Name,
            .FromTime = sessionFromTime,
            .ToTime = sessionToTime
        }
        SessionStore.TableAssignments(SelectedTable) = assignData

        Select Case SelectedTable
            Case "Table 1" : ParentTableForm.SetStatusLabel("Table 1", ParentTableForm.lbl_table1Status)
            Case "Table 2" : ParentTableForm.SetStatusLabel("Table 2", ParentTableForm.lbl_table2Status)
            Case "Table 3" : ParentTableForm.SetStatusLabel("Table 3", ParentTableForm.lbl_table3Status)
            Case "Table 4" : ParentTableForm.SetStatusLabel("Table 4", ParentTableForm.lbl_table4Status)
            Case "Table 5" : ParentTableForm.SetStatusLabel("Table 5", ParentTableForm.lbl_table5Status)
            Case "Table 6" : ParentTableForm.SetStatusLabel("Table 6", ParentTableForm.lbl_table6Status)
        End Select

        If now < sessionToTime Then
            Timer1.Start()
        Else
            currentSessionLabel.Text = baseText & vbCrLf & "Time Remaining: 00:00:00" & vbCrLf & "**Session complete**"
        End If

        txb_playerOne.Clear()
        txb_PlayerTwo.Clear()
        dtp_from.Value = DateTime.Now
        dtp_to.Value = DateTime.Now

        btn_Add.Enabled = False
        btn_Add.Text = "Occupied"

        txb_playerOne.Enabled = False
        txb_PlayerTwo.Enabled = False
        dtp_from.Enabled = False
        dtp_to.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not SessionStore.TableAssignments.ContainsKey(SelectedTable) Then
            Timer1.Stop()
            Return
        End If

        Dim session = SessionStore.TableAssignments(SelectedTable)
        Dim now As DateTime = DateTime.Now

        If now < session.ToTime Then
            Dim remaining As TimeSpan = session.ToTime - now
            currentSessionLabel.Text = currentSessionLabel.Tag.ToString() & vbCrLf &
                               "Time Remaining: " & remaining.ToString("hh\:mm\:ss")
        Else
            currentSessionLabel.Text = currentSessionLabel.Tag.ToString() & vbCrLf &
                               "Time Remaining: 00:00:00" & vbCrLf &
                               "**Session complete**"
            Timer1.Stop()

            session.Status = "COMPLETED"
            If ParentTableForm IsNot Nothing Then
                ParentTableForm.UpdateTableStatuses()
            End If

            If ParentTableForm IsNot Nothing Then
                Select Case SelectedTable
                    Case "Table 1"
                        With ParentTableForm.lbl_table1Status
                            .Text = "COMPLETED"
                            .ForeColor = Color.Orange
                        End With

                    Case "Table 2"
                        With ParentTableForm.lbl_table2Status
                            .Text = "COMPLETED"
                            .ForeColor = Color.Orange
                        End With

                    Case "Table 3"
                        With ParentTableForm.lbl_table3Status
                            .Text = "COMPLETED"
                            .ForeColor = Color.Orange
                        End With

                    Case "Table 4"
                        With ParentTableForm.lbl_table4Status
                            .Text = "COMPLETED"
                            .ForeColor = Color.Orange
                        End With

                    Case "Table 5"
                        With ParentTableForm.lbl_table5Status
                            .Text = "COMPLETED"
                            .ForeColor = Color.Orange
                        End With

                    Case "Table 6"
                        With ParentTableForm.lbl_table6Status
                            .Text = "COMPLETED"
                            .ForeColor = Color.Orange
                        End With
                End Select
            End If

            Dim duration As TimeSpan = session.ToTime - session.FromTime
            lastSessionPayment = CDec(duration.TotalHours) * 100D

            If session.PaymentDone Then
                btn_Payment.Enabled = False
                btn_Clear.Enabled = True
            Else
                btn_Payment.Enabled = True
                btn_Clear.Enabled = False
            End If
        End If
    End Sub


    Private Sub btn_Payment_Click(sender As Object, e As EventArgs) Handles btn_Payment.Click
        If SessionStore.TableAssignments.ContainsKey(SelectedTable) Then
            Dim session = SessionStore.TableAssignments(SelectedTable)

            Dim totalHours As Decimal = CDec((session.ToTime - session.FromTime).TotalHours)
            Dim hourlyRate As Decimal = 100D
            Dim totalPay As Decimal = Math.Round(totalHours * hourlyRate, 2)

            lastSessionPayment = totalPay

            Dim payForm As New payment()
            payForm.TotalPayment = totalPay
            payForm.Owner = Me
            payForm.Show()
            Hide()
        Else
            MessageBox.Show("Session not found for this table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub




    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        If SessionStore.TableAssignments.ContainsKey(SelectedTable) Then
            Dim session = SessionStore.TableAssignments(SelectedTable)

            If DateTime.Now >= session.ToTime Then
                SessionStore.TableAssignments.Remove(SelectedTable)

                btn_Payment.Enabled = True
                btn_Clear.Enabled = False


                Select Case SelectedTable
                    Case "Table 1" : ParentTableForm.SetStatusLabel("Table 1", ParentTableForm.lbl_table1Status)
                    Case "Table 2" : ParentTableForm.SetStatusLabel("Table 2", ParentTableForm.lbl_table2Status)
                    Case "Table 3" : ParentTableForm.SetStatusLabel("Table 3", ParentTableForm.lbl_table3Status)
                    Case "Table 4" : ParentTableForm.SetStatusLabel("Table 4", ParentTableForm.lbl_table4Status)
                    Case "Table 5" : ParentTableForm.SetStatusLabel("Table 5", ParentTableForm.lbl_table5Status)
                    Case "Table 6" : ParentTableForm.SetStatusLabel("Table 6", ParentTableForm.lbl_table6Status)
                End Select

                Timer1.Stop()
                Panel1.Controls.Clear()

                btn_Add.Enabled = True
                btn_Add.Text = "Add"

                txb_playerOne.Enabled = True
                txb_PlayerTwo.Enabled = True
                dtp_from.Enabled = True
                dtp_to.Enabled = True

                If ParentTableForm.tableForms.ContainsKey(SelectedTable) Then
                    ParentTableForm.tableForms.Remove(SelectedTable)
                End If

                Me.Close()
                MessageBox.Show("Session cleared. Table is now available.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("This session is still active. You can only clear it after the session ends.", "Active Session", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("No session data found for this table.", "No Session", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Hide()
    End Sub
End Class
