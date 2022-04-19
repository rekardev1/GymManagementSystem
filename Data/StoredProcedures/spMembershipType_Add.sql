CREATE PROCEDURE [dbo].[spMembershipType_Add]
	@Name nvarchar(250),
	@Start DATETIME2,
	@End DATETIME2,
	@Fee money
AS
begin
	
	insert into dbo.[MembershipType]([Name], [Start], [End], Fee)
	values (@Name, @Start, @End, @Fee)

end