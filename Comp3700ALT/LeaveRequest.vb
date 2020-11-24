Public Class LeaveRequest
    Private Property employeeID As Integer
    Private Property typeOfLeave As Integer
    Private Property hoursRequested As typeOfLeaveEnum
    Public Property approvalStatus As Boolean
    Public Property requestID As Integer

    Enum typeOfLeaveEnum
        Vacation
        Sick
        PaternityOrMaternity
    End Enum

    Public Sub New(eID, tOfLeave, hRequested)
        Dim rand As Random
        employeeID = eID
        typeOfLeave = tOfLeave
        hoursRequested = hRequested
        approvalStatus = vbNull
        requestID = rand.Next(2000)
    End Sub

    Public Function getemployeeID() As Integer
        Return employeeID
    End Function

    Public Function gettypeOfLeave() As Integer
        Return typeOfLeave
    End Function

    Public Function gethoursRequested() As Integer
        Return hoursRequested
    End Function

    Public Function getapprovalStatus() As Boolean
        Return approvalStatus
    End Function

    Public Function getrequestID() As Integer
        Return requestID
    End Function

End Class
