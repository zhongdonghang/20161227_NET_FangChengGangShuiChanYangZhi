//-----------------------------------------------------------------------
// <copyright file=" TMeteorologicalStation.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: TMeteorologicalStation.cs
// * history : Created by T4 12/29/2016 16:23:08 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Domain.Entity.Meteorological;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;

namespace NFine.Mapping.Meteorological
{
    public class TMeteorologicalStationMap : EntityTypeConfiguration<TMeteorologicalStationEntity>
    {
		 public TMeteorologicalStationMap()
        {
            this.ToTable("T_Meteorological_Station");
            this.HasKey(t => t.F_Id);
        }
    }
}