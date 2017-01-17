using mvc201701.Models.Module03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc201701.Controllers
{
    public class Module03Controller : Controller
    {

        private IPersonHelper repository;

        public Module03Controller()
        {
            // fattigmands DI....
            // hvis det er test så
            //repository = new mvc201701.Models.Module03.PersonHelperMock();            
            // else
            //repository = new mvc201701.Models.Module03.PersonHelper();

            repository = new mvc201701.Models.Module03.PersonHelper();
        }


        // GET: Module03
        public ActionResult Index()
        {
            
            var p = repository.GetPerson(1);
            return View(p);
        }
        
        public ActionResult Index2()
        {
            var ph = new mvc201701.Models.Module03.PersonHelper();
            var p = ph.GetPerson(1);
            return View(p);
        }

        [HttpGet]
        public ActionResult Login()
        {
            UserLoginViewModel m = new UserLoginViewModel() { Username = "", Password = "", Remember = false };
            return View(m);
        }

        [HttpPost]
        public ActionResult Login(UserLoginViewModel m)
        {
            // login logik....

            if (ModelState.IsValid) {
                // gem og redirect
                return View(m);
            } else {
                return View(m);
            }
                        
            
        }


    }
}