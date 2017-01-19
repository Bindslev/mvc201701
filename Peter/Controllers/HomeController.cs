using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Peter.Models;
using Peter.Models.Repositories;

// To try my program, remember to set my project as startup project
// Right click on "Peter" in solution explorer -> "Set as startup project"

namespace Peter.Controllers
{
    //[HandleError]
    public class HomeController : Controller
    {
        private IPersonRepository PersonRepository;
        private IPlaceRepository PlaceRepository;
        public bool debug = false;

        public HomeController() {
            DebugAble(debug);
        }

        // Is it wrong to have a method like this here?
        [NonAction]
        public void DebugAble(bool debug) {
            if (debug)
            {
                PersonRepository = new PersonRepositoryMock();
                PlaceRepository = new PlaceRepositoryMock();
            }
            else
            {
                PersonRepository = new PersonRepositoryProd();
                PlaceRepository = new PlaceRepositoryProd();
            }
        }

        [HttpGet]
        [Route("~/")]
        public ActionResult Index()
        {
            var pl = PlaceRepository.GetPlace();
            var pe = PersonRepository.GetPerson(1);

            HomeIndexViewModel vm = new HomeIndexViewModel() { Person = pe, Place = pl };
            return View(vm);
        }

        [HttpPost]
        [Route("~/")]
        public ActionResult Index(int id, string debugable) // Would be nice to get debugable as a bool (checkbox in index.html)
        {
            if (ModelState.IsValid)
            {
                if (debugable == null)
                    DebugAble(false);
                else
                    DebugAble(true);

                var pe = PersonRepository.GetPerson(id);
                var pl = PlaceRepository.GetPlace();
                //if (pe == null) return Content("Error, no such person exist!");
                HomeIndexViewModel vm = new HomeIndexViewModel() { Person = pe, Place = pl };
                return View(vm);
            }
            return Content("Error, I think.");
        }

        [ChildActionOnly]
        public ActionResult _SubmitButton() {
            return View();
        }
    }
}