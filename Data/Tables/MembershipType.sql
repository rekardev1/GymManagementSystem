CREATE TABLE [dbo].[MembershipType]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [Name] NVARCHAR(100) NOT NULL, 
    [Start] TIME NOT NULL, 
    [End] TIME NOT NULL
)
