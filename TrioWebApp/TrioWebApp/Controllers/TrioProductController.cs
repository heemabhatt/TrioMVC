using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;
using System.Web.Mvc;
using TrioWebApp.Models;
namespace TrioWebApp.Controllers
{
    public class TrioProductController : Controller
    {
        // GET: TroiProduct
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult showProduct()
        {

            dbContextTrioHome obj = new dbContextTrioHome();
            List<TrioProductModel> trioProductModels;

            // trioProductModels = obj.DBTrioProductModels.Where(pr => pr.category == c).ToList();

            trioProductModels = obj.DBTrioProductModels.ToList();

            return View(trioProductModels);
        }
        [HttpGet]
        public List<TrioProductModel> showProductByCategory(string cat)
        {

            dbContextTrioHome obj = new dbContextTrioHome();
            List<TrioProductModel> trioProductModels;
            if (cat != null)
            {
                 trioProductModels = obj.DBTrioProductModels.Where(pr => pr.category == cat).ToList();
            }
            else { 
            trioProductModels = obj.DBTrioProductModels.ToList();
            }
            


            return (trioProductModels);

        }

        [HttpGet]
        public JsonResult GetProductDataJson(string cat)

        {
            dbContextTrioHome obj = new dbContextTrioHome();
            List<TrioProductModel> trioProductModels;
            if (cat != null)
            {
                trioProductModels = obj.DBTrioProductModels.Where(pr => pr.category == cat).ToList();
            }
            else
            {
                trioProductModels = obj.DBTrioProductModels.ToList();
            }
            IEnumerable<TrioProductModel> data = trioProductModels;

            return Json(data, JsonRequestBehavior.AllowGet);

        }


    }
}