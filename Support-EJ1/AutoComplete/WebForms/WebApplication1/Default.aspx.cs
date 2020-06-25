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
            List<Customer> Customers = new List<Customer>();
            Customers.Add(new Customer() { ClientNumber = 1, ClientName = "John", RMName = "Derek" });
            Customers.Add(new Customer() { ClientNumber = 2, ClientName = "Will", RMName = "Smith" });
            Customers.Add(new Customer() { ClientNumber = 3, ClientName = "Stiles", RMName = "Stilinkski" });
            txt_Clientname.DataSource = Customers;

            List<DropDownData> data = new List<DropDownData>();
            data.Add(new DropDownData() { ValueColumn = 1, TextColumn = "Enable" });
            data.Add(new DropDownData() { ValueColumn = 2, TextColumn = "Disable" });
            data.Add(new DropDownData() { ValueColumn = 3, TextColumn = "Airways" });
            data.Add(new DropDownData() { ValueColumn = 4, TextColumn = "Waterways" });

            ddlEnqType.DataSource = data;

            ddlEnqType.ClientSideOnSelect = "onTypeChange";
        }
    }
    public class Customer
    {
        public int ClientNumber { get; set; }
        public string ClientName { get; set; }
        public string RMName { get; set; }
    }

    public class DropDownData
    {
        public int ValueColumn { get; set; }
        public string TextColumn { get; set; }
    }
}