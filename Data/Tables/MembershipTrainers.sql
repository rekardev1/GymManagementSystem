CREATE TABLE [dbo].[MembershipTrainers]
(
    [MembershipId] INT NOT NULL, 
    [TrainerId] INT NOT NULL, 
    CONSTRAINT [FK_MembershipTrainers_Membership] FOREIGN KEY (MembershipId) REFERENCES [Membership]([Id]), 
    CONSTRAINT [FK_MembershipTrainers_Employee] FOREIGN KEY (TrainerId) REFERENCES [Employee]([Id])
)
