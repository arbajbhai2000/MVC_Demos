using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1_MVCIntro.Controllers
{
    [RoutePrefix("product")]
    public class ProductController : Controller
    {
        [Route("")]

        // GET: Product
        public  string Getproduct()
        {
            return "<h1>All Products</h1>No available products";
        }

        public EmptyResult Index()
        {
            return new EmptyResult(); 
        }

        public ContentResult Index1()
        {
            return Content("Hello");
        }

        public ContentResult Index2()
        {
            return Content("<h2>Index Page 2<h2>  text/html");
        }
         
        public RedirectResult Index3()
        {
            return Redirect("http://www.google.com");
        }
        
        public JsonResult Index4()
        {
            string json = " {'Id' : 10 , 'Name':Arbaj , 'City': Barshi}";
            return Json(json,JsonRequestBehavior.AllowGet);
        }



    }
}