﻿CREATE TABLE [dbo].[Sys_ModuleButton] (
    [F_Id]               VARCHAR (50)  NOT NULL,
    [F_ModuleId]         VARCHAR (50)  NULL,
    [F_ParentId]         VARCHAR (50)  NULL,
    [F_Layers]           INT           NULL,
    [F_EnCode]           VARCHAR (50)  NULL,
    [F_FullName]         VARCHAR (50)  NULL,
    [F_Icon]             VARCHAR (50)  NULL,
    [F_Location]         INT           NULL,
    [F_JsEvent]          VARCHAR (50)  NULL,
    [F_UrlAddress]       VARCHAR (500) NULL,
    [F_Split]            BIT           NULL,
    [F_IsPublic]         BIT           NULL,
    [F_AllowEdit]        BIT           NULL,
    [F_AllowDelete]      BIT           NULL,
    [F_SortCode]         INT           NULL,
    [F_DeleteMark]       BIT           NULL,
    [F_EnabledMark]      BIT           NULL,
    [F_Description]      VARCHAR (500) NULL,
    [F_CreatorTime]      DATETIME      NULL,
    [F_CreatorUserId]    VARCHAR (50)  NULL,
    [F_LastModifyTime]   DATETIME      NULL,
    [F_LastModifyUserId] VARCHAR (50)  NULL,
    [F_DeleteTime]       DATETIME      NULL,
    [F_DeleteUserId]     VARCHAR (50)  NULL,
    CONSTRAINT [PK_SYS_MODULEBUTTON] PRIMARY KEY NONCLUSTERED ([F_Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'模块按钮', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ModuleButton';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'按钮主键', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ModuleButton', @level2type = N'COLUMN', @level2name = N'F_Id';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'模块主键', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ModuleButton', @level2type = N'COLUMN', @level2name = N'F_ModuleId';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'父级', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ModuleButton', @level2type = N'COLUMN', @level2name = N'F_ParentId';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'层次', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ModuleButton', @level2type = N'COLUMN', @level2name = N'F_Layers';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'编码', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ModuleButton', @level2type = N'COLUMN', @level2name = N'F_EnCode';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'名称', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ModuleButton', @level2type = N'COLUMN', @level2name = N'F_FullName';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'图标', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ModuleButton', @level2type = N'COLUMN', @level2name = N'F_Icon';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'位置', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ModuleButton', @level2type = N'COLUMN', @level2name = N'F_Location';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'事件', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ModuleButton', @level2type = N'COLUMN', @level2name = N'F_JsEvent';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'连接', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ModuleButton', @level2type = N'COLUMN', @level2name = N'F_UrlAddress';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'分开线', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ModuleButton', @level2type = N'COLUMN', @level2name = N'F_Split';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'公共', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ModuleButton', @level2type = N'COLUMN', @level2name = N'F_IsPublic';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'允许编辑', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ModuleButton', @level2type = N'COLUMN', @level2name = N'F_AllowEdit';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'允许删除', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ModuleButton', @level2type = N'COLUMN', @level2name = N'F_AllowDelete';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'排序码', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ModuleButton', @level2type = N'COLUMN', @level2name = N'F_SortCode';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'删除标志', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ModuleButton', @level2type = N'COLUMN', @level2name = N'F_DeleteMark';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'有效标志', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ModuleButton', @level2type = N'COLUMN', @level2name = N'F_EnabledMark';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'描述', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ModuleButton', @level2type = N'COLUMN', @level2name = N'F_Description';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'创建日期', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ModuleButton', @level2type = N'COLUMN', @level2name = N'F_CreatorTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'创建用户主键', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ModuleButton', @level2type = N'COLUMN', @level2name = N'F_CreatorUserId';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'最后修改时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ModuleButton', @level2type = N'COLUMN', @level2name = N'F_LastModifyTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'最后修改用户', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ModuleButton', @level2type = N'COLUMN', @level2name = N'F_LastModifyUserId';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'删除时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ModuleButton', @level2type = N'COLUMN', @level2name = N'F_DeleteTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'删除用户', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ModuleButton', @level2type = N'COLUMN', @level2name = N'F_DeleteUserId';

