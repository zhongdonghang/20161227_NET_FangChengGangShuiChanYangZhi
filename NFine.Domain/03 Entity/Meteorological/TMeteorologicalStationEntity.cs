//-----------------------------------------------------------------------
// <copyright file=" TMeteorologicalStation.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: TMeteorologicalStation.cs
// * history : Created by T4 12/29/2016 16:23:07 
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Domain.Entity.Meteorological
{
    /// <summary>
    /// TMeteorologicalStation Entity Model
    /// </summary>
    public class TMeteorologicalStationEntity : IEntity<TMeteorologicalStationEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
						public  String  F_Id { get; set; }
					public  String  F_Code { get; set; }
					public  String  F_Station_Name { get; set; }
					public  String  F_Station_Address { get; set; }
					public  String  F_Station_Address_X { get; set; }
					public  String  F_Station_Address_Y { get; set; }
					public  String  F_OrgNo { get; set; }
					public  String  F_Org_Name { get; set; }
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