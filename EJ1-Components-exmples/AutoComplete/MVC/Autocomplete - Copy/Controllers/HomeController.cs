using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Autocomplete.Controllers
{
    public class HomeController : Controller
    {
        List<CarsList> cars = new List<CarsList>();
        public ActionResult Index()
        {
            cars.Add(new CarsList { UniqueKey = 1, Text = "Audi S6" });

            cars.Add(new CarsList { UniqueKey = 2, Text = "Austin-Healey" });

            cars.Add(new CarsList { UniqueKey = 3, Text = "Alfa Romeo" });

            cars.Add(new CarsList { UniqueKey = 4, Text = "Aston Martin" });

            cars.Add(new CarsList { UniqueKey = 5, Text = "BMW 7" });

            cars.Add(new CarsList { UniqueKey = 6, Text = "Bentley Mulsanne" });

            cars.Add(new CarsList { UniqueKey = 7, Text = "Bugatti Veyron" });

            cars.Add(new CarsList { UniqueKey = 8, Text = "Chevrolet Camaro" });

            cars.Add(new CarsList { UniqueKey = 9, Text = "Cadillac" });

            cars.Add(new CarsList { UniqueKey = 10, Text = "Duesenberg J " });

            cars.Add(new CarsList { UniqueKey = 11, Text = "Dodge Sprinter" });

            cars.Add(new CarsList { UniqueKey = 12, Text = "Elantra" });

            cars.Add(new CarsList { UniqueKey = 13, Text = "Excavator" });

            cars.Add(new CarsList { UniqueKey = 14, Text = "Ford Boss 302" });

            cars.Add(new CarsList { UniqueKey = 15, Text = "Ferrari 360" });

            cars.Add(new CarsList { UniqueKey = 16, Text = "Ford Thunderbird" });

            cars.Add(new CarsList { UniqueKey = 17, Text = "GAZ Siber" });

            cars.Add(new CarsList { UniqueKey = 18, Text = "Honda S2000" });

            cars.Add(new CarsList { UniqueKey = 19, Text = "Hyundai Santro" });

            cars.Add(new CarsList { UniqueKey = 20, Text = "Isuzu Swift" });

            cars.Add(new CarsList { UniqueKey = 21, Text = "Infiniti Skyline" });

            cars.Add(new CarsList { UniqueKey = 22, Text = "Infiniti Skyline" });

            cars.Add(new CarsList { UniqueKey = 23, Text = "Kia Sedona EX" });

            cars.Add(new CarsList { UniqueKey = 24, Text = "Koenigsegg Agera" });

            cars.Add(new CarsList { UniqueKey = 25, Text = "Lotus Esprit" });

            cars.Add(new CarsList { UniqueKey = 26, Text = "Lamborghini Diablo" });

            cars.Add(new CarsList { UniqueKey = 27, Text = "Mercedes-Benz" });

            cars.Add(new CarsList { UniqueKey = 28, Text = "Mercury Coupe" });

            cars.Add(new CarsList { UniqueKey = 29, Text = "Maruti Alto 800" });

            cars.Add(new CarsList { UniqueKey = 30, Text = "Nissan Qashqai" });

            cars.Add(new CarsList { UniqueKey = 31, Text = "Oldsmobile S98" });

            cars.Add(new CarsList { UniqueKey = 32, Text = "Opel Superboss" });

            cars.Add(new CarsList { UniqueKey = 33, Text = "Porsche 356" });

            cars.Add(new CarsList { UniqueKey = 34, Text = "Pontiac Sunbird" });

            cars.Add(new CarsList { UniqueKey = 35, Text = "Scion SRS/SC/SD" });

            cars.Add(new CarsList { UniqueKey = 36, Text = "Saab Sportcombi" });

            cars.Add(new CarsList { UniqueKey = 37, Text = "Subaru Sambar" });

            cars.Add(new CarsList { UniqueKey = 38, Text = "Suzuki Swift" });

            cars.Add(new CarsList { UniqueKey = 39, Text = "Triumph Spitfire" });

            cars.Add(new CarsList { UniqueKey = 40, Text = "Toyota 2000GT" });

            cars.Add(new CarsList { UniqueKey = 41, Text = "Volvo P1800" });

            cars.Add(new CarsList { UniqueKey = 42, Text = "Volkswagen Shirako" });

            cars.Add(new CarsList { UniqueKey = 43, Text = "Ford Boss 302" });

            cars.Add(new CarsList { UniqueKey = 44, Text = "Ferrari 360" });

            cars.Add(new CarsList { UniqueKey = 45, Text = "Ford Thunderbird" });

            ViewBag.datasource = cars;

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
    }

    public class CarsList

    {

        public int UniqueKey { get; set; }

        public string Text { get; set; }

    }
}