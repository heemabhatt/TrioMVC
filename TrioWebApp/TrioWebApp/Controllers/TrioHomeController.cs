using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrioWebApp.Controllers
{
    public class TrioHomeController : Controller
    {
        // GET: TrioHome
        public ActionResult TrioIndex()
        {
            return View();
        }
        public ActionResult TrioAboutUs()
        {
            return View();
        }
    }
}