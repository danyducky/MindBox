﻿CREATE TABLE [dbo].[Categories]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(255) NOT NULL,
    CONSTRAINT AK_Name UNIQUE([Name]),
)
