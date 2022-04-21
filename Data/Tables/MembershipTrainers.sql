CREATE TABLE [dbo].[MembershipTrainers]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [MembershipId] INT NOT NULL, 
    [TrainerId] INT NOT NULL, 
    CONSTRAINT [FK_MembershipTrainers_Membership] FOREIGN KEY (MembershipId) REFERENCES [Membership]([Id]), 
    CONSTRAINT [FK_MembershipTrainers_Employee] FOREIGN KEY (TrainerId) REFERENCES [Employee]([Id])
)
