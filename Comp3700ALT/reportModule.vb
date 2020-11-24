Module reportModule

    Public employeesOut As Integer

    Function generateReport()
        employeesOut = LoginPage.leaveRequestController.CurrentRequests.Count
        Dim tmpInt As Integer = 0
        For Each employee In LoginPage.leaveRequestController.CurrentRequests.Values
            tmpInt = tmpInt + 1
            For Each currentLeaveRequest In employee.Values
                Dim unused = currentLeaveRequest.ApprovalStatus


            Next
        Next
    End Function

    Function displayReport(report)

    End Function
End Module
