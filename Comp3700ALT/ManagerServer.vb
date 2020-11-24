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

    Private Sub CmdRequestLeave_Click(sender As Object, e As EventArgs) Handles cmdRequestLeave.Click
        If LeaveTypeBox.SelectedItem IsNot Nothing Then
            Dim request As LeaveRequest
            request = LoginPage.activeEmployeeObj.MakeNewRequest(LoginPage.activeEmployeeObj.EmployeeID(), MonthCalendarTmp.SelectionRange(), LeaveTypeBox.SelectedItem)
            If (request Is Nothing) Then
                Exit Sub
                'might need soemthing here
            Else
                LoginPage.leaveRequestController.AddRequest(request)
            End If

        Else
            MsgBox("Please fill out all options.", Title:="Request Failed")
            Exit Sub
        End If

        PanelLeaveRequest.Hide()
        'Changed the request sent label to a msg box
        MsgBox("Request Sent", Title:="Request")
        Debug.Print("Test")
        MonthCalendarTmp.SelectionRange = New SelectionRange
        LeaveTypeBox.SelectedIndex = 0
        PanelWelcome.Show()
    End Sub

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        'TODO: Change this to anything else
        PanelLeaveRequest.Hide()
        PanelNotification.Hide()
        PanelWelcome.Show()
        lblWelcome.Visible = True

    End Sub
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Hide()
        LoginPage.activeEmployeeObj = LoginPage.nullObj
        LoginPage.Show()
    End Sub

    Private Sub bttnNotificationCancel_Click(sender As Object, e As EventArgs) Handles bttnNotificationCancel.Click
        PanelNotification.Hide()
        PanelWelcome.Show()
        DGVNotification.Rows.Clear()
        DGVNotification.Visible = False
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
        PanelWelcome.Visible = False
        PanelNotification.Visible = False
        PanelReport.Visible = True
        If LoginPage.leaveRequestController.CurrentRequests.Keys.Count > 0 Then
            lblLeaveRequestUpdate.Text = "You have an Active Request"
            DGVReport.Visible = True
            Dim newRow As DataGridViewRow
            For Each employee In LoginPage.leaveRequestController.CurrentRequests.Values
                For Each currentLeaveRequest In employee.Values
                    newRow = New DataGridViewRow
                    Dim unused = currentLeaveRequest.ApprovalStatus
                    Dim rowID As Integer = DGVReport.Rows.Add()
                    newRow = DGVReport.Rows(rowID)
                    newRow.Cells(0).Value = currentLeaveRequest.EmployeeID
                    newRow.Cells(1).Value = currentLeaveRequest.RequestID
                    newRow.Cells(2).Value = currentLeaveRequest.TypeOfLeave.ToString
                    newRow.Cells(3).Value = currentLeaveRequest.HoursRequested
                    newRow.Cells(4).Value = currentLeaveRequest.ApprovalStatus
                Next
            Next
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PanelReport.Visible = False
        PanelWelcome.Visible = True
        DGVNotification.Rows.Clear()
        DGVNotification.Visible = False
    End Sub
End Class