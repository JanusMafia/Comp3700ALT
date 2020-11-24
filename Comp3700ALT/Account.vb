Public Class Account
    Private _employeeID1 As Integer
    Private _userName1 As String
    Private _password1 As String
    Private _employmentType1 As EmploymentTypeEnum
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

    Public Property EmploymentType As EmploymentTypeEnum
        Get
            Return _employmentType1
        End Get
        Set(value As EmploymentTypeEnum)
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

    Enum EmploymentTypeEnum
        FullTimeEmployee
        PartTimeEmployee
        HREmployee
        ManagerEmployee
    End Enum

    Public Sub New(Optional _employeeId As Integer = 0, Optional _userName As String = "", Optional _password As String = "",
                   Optional _employmentType As EmploymentTypeEnum = EmploymentTypeEnum.FullTimeEmployee, Optional _onLeave As Boolean = False,
                   Optional _sickLeaveHours As Integer = 40, Optional _vacationLeaveHours As Integer = 40, Optional _paternalLeaveHours As Integer = 40)
        EmployeeID = _employeeId
        UserName = _userName
        Password = _password
        EmploymentType = _employmentType
        OnLeave = _onLeave
        SickLeaveHours = _sickLeaveHours
        VacationLeaveHours = _vacationLeaveHours
        PaternalLeaveHours = _paternalLeaveHours
        _notifications = New Dictionary(Of Integer, Notification)()
    End Sub

    ''' <summary>
    '''  Makes a new request.
    ''' </summary>
    ''' <param name="employeeID"> The ID of the employee that is  making the leave request.</param>
    ''' <param name="selectionRange"> The selected range of dates for the leave request.</param>
    ''' <param name="choosenLeaveType"> The leave type for the leave requested.</param>
    ''' <returns></returns>
    Public Function MakeNewRequest(employeeID As Integer, selectionRange As SelectionRange, choosenLeaveType As LeaveRequest.TypeOfLeaveEnum)
        Dim dt1 As DateTime = Convert.ToDateTime(selectionRange.Start)
        Dim dt2 As DateTime = Convert.ToDateTime(selectionRange.End)
        ' Counts total days between selected dates
        'TODO: Test this. no clue if itll work lol
        Dim numberOfSelectedDays As Integer = dt2.Subtract(dt1).Days + 1
        Dim hours As Integer = numberOfSelectedDays * 8
        Select Case choosenLeaveType
            Case LeaveRequest.TypeOfLeaveEnum.Sick
                If (SickLeaveHours < hours) Then
                    MsgBox("You dont have enough hours to make this request.")
                    Return Nothing
                End If
                SickLeaveHours -= hours
            Case LeaveRequest.TypeOfLeaveEnum.Vacation
                If (VacationLeaveHours < hours) Then
                    MsgBox("You dont have enough hours to make this request.")
                    Return Nothing
                Else
                    VacationLeaveHours -= hours
                End If
            Case LeaveRequest.TypeOfLeaveEnum.Paternal
                If (PaternalLeaveHours < hours) Then
                    MsgBox("You dont have enough hours to make this request.")
                    Return Nothing
                Else
                    PaternalLeaveHours -= hours
                End If
        End Select
        Dim request As LeaveRequest
        request = New LeaveRequest(employeeID, choosenLeaveType, hours)
        Dim notification As New Notification(Me.EmployeeID, request.RequestID)
        LoginPage.hrObj.Notifications.Add(request.RequestID, notification)
        LoginPage.managerObj.Notifications.Add(request.RequestID, notification)
        _notifications.Add(request.RequestID, notification)
        Return (request)
    End Function

End Class


