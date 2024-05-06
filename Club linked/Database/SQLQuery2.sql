CREATE TABLE [dbo].[Events]
(
	[eventID] INT NOT NULL PRIMARY KEY DEFAULT 1, 
    [event_title] VARCHAR(50) NOT NULL, 

    [sent_by_ID] INT

	FOREIGN KEY ([sent_by_ID]) REFERENCES Accounts (userID), 

    
)
