CREATE PROCEDURE [dbo].[spMembership_CheckExpirations]
	
AS
begin

	update Membership
	set IsExpired = 1
	where ExpirationDate < GETDATE()

end
