CREATE PROCEDURE [dbo].[spMembership_Add]
	@Id int out,
	@MemberId int,
	@PlanId int,
	@StartingDate datetime2,
	@ExpirationDate datetime2,
	@UserId int

as 
begin
	insert into Membership(MemberId, PlanId, StartingDate, ExpirationDate, UserId)
	values (@MemberId, @PlanId, @StartingDate, @ExpirationDate, @UserId)

	SET @Id = SCOPE_IDENTITY()
end
