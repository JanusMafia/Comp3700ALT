Public Class EmployeeServer
    Public newRequest As LeaveRequest
    Enum TypeOfLeaveEnum
        Vacation
        Sick
        Paternal
    End Enum

    Private Sub EmployeeServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelLeaveRequest.Visible = False
        PanelWelcome.Visible = True
        lblWelcome.Visible = True
        lblWelcome.Text = "Welcome to work, " + LoginPage.activeEmployeeObj.UserName()
        welcomeMSG.Text = "Welcome " + LoginPage.activeEmployeeObj.UserName()
        MonthCalendarTmp.SelectionRange.Start = Date.Today
    End Sub

    Private Sub CmdRequestLeave_Click(sender As Object, e As EventArgs) Handles cmdRequestLeave.Click
        If LeaveTypeBox.SelectedItem IsNot Nothing Then
            LoginPage.leaveRequestController.AddRequest(MakeNewRequest(LoginPage.activeEmployeeObj.EmployeeID(), MonthCalendarTmp.SelectionRange(), LeaveTypeBox.SelectedItem))
        Else
            MsgBox("Please fill out all options.", Title:="Request Failed")
            Exit Sub
        End If

        PanelLeaveRequest.Visible = False
        'Changed the request sent label to a msg box
        MsgBox("Request Sent", Title:="Request")
        Debug.Print("Test")
        MonthCalendarTmp.SelectionRange = New SelectionRange
        LeaveTypeBox.SelectedIndex = 0
    End Sub

    ''' <summary>
    '''  Makes a new request.
    ''' </summary>
    ''' <param name="requestID"> The ID of the leave request.</param>
    ''' <param name="selectionRange"> The selected range of dates for the leave request.</param>
    ''' <param name="choosenLeaveType"> The leave type for the leave requested.</param>
    ''' <returns></returns>
    Private Function MakeNewRequest(requestID As Integer, selectionRange As SelectionRange, choosenLeaveType As TypeOfLeaveEnum)
        Dim dt1 As DateTime = Convert.ToDateTime(selectionRange.Start)
        Dim dt2 As DateTime = Convert.ToDateTime(selectionRange.End)
        ' Counts total days between selected dates
        Dim numberOfSelectedDays As Integer = dt2.Subtract(dt1).Days + 1
        Dim hours As Integer = numberOfSelectedDays * 8
        Return (New LeaveRequest(requestID, choosenLeaveType, hours))
    End Function

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        'TODO: Change this to anything else
        Me.Dispose()

    End Sub

    Private Sub RequestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequestToolStripMenuItem.Click
        PanelWelcome.Visible = False
        PanelLeaveRequest.Visible = True
    End Sub

    Private Sub NotificationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotificationsToolStripMenuItem.Click
        PanelWelcome.Visible = False
        PanelNotification.Visible = True
        'TODO: Make notification display messages from the notifciation class.
        ' Look up the notification by searching the LeaveRequestControllers dictionary using the employeeID and the LeaveRequest. 
        ' I wasn't sure how else to connect the notification to someone.
    End Sub
End Class