CREATE PROCEDURE [dbo].[spMembership_Update]
	@Id int,
	@MembershipTypeId int,
	@StartingDate datetime2,
	@ExpirationDate datetime2
AS
begin

	update Membership
	set MembershipTypeId = @MembershipTypeId,
		StartingDate = @StartingDate,
		ExpirationDate = @ExpirationDate

	where Id = @Id

end
