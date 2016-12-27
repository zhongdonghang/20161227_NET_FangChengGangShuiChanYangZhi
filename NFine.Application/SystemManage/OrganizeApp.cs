/*******************************************************************************
 * Copyright © 2016 NFine.Framework 版权所有
 * Author: NFine
 * Description: NFine快速开发平台
 * Website：http://www.nfine.cn
*********************************************************************************/
using NFine.Domain.Entity.SystemManage;
using NFine.Domain.IRepository.SystemManage;
using NFine.Repository.SystemManage;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NFine.Application.SystemManage
{
    public class OrganizeApp
    {
        private IOrganizeRepository service = new OrganizeRepository();

        #region 钟东航扩展方法
        /// <summary>
        /// 根据组织架构节点ID来查询
        /// </summary>
        /// <param name="nodeID"></param>
        /// <returns>指定节点以及下属子节点，叶子节点</returns>
        public List<OrganizeEntity> GetList(string nodeID)
        {
            string sql = "with temp(F_Id,F_FullName,F_ParentId,F_Layers,F_EnCode,F_ShortName,"+
" F_CategoryId,F_ManagerId,F_TelePhone,F_MobilePhone,F_WeChat,F_Fax,F_Email,"+
" F_AreaId,F_Address,F_AllowEdit,F_AllowDelete,F_SortCode,F_DeleteMark,"+
" F_EnabledMark,F_Description,F_CreatorTime,F_CreatorUserId,F_LastModifyTime,"+
" F_LastModifyUserId,F_DeleteTime,F_DeleteUserId) as " +
                " ( " +
                "   select F_Id,F_FullName,F_ParentId,F_Layers,F_EnCode,F_ShortName,"+
"F_CategoryId,F_ManagerId,F_TelePhone,F_MobilePhone,F_WeChat,F_Fax,F_Email,"+
" F_AreaId,F_Address,F_AllowEdit,F_AllowDelete,F_SortCode,F_DeleteMark,"+
" F_EnabledMark,F_Description,F_CreatorTime,F_CreatorUserId,F_LastModifyTime,"+
" F_LastModifyUserId,F_DeleteTime,F_DeleteUserId from Sys_Organize ou " +
                "   where ou.F_ParentId = (select F_ParentId from Sys_Organize " +
                "   where F_Id = '"+ nodeID + "') " +
                "   and ou.F_Id = '"+ nodeID + "' " +
                "   union all " +
                "   select ou.F_Id,ou.F_FullName,ou.F_ParentId,ou.F_Layers,ou.F_EnCode,ou.F_ShortName," +
                "  ou.F_CategoryId,ou.F_ManagerId,ou.F_TelePhone,ou.F_MobilePhone,ou.F_WeChat,ou.F_Fax,ou.F_Email," +
                " ou.F_AreaId,ou.F_Address,ou.F_AllowEdit,ou.F_AllowDelete,ou.F_SortCode,ou.F_DeleteMark," +
                " ou.F_EnabledMark,ou.F_Description,ou.F_CreatorTime,ou.F_CreatorUserId,ou.F_LastModifyTime," +
                " ou.F_LastModifyUserId,ou.F_DeleteTime,ou.F_DeleteUserId from Sys_Organize ou, temp tm " +
                "    where ou.F_ParentId = tm.F_Id " +
                " ) " +
                " select* from temp   go";
            return service.FindList(sql);
           // return service.IQueryable().OrderBy(t => t.F_CreatorTime).ToList();
        } 
        #endregion

        public List<OrganizeEntity> GetList()
        {
            return service.IQueryable().OrderBy(t => t.F_CreatorTime).ToList();
        }
        public OrganizeEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }
        public void DeleteForm(string keyValue)
        {
            if (service.IQueryable().Count(t => t.F_ParentId.Equals(keyValue)) > 0)
            {
                throw new Exception("删除失败！操作的对象包含了下级数据。");
            }
            else
            {
                service.Delete(t => t.F_Id == keyValue);
            }
        }
        public void SubmitForm(OrganizeEntity organizeEntity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                organizeEntity.Modify(keyValue);
                service.Update(organizeEntity);
            }
            else
            {
                organizeEntity.Create();
                service.Insert(organizeEntity);
            }
        }
    }
}
