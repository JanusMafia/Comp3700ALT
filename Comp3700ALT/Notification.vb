Public Class Notification
    Private _employeeId As Integer
    Private _requestId As Integer
    Private _requestStatus As RequestStatusEnum

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

    Public Property RequestStatus As RequestStatusEnum
        Get
            Return _requestStatus
        End Get
        Set(value As RequestStatusEnum)
            _requestStatus = value
        End Set
    End Property

    Enum RequestStatusEnum
        Pending
        Verified
        Approved
        Rejected
    End Enum
    Public Sub New(employeeId1 As Integer, requestId1 As Integer)
        EmployeeId = employeeId1
        RequestStatus = RequestStatusEnum.Pending
        RequestId = requestId1
    End Sub
End Class
