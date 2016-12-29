//-----------------------------------------------------------------------
// <copyright file=" TSensorData.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: TSensorData.cs
// * history : Created by T4 12/29/2016 15:24:17 
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
    public class TSensorDataApp
    {
		private ITSensorDataRepository service = new TSensorDataRepository();


        public List<TSensorDataEntity> GetList(Pagination pagination, string keyword,string itemId)
        {
            var expression = ExtLinq.True<TSensorDataEntity>();
            if (!string.IsNullOrEmpty(keyword))
            {
                expression = expression.And(t => t.F_Device_Name.Contains(keyword));
                expression = expression.Or(t => t.F_Device_Code.Contains(keyword));
            }
            expression.And(t=>t.F_OrgNo== itemId);
            return service.FindList(expression, pagination);
        }

      //  public List<TSensorDataEntity> GetList(Pagination pagination, string queryJson)
      //  {
		    //var expression = ExtLinq.True<TSensorDataEntity>();
      //      var queryParam = queryJson.ToJObject();
      //      if (!queryParam["keyword"].IsEmpty())
      //      {
      //          string keyword = queryParam["keyword"].ToString();
      //          expression = expression.And(t => t.F_Device_Name.Contains(keyword));
      //          expression = expression.Or(t => t.F_Device_Code.Contains(keyword));
      //      }
      //      return service.FindList(expression, pagination);
      //  }

	    public TSensorDataEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void Delete(TSensorDataEntity entity)
        {
            service.Delete(entity);
        }

		public void SubmitForm(TSensorDataEntity entity, string keyValue)
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