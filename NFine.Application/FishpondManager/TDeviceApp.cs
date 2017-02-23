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
        /// ������֯�����ڵ��ȡ�����豸�б�
        /// </summary>
        /// <param name="orgNo"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public List<TDeviceEntity> GetCircuitList(string orgNo, string keyword)
        {
            var expression = ExtLinq.True<TDeviceEntity>();
            //if (!string.IsNullOrEmpty(orgNo))
            //{
                expression = expression.And(t => t.F_OrgNo == orgNo);
                expression = expression.And(t => t.F_Category_Name.Contains("����"));
          //  }
            if (!string.IsNullOrEmpty(keyword))
            {
                expression = expression.And(t => t.F_CName.Contains(keyword));
                expression = expression.Or(t => t.F_Code.Contains(keyword));
            }
            return service.IQueryable(expression).OrderBy(t => t.F_SortCode).ToList();
        }

        /// <summary>
        /// ������֯�����ڵ��ȡ����ͷ�豸�б�
        /// </summary>
        /// <param name="orgNo"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public List<TDeviceEntity> GetCameraList(string orgNo, string keyword)
        {
            var expression = ExtLinq.True<TDeviceEntity>();
            //if (!string.IsNullOrEmpty(orgNo))
            //{
                expression = expression.And(t => t.F_OrgNo == orgNo);
                expression = expression.And(t => t.F_Category_Name.Contains("����ͷ"));
           // }
            if (!string.IsNullOrEmpty(keyword))
            {
                expression = expression.And(t => t.F_CName.Contains(keyword));
                expression = expression.Or(t => t.F_Code.Contains(keyword));
            }
            return service.IQueryable(expression).OrderBy(t => t.F_SortCode).ToList();
        }


        /// <summary>
        /// ������֯�����ڵ��ȡˮ�崫�����豸�б�
        /// </summary>
        /// <param name="orgNo"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public List<TDeviceEntity> GetWaterList(string orgNo, string keyword)
        {
            var expression = ExtLinq.True<TDeviceEntity>();
            //if (!string.IsNullOrEmpty(orgNo))
            //{
                expression = expression.And(t => t.F_OrgNo == orgNo);
                expression = expression.And(t => t.F_Category_Name.Contains("ˮ������"));
           // }
            if (!string.IsNullOrEmpty(keyword))
            {
                expression = expression.And(t => t.F_CName.Contains(keyword));
           
                expression = expression.Or(t => t.F_Code.Contains(keyword));
            }
            return service.IQueryable(expression).OrderBy(t => t.F_SortCode).ToList();
        }

        /// <summary>
        /// ������֯�����ڵ��ȡ�豸�б�
        /// </summary>
        /// <param name="orgNo"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public List<TDeviceEntity> GetList(string orgNo, string keyword)
        {
            var expression = ExtLinq.True<TDeviceEntity>();
            expression = expression.And(t => t.F_OrgNo == orgNo);
            if (!string.IsNullOrEmpty(keyword))
            {
                expression = expression.And(t => t.F_CName.Contains(keyword));
                expression = expression.Or(t => t.F_Code.Contains(keyword));
            }
            return service.IQueryable(expression).OrderBy(t => t.F_SortCode).ToList();
        }


        /// <summary>
        /// ������֯�����ڵ��ȡ�豸�б�
        /// </summary>
        /// <param name="orgNo"></param>
        /// <param name="keyword"></param>
        /// <param name="deviceType"></param>
        /// <returns></returns>
        public List<TDeviceEntity> GetListByDeviceType(string orgNo, string keyword, string deviceType)
        {
            var expression = ExtLinq.True<TDeviceEntity>();
                expression = expression.And(t => t.F_OrgNo == orgNo);
            if (!string.IsNullOrEmpty(keyword))
            {
                expression = expression.And(t => t.F_CName.Contains(keyword));
               
                expression = expression.Or(t => t.F_Code.Contains(keyword));
            }
            expression = expression.And(t => t.F_Category_Id.Equals(deviceType));
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
            //�ж�F_Code �����ظ�
           int count  = service.IQueryable().Count(t => t.F_Code == entity.F_Code && t.F_Id != keyValue);

            //��ȡ������ƺ�������������
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
                throw new Exception("�Ѿ�������ͬ���豸��ţ������һ��");
            }
        }
    }
}