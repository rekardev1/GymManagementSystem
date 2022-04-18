CREATE PROCEDURE [dbo].[spUser_Update]
	@Id int,
	@Name nvarchar(250),
	@Address nvarchar(250),
	@Salary money,
	@PhoneNumber1 nvarchar(11),
	@PhoneNumber2 nvarchar(11),
	@RoleLevel int

AS
begin
	
	update [User] 

	set [Name] = @Name, 
		[Address] = @Address,
		Salary = @Salary, 
		PhoneNumber1 = @PhoneNumber1,
		PhoneNumber2 = @PhoneNumber2,
		RoleLevel = @RoleLevel

	where Id = @Id;
	

end
