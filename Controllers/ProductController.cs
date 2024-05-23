using _2_ViewsInMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2_ViewsInMVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1,Name="Shirt" , Price=299},
                new Product() { Id = 2, Name="Pant" , Price=399},
                new Product() { Id = 3,Name="Tshirt" ,Price=499}
            };
            return View(products);
             
        }

        public ActionResult Create() 
        {
            return View();
        }


        //public ActionResult Edit(int? id)
        //{
        //    List<Product> products = (List<Product>)TempData.Peek("products");

        //    Product product = products.FirstOrDefault(p => p.Id == id);

        //    return View(product);
        //}

        public ActionResult Edit(int? id)
        {
            if (!TempData.ContainsKey("products"))
                return RedirectToAction("Index");

            var products = TempData["products"] as List<Product>;
            var product = products?.FirstOrDefault(p => p.Id == id);

            if (product == null)
                return RedirectToAction("Index");

            return View(product);
        }

    }
}