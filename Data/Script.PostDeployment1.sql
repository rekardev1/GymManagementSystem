if not exists (select 1 from dbo.[User])
begin

    insert into dbo.[User]([Name], [Address], Salary, PhoneNumber1, PhoneNumber2, [Password], RoleLevel)
    values ('Admin', 'NoWhere', 0, '', '', 12345, 1)

end