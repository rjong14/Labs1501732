using _0.Installation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _0.Installation.Controllers
{
    public class IndexController : Controller{
        //
        // GET: /Index/

        public ActionResult Index(){

            List<IndexModel> students = new List<IndexModel>();

            IndexModel st1 = new IndexModel{
                ID = 1501732,
                Name = "Rick de Jong",
                Programme = "ASP.net"
            };
            IndexModel st2 = new IndexModel{
                ID = 98765432,
                Name = "Kake",
                Programme = "Media Engineerin"
            };
            students.Add(st1);
            students.Add(st2);
            return View(students);
        }

    }
}
