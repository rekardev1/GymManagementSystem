CREATE TABLE [dbo].[Membership]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [MemberId] INT NOT NULL, 
    [MembershipTypeId] INT NOT NULL, 
    [StartingDate] DATETIME2 NOT NULL,
    [ExpirationDate] DATETIME2 NOT NULL, 
    [UserId] INT NOT NULL, 
    CONSTRAINT [FK_Membership_Member] FOREIGN KEY (MemberId) REFERENCES Member(Id),
    CONSTRAINT [FK_Membership_User] FOREIGN KEY ([UserId]) REFERENCES [User](Id),
    CONSTRAINT [FK_Membership_MembershipType] FOREIGN KEY (MembershipTypeId) REFERENCES MembershipType(Id)
)
