CREATE PROCEDURE [dbo].[spEmployee_Delete]
	@Id int

as
begin
	
	delete 
	from Employee
	where Id = @Id;

end
