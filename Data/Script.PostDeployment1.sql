if not exists (select 1 from dbo.[User])
begin

    insert into dbo.[User]([Name], [Address], PhoneNumber1, PhoneNumber2, [Password], [Role])
    values ('Admin', 'NoWhere', '', '', 12345, 'Admin')

end













