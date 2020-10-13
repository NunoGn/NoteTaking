CREATE TABLE [dbo].[Contact]
(
	[FirstName] VARCHAR(50) NULL , 
    [LastName] VARCHAR(50) NULL, 
    [Mobile] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(50) NULL, 
    [Category] VARCHAR(50) NULL, 
    PRIMARY KEY ([Mobile])
)
