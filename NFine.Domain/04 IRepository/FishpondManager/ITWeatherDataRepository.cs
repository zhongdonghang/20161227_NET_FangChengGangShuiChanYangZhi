//-----------------------------------------------------------------------
// <copyright file=" TWeatherData.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: TWeatherData.cs
// * history : Created by T4 12/29/2016 15:24:27 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Data;
using NFine.Domain.Entity.FishpondManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Domain.IRepository.FishpondManager
{
    public interface ITWeatherDataRepository : IRepositoryBase<TWeatherDataEntity>
    {
    }
}