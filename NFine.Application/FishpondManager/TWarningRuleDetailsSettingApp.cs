//-----------------------------------------------------------------------
// <copyright file=" TWarningRuleDetailsSetting.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: TWarningRuleDetailsSetting.cs
// * history : Created by T4 01/03/2017 17:22:37 
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
    public class TWarningRuleDetailsSettingApp
    {
		private ITWarningRuleDetailsSettingRepository service = new TWarningRuleDetailsSettingRepository();

		public List<TWarningRuleDetailsSettingEntity> GetList(Pagination pagination, string queryJson)
        {
		    var expression = ExtLinq.True<TWarningRuleDetailsSettingEntity>();
            var queryParam = queryJson.ToJObject();
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyword = queryParam["keyword"].ToString();
              //  expression = expression.And(t => t..Contains(keyword));
            }
            return service.FindList(expression, pagination);
        }

	    public TWarningRuleDetailsSettingEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void Delete(TWarningRuleDetailsSettingEntity entity)
        {
            service.Delete(entity);
        }

		public void SubmitForm(TWarningRuleDetailsSettingEntity entity, string keyValue)
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