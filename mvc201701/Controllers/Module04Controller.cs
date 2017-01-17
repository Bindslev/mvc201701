using mvc201701.ActionResultMethods;
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
            //ContentResult c = new ContentResult();
            //c.ContentType = "application/vnd.ms-excel";
            //c.Content = "1,5,1,5";
            //return c;
            return Content("text");
        }

        public ActionResult Json()
        {
            Person p = new Person() { Id = 1, Name = "lk ld" };
            return Json(p, JsonRequestBehavior.AllowGet);
        }

        // EGEN XmlAction
        public ActionResult Xml()
        {
            Person p = new Person() { Id = 1, Name = "lk ld" };
            var x = new XmlActionResult<Person>() { Data = p };
            return x;
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
            HttpStatusCodeResult h 
                = new HttpStatusCodeResult(500, "FEJL");
            return h;
        }


        public ViewResult View1()
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

        public ActionResult Expando()
        {
            //var o = new { name = "test", age = 10 };
            dynamic o = new ExpandoObject();
            o.name = "Tes";
            o.age = 10;
            return View(o);
        }

        [HttpGet]
        public ActionResult Model1(string test, int? id)
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Model1(string name, int? number, Input i)
        {
            return View();
        }

        [OutputCache(Duration = 5)]
        public ActionResult Cache()
        {
            return View();
        }

        public ActionResult PartialViewTest()
        {
            return View();
        }

        //[OutputCache(Duration = 10)]
        //[ChildActionOnly]
        public PartialViewResult Klokken()
        {
            // burde være model.....
            ViewBag.Kl = DateTime.Now.ToLongTimeString();
            return PartialView();
        }

        //[OutputCache(Duration = 5)]
        [ChildActionOnly]
        public PartialViewResult Klokken2()
        {
            // burde være model.....
            ViewBag.Kl = DateTime.Now.Millisecond.ToString();
            return PartialView();
        }


        [NonAction]
        public void Test() {

        }
    }

    public class Input {
        public int Number2 { get; set; }
        public bool IsAdmin { get; set; }
    }

    public class MockTest {

        public void Test() {

            Module04Controller c = new Module04Controller();
            var r = c.View1();
            if (Convert.ToInt32(r.Model)==4) {
            
                //ok
                
            // else
            
            // ikke ok
            }

        }
    }
}