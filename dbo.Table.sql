CREATE TABLE [dbo].EmployeeInfo
(
	[EmpId] INT NOT NULL IDENTITY(1000, 1) , 
    [EmpName] VARCHAR(50) NOT NULL, 
    [EmpGender] VARCHAR(50) NOT NULL, 
    [EmpDOB] DATE NOT NULL, 
    [EmpAddress] VARCHAR(100) NOT NULL, 
    [EmpPosition] VARCHAR(50) NOT NULL, 
    [JoinDate] DATE NOT NULL, 
    [EmpQualification] VARCHAR(50) NOT NULL, 
    [EmpBasicSalary] INT NOT NULL, 
    [EmpPhone] VARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([EmpId])
)
