using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc201701.Controllers
{
    public class Module05Controller : Controller
    {

        //[Route("minTest/{mdr:int:min(1)}")]
        [Route("minTest/{mdr:bool}")]
        public ActionResult Index(bool mdr)
        {
            return View();
        }
    }
}