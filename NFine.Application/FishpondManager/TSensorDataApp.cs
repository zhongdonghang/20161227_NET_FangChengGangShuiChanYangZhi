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
using NFine.Domain._02_ViewModel.RptFishpond;
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


        /// <summary>
        /// 设备编号
        /// </summary>
        /// <param name="itemId"></param>
        /// <returns></returns>
        public RptWaterQualityAnalyzer GetReportForWaterQualityAnalyzer(string itemId)
        {
            RptWaterQualityAnalyzer rpt = new RptWaterQualityAnalyzer();

            var expression = ExtLinq.True<TSensorDataEntity>();
            List<TSensorDataEntity> list = service.IQueryable(t => t.F_Device_Code == itemId).OrderByDescending(t=>t.F_CreatorTime).Take(12).ToList();
            if (list.Count > 0)
            {
                rpt.Title = list[0].F_Device_Name + "最近12小时水体趋势报表";
            }
            else
            {
                rpt = null;
                return rpt;
            }
            
            rpt.F_PHValues = new List<string>();
            rpt.TemperatureValues = new List<string>();
            rpt.DOValues = new List<string>();
            foreach (TSensorDataEntity item in list)
            {
                rpt.F_PHValues.Add(item.F_PH);
                rpt.TemperatureValues.Add(item.F_Water_Temperature);
                rpt.DOValues.Add(item.F_Dissolved_Oxygen);
            }
            return rpt;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemId"></param>
        /// <returns></returns>
        public List<TSensorDataEntity> GetList(string itemId)
        {
            var expression = ExtLinq.True<TSensorDataEntity>();
            List<TSensorDataEntity> list = service.IQueryable(t => t.F_OrgNo == itemId).Take(12).ToList();
            return list;
        }

        public List<TSensorDataEntity> GetList(Pagination pagination, string keyword , string itemId)
        {
            var expression = ExtLinq.True<TSensorDataEntity>();
          
            if (!string.IsNullOrEmpty(keyword))
            {
                expression = expression.And(t => t.F_Device_Name.Contains(keyword));
                expression = expression.Or(t => t.F_Device_Code.Contains(keyword));
            }

            expression = expression.And(t => t.F_OrgNo==itemId);

            List<TSensorDataEntity> list = service.FindList(expression, pagination);
            return list;
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