CREATE PROCEDURE [dbo].[spEmployee_LogIn]
	@Username varchar(250),
	@Password varchar(250)
AS
begin

	select 1 
	from dbo.Employee 
	where Username = @Username and [Password] = @Password;

end
