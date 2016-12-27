CREATE TABLE [dbo].[Sys_ModuleFormInstance] (
    [F_Id]            VARCHAR (50)  NOT NULL,
    [F_FormId]        VARCHAR (50)  NOT NULL,
    [F_ObjectId]      VARCHAR (50)  NULL,
    [F_InstanceJson]  VARCHAR (MAX) NULL,
    [F_SortCode]      INT           NULL,
    [F_CreatorTime]   DATETIME      NULL,
    [F_CreatorUserId] VARCHAR (50)  NULL,
    CONSTRAINT [PK_SYS_MODULEFORMINSTANCE] PRIMARY KEY NONCLUSTERED ([F_Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'模块表单实例', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ModuleFormInstance';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'表单实例主键', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ModuleFormInstance', @level2type = N'COLUMN', @level2name = N'F_Id';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'表单主键', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ModuleFormInstance', @level2type = N'COLUMN', @level2name = N'F_FormId';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'对象主键', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ModuleFormInstance', @level2type = N'COLUMN', @level2name = N'F_ObjectId';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'表单实例Json', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ModuleFormInstance', @level2type = N'COLUMN', @level2name = N'F_InstanceJson';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'排序码', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ModuleFormInstance', @level2type = N'COLUMN', @level2name = N'F_SortCode';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'创建时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ModuleFormInstance', @level2type = N'COLUMN', @level2name = N'F_CreatorTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'创建用户', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ModuleFormInstance', @level2type = N'COLUMN', @level2name = N'F_CreatorUserId';

