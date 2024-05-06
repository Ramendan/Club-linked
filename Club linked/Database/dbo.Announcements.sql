CREATE TABLE [dbo].[Announcements] (
    [announcementsID]       INT           DEFAULT ((1)) NOT NULL,
    [announcement_title]    VARCHAR (50)  NOT NULL,
    [announcement_content] VARCHAR (MAX) NULL,
    [sent_by_ID]            INT           NULL,
    [annoucemnt_type] VARCHAR(20) NOT NULL, 
    PRIMARY KEY CLUSTERED ([announcementsID] ASC),
    FOREIGN KEY ([sent_by_ID]) REFERENCES [dbo].[Accounts] ([userID])
);

