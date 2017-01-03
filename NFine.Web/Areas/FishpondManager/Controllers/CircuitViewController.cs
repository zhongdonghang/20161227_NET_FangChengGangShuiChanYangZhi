using NFine.Application.FishpondManager;
using NFine.Application.SystemManage;
using NFine.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NFine.Web.Areas.FishpondManager.Controllers
{
    public class CircuitViewController : ControllerBase
    {
        //
        // GET: /FishpondManager/CircuitView/

        private TDeviceApp objTDeviceApp = new TDeviceApp();
        //
        // GET: /FishpondManager/CameraView/
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(string itemId, string keyword)
        {
            var data = objTDeviceApp.GetCircuitList(itemId, keyword);
            return Content(data.ToJson());
        }
    }
}
