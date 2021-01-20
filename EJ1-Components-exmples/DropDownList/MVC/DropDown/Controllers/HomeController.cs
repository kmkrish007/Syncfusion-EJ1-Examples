using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DropDown.Controllers
{
    public class HomeController : Controller
    {
        List<Customers> customer = new List<Customers>();
        public ActionResult Index()
        {
            customer.Add(new Customers { id = "1", text = "ALFKI" });
            customer.Add(new Customers { id = "2", text = "ANATR" });
            customer.Add(new Customers { id = "3", text = "ANTON" });
            customer.Add(new Customers { id = "4", text = "AROUT" });
            customer.Add(new Customers { id = "5", text = "BERGS" });
            customer.Add(new Customers { id = "6", text = "BLAUS" });
            ViewBag.datasource = customer;
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
    public class Customers
    {
        public string id { get; set; }
        public string text { get; set; }
    }
}