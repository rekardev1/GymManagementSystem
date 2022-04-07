CREATE TABLE [dbo].[Membership]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [MemberId] INT NOT NULL, 
    [TrainerId] INT NOT NULL, 
    [MembershipTypeId] INT NOT NULL, 
    [ExpirationDate] DATETIME2 NOT NULL, 
    [SignedByManagerId] INT NOT NULL, 
    CONSTRAINT [FK_Membership_Member] FOREIGN KEY (MemberId) REFERENCES Member(Id),
    CONSTRAINT [FK_Membership_Employee] FOREIGN KEY (TrainerId) REFERENCES Employee(Id),
    CONSTRAINT [FK_Membership_Employee2] FOREIGN KEY (SignedByManagerId) REFERENCES Employee(Id),
    CONSTRAINT [FK_Membership_MembershipType] FOREIGN KEY (MembershipTypeId) REFERENCES MembershipType(Id)
)
