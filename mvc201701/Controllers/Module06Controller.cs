using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc201701.Controllers
{
    public class Module06Controller : Controller
    {
        // GET: Module06
        public ActionResult Index()
        {
            var p = new mvc201701.Models.Module03.PersonHelper().GetPerson(1);
            return View(p);
        }
        public ActionResult layouttest()
        {            
            return View();
        }
    }
}