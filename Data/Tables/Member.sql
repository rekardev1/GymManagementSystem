CREATE TABLE [dbo].[Member]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL,
	[Birthdate] Datetime2 not null, 
    [Gender] NVARCHAR(10) NOT NULL, 
    [Address] NVARCHAR(50) NOT NULL, 
    [PhoneNumber1] NVARCHAR(11) NOT NULL, 
    [PhoneNumber2] NVARCHAR(11) NOT NULL
	
)
