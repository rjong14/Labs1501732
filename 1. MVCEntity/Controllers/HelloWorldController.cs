using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1.MVCEntity.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index() {
            return View();
        }

        // GET: /HelloWorld/Welcome

        // GET: /HelloWorld/Welcome
        public ActionResult Welcome(string greeting, int count = 1) {
            ViewBag.Greeting = "My greeting: " + greeting;
            ViewBag.Count = count;

            return View();   //Now type is ActionResult - not a string 
        }
    }
}