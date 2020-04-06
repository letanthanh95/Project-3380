using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace zooProject.Controllers
{
    public class ShopController : Controller
    {
        //
        // GET: /Shop/

        public ActionResult ShopIndex()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            return View();
        }

    }
}
