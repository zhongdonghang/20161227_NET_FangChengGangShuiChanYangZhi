using NFine.Application.FishpondManager;
using NFine.Application.SystemManage;
using NFine.Code;
using NFine.Domain._02_ViewModel.RptFishpond;
using NFine.Domain.Entity.FishpondManager;
using NFine.Domain.Entity.SystemManage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NFine.Web.Areas.FishpondManager.Controllers
{
    /// <summary>
    /// 水体数据趋势
    /// </summary>
    public class WaterQualityAnalyzerController : ControllerBase
    {
        //
        // GET: /FishpondManager/WaterQualityAnalyzer/
        private OrganizeApp organizeApp = new OrganizeApp();
        private TSensorDataApp objTSensorDataApp = new TSensorDataApp();

        private TDeviceApp objTDeviceApp = new TDeviceApp();

        /// <summary>
        /// 根据组织架构ID查询拥有的水体检测仪传感器设备
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetDeviceGridJson(string orgNo)
        {
            var data = objTDeviceApp.GetWaterList(orgNo, string.Empty);
            return Content(data.ToJson());
        }

        /// <summary>
        /// 加载左边当前登录用户的组织架构
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetTreeJson()
        {
            var data = organizeApp.GetList(OperatorProvider.Provider.GetCurrent().OrganizeId);
            var treeList = new List<TreeViewModel>();

            foreach (OrganizeEntity item in data)
            {
                TreeViewModel tree = new TreeViewModel();
                bool hasChildren = data.Count(t => t.F_ParentId == item.F_Id) == 0 ? false : true;
                tree.id = item.F_Id;
                tree.text = item.F_FullName;
                tree.value = item.F_EnCode;
                tree.parentId = item.F_ParentId;
                tree.isexpand = true;
                tree.complete = true;
                tree.hasChildren = hasChildren;
                treeList.Add(tree);
            }

 

            return Content(treeList.TreeViewJson(data[0].F_Id));
        }


        /// <summary>
        /// 获取指定设备的数据报表
        /// </summary>
        /// <param name="itemId">设备编号</param>
        /// <returns></returns>
        public ActionResult CreateRptLastPage(string itemId)
        {
            ViewResult vr = new ViewResult();
            vr.ViewName = "Index";
            RptWaterQualityAnalyzer  rpt= objTSensorDataApp.GetReportForWaterQualityAnalyzer(itemId);
            ViewDataDictionary dic = new ViewDataDictionary(rpt);
            vr.ViewData = dic;
            return vr;
        }

    }
}
