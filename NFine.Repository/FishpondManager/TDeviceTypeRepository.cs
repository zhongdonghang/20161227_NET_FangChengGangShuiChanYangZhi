//-----------------------------------------------------------------------
// <copyright file=" TDeviceType.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: TDeviceType.cs
// * history : Created by T4 12/28/2016 15:08:35 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Data;
using NFine.Domain.Entity.FishpondManager;
using NFine.Domain.IRepository.FishpondManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Repository.FishpondManager
{
    public class TDeviceTypeRepository : RepositoryBase<TDeviceTypeEntity>, ITDeviceTypeRepository
    {
    }
}