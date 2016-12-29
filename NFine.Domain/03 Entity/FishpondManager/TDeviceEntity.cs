//-----------------------------------------------------------------------
// <copyright file=" TDevice.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: TDevice.cs
// * history : Created by T4 12/28/2016 15:07:16 
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Domain.Entity.FishpondManager
{
    /// <summary>
    /// TDevice Entity Model
    /// </summary>
    public class TDeviceEntity : IEntity<TDeviceEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
        public String F_Id { get; set; }
        public String F_Code { get; set; }
        public String F_Category_Id { get; set; }

        public string F_Category_Name { get; set; }

        public String F_CName { get; set; }
        public String F_OrgNo { get; set; }

        public string F_Org_Name { get; set; }

        public String F_HeadIcon { get; set; }
        public Int32? F_SortCode { get; set; }
        public Boolean? F_DeleteMark { get; set; }
        public Boolean? F_EnabledMark { get; set; }
        public String F_Description { get; set; }
        public DateTime? F_CreatorTime { get; set; }
        public String F_CreatorUserId { get; set; }
        public DateTime? F_LastModifyTime { get; set; }
        public String F_LastModifyUserId { get; set; }
        public DateTime? F_DeleteTime { get; set; }
        public String F_DeleteUserId { get; set; }
    }
}