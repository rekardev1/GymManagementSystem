CREATE PROCEDURE [dbo].[spMembershipType_Delete]
	@Id int

as
begin
	
	delete 
	from MembershipType
	where Id = @Id;

end