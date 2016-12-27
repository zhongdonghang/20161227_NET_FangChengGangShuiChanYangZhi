CREATE TABLE [dbo].[Sys_User] (
    [F_Id]               VARCHAR (50)  NOT NULL,
    [F_Account]          VARCHAR (50)  NULL,
    [F_RealName]         VARCHAR (50)  NULL,
    [F_NickName]         VARCHAR (50)  NULL,
    [F_HeadIcon]         VARCHAR (50)  NULL,
    [F_Gender]           BIT           NULL,
    [F_Birthday]         DATETIME      NULL,
    [F_MobilePhone]      VARCHAR (20)  NULL,
    [F_Email]            VARCHAR (50)  NULL,
    [F_WeChat]           VARCHAR (50)  NULL,
    [F_ManagerId]        VARCHAR (50)  NULL,
    [F_SecurityLevel]    INT           NULL,
    [F_Signature]        VARCHAR (500) NULL,
    [F_OrganizeId]       VARCHAR (50)  NULL,
    [F_DepartmentId]     VARCHAR (500) NULL,
    [F_RoleId]           VARCHAR (500) NULL,
    [F_DutyId]           VARCHAR (500) NULL,
    [F_IsAdministrator]  BIT           NULL,
    [F_SortCode]         INT           NULL,
    [F_DeleteMark]       BIT           NULL,
    [F_EnabledMark]      BIT           NULL,
    [F_Description]      VARCHAR (500) NULL,
    [F_CreatorTime]      DATETIME      NULL,
    [F_CreatorUserId]    VARCHAR (50)  NULL,
    [F_LastModifyTime]   DATETIME      NULL,
    [F_LastModifyUserId] VARCHAR (50)  NULL,
    [F_DeleteTime]       DATETIME      NULL,
    [F_DeleteUserId]     VARCHAR (500) NULL,
    CONSTRAINT [PK_SYS_USER] PRIMARY KEY NONCLUSTERED ([F_Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'用户表', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_User';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'用户主键', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_User', @level2type = N'COLUMN', @level2name = N'F_Id';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'账户', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_User', @level2type = N'COLUMN', @level2name = N'F_Account';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'姓名', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_User', @level2type = N'COLUMN', @level2name = N'F_RealName';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'呢称', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_User', @level2type = N'COLUMN', @level2name = N'F_NickName';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'头像', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_User', @level2type = N'COLUMN', @level2name = N'F_HeadIcon';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'性别', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_User', @level2type = N'COLUMN', @level2name = N'F_Gender';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'生日', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_User', @level2type = N'COLUMN', @level2name = N'F_Birthday';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'手机', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_User', @level2type = N'COLUMN', @level2name = N'F_MobilePhone';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'邮箱', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_User', @level2type = N'COLUMN', @level2name = N'F_Email';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'微信', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_User', @level2type = N'COLUMN', @level2name = N'F_WeChat';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'主管主键', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_User', @level2type = N'COLUMN', @level2name = N'F_ManagerId';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'安全级别', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_User', @level2type = N'COLUMN', @level2name = N'F_SecurityLevel';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'个性签名', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_User', @level2type = N'COLUMN', @level2name = N'F_Signature';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'组织主键', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_User', @level2type = N'COLUMN', @level2name = N'F_OrganizeId';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'部门主键', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_User', @level2type = N'COLUMN', @level2name = N'F_DepartmentId';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'角色主键', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_User', @level2type = N'COLUMN', @level2name = N'F_RoleId';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'岗位主键', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_User', @level2type = N'COLUMN', @level2name = N'F_DutyId';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'是否管理员', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_User', @level2type = N'COLUMN', @level2name = N'F_IsAdministrator';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'排序码', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_User', @level2type = N'COLUMN', @level2name = N'F_SortCode';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'删除标志', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_User', @level2type = N'COLUMN', @level2name = N'F_DeleteMark';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'有效标志', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_User', @level2type = N'COLUMN', @level2name = N'F_EnabledMark';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'描述', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_User', @level2type = N'COLUMN', @level2name = N'F_Description';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'创建时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_User', @level2type = N'COLUMN', @level2name = N'F_CreatorTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'创建用户', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_User', @level2type = N'COLUMN', @level2name = N'F_CreatorUserId';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'最后修改时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_User', @level2type = N'COLUMN', @level2name = N'F_LastModifyTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'最后修改用户', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_User', @level2type = N'COLUMN', @level2name = N'F_LastModifyUserId';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'删除时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_User', @level2type = N'COLUMN', @level2name = N'F_DeleteTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'删除用户', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_User', @level2type = N'COLUMN', @level2name = N'F_DeleteUserId';

