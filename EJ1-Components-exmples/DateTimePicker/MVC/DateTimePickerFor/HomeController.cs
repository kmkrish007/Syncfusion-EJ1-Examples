using Syncfusion.JavaScript.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DateTimePicker_Helper.Controllers
{
    public class HomeController : Controller
    {
        DateModel model = new DateModel();
        public ActionResult Index()
        {
            model.Value = DateTime.Now;
            model.number = 66;
            model.percent = 75;

            model.currency = 89;
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(DateModel model)
        {
            
            return View(model);

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

    public class DateModel
    {
        public DateTime Value { get; set; }

        public int number { get; set; }

        public int percent { get; set; }

        public int currency { get; set; }
    }
}