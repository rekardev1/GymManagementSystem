CREATE PROCEDURE [dbo].[spMembership_Add]
	@Id int out,
	@MemberId int,
	@PlanId int,
	@StartingDate datetime2,
	@ExpirationDate datetime2,
	@UserId int,
	@AutoRenew bit


as 
begin
	insert into Membership(MemberId, PlanId, StartingDate, ExpirationDate, UserId, AutoRenew)
	values (@MemberId, @PlanId, @StartingDate, @ExpirationDate, @UserId, @AutoRenew)

	SET @Id = SCOPE_IDENTITY()
end
