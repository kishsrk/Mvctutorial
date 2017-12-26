using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTutorial.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services

        public ActionResult Servicing()
        {
            return View();
        }
        public ActionResult LaptopServicing()
        {
            return View();
        }

        public ActionResult TVServicing()
        {
            return View();
        }

        public ActionResult MobileServicing()
        {
            return View();
        }

        public ActionResult MicrowaveServicing()
        {
            return View();
        }
    }
}