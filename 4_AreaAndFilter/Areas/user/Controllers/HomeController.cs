using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _4_AreaAndFilter.Areas.user.Controllers
{
    [RouteArea("user")]
    public class HomeController : Controller
    {
        // GET: user/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}