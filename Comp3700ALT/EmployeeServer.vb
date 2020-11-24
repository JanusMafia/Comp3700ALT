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
            LoginPage.leaveRequestController.AddRequest(LoginPage.activeEmployeeObj.MakeNewRequest(LoginPage.activeEmployeeObj.EmployeeID(), MonthCalendarTmp.SelectionRange(), LeaveTypeBox.SelectedItem))
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

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Hide()
    End Sub
End Class