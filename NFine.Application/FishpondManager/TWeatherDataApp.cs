//-----------------------------------------------------------------------
// <copyright file=" TWeatherData.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: TWeatherData.cs
// * history : Created by T4 12/29/2016 15:24:26 
// </copyright>
//-----------------------------------------------------------------------
using Fine.Repository.FishpondManager;
using NFine.Code;
using NFine.Domain.Entity.FishpondManager;
using NFine.Domain.IRepository.FishpondManager;
using NFine.Repository.FishpondManager;
using System;
using System.Collections.Generic;
using System.Linq;
namespace NFine.Application.FishpondManager
{
    public class TWeatherDataApp
    {
		private ITWeatherDataRepository service = new TWeatherDataRepository();

		public List<TWeatherDataEntity> GetList(Pagination pagination, string queryJson)
        {
		    var expression = ExtLinq.True<TWeatherDataEntity>();
            var queryParam = queryJson.ToJObject();
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyword = queryParam["keyword"].ToString();
                expression = expression.And(t => t.F_Station.Contains(keyword));
            }
            return service.FindList(expression, pagination);
        }

	    public TWeatherDataEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void Delete(TWeatherDataEntity entity)
        {
            service.Delete(entity);
        }

		public void SubmitForm(TWeatherDataEntity entity, string keyValue)
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