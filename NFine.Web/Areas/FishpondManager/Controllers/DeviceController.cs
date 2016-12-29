using NFine.Application.FishpondManager;
using NFine.Application.SystemManage;
using NFine.Code;
using NFine.Domain.Entity.FishpondManager;
using NFine.Domain.Entity.SystemManage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NFine.Web.Areas.FishpondManager.Controllers
{
    public class DeviceController : ControllerBase
    {
        //
        // GET: /FishpondManager/Device/
        private OrganizeApp organizeApp = new OrganizeApp();
        private TDeviceApp objTDeviceApp = new TDeviceApp();
        private TDeviceTypeApp objTDeviceTypeApp = new TDeviceTypeApp();

        //[HttpPost]
        //[HandlerAjaxOnly]
        //[HandlerAuthorize]
        //[ValidateAntiForgeryToken]
        public ActionResult DeleteForm(string keyValue)
        {
            objTDeviceApp.Delete(objTDeviceApp.GetForm(keyValue));
            return Success("删除成功。");
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetFormJson(string keyValue)
        {
            var data = objTDeviceApp.GetForm(keyValue);
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(string itemId, string keyword)
        {
            var data = objTDeviceApp.GetList(itemId, keyword);
            return Content(data.ToJson());
        }

        /// <summary>
        /// 提交添加和编辑
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(TDeviceEntity entity, string keyValue)
        {
          //  entity.F_OrgNo = OperatorProvider.Provider.GetCurrent().OrganizeId;
            entity.F_HeadIcon = "-";
            entity.F_DeleteMark = false;
            entity.F_EnabledMark = true;
            objTDeviceApp.SubmitForm(entity, keyValue);
            return Success("操作成功。");
        }

        /// <summary>
        /// 获取设备类型下拉列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetCategorySelectJson()
        {
            var data = objTDeviceTypeApp.GetList();
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetTreeSelectJson()
        {
           var data = organizeApp.GetList(OperatorProvider.Provider.GetCurrent().OrganizeId);
            data.RemoveAt(0);
            return Content(data.ToJson());
            //var treeList = new List<TreeSelectModel>();
            //foreach (OrganizeEntity item in data)
            //{
            //    TreeSelectModel treeModel = new TreeSelectModel();
            //    treeModel.id = item.F_Id;
            //    treeModel.text = item.F_FullName;
            //    treeModel.parentId = item.F_ParentId;
            //    treeModel.data = item;
            //    treeList.Add(treeModel);
            //}
            //return Content(treeList.TreeSelectJson());
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
