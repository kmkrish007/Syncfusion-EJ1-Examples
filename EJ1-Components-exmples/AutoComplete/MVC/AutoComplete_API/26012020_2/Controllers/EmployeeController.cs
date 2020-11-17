using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _26012020_2.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index(DataManager value)
        {
            var models = GetTestData();

            IEnumerable Data = GetTestData();
            Syncfusion.JavaScript.DataSources.DataOperations operation = new Syncfusion.JavaScript.DataSources.DataOperations();

            var data = operation.Execute(models, value);
            if (value.Where != null && value.Where.Count > 0) //Filtering 
            {
                data = operation.PerformWhereFilter(models, value.Where, value.Where[0].Operator);
            }
            return Json(data, JsonRequestBehavior.AllowGet);
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

    public class AutocompleteModel
    {
        [Display(Name = "Id")]
        public string Id { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
    }


}