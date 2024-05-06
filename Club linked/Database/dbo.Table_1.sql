CREATE TABLE [dbo].[Reports]
(
	[reportID] INT NOT NULL PRIMARY KEY DEFAULT 1, 
    [report_reason] VARCHAR(50) NOT NULL, 
    [report_content] VARCHAR(MAX) NOT NULL, 
    [sent_by_ID] INT

	FOREIGN KEY ([sent_by_ID]) REFERENCES Accounts (userID), 

    
)
