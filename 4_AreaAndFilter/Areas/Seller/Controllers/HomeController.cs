using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _4_AreaAndFilter.Areas.Seller.Controllers
{
    [RouteArea("seller")]
    public class HomeController : Controller
    {
        // GET: Seller/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}