//-----------------------------------------------------------------------
// <copyright file=" TWarningRuleMainSetting.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: TWarningRuleMainSetting.cs
// * history : Created by T4 01/03/2017 17:22:30 
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
    public class TWarningRuleMainSettingApp
    {
		private ITWarningRuleMainSettingRepository service = new TWarningRuleMainSettingRepository();

		public List<TWarningRuleMainSettingEntity> GetList(Pagination pagination, string queryJson)
        {
		    var expression = ExtLinq.True<TWarningRuleMainSettingEntity>();
            var queryParam = queryJson.ToJObject();
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyword = queryParam["keyword"].ToString();
                expression = expression.And(t => t.F_Title.Contains(keyword));
            }
            return service.FindList(expression, pagination);
        }

	    public TWarningRuleMainSettingEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void Delete(TWarningRuleMainSettingEntity entity)
        {
            service.Delete(entity);
        }

		public void SubmitForm(TWarningRuleMainSettingEntity entity, string keyValue)
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