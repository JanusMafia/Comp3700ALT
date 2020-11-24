Public Class ManagerServer

    Private Sub ManagerServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Welcome " + LoginPage.activeEmployeeObj.UserName()
        welcomePanel.Visible = True
    End Sub


    Private Sub LeaveRequestsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeaveRequestsToolStripMenuItem.Click
        welcomePanel.Visible = False

    End Sub


End Class