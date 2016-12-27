CREATE TABLE [dbo].[Sys_Role] (
    [F_Id]               VARCHAR (50)  NOT NULL,
    [F_OrganizeId]       VARCHAR (50)  NULL,
    [F_Category]         INT           NULL,
    [F_EnCode]           VARCHAR (50)  NULL,
    [F_FullName]         VARCHAR (50)  NULL,
    [F_Type]             VARCHAR (50)  NULL,
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
    [F_DeleteUserId]     VARCHAR (500) NULL,
    CONSTRAINT [PK_SYS_ROLE] PRIMARY KEY NONCLUSTERED ([F_Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'角色表', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_Role';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'角色主键', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_Role', @level2type = N'COLUMN', @level2name = N'F_Id';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'组织主键', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_Role', @level2type = N'COLUMN', @level2name = N'F_OrganizeId';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'分类:1-角色2-岗位', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_Role', @level2type = N'COLUMN', @level2name = N'F_Category';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'编号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_Role', @level2type = N'COLUMN', @level2name = N'F_EnCode';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'名称', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_Role', @level2type = N'COLUMN', @level2name = N'F_FullName';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'类型', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_Role', @level2type = N'COLUMN', @level2name = N'F_Type';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'允许编辑', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_Role', @level2type = N'COLUMN', @level2name = N'F_AllowEdit';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'允许删除', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_Role', @level2type = N'COLUMN', @level2name = N'F_AllowDelete';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'排序码', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_Role', @level2type = N'COLUMN', @level2name = N'F_SortCode';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'删除标志', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_Role', @level2type = N'COLUMN', @level2name = N'F_DeleteMark';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'有效标志', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_Role', @level2type = N'COLUMN', @level2name = N'F_EnabledMark';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'描述', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_Role', @level2type = N'COLUMN', @level2name = N'F_Description';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'创建时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_Role', @level2type = N'COLUMN', @level2name = N'F_CreatorTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'创建用户', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_Role', @level2type = N'COLUMN', @level2name = N'F_CreatorUserId';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'最后修改时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_Role', @level2type = N'COLUMN', @level2name = N'F_LastModifyTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'最后修改用户', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_Role', @level2type = N'COLUMN', @level2name = N'F_LastModifyUserId';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'删除时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_Role', @level2type = N'COLUMN', @level2name = N'F_DeleteTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'删除用户', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_Role', @level2type = N'COLUMN', @level2name = N'F_DeleteUserId';

