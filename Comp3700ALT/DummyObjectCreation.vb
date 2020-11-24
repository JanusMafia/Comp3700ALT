Module DummyObjectCreation
    Public Sub accountCreation()

        'Employee Creation
        loginPage.employeeObj = New Account(1054, "e1", "e1")
        'Manager Creation
        loginPage.managerObj = New Account(30, "m1", "m1", Account.employmentTypeEnum.ManagerEmployee)
        'HR Creation
        loginPage.hrObj = New Account(56734, "h1", "h1", Account.employmentTypeEnum.HREmployee)
        'Dummy Creation
        loginPage.dummyObj = New Account(7235, "d1", "d1", Account.employmentTypeEnum.FullTimeEmployee)

    End Sub
End Module
