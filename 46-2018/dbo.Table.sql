﻿CREATE TABLE [dbo].[Employees]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY , 
    [Name] NVARCHAR(50) NOT NULL, 
    [Surname] NVARCHAR(10) NOT NULL, 
    [Salary] DECIMAL(18) NOT NULL,
)
