CREATE PROCEDURE [dbo].[spMember_Update]
	@Id int,
	@FirstName nvarchar(250),
	@LastName nvarchar(250),
	@BirthDate datetime2,
	@Gender nvarchar(250),
	@Address nvarchar(250),
	@PhoneNumber1 nvarchar(11),
	@PhoneNumber2 nvarchar(11)
AS
begin
	
	update Member 

	set FirstName = @FirstName, 
		LastName = @LastName,
		Birthdate = @Birthdate,
		Gender = @Gender,
		[Address] = @Address,
		PhoneNumber1 = @PhoneNumber1,
		PhoneNumber2 = @PhoneNumber2

	where Id = @Id;
	

end