CREATE TABLE [dbo].[UserTbl]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserName] VARCHAR(50) NOT NULL, 
    [FullName] VARCHAR(50) NULL, 
    [Password] VARCHAR(50) NOT NULL, 
    [Phone] VARCHAR(50) NULL
)
