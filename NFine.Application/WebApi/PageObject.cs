﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NFine.Application.WebApi
{

    /// <summary>
    /// 页对象
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PageObject<T>
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int PageCount { get; set; }
        public int RecordCount { get; set; }
        public IList<T> Data { get; set; }
    }

    /// <summary>
    /// API返回的页对象
    /// </summary>
    public class ApiResultForList<T>
    {
        public string ResultCode { get; set; }
        public string Msg { get; set; }
        public List<T> Page { get; set; }
    }

    /// <summary>
    /// API返回的页对象
    /// </summary>
    public class ApiResultForPage<T>
    {
        public string ResultCode { get; set; }
        public string Msg { get; set; }
        public PageObject<T> Page{get;set;}
    }

    /// <summary>
    /// api操作返回结果（带对象）
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ApiResultForObject<T>
    {
        public string ResultCode { get; set; }

        public string Msg { get; set; }

        public T t;
    }

    /// <summary>
    /// api操作返回结果，不带对象
    /// </summary>
    public class ApiResultForNoReturn
    {
        public string ResultCode { get; set; }

        public string Msg { get; set; }
    }
}