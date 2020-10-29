using Syncfusion.JavaScript;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationCS.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult GetOutletsForAutocomplete(DataManager value)
        {
            var models = GetTestData();

            IEnumerable<AutocompleteModel> Data = GetTestData();
            Syncfusion.JavaScript.DataSources.DataOperations operation = new Syncfusion.JavaScript.DataSources.DataOperations();
            if (value.Where != null && value.Where.Count > 0) //Filtering 
            {
                Data = operation.PerformWhereFilter(models, value.Where, value.Where[0].Operator);
            }
            return Json(Data, JsonRequestBehavior.AllowGet);
        }

        public class AutocompleteModel
        {
            [Display(Name = "Id")]
            public string Id { get; set; }
            [Display(Name = "Name")]
            public string Name { get; set; }
        }

        private List<AutocompleteModel> GetTestData()
        {
            var list = new List<AutocompleteModel>();
            list.Add(new AutocompleteModel() { Id = "1", Name = "One" });
            list.Add(new AutocompleteModel() { Id = "2", Name = "Two" });
            list.Add(new AutocompleteModel() { Id = "3", Name = "Three" });
            return list;
        }

    }
}