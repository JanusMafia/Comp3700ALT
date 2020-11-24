Public Class EmployeeServer
    Dim choosenLeaveType As typeOfLeaveEnum
    Public newRequest As LeaveRequest

    Enum typeOfLeaveEnum
        Vacation
        Sick
        PaternityOrMaternity
    End Enum

    Private Sub EmployeeServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LeaveRequestPanel.Visible = False
        WelcomePanel.Visible = True
        lblWelcome.Visible = True
        lblWelcome.Text = "Welcome to work, " + loginPage.activeEmployeeObj.GetUserName()
        welcomeMSG.Text = "Welcome " + loginPage.activeEmployeeObj.GetUserName()
        MonthCalendarTmp.SelectionRange.Start = Date.Today
    End Sub

    Private Sub cmdRequestLeave_Click(sender As Object, e As EventArgs) Handles cmdRequestLeave.Click
        If choosenLeaveType! = vbNull Then
            makeNewRequest(loginPage.activeEmployeeObj.GetEmployeeID(), MonthCalendarTmp.SelectionRange(), choosenLeaveType)
        End If

        LeaveRequestPanel.Visible = False
        lblRequestSent.Visible = True

        Threading.Thread.Sleep(5000)

        lblRequestSent.Visible = False

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
        WelcomePanel.Visible = False
        LeaveRequestPanel.Visible = True
    End Sub

End Class