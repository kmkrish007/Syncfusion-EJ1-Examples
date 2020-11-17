using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace _03022020_1.Controllers
{
    public class AutocompleteController : ApiController
    {
       
        // GET api/<controller>
        [System.Web.Http.HttpGet]
        public IEnumerable<EmployeeList> Get()
        {
            List<EmployeeList> details = new List<EmployeeList>();
            details.Add(new EmployeeList { ID = 1, Name = "Mark", JoiningDate = "6/2/2020", Age = 30 });
            details.Add(new EmployeeList { ID = 2, Name = "Allan", JoiningDate = "6/2/2020", Age = 35 });
            details.Add(new EmployeeList { ID = 3, Name = "Johny", JoiningDate = "6/2/2020", Age = 21 });
            details.Add(new EmployeeList { ID = 4, Name = "David", JoiningDate = "7/2/2020", Age = 25 });
            details.Add(new EmployeeList { ID = 5, Name = "Louis", JoiningDate = "7/2/2020", Age = 28 });
            return details;
        }
        public JsonResult GetDataCar(string data)
        {
            var data1 = Get();
            if (data != null)
            {
                // filter by startswith
                // var search = from n in data1 where n.Name.ToLower().StartsWith(data.ToLower()) select n;
                // filter by contains
                var search = from n in data1 where n.Name.ToLower().Contains(data.ToLower()) select n;

                return new JsonResult()
                {
                    Data = search,
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet
                };
            }
            else
            {
                return new JsonResult()
                {
                    Data = data1,
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet
                };
            }
        }





    }
    public class EmployeeList
    {
        public int ID;

        public string Name;

        public string JoiningDate;

        public int Age;


    }
}