//-----------------------------------------------------------------------
// <copyright file=" TDeviceType.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: TDeviceType.cs
// * history : Created by T4 12/28/2016 15:08:34 
// </copyright>
//-----------------------------------------------------------------------

using NFine.Domain.Entity.FishpondManager;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;

namespace NFine.Mapping.FishpondManager
{
    public class TDeviceTypeMap : EntityTypeConfiguration<TDeviceTypeEntity>
    {
		 public TDeviceTypeMap()
        {
            this.ToTable("T_Device_Type");
            this.HasKey(t => t.F_Id);
        }
    }
}