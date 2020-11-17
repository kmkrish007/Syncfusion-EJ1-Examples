using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sample145862;
using MVCSampleBrowser.Models;
using Syncfusion.Linq;
using System.Collections;
using Syncfusion.JavaScript;

using System.Web.Script.Serialization;
using System.Net;
using System.Reflection;
using System.EnterpriseServices;

using System.ComponentModel;
using Syncfusion.JavaScript.DataSources;
using Syncfusion.JavaScript.Models;

namespace Sample145862.Controllers
{
    public class GridController : Controller
    {
        //
        // GET: /Grid/
        // List<ParentItem> parent = new List<ParentItem>();
        public List<Employees> employee = new List<Employees>();
        public static List<Orders> order = new List<Orders>();
       public static List<Bikes> bike = new List<Bikes>();
        public ActionResult GridFeatures()
        {
            BindDataSource();
            var DataSource = order.ToList();
            ViewBag.datasource = DataSource;
            employee.Add(new Employees(1, "Michael"));
            employee.Add(new Employees(2, "Anne"));
            employee.Add(new Employees(3, "Janet"));
            employee.Add(new Employees(4, "Andrew"));

            employee.Add(new Employees(6, "Nancy"));
            employee.Add(new Employees(7, "Robert"));
            employee.Add(new Employees(8, "Laura"));
            employee.Add(new Employees(9, "Steven"));
            employee.Add(new Employees(10, "James"));
            employee.Add(new Employees(11, "Smith"));
            employee.Add(new Employees(12, "Jhonson"));
            employee.Add(new Employees(13, "George"));
            ViewBag.dataSource2 = employee;
            //bike.Add(new Bikes { empid = "bk1", text = "Apache RTR" });
            //bike.Add(new Bikes { empid = "bk2", text = "CBR 150-R" });
            //bike.Add(new Bikes { empid = "bk3", text = "CBZ Xtreme" });
            //bike.Add(new Bikes { empid = "bk4", text = "Discover" });
            //bike.Add(new Bikes { empid = "bk5", text = "Dazzler" });
            //bike.Add(new Bikes { empid = "bk6", text = "Flame" });
            //bike.Add(new Bikes { empid = "bk7", text = "Fazzer" });
            //bike.Add(new Bikes { empid = "bk8", text = "FZ-S" });
            //bike.Add(new Bikes { empid = "bk9", text = "Pulsar" });
            //bike.Add(new Bikes { empid = "bk10", text = "Shine" });
            //bike.Add(new Bikes { empid = "bk11", text = "R15" });
            //bike.Add(new Bikes { empid = "bk12", text = "Unicorn" });
            //ViewBag.datasource = bike;
            return View();
           

            
        }
        
