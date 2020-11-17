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
        }

        public static List<Customer> First()
        {
            List<Customer> Customers = new List<Customer>();
            Customers.Add(new Customer() { Product_ID = 1, Product_Group = "healthy", Description = "Its healthy products", Products = "Apple" });
            Customers.Add(new Customer() { Product_ID = 2, Product_Group = "Unhealthy", Description = "Its Unhealthy products", Products = "Magi" });
            return Customers;
        }

        protected void Autocomplete1_ValueSelect(object sender, Syncfusion.JavaScript.Web.AutocompleteSelectEventArgs e)
        {
            var items = e.Arguments["item"];
        }
    }
    public class Customer
    {
        public int Product_ID { get; set; }
        public string Product_Group { get; set; }
        public string Description { get; set; }
        public string Products { get; set; }
    }
}