CREATE PROCEDURE [dbo].[spUser_GetByName]
	@Name nvarchar(250)
AS
begin

	select *
	from [User]
	where Name = @Name

end
