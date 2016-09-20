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

        public ActionResult TrioContactUs()
        {
            return View();
        }
        public void submitContactUs(string fullName,string email,string phone, string comment)
        {
            Response.Write("Response submitted successfully.<br> NAME: " + fullName + " <br>EMAIL: " +email + " <br>PHONE: " +phone  + " <br>COMMENT: " + comment);
        }
    }
}