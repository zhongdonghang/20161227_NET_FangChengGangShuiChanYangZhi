CREATE TABLE [dbo].[T_Meteorological_Station]
(
	[F_Id] VARCHAR(50) NOT NULL PRIMARY KEY,
	[F_Code] VARCHAR(50) NULL, 
    [F_Station_Name] VARCHAR(50) NULL, 
    [F_Station_Address] VARCHAR(50) NULL, 
	[F_Station_Address_X] VARCHAR(50) NULL, 
	[F_Station_Address_Y] VARCHAR(50) NULL, 
	[F_OrgNo] VARCHAR(100) NULL, 
	[F_Org_Name] VARCHAR(100) NULL, 
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
