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
    public class DeviceController : ControllerBase
    {
        //
        // GET: /FishpondManager/Device/

        private OrganizeApp organizeApp = new OrganizeApp();

        public ActionResult Index()
        {
            return View();
        }

        private ItemsApp itemsApp = new ItemsApp();


        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetTreeJson()
        {
            //var data = organizeApp.GetList();
            var data = organizeApp.GetList(OperatorProvider.Provider.GetCurrent().OrganizeId);
            var treeList = new List<TreeViewModel>();

            string testString = "";

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

                testString += tree.GetString() + "$$\n";

                treeList.Add(tree);
            }
            return Content(treeList.TreeViewJson(data[0].F_Id));
        }

    }
}
