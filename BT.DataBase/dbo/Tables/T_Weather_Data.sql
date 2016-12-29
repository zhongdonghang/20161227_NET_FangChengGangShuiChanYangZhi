﻿CREATE TABLE [dbo].[T_Weather_Data]
(
	[F_Id] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [F_Code] VARCHAR(50) NULL, 
    [F_Address] VARCHAR(200) NULL, 
	[F_Address_X] VARCHAR(50) NULL, 
    [F_Address_Y] VARCHAR(50) NULL, 
	[F_Station_Code] VARCHAR(100) NULL, 
	[F_Station] VARCHAR(100) NULL, 
    [F_Temperature] VARCHAR(100) NULL, 
	[F_Rainfall] VARCHAR(100) NULL, 
	[F_WindForce] VARCHAR(100) NULL, 
	[F_WindDirection] VARCHAR(100) NULL, 
	[F_Visibility] VARCHAR(100) NULL, 
	[F_Humidity] VARCHAR(100) NULL, 
	[F_Pressure] VARCHAR(100) NULL, 
    [F_SortCode] INT NULL, 
    [F_DeleteMark] BIT NULL, 
    [F_EnabledMark] BIT NULL, 
    [F_Description] VARCHAR(200) NULL, 
    [F_CreatorTime] DATETIME NULL, 
    [F_CreatorUserId] VARCHAR(50) NULL, 
    [F_LastModifyTime] DATETIME NULL, 
    [F_LastModifyUserId] VARCHAR(50) NULL, 
    [F_DeleteTime] DATETIME NULL, 
    [F_DeleteUserId] VARCHAR(50) NULL
)
