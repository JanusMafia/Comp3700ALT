Imports System.Data.SqlClient

Public Class loginPage
    Public activeEmployeeObj As Account
    Public employeeObj As Account
    Public managerObj As Account
    Public hrObj As Account
    Public dummyObj As Account 'For use in HR and Manager
    Public accountDic As Dictionary(Of Integer, Account)
    Public leaveRequestController As LeaveRequestController

    Private Sub S_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        accountDic = New Dictionary(Of Integer, Account)
        DummyObjectCreation.accountCreation()
        leaveRequestController = New LeaveRequestController
        accountDic.Add(employeeObj.EmployeeID, employeeObj)
        accountDic.Add(managerObj.EmployeeID, managerObj)
        accountDic.Add(hrObj.EmployeeID, hrObj)
        accountDic.Add(dummyObj.EmployeeID, dummyObj)
    End Sub

    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        LoginSystem()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Dispose()
    End Sub

    Sub LoginSystem()
        If txtUsername.Text = employeeObj.Password And txtPassword.Text = employeeObj.Password Then
            MsgBox("Login Successful", Title:="Login")
            Me.Hide()
            activeEmployeeObj = employeeObj
            EmployeeServer.Show()
        ElseIf txtUsername.Text = hrObj.UserName And txtPassword.Text = hrObj.Password Then
            MsgBox("Login Successful", Title:="Login")
            Me.Hide()
            activeEmployeeObj = managerObj
            HRServer.Show()
        ElseIf txtUsername.Text = managerObj.UserName And txtPassword.Text = managerObj.Password Then
            MsgBox("Login Successful", Title:="Login")
            Me.Hide()
            activeEmployeeObj = hrObj
            ManagerServer.Show()
        Else MsgBox("Login Unsuccessful" + vbNewLine + "Username or password is incorrect, please try again.", Title:="Login")
        End If
    End Sub

End Class
