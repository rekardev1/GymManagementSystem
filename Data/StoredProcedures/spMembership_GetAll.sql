CREATE PROCEDURE [dbo].[spMembership_GetAll]
AS
begin

	select 
		Membership.Id,
		Member.Id as 'MemberId',
		Member.FirstName + ' '+ Member.LastName as 'MemberName', 
		MembershipType.Id as 'MembershipTypeId',
		MembershipType.[Name] as 'MembershipTypeName',
		Membership.StartingDate, 
		Membership.ExpirationDate,
		Membership.UserId,
		[User].[Name] as 'UserName'

		from Membership
		inner join Member on Member.Id = Membership.MemberId
		inner join MembershipType on MembershipType.Id = Membership.MembershipTypeId
		inner join [User] on [User].Id = Membership.UserId

end