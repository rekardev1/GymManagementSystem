CREATE PROCEDURE [dbo].[spMembershipTrainers_Add]
	@MembershipId int,  
	@TrainerId int

as

begin
	
	insert into MembershipTrainers(MembershipId, TrainerId)
	values (@MembershipId, @TrainerId)

end