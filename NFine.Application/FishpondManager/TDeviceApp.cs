//-----------------------------------------------------------------------
// <copyright file=" TDevice.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: TDevice.cs
// * history : Created by T4 12/28/2016 15:07:16 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Code;
using NFine.Domain.Entity.FishpondManager;
using NFine.Domain.IRepository.FishpondManager;
using NFine.Repository.FishpondManager;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NFine.Application.FishpondManager
{
    public class TDeviceApp
    {
		private ITDeviceRepository service = new TDeviceRepository();

		public List<TDeviceEntity> GetList(Pagination pagination, string queryJson)
        {
		    var expression = ExtLinq.True<TDeviceEntity>();
            var queryParam = queryJson.ToJObject();
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyword = queryParam["keyword"].ToString();
                expression = expression.And(t => t.F_CName.Contains(keyword));
            }
            return service.FindList(expression, pagination);
        }

	    public TDeviceEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void Delete(TDeviceEntity entity)
        {
            service.Delete(entity);
        }

		public void SubmitForm(TDeviceEntity entity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                entity.Modify(keyValue);
                service.Update(entity);
            }
            else
            {
                entity.Create();
                service.Insert(entity);
            }
        }
    }
}