Public Class Account
    Private _EmployeeID As Integer

    Public Function GetEmployeeID() As Integer
        Return _EmployeeID
    End Function

    Public Sub SetEmployeeID(AutoPropertyValue As Integer)
        _EmployeeID = AutoPropertyValue
    End Sub

    Private _UserName As String

    Public Function GetUserName() As String
        Return _UserName
    End Function

    Public Sub SetUserName(AutoPropertyValue As String)
        _UserName = AutoPropertyValue
    End Sub

    Private _Password As String

    Public Function GetPassword() As String
        Return _Password
    End Function

    Public Sub SetPassword(AutoPropertyValue As String)
        _Password = AutoPropertyValue
    End Sub

    Private _EmploymentType As employmentTypeEnum

    Public Function GetEmploymentType() As employmentTypeEnum
        Return _EmploymentType
    End Function

    Public Sub SetEmploymentType(AutoPropertyValue As employmentTypeEnum)
        _EmploymentType = AutoPropertyValue
    End Sub

    Private _OnLeave As Boolean

    Public Function GetOnLeave() As Boolean
        Return _OnLeave
    End Function

    Public Sub SetOnLeave(AutoPropertyValue As Boolean)
        _OnLeave = AutoPropertyValue
    End Sub

    Private _SickLeaveHours As Integer

    Public Function GetSickLeaveHours() As Integer
        Return _SickLeaveHours
    End Function

    Public Sub SetSickLeaveHours(AutoPropertyValue As Integer)
        _SickLeaveHours = AutoPropertyValue
    End Sub

    Private _VacationLeaveHours As Integer

    Public Function GetVacationLeaveHours() As Integer
        Return _VacationLeaveHours
    End Function

    Public Sub SetVacationLeaveHours(AutoPropertyValue As Integer)
        _VacationLeaveHours = AutoPropertyValue
    End Sub

    Private _PmLeaveHours As Integer

    Public Function GetPmLeaveHours() As Integer
        Return _PmLeaveHours
    End Function

    Public Sub SetPmLeaveHours(AutoPropertyValue As Integer)
        _PmLeaveHours = AutoPropertyValue
    End Sub

    Enum employmentTypeEnum
        FullTimeEmployee
        PartTimeEmployee
        HREmployee
        ManagerEmployee
    End Enum

    Public Sub New()
        SetEmployeeID(0)
        _UserName = ""
        SetPassword("")
        SetEmploymentType(employmentTypeEnum.FullTimeEmployee)
        SetOnLeave(False)
        SetSickLeaveHours(40)
        SetVacationLeaveHours(40)
        SetPmLeaveHours(40)
    End Sub

End Class


