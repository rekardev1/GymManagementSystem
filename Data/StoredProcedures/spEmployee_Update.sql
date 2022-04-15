CREATE PROCEDURE [dbo].[spEmployee_Update]
	@Id int,
	@Name nvarchar(100),
	@Address nvarchar(100),
	@Salary money,
	@JobType nvarchar(50),
	@PhoneNumber1 nvarchar(11),
	@PhoneNumber2 nvarchar(11)
AS
begin
	
	update Employee 

	set [Name] = @Name, 
		[Address] = @Address,
		Salary = @Salary, 
		JobType = @JobType, 
		PhoneNumber1 = @PhoneNumber1,
		PhoneNumber2 = @PhoneNumber2

	where Id = @Id;
			

end
