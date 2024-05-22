using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1_MVCIntro.Controllers
{
    [RoutePrefix("")]

    public class HomeController : Controller
    {

        public string Welcome()
        {
            return "My First MVC Application";
        }

        public string getresult(int id)
        {
            return $"you have passed {id} input value";
        }

        public string getemployeedata(int id, string name)
        {
            return $"Employee id{id} Employee name{name}";
        }

        [Route("vhaash/home/{id}/{studentname}")]
        public string getstudentdata(int id, string studentname)
        {
            return $" student id : {id}    studentname : {studentname}";
        }

    }
}