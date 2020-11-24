Imports System.Data.SqlClient

Public Class LoginPage
    Public activeEmployeeObj As Account
    Public employeeObj As Account
    Public managerObj As Account
    Public hrObj As Account
    Public dummyObj As Account 'For use in HR and Manager
    Public accountDic As Dictionary(Of Integer, Account)
    Public leaveRequestController As LeaveRequestController

    'Just making a broad list here. This stuff doesnt go here..
    'TODO: Not sure how to implement the AccountLeaveController. Its supposed to not let the employee request more time than the employee has worked.
    'TODO: Possibly Comment the code so its not hell to read. BTW tommy, if you type 3 ' above a sub or function or whatever it will automake a 
    ' summary. It makes it so that if you add a description for the paramaters you can see the descriptions when using that function. Very useful.
    'TODO: Implement report!!! Really need to do this tomorrow. It is one of our use cases.

    Private Sub LoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        accountDic = New Dictionary(Of Integer, Account)
        DummyObjectCreation.AccountCreation()
        leaveRequestController = New LeaveRequestController
        accountDic.Add(employeeObj.EmployeeID, employeeObj)
        accountDic.Add(managerObj.EmployeeID, managerObj)
        accountDic.Add(hrObj.EmployeeID, hrObj)
        accountDic.Add(dummyObj.EmployeeID, dummyObj)
    End Sub

    Private Sub CmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        LoginSystem()
    End Sub

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
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
