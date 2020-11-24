using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        List<Employee> Data = new List<Employee>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                d_addons.ShowOnInit = true;
            }
            
            Data.Add(new Employee
            {
                Text = "Erik Linden",
                Role = "Executive",
                Country = "England",
            });
            Data.Add(new Employee
            {
                Text = "John Linden",
                Role = "Representative",
                Country = "Norway",
            });
            Data.Add(new Employee
            {
                Text = "Louis",
                Role = "Representative",
                Country = "Australia",
            });
            Data.Add(new Employee
            {
                Text = "Lawrence",
                Role = "Executive",
                Country = "India",
            });
            txtaddonname.DataSource = Data;
        }

        protected void txtaddonname_ValueSelect(object sender, Syncfusion.JavaScript.Web.DropdownListEventArgs e)
        {
            var val = e.Arguments["value"];
        }
    }
    public class Employee
    {
        public string Text { get; set; }
        public string Role { get; set; }
        public string Country { get; set; }
    }
}