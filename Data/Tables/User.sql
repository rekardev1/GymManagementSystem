CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL DEFAULT 123456, 
    CONSTRAINT [FK_User_Employee] FOREIGN KEY ([Id]) REFERENCES [Employee]([Id])
)
