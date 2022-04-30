CREATE TABLE [dbo].[Membership]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [MemberId] INT NOT NULL, 
    [PlanId] INT NOT NULL, 
    [StartingDate] DATETIME2 NOT NULL,
    [ExpirationDate] DATETIME2 NOT NULL, 
    [IsExpired] BIT NOT NULL DEFAULT 0, 
    [UserId] INT NOT NULL, 
    CONSTRAINT [FK_Membership_Member] FOREIGN KEY (MemberId) REFERENCES Member(Id),
    
    CONSTRAINT [FK_Membership_Plan] FOREIGN KEY (PlanId) REFERENCES [Plan](Id), 
)
