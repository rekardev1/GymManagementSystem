CREATE TABLE [dbo].[Plan]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [Name] NVARCHAR(100) NOT NULL, 
    [Start] DATETIME2 NOT NULL, 
    [End] DATETIME2 NOT NULL,
    [Fee] money not null
)
