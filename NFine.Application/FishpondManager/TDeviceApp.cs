//-----------------------------------------------------------------------
// <copyright file=" TDevice.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: TDevice.cs
// * history : Created by T4 12/28/2016 15:07:16 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Application.SystemManage;
using NFine.Code;
using NFine.Domain.Entity.FishpondManager;
using NFine.Domain.IRepository.FishpondManager;
using NFine.Domain.IRepository.SystemManage;
using NFine.Repository.FishpondManager;
using NFine.Repository.SystemManage;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NFine.Application.FishpondManager
{
    public class TDeviceApp
    {
		private ITDeviceRepository service = new TDeviceRepository();

        private IOrganizeRepository objIOrganizeRepository = new OrganizeRepository();
        private ITDeviceTypeRepository objITDeviceTypeRepository = new TDeviceTypeRepository();

        /// <summary>
        /// 根据组织机构节点获取设备列表
        /// </summary>
        /// <param name="orgNo"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public List<TDeviceEntity> GetList(string orgNo, string keyword)
        {
            var expression = ExtLinq.True<TDeviceEntity>();
            if (!string.IsNullOrEmpty(orgNo))
            {
                expression = expression.And(t => t.F_OrgNo == orgNo);
            }
            if (!string.IsNullOrEmpty(keyword))
            {
                expression = expression.And(t => t.F_CName.Contains(keyword));
                expression = expression.Or(t => t.F_Code.Contains(keyword));
            }
            return service.IQueryable(expression).OrderBy(t => t.F_SortCode).ToList();
        }


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
            //判断F_Code 不能重复
           int count  = service.IQueryable().Count(t => t.F_Code == entity.F_Code && t.F_Id != keyValue);

            //获取类别名称和所属机构名称
            string orgName =  objIOrganizeRepository.FindEntity(entity.F_OrgNo).F_FullName;
            string categoryName = objITDeviceTypeRepository.FindEntity(entity.F_Category_Id).F_Category_Name;
            entity.F_Org_Name = orgName;
            entity.F_Category_Name = categoryName;
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
                throw new Exception("已经存在相同的设备编号，请更换一个");
            }
        }
    }
}