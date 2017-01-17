using mvc201701.Models.Module03;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc201701.Controllers
{
    public class Module04Controller : Controller
    {
        
        public ContentResult Content()
        {
            ContentResult c = new ContentResult();
            c.ContentType = "application/vnd.ms-excel";
            c.Content = "1,5,1,5";
            return c;
        }

        public ActionResult Json()
        {
            Person p = new Person() { Id = 1, Name = "lk ld" };
            return Json(p, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Redirect()
        {
            return Redirect("http://www.google.dk");
        }

        public ActionResult RedirectI()
        {
            return RedirectToAction("index", "home");
        }


        public ActionResult Status()
        {
            HttpStatusCodeResult h = new HttpStatusCodeResult(500, "FEJL");
            return h;
        }


        public ViewResult view()
        {
            return View("view", new Person());
        }

        public ActionResult viewtest()
        {
            var r = View("test");
            //var html = r.View.Render()
            return r;
        }


        public ViewResult TestViewBag()
        {
            ViewBag.text = "lkjdfg ældsjfg ælsdjfg ";
            ViewBag.number = 10;

            return View();
        }

        public ActionResult an()
        {
            //var o = new { name = "test", age = 10 };
            dynamic o = new ExpandoObject();
            o.name = "Tes";
            o.age = 10;
            return View(o);
        }

    }

    public class MockTest {

        public void Test() {

            Module04Controller c = new Module04Controller();
            var r = c.view();
            if (Convert.ToInt32(r.Model)==4) {
            
                //ok
                
            // else
            
            // ikke ok
            }

        }
    }
}