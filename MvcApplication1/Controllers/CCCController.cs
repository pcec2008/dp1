using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class CCCController : Controller
    {
        //
        // GET: /CCC/

        public ActionResult Index()
        {
            //return View();
            return Redirect("/Ceshi/Index");
        }

    }
}
