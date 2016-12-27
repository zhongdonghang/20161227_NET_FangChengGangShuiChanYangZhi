CREATE TABLE [dbo].[Sys_Log] (
    [F_Id]            VARCHAR (50)  NOT NULL,
    [F_Date]          DATETIME      NULL,
    [F_Account]       VARCHAR (50)  NULL,
    [F_NickName]      VARCHAR (50)  NULL,
    [F_Type]          VARCHAR (50)  NULL,
    [F_IPAddress]     VARCHAR (50)  NULL,
    [F_IPAddressName] VARCHAR (50)  NULL,
    [F_ModuleId]      VARCHAR (50)  NULL,
    [F_ModuleName]    VARCHAR (50)  NULL,
    [F_Result]        BIT           NULL,
    [F_Description]   VARCHAR (500) NULL,
    [F_CreatorTime]   DATETIME      NULL,
    [F_CreatorUserId] VARCHAR (50)  NULL,
    CONSTRAINT [PK_SYS_LOG] PRIMARY KEY NONCLUSTERED ([F_Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'系统日志', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_Log';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'日志主键', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_Log', @level2type = N'COLUMN', @level2name = N'F_Id';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'日期', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_Log', @level2type = N'COLUMN', @level2name = N'F_Date';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'用户名', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_Log', @level2type = N'COLUMN', @level2name = N'F_Account';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'姓名', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_Log', @level2type = N'COLUMN', @level2name = N'F_NickName';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'类型', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_Log', @level2type = N'COLUMN', @level2name = N'F_Type';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'IP地址', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_Log', @level2type = N'COLUMN', @level2name = N'F_IPAddress';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'IP所在城市', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_Log', @level2type = N'COLUMN', @level2name = N'F_IPAddressName';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'系统模块Id', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_Log', @level2type = N'COLUMN', @level2name = N'F_ModuleId';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'系统模块', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_Log', @level2type = N'COLUMN', @level2name = N'F_ModuleName';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'结果', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_Log', @level2type = N'COLUMN', @level2name = N'F_Result';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'描述', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_Log', @level2type = N'COLUMN', @level2name = N'F_Description';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'创建时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_Log', @level2type = N'COLUMN', @level2name = N'F_CreatorTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'创建用户', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_Log', @level2type = N'COLUMN', @level2name = N'F_CreatorUserId';

