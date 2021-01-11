#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


using System.Web.Script.Services;
using System.Web.Services;
using System.Collections;

namespace GridDetailTemplate
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindDatae();
        }

        public static List<Employees> Employee = new List<Employees>();
        private void BindDatae()
        {
            Employee.Add(new Employees(1, "Nancy", "Sales Representative", "Seattle", "USA"));
            Employee.Add(new Employees(2, "Andrew", "Vice President, Sales", "Tacoma", "USA"));
            Employee.Add(new Employees(3, "Janet", "Sales Representative", "Kirkland", "USA"));
            Employee.Add(new Employees(4, "Margaret", "Sales Representative", "Redmond", "USA"));
            Employee.Add(new Employees(5, "Steven", "Sales Manager", "London", "UK"));
            Employee.Add(new Employees(6, "Michael", "Sales Representative", "London", "UK"));
            Employee.Add(new Employees(7, "Robert", "Sales Representative", "London", "UK"));
            Employee.Add(new Employees(8, "Laura", "Inside Sales Coordinator", "Seattle", "USA"));
            Employee.Add(new Employees(9, "Anne", "Sales Representative", "London", "UK"));

            //this.gvRequests.DataSource = Employee;
            //this.gvRequests.DataBind();
        }
        [Serializable]
        public class Employees
        {
            public Employees()
            {

            }
            public Employees(int EmployeeId, string FirstName, string Title, string City, string Country)
            {

                this.EmployeeID = EmployeeId;
                this.FirstName = FirstName;
                this.Title = Title;
                this.City = City;
                this.Country = Country;
            }
            public int EmployeeID { get; set; }
            public string FirstName { get; set; }
            public string Title { get; set; }
            public string City { get; set; }
            public string Country { get; set; }
        }
                
        public static List<Orders> order = null;
        public static List<Orders> BindDataSource()
        {
            if (order == null)
            {
                order = new List<Orders>();
                int orderId = 10000;
                int empId = 0;
                for (int i = 1; i < 9; i++)
                {
                    order.Add(new Orders(orderId + 1, "VINET", empId + 1, 32.38, new DateTime(2014, 12, 25), "Reims", 43.232, "", null, null));
                    order.Add(new Orders(orderId + 2, "TOMSP", empId + 2, 11.61, new DateTime(2014, 12, 21), "Munster", 54.86, "", null, null));
                    order.Add(new Orders(orderId + 3, "ANATER", empId + 3, 45.34, new DateTime(2014, 10, 18), "Berlin", 34.321, "", null, null));
                    order.Add(new Orders(orderId + 4, "ALFKI", empId + 4, 37.28, new DateTime(2014, 11, 23), "Mexico", 23.142, "", null, null));
                    order.Add(new Orders(orderId + 5, "FRGYE", empId + 5, 67.00, new DateTime(2014, 05, 05), "Colchester", 65.21, "", null, null));
                    orderId += 5;
                    empId += 5;
                }
            }
            return order;
        }

        [Serializable]
        public class Orders
        {
            public Orders()
            {

            }
            public Orders(int orderId, string customerId, int empId, double freight, DateTime orderDate, string shipCity, double UnitPrize, string Growernumber, DateTime? TransactionDate, string Disbursement)
            {
                this.OrderID = orderId;
                this.CustomerID = customerId;
                this.EmployeeID = empId;
                this.Freight = freight;
                this.OrderDate = orderDate;
                this.ShipCity = shipCity;
                this.UnitPrize = UnitPrize;
                this.GrowerNumber = GrowerNumber;
                this.TransactionDate = TransactionDate;
                this.Disbursement = Disbursement;
            }
            public int? OrderID { get; set; }
            public string CustomerID { get; set; }
            public double? EmployeeID { get; set; }
            public double? Freight { get; set; }
            public DateTime? OrderDate { get; set; }
            public string ShipCity { get; set; }
            public double? UnitPrize { get; set; }

            public string GrowerNumber { get; set; }

            public DateTime? TransactionDate { get; set; }

            public string Disbursement { get; set; }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static object Data2()
        {
            IEnumerable data = BindDataSource().ToList();

            return data;
        }
    }
}