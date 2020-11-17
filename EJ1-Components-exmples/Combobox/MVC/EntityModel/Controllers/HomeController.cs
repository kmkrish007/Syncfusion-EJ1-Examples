using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Entity.Controllers
{
    public class HomeController : Controller
    {
        ModelMovieContainer db = new ModelMovieContainer();
        public ActionResult Index()
        {
            var dataset = db.Customers.Select(x => new Customer
                    {
                        ID = x.CustomerID,
                        Name = x.ContactName
                    }).ToList();
            ViewBag.DataSource = dataset;
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

    public class Customer
    {
        public string ID { get; set; }
        public string Name { get; set; }
    }
}