using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Treeview
{
    public partial class _Default : Page
    {
        List<LoadData> treeData = new List<LoadData>();
        protected void Page_Load(object sender, EventArgs e)
        {
           // this.treeview.DataSource = "https://js.syncfusion.com/demos/ejServices/Wcf/Northwind.svc/";
           // this.treeview.Query = "ej.Query().from('Customers')";
            //treeData.Add(new LoadData { Id = 1, Parent = 0, Text = "Item 1", Expanded = true });
            //treeData.Add(new LoadData { Id = 2, Parent = 0, Text = "Item 2" });
            //treeData.Add(new LoadData { Id = 3, Parent = 0, Text = "Item 3" });
            //treeData.Add(new LoadData { Id = 4, Parent = 0, Text = "Item 4" });
            //treeData.Add(new LoadData { Id = 5, Parent = 1, Text = "Item 1.1" });
            //treeData.Add(new LoadData { Id = 6, Parent = 1, Text = "Item 1.2" });
            //treeData.Add(new LoadData { Id = 7, Parent = 1, Text = "Item 1.3" });
            //treeData.Add(new LoadData { Id = 8, Parent = 3, Text = "Item 3.1" });
            //treeData.Add(new LoadData { Id = 9, Parent = 3, Text = "Item 3.2" });
            //treeData.Add(new LoadData { Id = 10, Parent = 5, Text = "Item 1.1.1" });
          //  this.treeview.DataSource = treeData;
        }
    }

    public class LoadData
    {
        public int Id { get; set; }
        public int Parent { get; set; }
        public string Text { get; set; }
        public bool Expanded { get; set; }
    }
}