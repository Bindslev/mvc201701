using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace mvc201701.Controllers
{
    public class HomeController : Controller
    {
        [Route("~/")]
        public ActionResult Index()
        {
            var grp = mvc201701.Models.Misc.ControllerActionViewModel.GetActionMethods();
            return View(grp);
        }


    }
}