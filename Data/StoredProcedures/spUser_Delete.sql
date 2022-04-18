CREATE PROCEDURE [dbo].[spUser_Delete]
	@Id int
as
begin
	
	delete 
	from [User]
	where Id = @Id;

end