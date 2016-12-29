//-----------------------------------------------------------------------
// <copyright file=" TWeatherData.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: TWeatherData.cs
// * history : Created by T4 12/29/2016 15:24:27 
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
    /// TWeatherData Entity Model
    /// </summary>
    public class TWeatherDataEntity : IEntity<TWeatherDataEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
						public  String  F_Id { get; set; }
					public  String  F_Code { get; set; }
					public  String  F_Address { get; set; }
					public  String  F_Address_X { get; set; }
					public  String  F_Address_Y { get; set; }
					public  String  F_Station_Code { get; set; }
					public  String  F_Station { get; set; }
					public  String  F_Temperature { get; set; }
					public  String  F_Rainfall { get; set; }
					public  String  F_WindForce { get; set; }
					public  String  F_WindDirection { get; set; }
					public  String  F_Visibility { get; set; }
					public  String  F_Humidity { get; set; }
					public  String  F_Pressure { get; set; }
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