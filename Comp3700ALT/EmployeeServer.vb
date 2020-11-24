Public Class EmployeeServer
    Dim choosenLeaveType As typeOfLeaveEnum
    Public newRequest As LeaveRequest

    Enum typeOfLeaveEnum
        Vacation
        Sick
        Paternal
    End Enum

    Private Sub EmployeeServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelLeaveRequest.Visible = False
        PanelWelcome.Visible = True
        lblWelcome.Visible = True
        lblWelcome.Text = "Welcome to work, " + loginPage.activeEmployeeObj.UserName()
        welcomeMSG.Text = "Welcome " + loginPage.activeEmployeeObj.UserName()
        MonthCalendarTmp.SelectionRange.Start = Date.Today
    End Sub

    Private Sub cmdRequestLeave_Click(sender As Object, e As EventArgs) Handles cmdRequestLeave.Click
        If choosenLeaveType! = vbNull Then
            loginPage.leaveRequestController.addRequest(makeNewRequest(loginPage.activeEmployeeObj.EmployeeID(), MonthCalendarTmp.SelectionRange(), choosenLeaveType))
        Else
            MsgBox("Please fill out all options.", Title:="Request Failed")
        End If

        PanelLeaveRequest.Visible = False
        'Changed the request sent label to a msg box
        MsgBox("Request Sent", Title:="Request")
    End Sub

    Private Function makeNewRequest(v As Integer, selectionRange As SelectionRange, choosenLeaveType As typeOfLeaveEnum)
        newRequest = New LeaveRequest(v, selectionRange, choosenLeaveType)
    End Function

    Private Sub LeaveTypeBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LeaveTypeBox.SelectedIndexChanged
        Dim selectedIndex As Integer = LeaveTypeBox.SelectedIndex
        choosenLeaveType = selectedIndex
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        'TODO: Change this to anything else
        Me.Dispose()

    End Sub

    Private Sub RequestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequestToolStripMenuItem.Click
        PanelWelcome.Visible = False
        PanelLeaveRequest.Visible = True
    End Sub

End Class