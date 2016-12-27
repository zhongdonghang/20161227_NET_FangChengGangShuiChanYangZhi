CREATE TABLE [dbo].[Sys_UserLogOn] (
    [F_Id]                 VARCHAR (50)  NOT NULL,
    [F_UserId]             VARCHAR (50)  NULL,
    [F_UserPassword]       VARCHAR (50)  NULL,
    [F_UserSecretkey]      VARCHAR (50)  NULL,
    [F_AllowStartTime]     DATETIME      NULL,
    [F_AllowEndTime]       DATETIME      NULL,
    [F_LockStartDate]      DATETIME      NULL,
    [F_LockEndDate]        DATETIME      NULL,
    [F_FirstVisitTime]     DATETIME      NULL,
    [F_PreviousVisitTime]  DATETIME      NULL,
    [F_LastVisitTime]      DATETIME      NULL,
    [F_ChangePasswordDate] DATETIME      NULL,
    [F_MultiUserLogin]     BIT           NULL,
    [F_LogOnCount]         INT           NULL,
    [F_UserOnLine]         BIT           NULL,
    [F_Question]           VARCHAR (50)  NULL,
    [F_AnswerQuestion]     VARCHAR (500) NULL,
    [F_CheckIPAddress]     BIT           NULL,
    [F_Language]           VARCHAR (50)  NULL,
    [F_Theme]              VARCHAR (50)  NULL,
    CONSTRAINT [PK_SYS_USERLOGON] PRIMARY KEY NONCLUSTERED ([F_Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'用户登录信息表', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_UserLogOn';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'用户登录主键', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_UserLogOn', @level2type = N'COLUMN', @level2name = N'F_Id';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'用户主键', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_UserLogOn', @level2type = N'COLUMN', @level2name = N'F_UserId';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'用户密码', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_UserLogOn', @level2type = N'COLUMN', @level2name = N'F_UserPassword';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'用户秘钥', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_UserLogOn', @level2type = N'COLUMN', @level2name = N'F_UserSecretkey';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'允许登录时间开始', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_UserLogOn', @level2type = N'COLUMN', @level2name = N'F_AllowStartTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'允许登录时间结束', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_UserLogOn', @level2type = N'COLUMN', @level2name = N'F_AllowEndTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'暂停用户开始日期', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_UserLogOn', @level2type = N'COLUMN', @level2name = N'F_LockStartDate';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'暂停用户结束日期', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_UserLogOn', @level2type = N'COLUMN', @level2name = N'F_LockEndDate';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'第一次访问时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_UserLogOn', @level2type = N'COLUMN', @level2name = N'F_FirstVisitTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'上一次访问时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_UserLogOn', @level2type = N'COLUMN', @level2name = N'F_PreviousVisitTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'最后访问时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_UserLogOn', @level2type = N'COLUMN', @level2name = N'F_LastVisitTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'最后修改密码日期', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_UserLogOn', @level2type = N'COLUMN', @level2name = N'F_ChangePasswordDate';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'允许同时有多用户登录', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_UserLogOn', @level2type = N'COLUMN', @level2name = N'F_MultiUserLogin';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'登录次数', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_UserLogOn', @level2type = N'COLUMN', @level2name = N'F_LogOnCount';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'在线状态', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_UserLogOn', @level2type = N'COLUMN', @level2name = N'F_UserOnLine';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'密码提示问题', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_UserLogOn', @level2type = N'COLUMN', @level2name = N'F_Question';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'密码提示答案', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_UserLogOn', @level2type = N'COLUMN', @level2name = N'F_AnswerQuestion';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'是否访问限制', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_UserLogOn', @level2type = N'COLUMN', @level2name = N'F_CheckIPAddress';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'系统语言', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_UserLogOn', @level2type = N'COLUMN', @level2name = N'F_Language';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'系统样式', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_UserLogOn', @level2type = N'COLUMN', @level2name = N'F_Theme';

