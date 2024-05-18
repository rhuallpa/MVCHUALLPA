using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHUALLPA.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }


        // GET: Demo
        public ActionResult Demo()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}

