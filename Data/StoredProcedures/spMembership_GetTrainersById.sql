CREATE PROCEDURE [dbo].[spMembership_GetTrainersById]
	@Id int

as
begin

	select e.Id, e.[Name], e.JobType, e.Salary, e.[Address], e.PhoneNumber1, e.PhoneNumber2
	from MembershipTrainers as m
	inner join Employee as e on e.Id = m.TrainerId


	where m.MembershipId = @Id

end