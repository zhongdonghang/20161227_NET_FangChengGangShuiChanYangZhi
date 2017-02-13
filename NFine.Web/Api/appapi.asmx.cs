using NFine.Application.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace NFine.Web.Api
{
    /// <summary>
    /// appapi 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://nnbetter.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class appapi : System.Web.Services.WebService
    {

        /// <summary>
        /// app登录接口
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        [WebMethod(Description ="app登录，传入用户名和密码")]
        public void AppLogin(string username, string password)
        {
            HttpContext.Current.Response.Write(ApiService.AppLogin(username,password));
        }

        /// <summary>
        /// 根据用户主键查询组织架构列表
        /// </summary>
        [WebMethod(Description = "根据用户主键查询组织架构列表")]
        public void GetTreeForUser(string UserId)
        {
            HttpContext.Current.Response.Write(ApiService.GetTreeForUser(UserId));
        }

        /// <summary>
        /// 查询设备类型列表
        /// </summary>
        [WebMethod(Description = "查询设备类型列表")]
        public void GetDeviceTypeList()
        {
            HttpContext.Current.Response.Write(ApiService.GetDeviceTypeList());
        }

        /// <summary>
        /// 查询设备列表
        /// </summary>
        [WebMethod(Description = "查询设备列表")]
        public void GetDeviceList(string orgNo, string keyword)
        {
            HttpContext.Current.Response.Write(ApiService.GetDeviceList( orgNo,  keyword));
        }
    }
}
