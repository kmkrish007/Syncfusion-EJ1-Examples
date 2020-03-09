using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.JavaScript.Models;

namespace RadioButtonFor.Controllers
{
    public class HomeController : Controller
    {
        RadioModel model = new RadioModel();
        public ActionResult Index()
        {
            model.IsActive = "true";
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(RadioModel model)
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

    public class RadioModel
    {
        public string IsActive { get; set; }
    }
}