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
            Autocomplete2.DataSource = Second();

        }

        protected void Autocomplete1_ValueSelect(object sender, Syncfusion.JavaScript.Web.AutocompleteSelectEventArgs e)
        {
            var key = e.Key;
            if(key == "1")
            {
                City.Text = "Chennai";
                State.Text = "TamilNadu";
            } else if (key == "2")
            {
                City.Text = "Beacon Hills";
                State.Text = "New york";
            }
        }

        public static List<Address> First()
        {
            List<Address> Addr = new List<Address>();
            Addr.Add(new Address() { ID = "1", ZipCode = "600005" });
            Addr.Add(new Address() { ID = "2", ZipCode = "24019" });
            return Addr;
        }

        public static List<Customer> Second()
        {
            List<Customer> Customers = new List<Customer>();
            Customers.Add(new Customer() { Product_ID = 1, Product_Group = "healthy", Description = "Its healthy products" });
            Customers.Add(new Customer() { Product_ID = 2, Product_Group = "Unhealthy", Description = "Its Unhealthy products" });
            return Customers;
        }

        protected void Autocomplete2_ValueSelect(object sender, Syncfusion.JavaScript.Web.AutocompleteSelectEventArgs e)
        {
            var key = e.Key;
            // using the selected item key value we can peform our custom operation
        }
    }
    public class Address
    {
        public string ID { get; set; }
        public string ZipCode { get; set; }
    }

    public class Customer
    {
        public int Product_ID { get; set; }
        public string Product_Group { get; set; }
        public string Description { get; set; }
    }
}