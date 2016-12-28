//-----------------------------------------------------------------------
// <copyright file=" TDeviceType.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: TDeviceType.cs
// * history : Created by T4 12/28/2016 15:08:32 
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
    public class TDeviceTypeApp
    {
		private ITDeviceTypeRepository service = new TDeviceTypeRepository();

        public List<TDeviceTypeEntity> GetList()
        {
            var expression = ExtLinq.True<TDeviceTypeEntity>();
            List<TDeviceTypeEntity> list = service.IQueryable(expression).OrderBy(t => t.F_SortCode).ToList();
            return list;
        }

        public List<TDeviceTypeEntity> GetList(Pagination pagination, string queryJson)
        {
		    var expression = ExtLinq.True<TDeviceTypeEntity>();
            var queryParam = queryJson.ToJObject();
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyword = queryParam["keyword"].ToString();
                expression = expression.And(t => t.F_Category_Name.Contains(keyword));
            }
            return service.FindList(expression, pagination);
        }

	    public TDeviceTypeEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void Delete(TDeviceTypeEntity entity)
        {
            service.Delete(entity);
        }

		public void SubmitForm(TDeviceTypeEntity entity, string keyValue)
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