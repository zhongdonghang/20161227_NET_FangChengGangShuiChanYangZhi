//-----------------------------------------------------------------------
// <copyright file=" TWeatherData.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: TWeatherData.cs
// * history : Created by T4 12/29/2016 15:24:28 
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
    public class TWeatherDataMap : EntityTypeConfiguration<TWeatherDataEntity>
    {
		 public TWeatherDataMap()
        {
            this.ToTable("T_Weather_Data");
            this.HasKey(t => t.F_Id);
        }
    }
}