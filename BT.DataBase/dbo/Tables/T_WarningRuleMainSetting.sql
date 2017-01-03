CREATE TABLE [dbo].[T_WarningRuleMainSetting]
(
	[F_Id] VARCHAR(50) NOT NULL PRIMARY KEY,
	[F_Code] VARCHAR(50) NULL, 
    [F_Title] VARCHAR(100) NULL, 
    [F_RuleContent] VARCHAR(50) NULL, 
	[F_WarningColor] VARCHAR(50) NULL, 
	[F_IsSMS] VARCHAR(10) NULL, 
	[F_IsAppPush] VARCHAR(10) NULL, 
	[F_IsPCPush] VARCHAR(10) NULL, 
	[F_WarningCategoryItemId] VARCHAR(50) NULL, 
	[F_WarningCategoryItemText] VARCHAR(50) NULL, 
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
