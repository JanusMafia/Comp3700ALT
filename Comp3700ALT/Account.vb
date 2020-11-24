Public Class Account
    Private Property employeeID As Integer
    Private Property userName As String
    Private Property password As String
    Private Property employmentType As employmentTypeEnum
    Private Property onLeave As Boolean
    Private Property sickLeaveHours As Integer
    Private Property vacationLeaveHours As Integer
    Private Property pmLeaveHours As Integer

    Enum employmentTypeEnum
        FullTimeEmployee
        PartTimeEmployee
        HREmployee
        ManagerEmployee
    End Enum

    Public Sub New()
        employeeID = 0
        userName = ""
        password = ""
        employmentType = employmentTypeEnum.FullTimeEmployee
        onLeave = False
        sickLeaveHours = 40
        vacationLeaveHours = 40
        pmLeaveHours = 40
    End Sub

    Public Function getemployeeID() As Integer
        Return employeeID
    End Function

    Public Function getuserName() As String
        Return userName
    End Function

    Public Function getpassword() As String
        Return password
    End Function

    Public Function getemploymentType() As Integer
        Return employmentType
    End Function

    Public Function getonLeave() As Boolean
        Return onLeave
    End Function

    Public Function getsickLeaveHours() As Integer
        Return sickLeaveHours
    End Function

    Public Function getvacationLeaveHours() As Integer
        Return vacationLeaveHours
    End Function

    Public Function getpmLeaveHours() As Integer
        Return pmLeaveHours
    End Function

End Class


