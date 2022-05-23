CREATE PROCEDURE [dbo].[spUser_Update]
	@Id int,
	@Name nvarchar(250),
	@Address nvarchar(250),
	@PhoneNumber1 nvarchar(11),
	@PhoneNumber2 nvarchar(11),
	@Role nvarchar(250)

AS
begin
	
	update [User] 

	set [Name] = @Name, 
		[Address] = @Address,
		PhoneNumber1 = @PhoneNumber1,
		PhoneNumber2 = @PhoneNumber2,
		[Role] = @Role

	where Id = @Id;
	

end
