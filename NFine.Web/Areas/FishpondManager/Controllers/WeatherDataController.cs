using NFine.Application.FishpondManager;
using NFine.Application.Meteorological;
using NFine.Code;
using NFine.Domain.Entity.Meteorological;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NFine.Web.Areas.FishpondManager.Controllers
{
    public class WeatherDataController : ControllerBase
    {
        //
        // GET: /FishpondManager/WeatherData/

        private TWeatherDataApp objTWeatherDataApp = new TWeatherDataApp();

        private TMeteorologicalStationApp objTMeteorologicalStationApp = new TMeteorologicalStationApp();

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(Pagination pagination, string keyword, string itemId)
        {
            var data = new
            {
                rows = objTWeatherDataApp.GetList(pagination, keyword, itemId),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }

        public ActionResult GetTreeJson()
        {
            var data = objTMeteorologicalStationApp.GetList();
            var treeList = new List<TreeViewModel>();

            TreeViewModel root = new TreeViewModel();
            root.hasChildren = true;
            root.id = "root";
            root.text = "气象监测站根节点";
            root.value = "root";
            root.parentId = "0";
            root.isexpand = true;
            root.complete = true;
            treeList.Add(root);
            foreach (TMeteorologicalStationEntity item in data)
            {
                TreeViewModel tree = new TreeViewModel();
               // bool hasChildren = data.Count(t => t.F_ParentId == item.F_Id) == 0 ? false : true;
                tree.id = item.F_Code;
                tree.text = item.F_Station_Name;
                tree.value = item.F_Code;
                tree.parentId = "root";
                tree.isexpand = true;
                tree.complete = true;
                tree.hasChildren = false;
                treeList.Add(tree);
            }
            return Content(treeList.TreeViewJson("root"));
        }

    }
}
