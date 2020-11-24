Public Class EmployeeServer
    Dim choosenLeaveType As TypeOfLeaveEnum
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
        If choosenLeaveType! = vbNull Then
            LoginPage.leaveRequestController.AddRequest(MakeNewRequest(LoginPage.activeEmployeeObj.EmployeeID(), MonthCalendarTmp.SelectionRange(), choosenLeaveType))
        Else
            MsgBox("Please fill out all options.", Title:="Request Failed")
        End If

        PanelLeaveRequest.Visible = False
        'Changed the request sent label to a msg box
        MsgBox("Request Sent", Title:="Request")
    End Sub

    ''' <summary>
    '''  Makes a new request.
    ''' </summary>
    ''' <param name="requestID"></param>
    ''' <param name="selectionRange"></param>
    ''' <param name="choosenLeaveType"></param>
    ''' <returns></returns>
    Private Function MakeNewRequest(requestID As Integer, selectionRange As SelectionRange, choosenLeaveType As TypeOfLeaveEnum)
        newRequest = New LeaveRequest(requestID, selectionRange, choosenLeaveType)
    End Function

    Private Sub LeaveTypeBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LeaveTypeBox.SelectedIndexChanged
        Dim selectedIndex As Integer = LeaveTypeBox.SelectedIndex
        choosenLeaveType = selectedIndex
    End Sub

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        'TODO: Change this to anything else
        Me.Dispose()

    End Sub

    Private Sub RequestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequestToolStripMenuItem.Click
        PanelWelcome.Visible = False
        PanelLeaveRequest.Visible = True
    End Sub

End Class