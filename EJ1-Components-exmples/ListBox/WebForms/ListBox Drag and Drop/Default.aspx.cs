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
            listBoxSample.DataSource = GetData();
            listBox3.DataSource = GetData();
        }

        protected void ListBox1_ItemDrop(object sender, Syncfusion.JavaScript.Web.ListBoxEventArgs e)
        {
            Response.Redirect("http://www.google.com");
        }

        protected void ListBox2_ItemDrop(object sender, Syncfusion.JavaScript.Web.ListBoxEventArgs e)
        {
            Response.Redirect("http://www.google.com");
        }

        protected void treeview_NodeDropped(object sender, Syncfusion.JavaScript.Web.TreeViewEventArgs e)
        {
            var str = e.Arguments;
        }

        protected void treeview2_NodeDropped(object sender, Syncfusion.JavaScript.Web.TreeViewEventArgs e)
        {
            var tt = e.Arguments;
        }

        private List<Languages> GetData()

        {

            List<Languages> data = new List<Languages>();

            data.Add(new Languages() { Name = "ASP.NET" });

            data.Add(new Languages() { Name = "ActionScript" });

            data.Add(new Languages() { Name = "Basic" });

            return data;

        }

        protected void listBox3_ItemDrop(object sender, Syncfusion.JavaScript.Web.ListBoxEventArgs e)
        {
            var aa = e.Arguments;
        }

        protected void listBoxSample_ItemDrop(object sender, Syncfusion.JavaScript.Web.ListBoxEventArgs e)
        {
            var b = e.Arguments;
        }
    }

    public class Languages

    {

        public string Name;

    }
}