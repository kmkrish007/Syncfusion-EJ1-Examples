using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Syncfusion.JavaScript;
using Syncfusion.JavaScript.DataSources;
using Syncfusion.JavaScript.Models;
using Syncfusion.JavaScript.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Collections;
using System.ComponentModel;
using System.Data;
using Newtonsoft.Json;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        //public static List<loadOnDemand> returnData;

        protected void Page_Load(object sender, EventArgs e)
        {
            List<tree> data = new List<tree>();
            data.Add(new tree() { Name = "Tree 1", Id = 1 });
            data.Add(new tree() { Name = "Tree 2", Id = 2 });
            data.Add(new tree() { Name = "Tree 3", Id = 3 });
            listBoxSample.DataSource = data;

            var load = new loadOnDemand();
            tree.DataSource = load.GetTreeItems();
        }

        [System.Web.Services.WebMethod]
        public static object Data(int id)
        {
            if (id == 2)
            {
                return GetTree2Data();
            }
            else
            {
                var load = new loadOnDemand();
                return load.GetTreeItems();
            }
        }

        public static List<LoadData> GetTree2Data()
        {
            List<LoadData> treeData = new List<LoadData>();
            treeData.Add(new LoadData { ID = 1, ParentID = 0, Text = "Item 1", Expanded = true });
            treeData.Add(new LoadData { ID = 2, ParentID = 0, Text = "Item 2" });
            treeData.Add(new LoadData { ID = 3, ParentID = 0, Text = "Item 3" });
            treeData.Add(new LoadData { ID = 4, ParentID = 0, Text = "Item 4" });
            treeData.Add(new LoadData { ID = 5, ParentID = 1, Text = "Item 1.1" });
            treeData.Add(new LoadData { ID = 6, ParentID = 1, Text = "Item 1.2" });
            treeData.Add(new LoadData { ID = 7, ParentID = 1, Text = "Item 1.3" });
            treeData.Add(new LoadData { ID = 8, ParentID = 3, Text = "Item 3.1" });
            treeData.Add(new LoadData { ID = 9, ParentID = 3, Text = "Item 3.2" });
            treeData.Add(new LoadData { ID = 10, ParentID = 5, Text = "Item 1.1.1" });
            return treeData;
        }
    }

    public class tree
    {
        public string Name;
        public int Id;
    }

    public class LoadData
    {
        public int ID { get; set; }
        public int ParentID { get; set; }
        public string Text { get; set; }
        public bool Expanded { get; set; }
    }

    [Serializable]
    public class loadOnDemand
    {
        public loadOnDemand(int _id, int _parentId = 0, string _text = "", string _hasChild = "")
        {
            this.ID = _id;
            this.ParentID = _parentId;
            this.Text = _text;
            this.HasChild = _hasChild;
        }
        public loadOnDemand() { }

        [Browsable(true)]
        public int ID { get; set; }

        [Browsable(true)]
        public int ParentID { get; set; }

        [Browsable(true)]
        public string Text { get; set; }

        [Browsable(true)]
        public string HasChild { get; set; }

        public List<loadOnDemand> GetTreeItems()
        {
            List<loadOnDemand> data = new List<loadOnDemand>();
            data.Add(new loadOnDemand(1, 0, "Local Disk(C:)", "true"));
            data.Add(new loadOnDemand(2, 0, "Local Disk(D:)", "true"));
            data.Add(new loadOnDemand(3, 0, "Local Disk(E:)", "true"));
            data.Add(new loadOnDemand(4, 1, "Folder 1", "true"));
            data.Add(new loadOnDemand(5, 1, "Folder 2"));
            data.Add(new loadOnDemand(6, 1, "Folder 3"));
            data.Add(new loadOnDemand(7, 2, "Folder 4"));
            data.Add(new loadOnDemand(8, 2, "Folder 5", "true"));
            data.Add(new loadOnDemand(9, 2, "Folder 6"));
            data.Add(new loadOnDemand(10, 3, "Folder 7"));
            data.Add(new loadOnDemand(11, 3, "Folder 8"));
            data.Add(new loadOnDemand(12, 3, "Folder 9", "true"));
            data.Add(new loadOnDemand(13, 4, "File 1"));
            data.Add(new loadOnDemand(14, 4, "File 2"));
            data.Add(new loadOnDemand(15, 4, "File 3"));
            data.Add(new loadOnDemand(16, 8, "File 4"));
            data.Add(new loadOnDemand(17, 8, "File 5"));
            data.Add(new loadOnDemand(18, 8, "File 6"));
            data.Add(new loadOnDemand(19, 12, "File 7"));
            data.Add(new loadOnDemand(20, 12, "File 8"));
            data.Add(new loadOnDemand(21, 12, "File 9"));
            return data;
        }

    }
}