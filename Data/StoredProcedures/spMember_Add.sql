CREATE PROCEDURE [dbo].[spMember_Add]
	@FirstName nvarchar(250),
	@LastName nvarchar(250),
	@Gender nvarchar(250),
	@Address nvarchar(250),
	@BirthDate datetime2,
	@PhoneNumber1 nvarchar(11),
	@PhoneNumber2 nvarchar(11)
	
AS
begin
	
	insert into dbo.[Member]([FirstName], LastName, Gender, [Address], Birthdate, PhoneNumber1, PhoneNumber2)
	values (@FirstName, @LastName, @Gender, @Address, @Birthdate, @PhoneNumber1, @PhoneNumber2)

end