CREATE PROCEDURE [dbo].[spMember_Delete]
	@Id int
as
begin
	
	delete 
	from Member
	where Id = @Id;

end