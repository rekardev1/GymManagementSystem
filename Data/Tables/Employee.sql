CREATE TABLE [dbo].[Employee]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [Name] NVARCHAR(100) NOT NULL, 
    [Password] NVARCHAR(100) NOT NULL, 
    [Address] NVARCHAR(100) NOT NULL, 
    [Salary] MONEY NOT NULL, 
    [JobType] NVARCHAR(50) NOT NULL, 
    [PhoneNumber1] NVARCHAR(11) NOT NULL, 
    [PhoneNumber2] NVARCHAR(11) NOT NULL
    
)
