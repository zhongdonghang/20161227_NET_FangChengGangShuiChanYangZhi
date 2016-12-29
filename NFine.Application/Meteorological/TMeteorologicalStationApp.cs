//-----------------------------------------------------------------------
// <copyright file=" TMeteorologicalStation.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: TMeteorologicalStation.cs
// * history : Created by T4 12/29/2016 16:23:07 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Code;
using NFine.Domain.Entity.Meteorological;
using NFine.Domain.IRepository.Meteorological;
using NFine.Repository.Meteorological;
using System;
using System.Collections.Generic;
using System.Linq;
namespace NFine.Application.Meteorological
{
    public class TMeteorologicalStationApp
    {
		private ITMeteorologicalStationRepository service = new TMeteorologicalStationRepository();


        public List<TMeteorologicalStationEntity> GetList(Pagination pagination, string keyword)
        {
            var expression = ExtLinq.True<TMeteorologicalStationEntity>();
            if (!string.IsNullOrEmpty(keyword))
            {
                expression = expression.And(t => t.F_Station_Name.Contains(keyword));
                expression = expression.Or(t => t.F_Code.Contains(keyword));
            }
            return service.FindList(expression, pagination);
        }

        //public List<TMeteorologicalStationEntity> GetList(Pagination pagination, string queryJson)
        //      {
        //    var expression = ExtLinq.True<TMeteorologicalStationEntity>();
        //          var queryParam = queryJson.ToJObject();
        //          if (!queryParam["keyword"].IsEmpty())
        //          {
        //              string keyword = queryParam["keyword"].ToString();
        //              expression = expression.And(t => t.F_Station_Name.Contains(keyword));
        //          }
        //          return service.FindList(expression, pagination);
        //      }

        public TMeteorologicalStationEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }
    
        public void Delete(TMeteorologicalStationEntity entity)
        {
            service.Delete(entity);
        }

		public void SubmitForm(TMeteorologicalStationEntity entity, string keyValue)
        {
            //判断F_Code 不能重复
            int count = service.IQueryable().Count(t => t.F_Code == entity.F_Code && t.F_Id != entity.F_Id);

            if (count == 0)
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
            else
            {
                throw new Exception("已经存在相同编号的站点，请更换一个");
            }
        }
    }
}