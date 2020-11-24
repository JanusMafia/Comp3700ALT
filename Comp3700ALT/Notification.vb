Public Class Notification
    Private _employeeId As Integer
    Private _requestId As Integer
    Private _requestStatus As LeaveRequest.RequestStatusEnum

    Public Property EmployeeId As Integer
        Get
            Return _employeeId
        End Get
        Set(value As Integer)
            _employeeId = value
        End Set
    End Property

    Public Property RequestId As Integer
        Get
            Return _requestId
        End Get
        Set(value As Integer)
            _requestId = value
        End Set
    End Property

    Public Property RequestStatus As LeaveRequest.RequestStatusEnum
        Get
            Return _requestStatus
        End Get
        Set(value As LeaveRequest.RequestStatusEnum)
            _requestStatus = value
        End Set
    End Property

    Public Sub New(employeeId1 As Integer, requestId1 As Integer)
        EmployeeId = employeeId1
        RequestStatus = LeaveRequest.RequestStatusEnum.Pending
        RequestId = requestId1
    End Sub
End Class
