CREATE TABLE [dbo].[Sys_ItemsDetail] (
    [F_Id]               VARCHAR (50)  NOT NULL,
    [F_ItemId]           VARCHAR (50)  NULL,
    [F_ParentId]         VARCHAR (50)  NULL,
    [F_ItemCode]         VARCHAR (50)  NULL,
    [F_ItemName]         VARCHAR (50)  NULL,
    [F_SimpleSpelling]   VARCHAR (500) NULL,
    [F_IsDefault]        BIT           NULL,
    [F_Layers]           INT           NULL,
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
    CONSTRAINT [PK_SYS_ITEMDETAIL] PRIMARY KEY NONCLUSTERED ([F_Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'选项明细表', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ItemsDetail';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'明细主键', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ItemsDetail', @level2type = N'COLUMN', @level2name = N'F_Id';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'主表主键', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ItemsDetail', @level2type = N'COLUMN', @level2name = N'F_ItemId';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'父级', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ItemsDetail', @level2type = N'COLUMN', @level2name = N'F_ParentId';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'编码', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ItemsDetail', @level2type = N'COLUMN', @level2name = N'F_ItemCode';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'名称', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ItemsDetail', @level2type = N'COLUMN', @level2name = N'F_ItemName';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'简拼', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ItemsDetail', @level2type = N'COLUMN', @level2name = N'F_SimpleSpelling';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'默认', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ItemsDetail', @level2type = N'COLUMN', @level2name = N'F_IsDefault';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'层次', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ItemsDetail', @level2type = N'COLUMN', @level2name = N'F_Layers';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'排序码', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ItemsDetail', @level2type = N'COLUMN', @level2name = N'F_SortCode';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'删除标志', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ItemsDetail', @level2type = N'COLUMN', @level2name = N'F_DeleteMark';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'有效标志', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ItemsDetail', @level2type = N'COLUMN', @level2name = N'F_EnabledMark';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'描述', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ItemsDetail', @level2type = N'COLUMN', @level2name = N'F_Description';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'创建日期', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ItemsDetail', @level2type = N'COLUMN', @level2name = N'F_CreatorTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'创建用户主键', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ItemsDetail', @level2type = N'COLUMN', @level2name = N'F_CreatorUserId';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'最后修改时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ItemsDetail', @level2type = N'COLUMN', @level2name = N'F_LastModifyTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'最后修改用户', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ItemsDetail', @level2type = N'COLUMN', @level2name = N'F_LastModifyUserId';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'删除时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ItemsDetail', @level2type = N'COLUMN', @level2name = N'F_DeleteTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'删除用户', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Sys_ItemsDetail', @level2type = N'COLUMN', @level2name = N'F_DeleteUserId';

