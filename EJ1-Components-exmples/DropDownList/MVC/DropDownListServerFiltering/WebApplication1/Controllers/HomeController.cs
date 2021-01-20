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

        public JsonResult GetItems(DataManager dm)
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    Text="IR-000024",
                    Selected=false,
                    Value="1"
                },
                new Product
                {
                    Text="IR-000020",
                    Selected=false,
                    Value="2"
                },
                new Product
                {
                    Text="IR-000021",
                    Selected=false,
                    Value="3"
                },
                new Product
                {
                    Text="IR-000022",
                    Selected=false,
                    Value="4"
                },
                new Product
                {
                    Text="IR-000026",
                    Selected=false,
                    Value="5"
                },
                new Product
                {
                    Text="IR-000027",
                    Selected=false,
                    Value="6"
                },
                new Product
                {
                    Text="IR-000028",
                    Selected=false,
                    Value="7"
                },
                new Product
                {
                    Text="IR-000030",
                    Selected=false,
                    Value="8"
                }
            };
            int count = products.Count();
            if (dm.skip != 0)
                products = products.Skip(dm.skip).ToList();
            if (dm.take != 0)
                products = products.Take(dm.take).ToList();
            if (dm.where != null)
            {
                products = (from n in products where n.Text.ToLower().StartsWith(dm.@where[0].value) select n).ToList();
            }
            return dm.requiresCounts ? Json(new { result = products, count = count }) : Json(products);
        }


    }

    public class DataManager
    {

        public bool requiresCounts { get; set; }
        public int skip { get; set; }
        public int take { get; set; }
        public List<Whereas> where { get; set; }

    }

    public class Whereas
    {
        public string field { get; set; }
        public bool ignoreCase { get; set; }

        public bool isComplex { get; set; }

        public string value { get; set; }
        public string Operator { get; set; }

    }
}