        [Serializable]
        public class Employees
        {
            public Employees()
            {

            }
            public Employees(int EmployeeId, string FirstName)
            {
                this.EmployeeID = EmployeeId;
                this.FirstName = FirstName;
            }
            public int EmployeeID { get; set; }
            public string FirstName { get; set; }
        }
        public class Bikes
        {
            public string text { get; set; }
            public string empid { get; set; }
        }
        public static void BindDataSource()
        {
            int code = 10000, i;
            for (i= 1; i < 1000; i++)
            {
                order.Add(new Orders(code + 1,"VINET", new DateTime(1991, 05, 15), i+ 1, 2.3 * i, "Vins et alcoos Chevalier fhhgh", "Berlin", "Argentina", true));
                order.Add(new Orders(code + 2,"SUPRD", new DateTime(1991, 05, 06), i+ 2, 3.3 * i, "Toms spezialitatean hhkkhk", "Madrid", "Autria", false));
                order.Add(new Orders(code + 3,"VICTE", new DateTime(1991, 05, 07), i+ 3, 4.3 * i, "Hanari Carnes kkhkhkhk", "Cholchester", "Austria", true));
                order.Add(new Orders(code + 4,"ANDRE",new DateTime(1991, 05, 10), i+4, 5.3 * i, "Victuailles en stock khkkhkkjkjkj", "Marseille", "Argentina", true));
                order.Add(new Orders(code + 5,"VIVV", new DateTime(1991, 05, 11), i+5, 2.3 * i, "Vins et alcoos Chevalier hkhkhk hkhkhkhkhk", "Berlin", "Argentina", true));
                order.Add(new Orders(code + 6,"VIVo", new DateTime(1991, 05, 12), 6, 3.3 * i, "Toms spezialitatean", "Madrid", "Autria",false));
                order.Add(new Orders(code + 7,"VIVV", new DateTime(1991, 05, 13), 7, 4.3 * i, "Hanari Carnes", "Cholchester", "Austria",true));
                order.Add(new Orders(code + 8,"SUPRD", new DateTime(1991, 05, 14), 8, 5.3 * i, "Victuailles en stock", "Marseille", "Argentina",true));
                //order.Add(new Orders(code + 9, new DateTime(1991, 05, 15), 9, 2.3 * i, "Vins et alcoos Chevalier", "Berlin", "Argentina"));
                //order.Add(new Orders(code + 10, new DateTime(1990, 04, 04), 10, 3.3 * i, "Toms spezialitatean", "Madrid", "Autria"));
                //order.Add(new Orders(code + 11, new DateTime(1957, 11, 30), 11, 4.3 * i, "Hanari Carnes", "Cholchester", "Austria"));
                //order.Add(new Orders(code + 12, new DateTime(1930, 10, 22), 12, 5.3 * i, "Victuailles en stock", "Marseille", "Argentina"));
                //order.Add(new Orders(code + 13, new DateTime(1930, 10, 22), 13, 5.3 * i, "Supremes delices", "Tsawassen", "Argentina"));
                code += 5;
                i += 1;
            }

        }
        public ActionResult UrlUpdate(Orders value)
        {
            var ord = value;
            Orders val = order.Where(or => or.OrderID == ord.OrderID).FirstOrDefault();
            val.OrderID = ord.OrderID;
            val.EmployeeID = ord.EmployeeID;
            
            val.Freight = ord.Freight;
            val.ShipCity = ord.ShipCity;
           
            return Json(value, JsonRequestBehavior.AllowGet);
        }
        [Serializable]
        public class Orders
        {
            public Orders()
            {

            }
            public Orders(long OrderId, string CustomerID, DateTime? OrderDate, int EmployeeID, double Freight, string ShipName, string ShipCity, string ShipCountry, bool Verified)
            {
                this.OrderID = OrderId;
                this.CustomerID = CustomerID;
                this.OrderDate = OrderDate;
                this.EmployeeID = EmployeeID; ;
                this.Freight = Freight;
                this.ShipName = ShipName;
                this.ShipCity = ShipCity;
                this.ShipCountry = ShipCountry;
                this.Verified = Verified;
            }
            public long OrderID { get; set; }

            public  string CustomerID { get; set; }
            public DateTime? OrderDate { get; set; }

            public int EmployeeID { get; set; }
            public double Freight { get; set; }
            public string ShipName { get; set; }
            public string ShipCity { get; set; }
            public string ShipCountry { get; set; }

            public Boolean Verified { get; set; }
        }

        public ActionResult UrlDataSource(Syncfusion.JavaScript.DataManager dm)
        {
            if (order.Count() == 0)
                BindDataSource();

            IEnumerable data = order.ToList();
            // IEnumerable data = new NorthwindDataContext().OrdersViews.ToList();
            DataOperations operation = new DataOperations();
            if (dm.Sorted != null && dm.Sorted.Count > 0) //Sorting
            {
                data = operation.PerformSorting(data, dm.Sorted);
            }
            if (dm.Where != null && dm.Where.Count > 0) //Filtering
            {
                data = operation.PerformWhereFilter(data, dm.Where, dm.Where[0].Operator);
               
            }
            if (dm.Search != null && dm.Search.Count > 0) //Searching
            {
                data = operation.PerformSearching(data, dm.Search);


            }
            if (dm.Select != null && dm.Select.Count > 0)
            {
                data = operation.PerformSelect(data, dm.Select);
            }
            var count = data.AsQueryable().Count();
            if (dm.Skip != 0)
            {
                data = operation.PerformSkip(data, dm.Skip);
            }
            if (dm.Take != 0)
            {
                data = operation.PerformTake(data, dm.Take);
            }
          

          
            return Json(new { result = data, count = count });


        }


        
       

    }
}
