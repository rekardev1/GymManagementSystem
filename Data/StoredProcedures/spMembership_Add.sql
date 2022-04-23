CREATE PROCEDURE [dbo].[spMembership_Add]
	@Id int out,
	@MemberId int,
	@MembershipTypeId int,
	@StartingDate datetime2,
	@ExpirationDate datetime2,
	@UserId int

as 
begin
	insert into Membership(MemberId, MembershipTypeId, StartingDate, ExpirationDate, UserId)
	values (@MemberId, @MembershipTypeId, @StartingDate, @ExpirationDate, @UserId)

	SET @Id = SCOPE_IDENTITY()
end
