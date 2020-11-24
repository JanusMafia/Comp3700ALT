Public Class LeaveRequest
    Private _employeeID As Integer
    Private _typeOfLeave As TypeOfLeaveEnum
    Private _hoursRequested As Integer
    Private _approvalStatus As RequestStatusEnum
    Private _requestID As Integer

    Public Property EmployeeID As Integer
        Get
            Return _employeeID
        End Get
        Set(value As Integer)
            _employeeID = value
        End Set
    End Property

    Public Property TypeOfLeave As TypeOfLeaveEnum
        Get
            Return _typeOfLeave
        End Get
        Set(value As TypeOfLeaveEnum)
            _typeOfLeave = value
        End Set
    End Property

    Public Property HoursRequested As Integer
        Get
            Return _hoursRequested
        End Get
        Set(value As Integer)
            _hoursRequested = value
        End Set
    End Property

    Public Property ApprovalStatus As RequestStatusEnum
        Get
            Return _approvalStatus
        End Get
        Set(value As RequestStatusEnum)
            _approvalStatus = value
        End Set
    End Property

    Public Property RequestID As Integer
        Get
            Return _requestID
        End Get
        Set(value As Integer)
            _requestID = value
        End Set
    End Property

    Enum TypeOfLeaveEnum
        Vacation
        Sick
        Paternal
    End Enum

    Public Sub New(_employeeID As Integer, _typeOfLeave As TypeOfLeaveEnum, _hoursRequested As Integer)
        Dim rand As New Random
        EmployeeID = _employeeID
        TypeOfLeave = _typeOfLeave
        HoursRequested = _hoursRequested
        ApprovalStatus = RequestStatusEnum.Pending
        RequestID = rand.Next(2000)
    End Sub

    Public Enum RequestStatusEnum
        Pending
        Verified
        Approved
        Rejected
    End Enum

End Class
