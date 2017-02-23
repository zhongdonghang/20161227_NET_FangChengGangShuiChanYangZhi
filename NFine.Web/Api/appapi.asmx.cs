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
        /// <param name="orgNo"></param>
        /// </summary>
        [WebMethod(Description = "根据架构编号和设备类型查询设备列表，1：摄像头，2：水体检测仪，3：投料机开关，4：增氧机开关")]
        public void GetDeviceList(string orgNo, string keyword,string deviceType)
        {
            HttpContext.Current.Response.Write(ApiService.GetDeviceList( orgNo,  keyword, deviceType));
        }

        /// <summary>
        /// 查询指定设备的采集数据列表
        /// </summary>
        [WebMethod(Description = "查询指定设备的采集数据列表")]
        public void GetSensorDataByDeviceCode(string F_Device_Code)
        {
            HttpContext.Current.Response.Write(ApiService.GetSensorDataByDeviceId(F_Device_Code));
        }

        //
        [WebMethod(Description = "返回气象监测站列表")]
        public void GetT_Meteorological_StationList()
        {
            HttpContext.Current.Response.Write(ApiService.GetT_Meteorological_StationList());
        }

        [WebMethod(Description = "根据传入的气象监测站代码查询天气数据指标")]
        public void GetT_Weather_Data(string F_Station_Code)
        {
            HttpContext.Current.Response.Write(ApiService.GetT_Weather_Data(F_Station_Code));
        }

    }
}
