using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc201701.Controllers
{
    public class Module07Controller : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetPersons()
        {
            var h = new mvc201701.Models.Module03.PersonHelper();
            var l = h.GetPersons();
            return Json(l, JsonRequestBehavior.AllowGet);

        }

    }
}