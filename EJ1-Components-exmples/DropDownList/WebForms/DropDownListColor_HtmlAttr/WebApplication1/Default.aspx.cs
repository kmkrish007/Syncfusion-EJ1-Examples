using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            this.ddl_ContactType.DataSource = GetListItems();
        }

        protected void DropBtn_Click(object Sender, Syncfusion.JavaScript.Web.ButtonEventArgs e)
        {
            var items = GetListItems();
            items[0].HtmlAttr = "style='color:red;";
            items[1].HtmlAttr = "style='color:blue;";
            ddl_ContactType.DataSource = items;
        }

        public List<DropDownData> GetListItems()
        {
            List<DropDownData> data = new List<DropDownData>();
            data.Add(new DropDownData { Id = 1, Text = "Railways", HtmlAttr = "style='color:blue;" });
            data.Add(new DropDownData { Id = 2, Text = "Roadways", HtmlAttr = "style='color:red;" });
            data.Add(new DropDownData { Id = 3, Text = "Airways", HtmlAttr = "style='color:green;" });
            data.Add(new DropDownData { Id = 4, Text = "Waterways", HtmlAttr = "style='color:orange;" });
            data.Add(new DropDownData { Id = 5, Text = "Electric Trains", HtmlAttr = "style='color:grey;" });
            data.Add(new DropDownData { Id = 6, Text = "Diesel Trains", HtmlAttr = "style='color:purple;" });
            return data;
        }
    }
    public class DropDownData
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string HtmlAttr { get; set; }
    }
}