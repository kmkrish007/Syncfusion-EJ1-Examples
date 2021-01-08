using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public JsonResult GetItems()
        {
            List<CarsList> products = new List<CarsList>
            {
            new CarsList { uniqueKey = 1, text = "Audi S6", company = "Audi" },
            new CarsList { uniqueKey = 2, text = "Austin-žHealey", company = "Austin" },
            new CarsList { uniqueKey = 3, text = "BMW š7", company = "BMW" },
            new CarsList { uniqueKey = 4, text = "Chevrolet Camarož", company = "Chevrolet" },
            new CarsList { uniqueKey = 6, text = "Ferrari š360", company = "Ferrari" },
            new CarsList { uniqueKey = 7, text = "Honda S2000", company = "Honda" },
            new CarsList { uniqueKey = 8, text = "Hyundai Santroš", company = "Hyundai" },
            new CarsList { uniqueKey = 9, text = "Isuzu Swift", company = "Isuzu" },
            new CarsList { uniqueKey = 10, text = "Jaguar XJS", company = "Jaguar" },
            new CarsList { uniqueKey = 11, text = "iLotus Esprit", company = "Lotus" },
           new CarsList { uniqueKey = 12, text = "Mercedes-Benz", company = "Mercedes" },
           new CarsList { uniqueKey = 13, text = "Toyota ž2000GT", company = "Toyota" },
            new CarsList { uniqueKey = 14, text = "Volvo P1800", company = "Volvo" }
        };
            
            return Json(products);
        }


    }
}
