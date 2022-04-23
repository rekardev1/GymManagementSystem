CREATE PROCEDURE [dbo].[spMembershipTrainers_Delete]
	@Id int
as
begin
	
	delete 
	from MembershipTrainers
	where MembershipId = @Id;

end