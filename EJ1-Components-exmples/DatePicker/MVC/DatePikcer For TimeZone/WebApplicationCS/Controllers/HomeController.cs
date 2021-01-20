using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationCS.Controllers
{
    public class HomeController : Controller
    {
        // GET: DatePicker
        [HttpGet]
        public ActionResult Index()
        {
            DatePickerModel model = new DatePickerModel();
            model.LoadData();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(DatePickerModel model)
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

    public class DatePickerModel : List<DateTime>
    {
        public void LoadData()
        {
            this.Add(new DateTime(1933, 4, 19));
        }

    }
}