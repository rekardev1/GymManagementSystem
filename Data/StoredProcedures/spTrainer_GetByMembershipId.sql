CREATE PROCEDURE [dbo].[spTrainer_GetByMembershipId]
	@Id int
AS
begin

	select e.[Id], [Name], [Address], [Salary], [JobType], [PhoneNumber1], [PhoneNumber2] 
	from Employee as e
	inner join MembershipTrainers on TrainerId = e.Id
	inner join Membership on Membership.Id = MembershipTrainers.MembershipId
	where Membership.Id = @Id

end
