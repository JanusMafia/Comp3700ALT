Public Class LeaveRequest
    Private _employeeID As Integer
    Private _typeOfLeave As Integer
    Private _hoursRequested As TypeOfLeaveEnum
    Private _approvalStatus As Boolean
    Private _requestID As Integer

    Public Property EmployeeID As Integer
        Get
            Return _employeeID
        End Get
        Set(value As Integer)
            _employeeID = value
        End Set
    End Property

    Public Property TypeOfLeave As Integer
        Get
            Return _typeOfLeave
        End Get
        Set(value As Integer)
            _typeOfLeave = value
        End Set
    End Property

    Public Property HoursRequested As TypeOfLeaveEnum
        Get
            Return _hoursRequested
        End Get
        Set(value As TypeOfLeaveEnum)
            _hoursRequested = value
        End Set
    End Property

    Public Property ApprovalStatus As Boolean
        Get
            Return _approvalStatus
        End Get
        Set(value As Boolean)
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

    Public Sub New(_employeeID, _typeOfLeave, _hoursRequested)
        Dim rand As New Random
        EmployeeID = _employeeID
        TypeOfLeave = _typeOfLeave
        HoursRequested = _hoursRequested
        ApprovalStatus = vbNull
        RequestID = rand.Next(2000)
    End Sub


End Class
