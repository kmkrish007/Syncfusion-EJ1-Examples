using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using System.Web.Http.Results;


using _26012020_2.Models;


namespace _26012020_2.Controllers
{
    public class EmployeesController : ApiController
    {


        private MockDb db;
        public EmployeesController()
        {
            db = PopulateDb();
        }

        // GET: api/Employees
        public IEnumerable<Employee> Get()
        {
            return db.Employees;
        }

        // GET: api/Employees/5
        public Employee Get(int id)
        {
            return db.Employees.Where(e => e.ID == id).FirstOrDefault();
        }

        // POST: api/Employees
        public void Post([FromBody]Employee value)
        {
        }

        // PUT: api/Employees/5
        public void Put(int id, [FromBody]Employee value)
        {
        }

        // DELETE: api/Employees/5
        public void Delete(int id)
        {
        }

        private MockDb PopulateDb()
        {
            var employees = new List<Employee>{
                new Employee
                {
                    ID = 1,
                    Name = "Mark",
                    JoiningDate = DateTime.Today,
                    Age = 30
                },
                new Employee
                 {
                     ID = 2,
                     Name = "Aliah",
                     JoiningDate = DateTime.Today,
                     Age = 35
                 },
                 new Employee
                 {
                     ID = 3,
                     Name = "Johny",
                     JoiningDate =DateTime.Today,
                     Age = 21
                 }
            };

            MockDb db = new MockDb() { Employees = employees.AsEnumerable() };
            return db;
        }
    }
}
