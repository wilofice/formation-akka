CREATE TABLE [dbo].[Teams]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Nom] Varchar(15) NOT NULL,
	[Description] Varchar(56) NOT NULL, 
    [Reference] INT NULL,
)
