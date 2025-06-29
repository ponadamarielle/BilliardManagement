Public Module SessionStore
    Public TableAssignments As New Dictionary(Of String, AssignSession)

    Public HistoryList As New List(Of HistoryRecord)

End Module

Public Class AssignSession
    Public Property Player1 As String
    Public Property Player2 As String
    Public Property FromTime As DateTime
    Public Property ToTime As DateTime
    Public Property PaymentDone As Boolean = False
    Public Property Status As String

End Class