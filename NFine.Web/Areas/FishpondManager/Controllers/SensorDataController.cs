using NFine.Application.FishpondManager;
using NFine.Application.SystemManage;
using NFine.Code;
using NFine.Domain.Entity.SystemManage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NFine.Web.Areas.FishpondManager.Controllers
{
    public class SensorDataController : ControllerBase
    {
        private OrganizeApp organizeApp = new OrganizeApp();
        private TDeviceApp objTDeviceApp = new TDeviceApp();
        private TDeviceTypeApp objTDeviceTypeApp = new TDeviceTypeApp();

        private TSensorDataApp objTSensorDataApp = new TSensorDataApp();
        //
        // GET: /FishpondManager/SensorData/

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(Pagination pagination, string keyword,string itemId)
        {
            var data = new
            {
                rows = objTSensorDataApp.GetList(pagination, keyword, itemId),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
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

    }
}
