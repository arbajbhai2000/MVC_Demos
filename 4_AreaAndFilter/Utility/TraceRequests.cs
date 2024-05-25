using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _4_AreaAndFilters.Utility
{
    public class TraceRequestsAttribute : ActionFilterAttribute, IExceptionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string controller = filterContext.RouteData.Values["controller"].ToString();
            string action = filterContext.RouteData.Values["action"].ToString();
            string message = $"{controller} : {action} : OnActionExecuting : @{DateTime.Now.ToString()}\n";

            LogMessageToFile(message);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            string controller = filterContext.RouteData.Values["controller"].ToString();
            string action = filterContext.RouteData.Values["action"].ToString();
            string message = $"{controller} : {action} : OnActionExecuted : @{DateTime.Now.ToString()}\n";

            LogMessageToFile(message);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            string controller = filterContext.RouteData.Values["controller"].ToString();
            string action = filterContext.RouteData.Values["action"].ToString();
            string message = $"{controller} : {action} : OnResultExecuting : @{DateTime.Now.ToString()}\n";

            LogMessageToFile(message);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            string controller = filterContext.RouteData.Values["controller"].ToString();
            string action = filterContext.RouteData.Values["action"].ToString();
            string message = $"{controller} : {action} : OnResultExecuted : @{DateTime.Now.ToString()}\n";

            LogMessageToFile(message);
        }

        public void OnException(ExceptionContext filterContext)
        {
            string controller = filterContext.RouteData.Values["controller"].ToString();
            string action = filterContext.RouteData.Values["action"].ToString();
            string errorMessage = filterContext.Exception.Message;
            string message = $"{controller} : {action} : OnException : " +
                $"@{DateTime.Now.ToString()} Error Message : {errorMessage}\n";

            LogMessageToFile(message);

            filterContext.Result = new ViewResult()
            {
                ViewName = "Error"
            };

            filterContext.ExceptionHandled = true;
        }

        public void LogMessageToFile(string message)
        {
            string logFilePath = AppDomain.CurrentDomain.BaseDirectory + "/Logs/Logs.txt";
            File.AppendAllText(logFilePath, message);
        }
    }
}