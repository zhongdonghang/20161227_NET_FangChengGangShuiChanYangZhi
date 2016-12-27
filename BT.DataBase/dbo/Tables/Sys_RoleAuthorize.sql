CREATE TABLE [dbo].[Sys_RoleAuthorize] (
    [F_Id]            VARCHAR (50) NOT NULL,
    [F_ItemType]      INT          NULL,
    [F_ItemId]        VARCHAR (50) NULL,
    [F_ObjectType]    INT          NULL,
    [F_ObjectId]      VARCHAR (50) NULL,
    [F_SortCode]      INT          NULL,
    [F_CreatorTime]   DATETIME     NULL,
    [F_CreatorUserId] VARCHAR (50) NULL,
    CONSTRAINT [PK_SYS_ROLEAUTHORIZE] PRIMARY KEY NONCLUSTERED ([F_Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'角色授权表', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_RoleAuthorize';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'角色授权主键', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_RoleAuthorize', @level2type = N'COLUMN', @level2name = N'F_Id';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'项目类型1-模块2-按钮3-列表', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_RoleAuthorize', @level2type = N'COLUMN', @level2name = N'F_ItemType';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'项目主键', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_RoleAuthorize', @level2type = N'COLUMN', @level2name = N'F_ItemId';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'对象分类1-角色2-部门-3用户', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_RoleAuthorize', @level2type = N'COLUMN', @level2name = N'F_ObjectType';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'对象主键', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_RoleAuthorize', @level2type = N'COLUMN', @level2name = N'F_ObjectId';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'排序码', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_RoleAuthorize', @level2type = N'COLUMN', @level2name = N'F_SortCode';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'创建时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_RoleAuthorize', @level2type = N'COLUMN', @level2name = N'F_CreatorTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'创建用户', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_RoleAuthorize', @level2type = N'COLUMN', @level2name = N'F_CreatorUserId';

