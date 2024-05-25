using _4_AreaAndFilters.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _4_AreaAndFilter.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        [AllowAnonymous]
        //[RequireHttps]

        [TraceRequestsAttribute]
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]

        public ActionResult PostComments(string comment)
        {
            ViewBag.Comment = comment;
            return View("PostComments");
        }

        [OutputCache(Duration =15)]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            ViewBag.LoadedTime=DateTime.Now;

            return View();
        }

        [ChildActionOnly]
        public PartialViewResult Loginsection()
        {
            return PartialView("_LoginPartial");
        }

    }
}