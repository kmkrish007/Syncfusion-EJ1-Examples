using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.JavaScript.Models;

namespace DatePicker_EndDate.Controllers
{
    public class HomeController : Controller
    {
        DateModel model = new DateModel();
        public ActionResult Index()
        {
            model.StartDate = DateTime.Now.ToString();
            DatePickerProperties datemodel = new DatePickerProperties();
            datemodel.ShowOtherMonths = false;
            ViewData["date"] = datemodel;
            return View(model);
            //return View();
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
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}