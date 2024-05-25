using System.Security.Claims;
using System.Web.Mvc;
using System.Web;
using MVCAuthentication.Models;
using System.Linq;

public class CustomAuthorizeAttribute : AuthorizeAttribute
{
    ProductDbContext _db = new ProductDbContext();
    protected override bool AuthorizeCore(HttpContextBase httpContext)
    {
        // Fetch the roles of the current user from your database
        var userId = _db.Users.FirstOrDefault(u =>
        u.Email == HttpContext.Current.User.Identity.Name)?.UserId;

        var userRoleId = _db.UserRoles.FirstOrDefault(ur => 
        ur.UserId == userId)?.RoleId;

        var userRole = _db.Roles.Find(userRoleId)?.RoleName ?? "Guest";

        return Roles.Contains(userRole);
    }
}
