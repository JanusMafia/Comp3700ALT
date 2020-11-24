Imports System.Data.SqlClient

Public Class loginPage
    Public activeEmployeeObj As Account
    Public employeeObj As Account
    Public managerObj As Account
    Public hrObj As Account
    Public dummyObj As Account 'For use in HR and Manager
    Public accountDic As Dictionary(Of Integer, Account)

    Private Sub S_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        accountDic = New Dictionary(Of Integer, Account)
        employeeObj = New Account()
        managerObj = New Account()
        hrObj = New Account()
        dummyObj = New Account()
        accountDic.Add(employeeObj.GetEmployeeID, employeeObj)
        accountDic.Add(managerObj.GetEmployeeID, managerObj)
        accountDic.Add(hrObj.GetEmployeeID, hrObj)
        accountDic.Add(dummyObj.GetEmployeeID, dummyObj)
    End Sub

    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        LoginSystem()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Dispose()
    End Sub

    Sub LoginSystem()
        If txtUsername.Text = employeeObj.GetUserName Then
            If txtPassword.Text = employeeObj.GetPassword Then
                MsgBox("Login Successful")
                Me.Hide()
                EmployeeServer.Show()
            Else MsgBox("Login UnSuccessful")
            End If
        Else
            MsgBox("Login UnSuccessful")
        End If
    End Sub

End Class
