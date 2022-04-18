CREATE PROCEDURE [dbo].[spUser_UpdatePassword]
	@Id int,
	@Password nvarchar(250)
AS
begin

	update [User]
	set [Password] = @Password
	where Id = @Id

end 