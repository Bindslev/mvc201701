using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc201701.Controllers
{
    public class SalgController : Controller
    {
        // enten modelbinding
        public ActionResult Index(int aar, int mdr)
        {
            // explicit
            //int år = Convert.ToInt32(RouteData.Values["aar"]);
            //int mdr = Convert.ToInt32(RouteData.Values["mdr"]);
            return View();
        }
    }
}