Public Class ManagerServer

    Private Sub ManagerServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LeaveTypeBox.DataSource = System.Enum.GetValues(GetType(LeaveRequest.TypeOfLeaveEnum))
        PanelLeaveRequest.Visible = False
        PanelWelcome.Visible = True
        lblWelcome.Visible = True
        lblWelcome.Text = "Welcome to work, " + LoginPage.activeEmployeeObj.UserName()
        welcomeMSG.Text = "Welcome " + LoginPage.activeEmployeeObj.UserName()
        MonthCalendarTmp.SelectionRange.Start = Date.Today
    End Sub

    Private Sub RequestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequestToolStripMenuItem.Click
        PanelWelcome.Visible = False
        PanelLeaveRequest.Visible = True
    End Sub
    Private Sub NotificationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotificationsToolStripMenuItem.Click
        PanelWelcome.Visible = False
        PanelNotification.Visible = True
        If LoginPage.leaveRequestController.CurrentRequests.ContainsKey(LoginPage.activeEmployeeObj.EmployeeID) Then
            lblLeaveRequestUpdate.Text = "You have an Active Request"
            DGVNotification.Visible = True
            Dim newRow As DataGridViewRow
            For Each values In LoginPage.leaveRequestController.CurrentRequests.Item(LoginPage.activeEmployeeObj.EmployeeID).Values
                newRow = New DataGridViewRow

                Dim rowID As Integer = DGVNotification.Rows.Add()
                newRow = DGVNotification.Rows(rowID)
                newRow.Cells(0).Value = values.RequestID
                newRow.Cells(1).Value = values.TypeOfLeave.ToString
                newRow.Cells(2).Value = values.HoursRequested
                newRow.Cells(3).Value = values.ApprovalStatus

                'TODO: add tabel of values
            Next
        End If

        'TODO: Make notification display messages from the notifciation class.
        ' Look up the notification by searching the LeaveRequestControllers dictionary using the employeeID and the LeaveRequest. 
        ' I wasn't sure how else to connect the notification to someone.
    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click

    End Sub
End Class