CREATE PROCEDURE [dbo].[spMembership_CheckExpirations]
	
AS
begin
	
	declare @today date = GETDATE();

	update Membership
	set IsExpired = 1
	where ExpirationDate < @today and AutoRenew = 0;

	update Membership
	set ExpirationDate = DATEADD(DD, 30, ExpirationDate), LastRenewDate = @today
	where ExpirationDate < @today and AutoRenew = 1;

end
