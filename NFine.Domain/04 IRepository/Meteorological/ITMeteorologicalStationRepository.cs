//-----------------------------------------------------------------------
// <copyright file=" TMeteorologicalStation.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: TMeteorologicalStation.cs
// * history : Created by T4 12/29/2016 16:23:08 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Data;
using NFine.Domain.Entity.Meteorological;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Domain.IRepository.Meteorological
{
    public interface ITMeteorologicalStationRepository : IRepositoryBase<TMeteorologicalStationEntity>
    {
    }
}