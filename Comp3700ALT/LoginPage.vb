Imports System.Data.SqlClient

Public Class loginPage
    Public employeeObj As Account
    Public accountDic As Dictionary(Of Integer, Account)

    Private Sub S_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        accountDic = New Dictionary(Of Integer, Account)
        employeeObj = New Account()
        accountDic.Add(employeeObj.getemployeeID, employeeObj)
    End Sub

    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        LoginSystem()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Dispose()
    End Sub

    'private sub txtpassword_keydown(sender as object, e as keyeventargs) handles txtpassword.keydown
    '    if e.keycode = 13 then
    '        loginsystem()
    '    end if
    'end sub

    Sub LoginSystem()
        If txtUsername.Text = employeeObj.getuserName Then
            If txtPassword.Text = employeeObj.getpassword Then
                MsgBox("Login Successful")
                Me.Hide()
                EmployeeServer.Show()
            Else MsgBox("Login UnSuccessful")
            End If
        Else
            MsgBox("Login UnSuccessful")
        End If
    End Sub

    'Sub LoginSystem()
    '    If txtUsername.Text = "" Then
    '        MsgBox("Username is Required!", MsgBoxStyle.Critical)
    '        txtUsername.Focus()
    '    ElseIf txtPassword.Text = "" Then
    '        MsgBox("Password is Required!", MsgBoxStyle.Critical)
    '        txtPassword.Focus()
    '    Else
    '        Try
    '            ConnecDatabase()
    '            Sql = "Select * From tbl_accounts Where Username = @Username And Password = @Password;"
    '            cmd = New SqlCommand
    '            With cmd
    '                .Connection = Conn
    '                .CommandText = Sql
    '                .Parameters.Clear()
    '                .Parameters.AddWithValue("@Username", txtUsername.Text)
    '                .Parameters.AddWithValue("@Password", txtPassword.Text)
    '                .ExecuteNonQuery()
    '            End With
    '            da = New SqlDataAdapter
    '            dt = New DataTable
    '            da.SelectCommand = cmd
    '            da.Fill(dt)
    '        Catch ex As SqlException
    '            MsgBox(ex.Message)
    '        Finally
    '            Conn.Close()
    '            da.Dispose()
    '            If dt.Rows.Count > 0 Then
    '                Dim Username, Password As String
    '                Username = dt.Rows(0).Item("Username")
    '                Password = dt.Rows(0).Item("Password")
    '                If txtUsername.Text = Username And txtPassword.Text = Password Then
    '                    MsgBox("Welcome " & txtUsername.Text)
    '                    txtUsername.Text = ""
    '                    txtPassword.Text = ""
    '                ElseIf txtUsername.Text <> Username Then
    '                    MsgBox("Username Doesn't Match!", MsgBoxStyle.Exclamation)
    '                    txtUsername.Text = ""
    '                    txtUsername.Focus()
    '                ElseIf txtPassword.Text <> Password Then
    '                    MsgBox("Password Doesn't Match!", MsgBoxStyle.Exclamation)
    '                    txtPassword.Text = ""
    '                    txtPassword.Focus()
    '                Else
    '                    MsgBox("Username or Password is Invalid!", MsgBoxStyle.Exclamation)
    '                    txtPassword.Text = ""
    '                    txtPassword.Focus()
    '                    txtUsername.Text = ""
    '                    txtPassword.Text = ""
    '                End If
    '            End If
    '        End Try
    '    End If
    'End Sub
End Class
