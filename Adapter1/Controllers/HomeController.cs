using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Adapter1.Models;

namespace Adapter1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Duck aDuck1 = new Duck();
            Duck aDuck2 = new Duck();
            Duck aDuck3 = new Duck();
            Duck aDuck4 = new Duck();
            List<IDuck> aListOfDucks = new List<IDuck>();


            Turkey aTurkey1 = new Models.Turkey();
            TurkeyAdaptor aTurkeyAdaptor1 = new TurkeyAdaptor(aTurkey1);

            aListOfDucks.Add(aDuck1);
            aListOfDucks.Add(aDuck2);
            aListOfDucks.Add(aDuck3);
            aListOfDucks.Add(aDuck4);
            aListOfDucks.Add(aTurkeyAdaptor1);

            ViewBag.ListOfDucks = aListOfDucks;

            return View();
        }
    }
}