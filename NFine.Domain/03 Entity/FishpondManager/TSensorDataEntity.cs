//-----------------------------------------------------------------------
// <copyright file=" TSensorData.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: TSensorData.cs
// * history : Created by T4 12/29/2016 15:24:18 
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
    /// TSensorData Entity Model
    /// </summary>
    public class TSensorDataEntity : IEntity<TSensorDataEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
						public  String  F_Id { get; set; }
					public  String  F_Code { get; set; }
					public  String  F_Address { get; set; }
					public  String  F_Address_X { get; set; }
					public  String  F_Address_Y { get; set; }
					public  String  F_Category_Id { get; set; }
					public  String  F_Category_Name { get; set; }
					public  String  F_OrgNo { get; set; }
					public  String  F_Org_Name { get; set; }
					public  String  F_Device_Code { get; set; }
					public  String  F_Device_Name { get; set; }
					public  String  F_PH { get; set; }
					public  String  F_Water_Temperature { get; set; }
					public  String  F_Dissolved_Oxygen { get; set; }
					public  String  F_Salinity { get; set; }
					public  String  F_Ammonia { get; set; }
					public  String  F_Nitrogen { get; set; }
					public  Int32?  F_SortCode { get; set; }
					public  Boolean?  F_DeleteMark { get; set; }
					public  Boolean?  F_EnabledMark { get; set; }
					public  String  F_Description { get; set; }
					public  DateTime?  F_CreatorTime { get; set; }
					public  String  F_CreatorUserId { get; set; }
					public  DateTime?  F_LastModifyTime { get; set; }
					public  String  F_LastModifyUserId { get; set; }
					public  DateTime?  F_DeleteTime { get; set; }
					public  String  F_DeleteUserId { get; set; }
		    }
}