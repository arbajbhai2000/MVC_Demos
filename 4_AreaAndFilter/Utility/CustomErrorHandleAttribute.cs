using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _4_AreaAndFilters.Utility
{
    public class CustomHandleErrorAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            string controller = filterContext.RouteData.Values["controller"].ToString();
            string action = filterContext.RouteData.Values["action"].ToString();
            string errorMessage = filterContext.Exception.Message;
            string message = $"{controller} : {action} : OnException : @{DateTime.Now.ToString()}\n";

            // LogMessageToFile(message);
            // save error information to database

            filterContext.Result = new ViewResult()
            {
                ViewName = "Error"
            };

            filterContext.ExceptionHandled = true;
        }
    }
}