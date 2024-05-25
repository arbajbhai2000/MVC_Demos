using MVCAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAuthentication.Controllers
{
    [CustomAuthorize(Roles = "Admin")]
    public class ManageController : Controller
    {
        ProductDbContext _db = new ProductDbContext();
        // GET: Manage
        public ActionResult Index()
        {
            var users = _db.Users.ToList();

            return View(users);
        }
    }
}