Public Class Account
    Private _employeeID1 As Integer
    Private _userName1 As String
    Private _password1 As String
    Private _employmentType1 As employmentTypeEnum
    Private _onLeave1 As Boolean
    Private _sickLeaveHours1 As Integer
    Private _vacationLeaveHours1 As Integer
    Private _paternalLeaveHours1 As Integer
    Private _notifications As Dictionary(Of Integer, Notification)

    Public Property EmployeeID As Integer
        Get
            Return _employeeID1
        End Get
        Set(value As Integer)
            _employeeID1 = value
        End Set
    End Property

    Public Property UserName As String
        Get
            Return _userName1
        End Get
        Set(value As String)
            _userName1 = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _password1
        End Get
        Set(value As String)
            _password1 = value
        End Set
    End Property

    Public Property EmploymentType As employmentTypeEnum
        Get
            Return _employmentType1
        End Get
        Set(value As employmentTypeEnum)
            _employmentType1 = value
        End Set
    End Property

    Public Property OnLeave As Boolean
        Get
            Return _onLeave1
        End Get
        Set(value As Boolean)
            _onLeave1 = value
        End Set
    End Property

    Public Property SickLeaveHours As Integer
        Get
            Return _sickLeaveHours1
        End Get
        Set(value As Integer)
            _sickLeaveHours1 = value
        End Set
    End Property

    Public Property VacationLeaveHours As Integer
        Get
            Return _vacationLeaveHours1
        End Get
        Set(value As Integer)
            _vacationLeaveHours1 = value
        End Set
    End Property

    Public Property PaternalLeaveHours As Integer
        Get
            Return _paternalLeaveHours1
        End Get
        Set(value As Integer)
            _paternalLeaveHours1 = value
        End Set
    End Property

    Public Property Notifications As Dictionary(Of Integer, Notification)
        Get
            Return _notifications
        End Get
        Set(value As Dictionary(Of Integer, Notification))
            _notifications = value
        End Set
    End Property

    Enum employmentTypeEnum
        FullTimeEmployee
        PartTimeEmployee
        HREmployee
        ManagerEmployee
    End Enum

    Public Sub New(Optional _employeeId As Integer = 0, Optional _userName As String = "", Optional _password As String = "",
                   Optional _employmentType As employmentTypeEnum = employmentTypeEnum.FullTimeEmployee, Optional _onLeave As Boolean = False,
                   Optional _sickLeaveHours As Integer = 40, Optional _vacationLeaveHours As Integer = 40, Optional _paternalLeaveHours As Integer = 40)
        EmployeeID = _employeeId
        UserName = _userName
        Password = _password
        EmploymentType = _employmentType
        OnLeave = _onLeave
        SickLeaveHours = _sickLeaveHours
        VacationLeaveHours = _vacationLeaveHours
        PaternalLeaveHours = _paternalLeaveHours
    End Sub

End Class


