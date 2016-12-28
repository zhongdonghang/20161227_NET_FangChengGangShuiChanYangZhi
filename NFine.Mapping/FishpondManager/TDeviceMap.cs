//-----------------------------------------------------------------------
// <copyright file=" TDevice.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: TDevice.cs
// * history : Created by T4 12/28/2016 15:07:17 
// </copyright>
//-----------------------------------------------------------------------

using NFine.Domain.Entity.FishpondManager;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;

namespace NFine.Mapping.FishpondManager
{
    public class TDeviceMap : EntityTypeConfiguration<TDeviceEntity>
    {
		 public TDeviceMap()
        {
            this.ToTable("T_Device");
            this.HasKey(t => t.F_Id);
        }
    }
}