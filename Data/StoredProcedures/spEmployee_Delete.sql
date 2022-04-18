CREATE PROCEDURE [dbo].[spEmployee_Delete]
	@Id int

as
begin
	
	if 1 = (Select 1 from [User] where Id = @Id)
	begin
		delete 
		from [User]
		where Id = @Id;
	end

	delete 
	from Employee
	where Id = @Id;

end
