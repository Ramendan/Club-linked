CREATE TABLE [dbo].[Reports]
(
	[reportID] INT NOT NULL PRIMARY KEY, 
    [report_reason] VARCHAR(50) NOT NULL, 
    [report_content] VARCHAR(MAX) NOT NULL, 
    [sent_by] INT
	FOREIGN KEY (sent_by) REFERENCES Accounts (userID) 
)