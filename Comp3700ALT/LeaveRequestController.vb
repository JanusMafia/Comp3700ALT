Public Class LeaveRequestController
    Private _currentRequests As Dictionary(Of Integer, LeaveRequest)
    Public Sub New()
        CurrentRequests = New Dictionary(Of Integer, LeaveRequest)
    End Sub

    Public Property CurrentRequests As Dictionary(Of Integer, LeaveRequest)
        Get
            Return _currentRequests
        End Get
        Set(value As Dictionary(Of Integer, LeaveRequest))
            _currentRequests = value
        End Set
    End Property

    Public Sub addRequest(request As LeaveRequest)
        _currentRequests.Add(request.GetRequestID, request)
    End Sub

    Public Sub deleteRequest(request As LeaveRequest)
        _currentRequests.Remove(request.GetRequestID)
    End Sub
End Class
