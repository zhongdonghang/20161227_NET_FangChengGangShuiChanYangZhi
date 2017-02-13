using Newtonsoft.Json;
using NFine.Application.FishpondManager;
using NFine.Application.SystemManage;
using NFine.Application.SystemSecurity;
using NFine.Code;
using NFine.Domain.Entity.FishpondManager;
using NFine.Domain.Entity.SystemManage;
using NFine.Domain.Entity.SystemSecurity;
using NFine.Domain.IRepository.SystemManage;
using NFine.Repository.SystemManage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//测试git
namespace NFine.Application.WebApi
{
    /// <summary>
    /// 专供app使用的api服务接口
    /// </summary>
    public class ApiService
    {
        //private IUserRepository userService = new UserRepository();

        //用户注册接口

        //用户登录接口
        public static string AppLogin(string username, string password)
        {
            string resultString = "";
            ApiResultForObject<OperatorModel> obj = new ApiResultForObject<OperatorModel>();
            LogEntity logEntity = new LogEntity();
            logEntity.F_ModuleName = "系统登录";
            logEntity.F_Type = DbLogType.Login.ToString();
            try
            {
                UserEntity userEntity = new UserApp().CheckLogin(username, password);
                if (userEntity != null)
                {
                    OperatorModel operatorModel = new OperatorModel();
                    operatorModel.UserId = userEntity.F_Id;
                    operatorModel.UserCode = userEntity.F_Account;
                    operatorModel.UserName = userEntity.F_RealName;
                    operatorModel.OrganizeId = userEntity.F_OrganizeId;
                    operatorModel.CompanyId = userEntity.F_OrganizeId;
                    operatorModel.DepartmentId = userEntity.F_DepartmentId;
                    operatorModel.RoleId = userEntity.F_RoleId;
                    operatorModel.LoginIPAddress = Net.Ip;
                    operatorModel.LoginIPAddressName = Net.GetLocation(operatorModel.LoginIPAddress);
                    operatorModel.LoginTime = DateTime.Now;
                    operatorModel.LoginToken = DESEncrypt.Encrypt(Guid.NewGuid().ToString());
                    if (userEntity.F_Account == "admin")
                    {
                        operatorModel.IsSystem = true;
                    }
                    else
                    {
                        operatorModel.IsSystem = false;
                    }
                    OperatorProvider.Provider.AddCurrent(operatorModel);
                    logEntity.F_Account = userEntity.F_Account;
                    logEntity.F_NickName = userEntity.F_RealName;
                    logEntity.F_Result = true;
                    logEntity.F_Description = logEntity.F_Account+ "在App登录成功";
                    new LogApp().WriteDbLog(logEntity);

                    obj.Msg = logEntity.F_Account + "在App登录成功";
                    obj.ResultCode = "0";
                    obj.t = operatorModel;
                }
            }
            catch (Exception ex)
            {
                logEntity.F_Account = username;
                logEntity.F_NickName = username;
                logEntity.F_Result = false;
                logEntity.F_Description = logEntity.F_Account = username+"在App登录失败，" + ex.Message;
                new LogApp().WriteDbLog(logEntity);

                obj.Msg = logEntity.F_Account + "在App登录失败，" + ex.Message;
                obj.ResultCode = "-1";
                obj.t = null;
            }
            resultString = JsonConvert.SerializeObject(obj);
            return resultString;
        }

        //获取指定用户的组织架构列表
        public static string GetTreeForUser(string UserId)
        {
            string resultString = "";
            var treeList = new List<TreeViewModel>();
            ApiResultForObject<List<TreeViewModel>> obj = new ApiResultForObject<List<TreeViewModel>>();

            try
            {
                UserEntity userEntity = new UserRepository().FindEntity(t => t.F_Id == UserId);
                var data = new OrganizeApp().GetList(userEntity.F_OrganizeId);
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
                obj.Msg = "操作成功";
                obj.ResultCode = "0";
                obj.t = treeList;
            }
            catch (Exception ex)
            {
                obj.Msg = UserId + "用户查询组织架构出错，" + ex.Message;
                obj.ResultCode = "-1";
                obj.t = null;
            }
            resultString = JsonConvert.SerializeObject(obj);
            return resultString;
        }

        //获取设备类型
        public static string GetDeviceTypeList()
        {
            ApiResultForList<TDeviceTypeEntity> obj = new ApiResultForList<TDeviceTypeEntity>();
            try
            {
                TDeviceTypeApp objTDeviceTypeApp = new TDeviceTypeApp();
                List<TDeviceTypeEntity> list = objTDeviceTypeApp.GetList();
                obj.Msg = "查询成功";
                obj.Page = list;
                obj.ResultCode = "0";
            }
            catch (Exception ex)
            {
                obj.Msg = "查询设备类型列表出错：" + ex.Message;
                obj.ResultCode = "-1";
            }

            string  resultString = JsonConvert.SerializeObject(obj);
            return resultString;
        }


        //获取指定组织架构拥有的设备列表
        public static string GetDeviceList(string orgNo, string keyword)
        {
            ApiResultForList<TDeviceEntity> obj = new ApiResultForList<TDeviceEntity>();
            try
            {
                TDeviceApp objTDeviceApp = new TDeviceApp();
                List<TDeviceEntity> list = objTDeviceApp.GetList(orgNo,keyword);
                obj.Msg = "查询成功";
                obj.Page = list;
                obj.ResultCode = "0";
            }
            catch (Exception ex)
            {
                obj.Msg = "查询设备列表出错：" + ex.Message;
                obj.ResultCode = "-1";
            }

            string resultString = JsonConvert.SerializeObject(obj);
            return resultString;
        }



        //获取指定组织架构基地的水质数据

        //获取指定气象采集站的气象数据

        //获取指定基地的摄像头列表

        //获取指定设备的开关列表


    }
}
