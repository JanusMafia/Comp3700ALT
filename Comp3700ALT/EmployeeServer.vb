Public Class EmployeeServer
    Private Sub EmployeeServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        welcomeMSG.Text = "Welcome Alex"
        MonthCalendarTmp.SelectionRange.Start = Date.Today
    End Sub


    Private Sub MenueToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LeaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeaveToolStripMenuItem.Click

    End Sub

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendarTmp.DateSelected

    End Sub

    Private Sub cmdRequestLeave_Click(sender As Object, e As EventArgs) Handles cmdRequestLeave.Click
        makeNewRequest(loginPage.employeeObj.getemployeeID(), MonthCalendarTmp.SelectionRange(),)
    End Sub

    Private Function makeNewRequest(v As Integer, selectionRange As SelectionRange)

    End Function

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendarTmp.DateChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class