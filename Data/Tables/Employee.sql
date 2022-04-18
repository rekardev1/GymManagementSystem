CREATE TABLE [dbo].[Employee]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [Name] NVARCHAR(250) NOT NULL, 
    [Address] NVARCHAR(250) NOT NULL, 
    [Salary] MONEY NOT NULL, 
    [JobType] NVARCHAR(250) NOT NULL, 
    [PhoneNumber1] NVARCHAR(11) NOT NULL, 
    [PhoneNumber2] NVARCHAR(11) NOT NULL
    
)
