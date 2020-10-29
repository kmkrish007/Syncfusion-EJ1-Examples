using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Autocomplete1.DataSource = First();


            Autocomplete2.DataSource = SecondData();

        }

        protected void Autocomplete1_ValueSelect(object sender, Syncfusion.JavaScript.Web.AutocompleteSelectEventArgs e)
        {
            var key = e.Key;
            List<Details> data = new List<Details>();
            for (var i=0; i < SecondData().Count; i++)
            {
                if (key == SecondData()[i].Product_ID.ToString())
                {
                    data.Add(SecondData()[i]);
                }
            }
            Autocomplete2.DataSource = data;
        }

        public static List<Customer> First()
        {
            List<Customer> Customers = new List<Customer>();
            Customers.Add(new Customer() { Product_ID = 1, Product_Group = "healthy", Description = "Its healthy products" });
            Customers.Add(new Customer() { Product_ID = 2, Product_Group = "Unhealthy", Description = "Its Unhealthy products" });
            return Customers;
        }

        public static List<Details> SecondData()
        {
            List<Details> details = new List<Details>();
            details.Add(new Details() { Details_ID = 1, Product_ID = 1, Products = "Apple" });
            details.Add(new Details() { Details_ID = 2, Product_ID = 1, Products = "Ego" });
            details.Add(new Details() { Details_ID = 3, Product_ID = 1, Products = "Orange" });
            details.Add(new Details() { Details_ID = 4, Product_ID = 2, Products = "Pizza" });
            details.Add(new Details() { Details_ID = 5, Product_ID = 2, Products = "Magi" });
            return details;
        }

        }
    public class Customer
    {
        public int Product_ID { get; set; }
        public string Product_Group { get; set; }
        public string Description { get; set; }
    }

    public class Details
    {
        public int Details_ID { get; set; }
        public int Product_ID { get; set; }
        public string Products { get; set; }
    }
}