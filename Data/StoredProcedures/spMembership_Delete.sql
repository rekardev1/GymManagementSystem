CREATE PROCEDURE [dbo].[spMembership_Delete]
	@Id int

as
begin 

	delete 
	from Membership
	where Id = @Id;

end