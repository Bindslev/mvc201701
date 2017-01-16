using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc201701.Controllers
{
    public class Module03Controller : Controller
    {
        // GET: Module03
        public ActionResult Index()
        {
            var ph = new mvc201701.Models.Module03.PersonHelper();
            var p = ph.GetPerson(1);
            return View(p);
        }

        public ActionResult Index2()
        {
            var ph = new mvc201701.Models.Module03.PersonHelper();
            var p = ph.GetPerson(1);
            return View(p);
        }
    }
}