using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.JavaScript.Models;
using Syncfusion.JavaScript;

namespace RadioButtonFor.Controllers
{
    

    public class HomeController : Controller
    {
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
       // RadioModel model = new RadioModel();

        //public ActionResult Index()
        //{
        //    model.IsActive = "true";
        //    model.Gender = "Female";
        //    model.answer = true;
        //    model.option = false;
        //    model.Gen = "Male";
        //    return View(model);
        //}

        //[HttpPost]
        //public ActionResult Index(RadioModel model)
        //{

        //    return View(model);

        //}

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

    //public class RadioModel
    //{
    //    public string IsActive { get; set; }

    //    public string Gender { get; set; }

    //    public bool answer { get; set; }

    //    public bool option { get; set; }

    //    public string Gen { get; set; }
    //}

    public class DatePickerModel : List<DateTime>
    {

        public void LoadData()
        {
            this.Add(new DateTime(1978, 10, 13));
            this.Add(new DateTime(1995, 10, 13));
            this.Add(new DateTime(2000, 10, 13));

        }

    }
}