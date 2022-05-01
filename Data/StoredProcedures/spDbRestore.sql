CREATE PROCEDURE [dbo].[spDbRestore]
	@File nvarchar(max)
AS
begin
	

	RESTORE DATABASE GMSData FROM DISK = @File;

end