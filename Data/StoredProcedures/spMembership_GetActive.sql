CREATE PROCEDURE [dbo].[spMembership_GetActive]
	
AS
begin

select 
		Membership.Id,
		Member.Id as 'MemberId',
		Member.FirstName + ' '+ Member.LastName as 'MemberName', 
		[Plan].Id as 'PlanId',
		[Plan].[Name] as 'PlanName',
		Membership.StartingDate, 
		Membership.ExpirationDate,
		Membership.IsExpired,
		Membership.UserId,
		[User].[Name] as 'UserName',
		Membership.AutoRenew,
		Membership.LastRenewDate

		from Membership
		inner join Member on Member.Id = Membership.MemberId
		inner join [Plan] on [Plan].Id = Membership.PlanId
		inner join [User] on [User].Id = Membership.UserId

		where Membership.IsExpired = 0

end