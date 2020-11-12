using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class CeshiController : Controller
    {
        //
        // GET: /Ceshi/

        public ActionResult Index()
        {
            string s = "11111111111111111111";
            ViewBag.s = s;
            return View();
        }

    }
}
