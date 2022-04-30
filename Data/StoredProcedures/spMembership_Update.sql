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
	where Id = @Id;


	update Membership
	set IsExpired = 1
	where Id = @Id and ExpirationDate < GETDATE()


	update Membership
	set IsExpired = 0
	where Id = @Id and ExpirationDate > GETDATE()

	
end
