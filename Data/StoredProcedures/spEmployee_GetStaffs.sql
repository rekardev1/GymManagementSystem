CREATE PROCEDURE [dbo].[spEmployee_GetStaffs]
as
begin

	select [Id], [Name], [Address], [Salary], [JobType], [PhoneNumber1], [PhoneNumber2]
	from Employee
	where JobType = 'staff'

end
