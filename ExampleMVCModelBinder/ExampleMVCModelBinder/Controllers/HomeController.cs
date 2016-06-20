using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleMVCModelBinder.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Foo类型标记了ModelBinder
        /// </summary>
        /// <param name="foo"></param>
        /// <returns></returns>
        public ActionResult Foo(Models.Foo foo)
        {
            return Json(foo, JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// 参数上标记的ModelBinder会覆盖Foo类型上标记的ModelBinder
        /// </summary>
        /// <param name="foo"></param>
        /// <returns></returns>
        public ActionResult Fox([ModelBinder(typeof(Models.FoxModelBinder))]Models.Foo foo)
        {
            return Json(foo, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 参数标记ModelBinder
        /// </summary>
        /// <param name="bar"></param>
        /// <returns></returns>
        public ActionResult Bar([ModelBinder(typeof(Models.BarModelBinder))]Models.Bar bar)
        {
            return Json(bar, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 使用DefaultModelBinder
        /// /baz?Name=baz&Desc=hehe
        /// </summary>
        /// <param name="bar"></param>
        /// <returns></returns>
        public ActionResult Baz(Models.Bar bar)
        {
            return Json(bar, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 使用ModelBinderProviders来注册ModelBinder
        /// 详见 Global.asax.cs 
        /// </summary>
        /// <param name="lee"></param>
        /// <returns></returns>
        public ActionResult Lee(Models.Lee lee)
        {
            return Json(lee, JsonRequestBehavior.AllowGet);
        }
    }
}