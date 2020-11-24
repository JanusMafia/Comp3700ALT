Module DummyObjectCreation
    Public Sub AccountCreation()

        'Employee Creation
        LoginPage.employeeObj = New Account(1054, "e1", "e1", Account.EmploymentTypeEnum.FullTimeEmployee)
        'Manager Creation
        LoginPage.managerObj = New Account(30, "m1", "m1", Account.EmploymentTypeEnum.ManagerEmployee)
        'HR Creation
        LoginPage.hrObj = New Account(56734, "h1", "h1", Account.EmploymentTypeEnum.HREmployee)

    End Sub
End Module
