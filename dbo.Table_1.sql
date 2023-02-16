CREATE TABLE [dbo].SalaryTbl
(
	[SalNum] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EmpId] INT NOT NULL, 
    [EmpName] VARCHAR(50) NOT NULL, 
    [EmpBasicSalary] INT NOT NULL, 
    [EmpBonus] INT NOT NULL, 
    [EmpAttendance] INT NOT NULL, 
    [EmpTax] INT NOT NULL, 
    [EmpBalance] INT NOT NULL, 
    [SalPeriod] VARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_SalaryTbl_ToTable] FOREIGN KEY ([EmpId]) REFERENCES [EmployeeTbl]([EmpId])
)
