CREATE PROCEDURE [dbo].[spMembership_Update]
	@Id int,
	@PlanId int,
	@StartingDate datetime2,
	@ExpirationDate datetime2,
	@AutoRenew bit
AS
begin

	update Membership
	set PlanId = @PlanId,
		StartingDate = @StartingDate,
		ExpirationDate = @ExpirationDate,
		AutoRenew = @AutoRenew
	where Id = @Id;


	--update Membership
	--set IsExpired = 1
	--where Id = @Id and ExpirationDate < GETDATE() and AutoRenew = 0


	--update Membership
	--set IsExpired = 0
	--where Id = @Id and ExpirationDate > GETDATE()

	--update Membership
	--set IsExpired = 1
	--where ExpirationDate < GETDATE() and AutoRenew = 0;

	--update Membership
	--set ExpirationDate = DATEADD(DD, 30, ExpirationDate), LastRenewDate = GETDATE()
	--where ExpirationDate < GETDATE() and IsExpired = 1 and AutoRenew = 1;

	EXEC dbo.spMembership_CheckExpirations

	
end
