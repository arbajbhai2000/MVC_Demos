using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1_MVCIntro.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ViewResult Index()
        {
            //return View();
            //return View("Index1");
            return View("~/Views/Student/Index.cshtml");
        }

        public ViewResult Allcategories()
        {
            return View();
        }
    }

}