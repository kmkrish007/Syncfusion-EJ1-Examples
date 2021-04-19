using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationCS.Controllers
{
    public class HomeController : Controller
    {
        List<CarsList> car = new List<CarsList>();
        public ActionResult Index()
        {
            car.Add(new CarsList { text = "Audi S6" });
            car.Add(new CarsList { text = "Austin-Healey" });
            car.Add(new CarsList { text = "Alfa Romeo" });
            car.Add(new CarsList { text = "Aston Martin" });
            car.Add(new CarsList { text = "BMW 7" });
            car.Add(new CarsList { text = "Bentley Mulsanne" });
            ViewBag.datasource = car;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public class CarsList
        {
            public string text { get; set; }
        }
    }
}