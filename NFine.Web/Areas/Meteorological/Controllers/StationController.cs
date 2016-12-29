using NFine.Application.Meteorological;
using NFine.Code;
using NFine.Domain.Entity.Meteorological;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NFine.Web.Areas.Meteorological.Controllers
{
    public class StationController : ControllerBase
    {
        //
        // GET: /Meteorological/Station/

        TMeteorologicalStationApp objTMeteorologicalStationApp = new TMeteorologicalStationApp();

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(Pagination pagination, string keyword)
        {
            var data = new
            {
                rows = objTMeteorologicalStationApp.GetList(pagination, keyword),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }

        public ActionResult DeleteForm(string keyValue)
        {
            objTMeteorologicalStationApp.Delete(objTMeteorologicalStationApp.GetForm(keyValue));
            return Success("删除成功。");
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetFormJson(string keyValue)
        {
            var data = objTMeteorologicalStationApp.GetForm(keyValue);
            return Content(data.ToJson());
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(TMeteorologicalStationEntity objTMeteorologicalStationEntity, string keyValue)
        {
            objTMeteorologicalStationApp.SubmitForm(objTMeteorologicalStationEntity, keyValue);
            return Success("操作成功。");
        }

    }
}
