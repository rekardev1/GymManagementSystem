CREATE PROCEDURE [dbo].[spEmployee_GetTrainers]
	
AS
begin

	select [Id], [Name], [Address], [Salary], [JobType], [PhoneNumber1], [PhoneNumber2]
	from Employee
	where JobType = 'trainer'
end