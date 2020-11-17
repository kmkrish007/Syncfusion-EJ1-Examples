using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _26012020_2.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime JoiningDate { get; set; }
        public int Age { get; set; }

    }

    public class CarsList
    {
        public int uniqueKey { get; set; }
        public string text { get; set; }
        public string company { get; set; }
    }
}