using Restoraunt.BusinessLogic.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restoraunt.Controllers
{
    public class WaiterIDController : Controller
    {
        public ActionResult WaiterID()
        {
            return View();
        }
        public ActionResult Waitrers()
        {
            ViewBag.ActivePage = "Waitrers";
            return View();
        }
    }
}