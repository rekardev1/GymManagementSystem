CREATE PROCEDURE [dbo].[spEmployee_LogIn]
	@Name varchar(250),
	@Password varchar(250)
AS
begin

	select 1 
	from Employee as e
	inner join [User] as u on e.Id = e.Id
	where e.[Name] = @Name and u.Password = @Password;

end
