Public Class LeaveRequestController
    Private _currentRequests As Dictionary(Of Integer, Dictionary(Of Integer, LeaveRequest))
    Public Sub New()
        CurrentRequests = New Dictionary(Of Integer, Dictionary(Of Integer, LeaveRequest))
    End Sub

    Public Property CurrentRequests As Dictionary(Of Integer, Dictionary(Of Integer, LeaveRequest))
        Get
            Return _currentRequests
        End Get
        Set(value As Dictionary(Of Integer, Dictionary(Of Integer, LeaveRequest)))
            _currentRequests = value
        End Set
    End Property

    Public Sub AddRequest(request As LeaveRequest)
        If (_currentRequests.ContainsKey(request.EmployeeID)) Then
            _currentRequests.Item(request.EmployeeID).Add(request.RequestID, request)
        Else
            Dim newRequest As New Dictionary(Of Integer, LeaveRequest) From {
                {request.RequestID, request}
            }
            _currentRequests.Add(request.EmployeeID, newRequest)
        End If
    End Sub

    Public Sub DeleteRequest(request As LeaveRequest)
        _currentRequests.Remove(request.RequestID)
    End Sub
End Class
