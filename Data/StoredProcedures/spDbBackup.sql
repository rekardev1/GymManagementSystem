CREATE PROCEDURE [dbo].[spDbBackup]
	@Destination nvarchar(max)
	 
AS

begin

	BACKUP DATABASE [GMSData]
	TO DISK = @Destination 
	WITH NOFORMAT, NOINIT,
	NAME = N'SQLTestDB-Full Database Backup', SKIP, NOREWIND, NOUNLOAD, STATS = 10;
end