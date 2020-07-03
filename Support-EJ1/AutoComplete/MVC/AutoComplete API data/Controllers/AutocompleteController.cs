using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;

using AutoCompleteWebAPI_19022020_01.Models;


namespace AutoCompleteWebAPI_19022020_01.Controllers
{
    public class AutocompleteController : ApiController
    {


        // GET api/<controller>
        [System.Web.Http.HttpGet]
        public IEnumerable<Employee> Get()
        {
            List<Employee> details = new List<Employee>();
            details.Add(new Employee { ID = 1, Name = "Mark", JoiningDate = DateTime.Today, Age = 30 });
            details.Add(new Employee { ID = 2, Name = "Allan", JoiningDate = DateTime.Today, Age = 35 });
            details.Add(new Employee { ID = 3, Name = "Johny", JoiningDate = DateTime.Today, Age = 21 });
            details.Add(new Employee { ID = 4, Name = "David", JoiningDate = DateTime.Today, Age = 25 });
            details.Add(new Employee { ID = 5, Name = "Louis", JoiningDate = DateTime.Today, Age = 28 });
            return details;
        }

        public JsonResult GetDataEmployee(string data)
        {
            var data1 = Get();
            if (data != null)
            {
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
}
