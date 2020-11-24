Public Class LeaveRequest
    Private _EmployeeID As Integer
    Private _TypeOfLeave As Integer
    Private _HoursRequested As typeOfLeaveEnum
    Private _ApprovalStatus As Boolean
    Private _RequestID As Integer

    Public Function GetEmployeeID() As Integer
        Return _EmployeeID
    End Function

    Public Sub SetEmployeeID(AutoPropertyValue As Integer)
        _EmployeeID = AutoPropertyValue
    End Sub

    Public Function GetTypeOfLeave() As Integer
        Return _TypeOfLeave
    End Function

    Public Sub SetTypeOfLeave(AutoPropertyValue As Integer)
        _TypeOfLeave = AutoPropertyValue
    End Sub

    Public Function GetHoursRequested() As typeOfLeaveEnum
        Return _HoursRequested
    End Function

    Public Sub SetHoursRequested(AutoPropertyValue As typeOfLeaveEnum)
        _HoursRequested = AutoPropertyValue
    End Sub

    Public Function GetApprovalStatus() As Boolean
        Return _ApprovalStatus
    End Function

    Public Sub SetApprovalStatus(AutoPropertyValue As Boolean)
        _ApprovalStatus = AutoPropertyValue
    End Sub

    Public Function GetRequestID() As Integer
        Return _RequestID
    End Function

    Public Sub SetRequestID(AutoPropertyValue As Integer)
        _RequestID = AutoPropertyValue
    End Sub

    Enum typeOfLeaveEnum
        Vacation
        Sick
        PaternityOrMaternity
    End Enum

    Public Sub New(eID, tOfLeave, hRequested)
        Dim rand As New Random
        SetEmployeeID(eID)
        _TypeOfLeave = tOfLeave
        SetHoursRequested(hRequested)
        SetApprovalStatus(vbNull)
        SetRequestID(rand.Next(2000))

    End Sub


End Class
