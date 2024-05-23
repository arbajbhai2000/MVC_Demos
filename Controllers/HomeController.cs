using _2_ViewsInMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2_ViewsInMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["name"] = "Tata Consaltancy Services";
            ViewBag.Email = "support@tcs.com";

            TempData["Address"] = "Value stored in tempdata";

            return View();
        }

        public ActionResult Index2()
        {
             
            return View();
        }

        public ActionResult Index3()
        {
             int number = 50;
            return View("Index3" , number);
        }

        public ActionResult Index4()
        {
            Product p = new Product()
            { Id = 1, Name = "Shirt", Price = 499 };
            return View(p);
        }

        public ActionResult Index5()
        {
            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1,Name="Shirt" , Price=299},
                new Product() { Id = 2, Name="Pant" , Price=399},
                new Product() { Id = 3,Name="Tshirt" ,Price=499}
            };
            return View(products);
        }

    }
}