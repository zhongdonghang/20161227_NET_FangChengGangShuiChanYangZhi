CREATE TABLE [dbo].[T_WarningRuleDetailsSetting]
(
	[F_Id] VARCHAR(50) NOT NULL PRIMARY KEY,
	[F_Code] VARCHAR(50) NULL, 
    [F_MailRuleId] VARCHAR(100) NULL, 
    [F_MailRuleText] VARCHAR(50) NULL, 

	[F_PhAndOr] VARCHAR(50) NULL, 
	[F_OperatePHValue] VARCHAR(50) NULL, 
	[F_PHValue] VARCHAR(50) NULL, 

	[F_DOAndOr] VARCHAR(50) NULL, 
	[F_OperateDOValue] VARCHAR(50) NULL, 
	[F_DOValue] VARCHAR(50) NULL, 

	[F_WaterTemperatureAndOr] VARCHAR(50) NULL, 
	[F_OperateWaterTemperatureValue] VARCHAR(50) NULL, 
	[F_WaterTemperatureValue] VARCHAR(50) NULL, 

	[F_TemperatureAndOr] VARCHAR(50) NULL, 
	[F_OperateTemperatureValue] VARCHAR(50) NULL, 
	[F_TemperatureValue] VARCHAR(50) NULL, 

	[F_RainfallAndOr] VARCHAR(50) NULL, 
	[F_OperateRainfallValue] VARCHAR(50) NULL, 
	[F_RainfallValue] VARCHAR(50) NULL, 

	[F_WindForceAndOr] VARCHAR(50) NULL, 
	[F_OperateWindForceValue] VARCHAR(50) NULL, 
	[F_WindForceValue] VARCHAR(50) NULL, 

	[F_WindDirectionAndOr] VARCHAR(50) NULL, 
	[F_OperateWindDirectionValue] VARCHAR(50) NULL, 
	[F_WindDirectionValue] VARCHAR(50) NULL, 

	[F_VisibilityAndOr] VARCHAR(50) NULL, 
	[F_OperateVisibilityValue] VARCHAR(50) NULL, 
	[F_VisibilityValue] VARCHAR(50) NULL, 

	[F_HumidityAndOr] VARCHAR(50) NULL, 
	[F_OperateHumidityValue] VARCHAR(50) NULL, 
	[F_HumidityValue] VARCHAR(50) NULL, 

	[F_PressureAndOr] VARCHAR(50) NULL, 
	[F_OperatePressureValue] VARCHAR(50) NULL, 
	[F_PressureValue] VARCHAR(50) NULL, 

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
