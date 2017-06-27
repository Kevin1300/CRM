using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM11.UI.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        /// <summary>
        /// Action 方法
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            //获取业务仓储对象
            IService.IServiceSession bllSession = Utility.DI.GetObject<IService.IServiceSession>("bllSession");

            //直接通过业务仓储对象 里的 业务子接口属性 来完成操作
            bllSession.Role.Remove(new MODEL.Role() { roleId = 3 });
            bllSession.Role.Remove(new MODEL.Role() { roleId =2 });

            //MODEL.Department dep = new MODEL.Department()
            //{
            //    depRemark = "123123asdf",
            //    depIsDel = false,
            //    depAddTime = DateTime.Now
            //};

            //bllSession.Department.Add(dep);


            //bllSession.SaveChange();
            return View();
        }

    }
}
