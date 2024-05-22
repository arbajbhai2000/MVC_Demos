using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _1_MVCIntro
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapMvcAttributeRoutes();

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //first route
            routes.MapRoute(
                name: "Default ",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Welcome", id = UrlParameter.Optional }
                );
                routes.MapRoute(
                name: "Default1 ",
                url: "{controller}/{action}/{id}/{name}",
                defaults: new { controller = "Home", action = "Welcome", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default2 ",
                url: "{controller}/{action}/{id}/{studentname}",
                defaults: new { controller = "Home", action = "Welcome", id = UrlParameter.Optional }
                );
        }
    }
}
