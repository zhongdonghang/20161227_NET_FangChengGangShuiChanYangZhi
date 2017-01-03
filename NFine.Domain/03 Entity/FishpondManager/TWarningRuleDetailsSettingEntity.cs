//-----------------------------------------------------------------------
// <copyright file=" TWarningRuleDetailsSetting.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: TWarningRuleDetailsSetting.cs
// * history : Created by T4 01/03/2017 17:22:37 
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
    /// TWarningRuleDetailsSetting Entity Model
    /// </summary>
    public class TWarningRuleDetailsSettingEntity : IEntity<TWarningRuleDetailsSettingEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
						public  String  F_Id { get; set; }
					public  String  F_Code { get; set; }
					public  String  F_MailRuleId { get; set; }
					public  String  F_MailRuleText { get; set; }
					public  String  F_PhAndOr { get; set; }
					public  String  F_OperatePHValue { get; set; }
					public  String  F_PHValue { get; set; }
					public  String  F_DOAndOr { get; set; }
					public  String  F_OperateDOValue { get; set; }
					public  String  F_DOValue { get; set; }
					public  String  F_WaterTemperatureAndOr { get; set; }
					public  String  F_OperateWaterTemperatureValue { get; set; }
					public  String  F_WaterTemperatureValue { get; set; }
					public  String  F_TemperatureAndOr { get; set; }
					public  String  F_OperateTemperatureValue { get; set; }
					public  String  F_TemperatureValue { get; set; }
					public  String  F_RainfallAndOr { get; set; }
					public  String  F_OperateRainfallValue { get; set; }
					public  String  F_RainfallValue { get; set; }
					public  String  F_WindForceAndOr { get; set; }
					public  String  F_OperateWindForceValue { get; set; }
					public  String  F_WindForceValue { get; set; }
					public  String  F_WindDirectionAndOr { get; set; }
					public  String  F_OperateWindDirectionValue { get; set; }
					public  String  F_WindDirectionValue { get; set; }
					public  String  F_VisibilityAndOr { get; set; }
					public  String  F_OperateVisibilityValue { get; set; }
					public  String  F_VisibilityValue { get; set; }
					public  String  F_HumidityAndOr { get; set; }
					public  String  F_OperateHumidityValue { get; set; }
					public  String  F_HumidityValue { get; set; }
					public  String  F_PressureAndOr { get; set; }
					public  String  F_OperatePressureValue { get; set; }
					public  String  F_PressureValue { get; set; }
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