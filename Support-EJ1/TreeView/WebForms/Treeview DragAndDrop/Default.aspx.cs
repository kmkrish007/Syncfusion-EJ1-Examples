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
        List<LoadData> treeData2 = new List<LoadData>();
        protected void Page_Load(object sender, EventArgs e)
        {
            treeData.Add(new LoadData { Id = 1, Parent = 0, Text = "Item 1", Expanded = true });
            treeData.Add(new LoadData { Id = 2, Parent = 0, Text = "Item 2" });
            treeData.Add(new LoadData { Id = 3, Parent = 0, Text = "Item 3" });
            treeData.Add(new LoadData { Id = 4, Parent = 0, Text = "Item 4" });
            treeData.Add(new LoadData { Id = 5, Parent = 1, Text = "Item 1.1" });
            treeData.Add(new LoadData { Id = 6, Parent = 1, Text = "Item 1.2" });
            treeData.Add(new LoadData { Id = 7, Parent = 1, Text = "Item 1.3" });
            treeData.Add(new LoadData { Id = 8, Parent = 3, Text = "Item 3.1" });
            treeData.Add(new LoadData { Id = 9, Parent = 3, Text = "Item 3.2" });
            treeData.Add(new LoadData { Id = 10, Parent = 5, Text = "Item 1.1.1" });
            this.treeViewDrag.DataSource = treeData;

            treeData2.Add(new LoadData { Id = 11, Parent = 0, Text = "Item 5", Expanded = true });
            treeData2.Add(new LoadData { Id = 12, Parent = 0, Text = "Item 6" });
            treeData2.Add(new LoadData { Id = 13, Parent = 0, Text = "Item 7" });
            treeData2.Add(new LoadData { Id = 14, Parent = 0, Text = "Item 4" });
            treeData2.Add(new LoadData { Id = 15, Parent = 11, Text = "Item 5.1" });
            treeData2.Add(new LoadData { Id = 16, Parent = 11, Text = "Item 5.2" });
            treeData2.Add(new LoadData { Id = 17, Parent = 11, Text = "Item 5.3" });
            treeData2.Add(new LoadData { Id = 18, Parent = 13, Text = "Item 7.1" });
            treeData2.Add(new LoadData { Id = 19, Parent = 13, Text = "Item 7.2" });
            treeData2.Add(new LoadData { Id = 10, Parent = 15, Text = "Item 5.1.1" });
            this.treeViewDrop.DataSource = treeData2;
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