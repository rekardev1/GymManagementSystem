CREATE PROCEDURE [dbo].[spEmployee_Add]
	@Name nvarchar(250),
	@Address nvarchar(250),
	@Salary money,
	@JobType nvarchar(250),
	@PhoneNumber1 nvarchar(11),
	@PhoneNumber2 nvarchar(11)
AS
begin
	
	insert into dbo.Employee ([Name], [Address], Salary, JobType, PhoneNumber1, PhoneNumber2)
	values (@Name, @Address, @Salary, @JobType, @PhoneNumber1, @PhoneNumber2)

end
