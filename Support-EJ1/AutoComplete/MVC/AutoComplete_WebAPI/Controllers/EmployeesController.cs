using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.JavaScript;
namespace AutoComplete_WebAPI.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            //var models = GetData();

            //IEnumerable Data = GetData();
            //Syncfusion.JavaScript.DataSources.DataOperations operation = new Syncfusion.JavaScript.DataSources.DataOperations();

            //var data = operation.Execute(models, value);
            //if (value.Where != null && value.Where.Count > 0) //Filtering 
            //{
            //    data = operation.PerformWhereFilter(models, value.Where, value.Where[0].Operator);
            //}
            //return Json(data, JsonRequestBehavior.AllowGet);

            return View();

            //var models = GetTestData();

            //IEnumerable Data = GetTestData();
            //Syncfusion.JavaScript.DataSources.DataOperations operation = new Syncfusion.JavaScript.DataSources.DataOperations();

            //var data = operation.Execute(models, value);
            //if (value.Where != null && value.Where.Count > 0) //Filtering 
            //{
            //    data = operation.PerformWhereFilter(models, value.Where, value.Where[0].Operator);
            //}
            //return Json(data, JsonRequestBehavior.AllowGet);
        }

        //public class AutocompleteModel
        //{
        //   // [Display(Name = "Id")]
        //    public string Id { get; set; }
        //   // [Display(Name = "Name")]
        //    public string Name { get; set; }
        //}

        //private List<AutocompleteModel> GetTestData()
        //{
        //    var list = new List<AutocompleteModel>();
        //    list.Add(new AutocompleteModel() { Id = "1", Name = "One" });
        //    list.Add(new AutocompleteModel() { Id = "2", Name = "Two" });
        //    list.Add(new AutocompleteModel() { Id = "3", Name = "Three" });
        //    return list;
        //}

        private List<CarsList> GetData()
        {
            List<CarsList> cars = new List<CarsList>();

            cars.Add(new CarsList { uniqueKey = 1, text = "Audi S6", company = "Audi" });
            cars.Add(new CarsList { uniqueKey = 2, text = "Austin-žHealey", company = "Austin" });
            cars.Add(new CarsList { uniqueKey = 3, text = "BMW š7", company = "BMW" });
            cars.Add(new CarsList { uniqueKey = 4, text = "Chevrolet Camarož", company = "Chevrolet" });
            cars.Add(new CarsList { uniqueKey = 6, text = "Ferrari š360", company = "Ferrari" });
            cars.Add(new CarsList { uniqueKey = 7, text = "Honda S2000", company = "Honda" });
            cars.Add(new CarsList { uniqueKey = 8, text = "Hyundai Santroš", company = "Hyundai" });
            cars.Add(new CarsList { uniqueKey = 9, text = "Isuzu Swift", company = "Isuzu" });
            cars.Add(new CarsList { uniqueKey = 10, text = "Jaguar XJS", company = "Jaguar" });
            cars.Add(new CarsList { uniqueKey = 11, text = "iLotus Esprit", company = "Lotus" });
            cars.Add(new CarsList { uniqueKey = 12, text = "Mercedes-Benz", company = "Mercedes" });
            cars.Add(new CarsList { uniqueKey = 13, text = "Toyota ž2000GT", company = "Toyota" });
            cars.Add(new CarsList { uniqueKey = 14, text = "Volvo P1800", company = "Volvo" });

            return cars;
        }

        public class CarsList
        {
            public int uniqueKey { get; set; }
            public string text { get; set; }
            public string company { get; set; }
        }

        public JsonResult GetDataCar(string data)
        {
            var data1 = GetData();
            if (data != null)
            {
                var search = from n in data1 where n.text.ToLower().StartsWith(data.ToLower()) select n;
                return Json(search, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(data1, JsonRequestBehavior.AllowGet);
            }


        }

    }


}