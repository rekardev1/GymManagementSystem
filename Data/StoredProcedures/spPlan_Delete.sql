CREATE PROCEDURE [dbo].[spPlan_Delete]
	@Id int

as
begin
	
	delete 
	from [Plan]
	where Id = @Id;

end