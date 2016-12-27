CREATE TABLE [dbo].[T_Device_Type]
(
	[F_Id] VARCHAR(50) NOT NULL PRIMARY KEY,
	    [F_Code] VARCHAR(50) NULL, 
    [F_Category_Name] VARCHAR(50) NULL, 
    [F_HeadIcon] VARCHAR(50) NULL, 
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

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'代码',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'T_Device_Type',
    @level2type = N'COLUMN',
    @level2name = N'F_Code'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'类型名字',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'T_Device_Type',
    @level2type = N'COLUMN',
    @level2name = N'F_Category_Name'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'图片',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'T_Device_Type',
    @level2type = N'COLUMN',
    @level2name = N'F_HeadIcon'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'排序号',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'T_Device_Type',
    @level2type = N'COLUMN',
    @level2name = N'F_SortCode'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'删除标志',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'T_Device_Type',
    @level2type = N'COLUMN',
    @level2name = N'F_DeleteMark'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'可用标志',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'T_Device_Type',
    @level2type = N'COLUMN',
    @level2name = N'F_EnabledMark'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'描述',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'T_Device_Type',
    @level2type = N'COLUMN',
    @level2name = N'F_Description'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'创建时间',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'T_Device_Type',
    @level2type = N'COLUMN',
    @level2name = N'F_CreatorTime'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'创建人标号',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'T_Device_Type',
    @level2type = N'COLUMN',
    @level2name = N'F_CreatorUserId'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'最后修改时间',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'T_Device_Type',
    @level2type = N'COLUMN',
    @level2name = N'F_LastModifyTime'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'修改人编号',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'T_Device_Type',
    @level2type = N'COLUMN',
    @level2name = N'F_LastModifyUserId'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'删除时间',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'T_Device_Type',
    @level2type = N'COLUMN',
    @level2name = N'F_DeleteTime'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'删除者标志',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'T_Device_Type',
    @level2type = N'COLUMN',
    @level2name = N'F_DeleteUserId'