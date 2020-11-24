Module DummyObjectCreation
    Public Sub accountCreation()

        'Employee Creation
        loginPage.employeeObj = New Account()
        loginPage.employeeObj.SetEmployeeID(1054)
        loginPage.employeeObj.SetUserName("e1")
        loginPage.employeeObj.SetPassword("e1")
        loginPage.employeeObj.SetEmploymentType(Account.employmentTypeEnum.FullTimeEmployee)
        'Manager Creation
        loginPage.managerObj = New Account()
        loginPage.managerObj.SetEmployeeID(30)
        loginPage.managerObj.SetUserName("m1")
        loginPage.managerObj.SetPassword("m1")
        loginPage.managerObj.SetEmploymentType(Account.employmentTypeEnum.ManagerEmployee)
        'HR Creation
        loginPage.hrObj = New Account()
        loginPage.hrObj.SetEmployeeID(56734)
        loginPage.hrObj.SetUserName("h1")
        loginPage.hrObj.SetPassword("h1")
        loginPage.hrObj.SetEmploymentType(Account.employmentTypeEnum.HREmployee)
        'Dummy Creation
        loginPage.dummyObj = New Account()
        loginPage.dummyObj.SetEmployeeID(7235)
        loginPage.dummyObj.SetUserName("d1")
        loginPage.dummyObj.SetPassword("d1")
        loginPage.dummyObj.SetEmploymentType(Account.employmentTypeEnum.FullTimeEmployee)

    End Sub
End Module
