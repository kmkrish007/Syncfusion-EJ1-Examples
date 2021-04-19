using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Web.Script.Serialization;
using Syncfusion.JavaScript.Web;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // first treeview datasource
            this.Treeview.DataSource = new TreeIconsDataSource().GetTreeIconItems().ToList();

            //second treeview datasource
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
            this.Treeview1.DataSource = treeData;
        }

        protected void TreeCheck_Click(object Sender, ButtonEventArgs e)
        {
            // integrated treeview
            string clientModel = Page.Request.Params[Treeview.ClientID + "_hidden_model"];
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            Dictionary<string, object> jsonDict = serializer.Deserialize<Dictionary<string, object>>(clientModel);
            var checkedNodes = jsonDict["checkedNodes"];

            // individual treeview
            var TreeCheckedNodes = Treeview1.CheckedNodes;
        }
    }

    public class LoadData
    {
        public int ID { get; set; }
        public int ParentID { get; set; }
        public string Text { get; set; }
        public bool Expanded { get; set; }
    }
    public class TreeIconsDataSource
    {

        public TreeIconsDataSource()
        { }
        public TreeIconsDataSource(int _id, int _parentid, string _text, string _hasChild, string _expanded, string _spriteCssClass)
        {
            this.ID = _id;
            this.ParentID = _parentid;
            this.Text = _text;
            this.HasChild = _hasChild;
            this.Expanded = _expanded;
        }
        [Browsable(true)]
        public int ID
        {
            get;
            set;
        }

        [Browsable(true)]
        public int ParentID
        {
            get;
            set;
        }

        [Browsable(true)]
        public string Text
        {
            get;
            set;
        }
        [Browsable(true)]
        public string HasChild
        {
            get;
            set;
        }
        [Browsable(true)]
        public string Expanded
        {
            get;
            set;
        }
        [Browsable(true)]
        public string SpriteCssClass
        {
            get;
            set;
        }

        public List<TreeIconsDataSource> GetTreeIconItems()
        {
            List<TreeIconsDataSource> data = new List<TreeIconsDataSource>();
            data.Add(new TreeIconsDataSource(1, 0, "Mai,l", "true", "true", "mailicon sprite-root"));
            data.Add(new TreeIconsDataSource(2, 1, "Inbox ", "true", "", "mailicon sprite-inbox"));
            data.Add(new TreeIconsDataSource(3, 2, "Development ", "", "", "mailicon sprite-folder"));
            data.Add(new TreeIconsDataSource(4, 2, "Supports", "", "", "mailicon sprite-folder"));
            data.Add(new TreeIconsDataSource(20, 2, "Management", "", "", "mailicon sprite-folder"));
            data.Add(new TreeIconsDataSource(21, 2, "Team Meeting", "", "", "mailicon sprite-folder"));
            data.Add(new TreeIconsDataSource(6, 1, "Drafts", "true", "", "mailicon sprite-drafts"));
            data.Add(new TreeIconsDataSource(7, 6, "Support template ", "", "", "mailicon sprite-folder"));
            data.Add(new TreeIconsDataSource(8, 6, "Personal ", "", "", "mailicon sprite-folder"));
            data.Add(new TreeIconsDataSource(9, 1, "Sent items ", "true", "", "mailicon sprite-sentitems"));
            data.Add(new TreeIconsDataSource(10, 9, "Support ", "", "", "mailicon sprite-folder"));
            data.Add(new TreeIconsDataSource(22, 9, "HTML JS ", "", "", "mailicon sprite-folder"));
            data.Add(new TreeIconsDataSource(24, 1, "De,leted ", "", "", "mailicon sprite-deleted"));
            data.Add(new TreeIconsDataSource(25, 1, "Junk Mails ", "", "", "mailicon sprite-junk"));
            data.Add(new TreeIconsDataSource(26, 1, "Peronal ", "true", "", "mailicon sprite-folder"));
            data.Add(new TreeIconsDataSource(27, 26, "HR Team ", "", "", "mailicon sprite-folder"));
            data.Add(new TreeIconsDataSource(28, 26, "My Works ", "", "", "mailicon sprite-folder"));
            data.Add(new TreeIconsDataSource(29, 26, "Login details ", "", "", "mailicon sprite-folder"));
            data.Add(new TreeIconsDataSource(11, 0, "Calendar", "true", "", "mailicon sprite-calendar"));
            data.Add(new TreeIconsDataSource(12, 11, "My C,alendar ", "", "", "mailicon sprite-calendar"));
            data.Add(new TreeIconsDataSource(13, 11, "Team", "", "", "mailicon sprite-calendar"));
            data.Add(new TreeIconsDataSource(14, 11, "Others", "", "", "mailicon sprite-calendar"));
            data.Add(new TreeIconsDataSource(15, 0, "Notes", "true", "", "mailicon sprite-notes"));
            data.Add(new TreeIconsDataSource(16, 15, "My Reference ", "", "", "mailicon sprite-folder"));
            data.Add(new TreeIconsDataSource(30, 0, "Contacts", "true", "", "mailicon sprite-contacts"));
            data.Add(new TreeIconsDataSource(31, 30, "Suggested", "", "", "mailicon sprite-contacts"));
            data.Add(new TreeIconsDataSource(32, 30, "MY Team", "", "", "mailicon sprite-contacts"));


            return data;
        }
    }
}