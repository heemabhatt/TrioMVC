using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrioWebApp.Models;

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
        public ActionResult submitContactUs(string fullName,string email,string phone, string comment)
        {
            TrioHomeModel trioHomeModel = new TrioHomeModel();
            trioHomeModel.fullName = fullName;
            trioHomeModel.email = email;
            trioHomeModel.phone = phone;
            trioHomeModel.comment = comment;

            
            dbContextTrioHome objdbContextTrioHome = new dbContextTrioHome();

            objdbContextTrioHome.TrioHomeModels.Add(trioHomeModel);
            objdbContextTrioHome.SaveChanges();
            ViewBag.Message = "Data inserted successfully.";
            return View("TrioContactUs");
            /*
            foreach(TrioHomeModel v in obj)
            {
            List <TrioHomeModel> obj =   objdbContextTrioHome.TrioHomeModels.ToList();
            Response.Write("Response submitted successfully.<br> NAME: " + v.fullName + " <br>EMAIL: " + v.email + " <br>PHONE: " + v.phone + " <br>COMMENT: " + v.comment);
            }*/

        }
    }
}