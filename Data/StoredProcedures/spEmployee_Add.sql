CREATE PROCEDURE [dbo].[spEmployee_Add]
	@Name nvarchar(100),
	@Address nvarchar(100),
	@Salary money,
	@JobType nvarchar(50),
	@PhoneNumber1 nvarchar(11),
	@PhoneNumber2 nvarchar(11)
AS
begin
	
	insert into dbo.Employee ([Name], [Address], Salary, JobType, PhoneNumber1, PhoneNumber2)
	values (@Name, @Address, @Salary, @JobType, @PhoneNumber1, @PhoneNumber2)

end
