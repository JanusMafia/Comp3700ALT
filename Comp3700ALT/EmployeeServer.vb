Public Class EmployeeServer
    Dim choosenLeaveType As typeOfLeaveEnum
    Public newRequest As LeaveRequest

    Enum typeOfLeaveEnum
        Vacation
        Sick
        PaternityOrMaternity
    End Enum

    Private Sub EmployeeServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        welcomeMSG.Text = "Welcome Alex"
        MonthCalendarTmp.SelectionRange.Start = Date.Today
    End Sub

    Private Sub cmdRequestLeave_Click(sender As Object, e As EventArgs) Handles cmdRequestLeave.Click
        If choosenLeaveType! = vbNull Then
            makeNewRequest(loginPage.activeEmployeeObj.GetEmployeeID(), MonthCalendarTmp.SelectionRange(), choosenLeaveType)
        End If
    End Sub

    Private Function makeNewRequest(v As Integer, selectionRange As SelectionRange, choosenLeaveType As typeOfLeaveEnum)
        newRequest = New LeaveRequest(v, selectionRange, choosenLeaveType)

    End Function

    Private Sub LeaveTypeBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LeaveTypeBox.SelectedIndexChanged
        Dim selectedIndex As Integer = LeaveTypeBox.SelectedIndex
        choosenLeaveType = selectedIndex
    End Sub
End Class