//-----------------------------------------------------------------------
// <copyright file=" TWarningRuleDetailsSetting.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: TWarningRuleDetailsSetting.cs
// * history : Created by T4 01/03/2017 17:22:38 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Domain.Entity.FishpondManager;
using NFine.Domain.IRepository.FishpondManager;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;

namespace NFine.Mapping.FishpondManager
{
    public class TWarningRuleDetailsSettingMap : EntityTypeConfiguration<TWarningRuleDetailsSettingEntity>
    {
		 public TWarningRuleDetailsSettingMap()
        {
            this.ToTable("T_WarningRuleDetailsSetting");
            this.HasKey(t => t.F_Id);
        }
    }
}