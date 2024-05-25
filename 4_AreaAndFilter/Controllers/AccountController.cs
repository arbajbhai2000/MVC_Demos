using _4_AreaAndFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _4_AreaAndFilter.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [HttpGet]
        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]

        [ValidateAntiForgeryToken]          
        public ActionResult LogIn(LogInModel user)
        {
            if (user.username == "admin" && user.password == "admin")
            {
                return RedirectToAction("Index", "Home", new {area="admin"});
            }

            else if (user.username == "seller" && user.password == "seller")
            {
                return RedirectToAction("Index", "Home", new { area = "seller" });
            }

            else if(user.username == "user" && user.password == "user")
            {
                return RedirectToAction("Index", "Home", new { area = "user" });
            }

            else
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
        }
    }
}