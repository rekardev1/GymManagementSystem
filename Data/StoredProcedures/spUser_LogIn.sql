CREATE PROCEDURE [dbo].[spUser_LogIn]
	@Name varchar(250),
	@Password varchar(250)
AS
begin

	select 1 
	from [User]
	where [Name] = @Name and [Password] = @Password;

end