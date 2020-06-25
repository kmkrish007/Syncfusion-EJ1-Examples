using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Syncfusion.JavaScript.Web;

namespace Treeview
{
    public partial class _Default : Page
    {
        List<LoadData> treeData = new List<LoadData>();
        public List<LoadData> Predicates = new List<LoadData>();
        public string value;
        public bool search = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            treeData.Add(new LoadData { Id = 1, Parent = 0, Text = "Australia", Expanded = true });
            treeData.Add(new LoadData { Id = 2, Parent = 0, Text = "Brazil" });
            treeData.Add(new LoadData { Id = 3, Parent = 0, Text = "China" });
            treeData.Add(new LoadData { Id = 4, Parent = 0, Text = "India" });
            treeData.Add(new LoadData { Id = 5, Parent = 1, Text = "New South Wales" });
            treeData.Add(new LoadData { Id = 6, Parent = 1, Text = "Victoria" });
            treeData.Add(new LoadData { Id = 7, Parent = 1, Text = "South Australia" });
            treeData.Add(new LoadData { Id = 8, Parent = 2, Text = "Paraná" });
            treeData.Add(new LoadData { Id = 9, Parent = 2, Text = "Ceará" });
            treeData.Add(new LoadData { Id = 10, Parent = 2, Text = "Acre" });
            treeData.Add(new LoadData { Id = 11, Parent = 3, Text = "Guangzhou" });
            treeData.Add(new LoadData { Id = 12, Parent = 3, Text = "Shanghai" });
            treeData.Add(new LoadData { Id = 13, Parent = 3, Text = "Beijing" });
            treeData.Add(new LoadData { Id = 14, Parent = 3, Text = "Shantou" });
            treeData.Add(new LoadData { Id = 15, Parent = 4, Text = "Assam" });
            treeData.Add(new LoadData { Id = 16, Parent = 4, Text = "Bihar" });
            treeData.Add(new LoadData { Id = 17, Parent = 4, Text = "Tamil Nadu" });
            treeData.Add(new LoadData { Id = 18, Parent = 4, Text = "Punjab" });

            this.treeViewDrag.DataSource = treeData;

        }

        protected void inputBox_FocusOut(object sender, Syncfusion.JavaScript.Web.MaskEditFocusOutEventArgs e)
        {
            var val = e.Arguments["value"];
            if (val != null)
            {
                this.value = val.ToString();
            }
            List<int> _array = new List<int>();
            if (this.value == null)
            {
                this.ChangeDataSource(treeData);
            }
            else
            {
                var FilterData = treeData.FindAll(x => x.Text.ToLower().StartsWith(this.value.ToLower()));
                var FilterList = FilterData.ToList();
                for (var i = 0; i < FilterList.Count; i++)
                {
                    var filters = GetFilterItems(FilterList[i]);
                    for (var j = 0; j < filters.Count; j++)
                    {
                        if (_array.Contains(filters[j]) == false && filters[j] != null)
                        {
                            _array.Add(filters[j]);
                            var predicate = treeData.FindAll(x => x.Id.Equals(filters[j]));
                            Predicates.Add(predicate[0]);
                        }

                    }
                }
                if (Predicates.Count == 0)
                {
                    this.treeViewDrag.DataSource = null;
                }
                else
                {
                    var newList = Predicates.ToList();
                    this.ChangeDataSource(newList);
                    Predicates.Clear();
                    _array.Clear();
                }
            }
        }

        public List<int> GetFilterItems(LoadData fList)
        {
            List<int> nodes = new List<int>();
            nodes.Add(fList.Id);
            var ParentData = treeData.FindAll(e => e.Id.Equals(fList.Parent));
            var ParentItem = ParentData.ToList();
            if (ParentItem.Count != 0)
            {
                var pNode = GetFilterItems(ParentItem[0]);
                for (var i = 0; i < pNode.Count; i++)
                {
                    if (nodes.IndexOf(pNode[i]) == -1 && pNode[i] != null)
                        nodes.Add(pNode[i]);
                }
                return nodes;
            }
            return nodes;
        }

        public void ChangeDataSource(List<LoadData> Data)
        {
            if (this.value != "")
            {
                this.search = true;
            }
            this.treeViewDrag.DataSource = Data;
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