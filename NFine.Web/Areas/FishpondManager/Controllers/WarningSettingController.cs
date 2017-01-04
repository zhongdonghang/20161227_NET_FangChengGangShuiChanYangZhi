using NFine.Application.FishpondManager;
using NFine.Application.SystemManage;
using NFine.Code;
using NFine.Domain.Entity.FishpondManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NFine.Web.Areas.FishpondManager.Controllers
{
    public class WarningSettingController : ControllerBase
    {
        //
        // GET: /FishpondManager/WarningSetting/

        private TWarningRuleMainSettingApp objTWarningRuleMainSettingApp = new TWarningRuleMainSettingApp();

        private ItemsDetailApp objItemsDetailApp = new ItemsDetailApp();


        [HttpPost]
        [HandlerAuthorize]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteForm(string keyValue)
        {
            objTWarningRuleMainSettingApp.Delete(objTWarningRuleMainSettingApp.GetForm(keyValue));
            return Success("删除成功。");
        }

        public ActionResult GetWarningCategoryGridJson()
        {
            var data  =  objItemsDetailApp.GetList("bdfec8d8-20e4-4d8a-a7f3-a28ca0fa0555", "");
          //  var data = dutyApp.GetList(keyword);
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(Pagination pagination, string keyword)
        {
            var data = new
            {
                rows = objTWarningRuleMainSettingApp.GetList(pagination, keyword),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetFormJson(string keyValue)
        {
            var data = objTWarningRuleMainSettingApp.GetForm(keyValue);
            return Content(data.ToJson());
        }

        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(TWarningRuleMainSettingEntity objTWarningRuleMainSettingEntity, string keyValue)
        {
            objTWarningRuleMainSettingEntity.F_WarningCategoryItemText = objItemsDetailApp.GetForm(objTWarningRuleMainSettingEntity.F_WarningCategoryItemId).F_ItemName;
            objTWarningRuleMainSettingApp.SubmitForm(objTWarningRuleMainSettingEntity, keyValue);
            return Success("操作成功。");
        }

    }
}
