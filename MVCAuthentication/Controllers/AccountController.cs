using MVCAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCAuthentication.Controllers
{
    public class AccountController : Controller
    {
        ProductDbContext _db = new ProductDbContext();

        // GET: Account
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(User user)
        {
            user.IsActive = true;
            user.CreatedDate = DateTime.Now;

            _db.Users.Add(user);
            _db.SaveChanges();

            UserRole userRole = new UserRole()
            { UserId = user.UserId, RoleId = 3 };

            _db.UserRoles.Add(userRole);
            _db.SaveChanges();

            return RedirectToAction("Index", "Product");
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                User user = _db.Users.Include("UserRoles")
                    .FirstOrDefault(u =>
                 u.Email == loginModel.Email && 
                 u.Password == loginModel.Password);

                if (user != null)
                {
                    // user is already registered 

                    FormsAuthentication.SetAuthCookie(user.Email,
                        false);

                    if (user.UserRoles.Any(r => r.RoleId == 1)) // admin
                    {
                        return RedirectToAction("Index", "Manage");
                    }
                    else if (user.UserRoles.Any(r => r.RoleId == 2)) // seller
                    {
                        return RedirectToAction("Create", "Product");
                    }
                    else // user
                    {
                        return RedirectToAction("Index", "Product"); 
                    }
                }
                else
                {
                    ViewBag.Message = "Email or Password is incorrect";
                    return View();
                }
            }
            
            return View();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}