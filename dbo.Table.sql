﻿CREATE TABLE [dbo].[Employees]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Surname] NCHAR(10) NOT NULL, 
    [Salary] DECIMAL NOT NULL
)
