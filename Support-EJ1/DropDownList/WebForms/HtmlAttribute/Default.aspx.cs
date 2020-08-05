using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EJDropDownList
{
    public partial class _Default : Page
    {
        List<DropDownData> data = new List<DropDownData>();
        protected void Page_Load(object sender, EventArgs e)
        {
            data.Add(new DropDownData { Id = 1, Text = "Railways" });
            data.Add(new DropDownData { Id = 2, Text = "Roadways" });
            data.Add(new DropDownData { Id = 3, Text = "Airways" });
            data.Add(new DropDownData { Id = 4, Text = "Waterways" });
            data.Add(new DropDownData { Id = 5, Text = "Electric Trains" });
            data.Add(new DropDownData { Id = 6, Text = "Diesel Trains" });
            data.Add(new DropDownData { Id = 7, Text = "Heavy Motor Vehicles" });
            data.Add(new DropDownData { Id = 8, Text = "Light Motor Vehicles" });
            data.Add(new DropDownData { Id = 9, Text = "Aero planes" });
            data.Add(new DropDownData { Id = 10, Text = "Helicopters", HtmlAttr = "class='e-disable'" });
            data.Add(new DropDownData { Id = 11, Text = "Ships" });
            data.Add(new DropDownData { Id = 12, Text = "Submarines" });
            DropDownList1.DataSource = data;
        }
    }

    public class DropDownData
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public string HtmlAttr { get; set; }
    }
}