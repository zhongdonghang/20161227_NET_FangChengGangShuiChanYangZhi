//-----------------------------------------------------------------------
// <copyright file=" TWarningRuleMainSetting.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: TWarningRuleMainSetting.cs
// * history : Created by T4 01/03/2017 17:22:30 
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Domain.Entity.FishpondManager
{
    /// <summary>
    /// TWarningRuleMainSetting Entity Model
    /// </summary>
    public class TWarningRuleMainSettingEntity : IEntity<TWarningRuleMainSettingEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
						public  String  F_Id { get; set; }
					public  String  F_Code { get; set; }
					public  String  F_Title { get; set; }
					public  String  F_RuleContent { get; set; }
					public  String  F_WarningColor { get; set; }
					public  String  F_IsSMS { get; set; }
					public  String  F_IsAppPush { get; set; }
					public  String  F_IsPCPush { get; set; }
					public  String  F_WarningCategoryItemId { get; set; }
					public  String  F_WarningCategoryItemText { get; set; }
					public  Int32?  F_SortCode { get; set; }
					public  Boolean?  F_DeleteMark { get; set; }
					public  Boolean?  F_EnabledMark { get; set; }
					public  String  F_Description { get; set; }
					public  DateTime?  F_CreatorTime { get; set; }
					public  String  F_CreatorUserId { get; set; }
					public  DateTime?  F_LastModifyTime { get; set; }
					public  String  F_LastModifyUserId { get; set; }
					public  DateTime?  F_DeleteTime { get; set; }
					public  String  F_DeleteUserId { get; set; }
		    }
}