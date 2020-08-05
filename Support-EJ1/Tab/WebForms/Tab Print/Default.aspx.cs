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
            //this.lstSDN.DataSource = GetListItems();
            //this.lstSDN1.DataSource = GetListItems();
        }
        public List<ListViewData> GetListItems()
        {
            List<ListViewData> data = new List<ListViewData>();
            data.Add(new ListViewData() { Name = "Brooke", Class = "brooke", Designation = "HR Assistant" });
            data.Add(new ListViewData() { Name = "Claire", Class = "claire", Designation = "HR Manager" });
            data.Add(new ListViewData() { Name = "Erik", Class = "erik", Designation = "Training Specialist" });
            data.Add(new ListViewData() { Name = "Grace", Class = "grace", Designation = "Development Manager" });
            data.Add(new ListViewData() { Name = "Jacob", Class = "jacob", Designation = "Recruitment Manager" });
            data.Add(new ListViewData() { Name = "Derek", Class = "hale", Designation = "Development Manager" });
            data.Add(new ListViewData() { Name = "Oliver", Class = "queeen", Designation = "Recruitment Manager" });
            data.Add(new ListViewData() { Name = "Stiles", Class = "flash", Designation = "Development Manager" });
            data.Add(new ListViewData() { Name = "Tomas", Class = "shelby", Designation = "Recruitment Manager" });
            return data;
        }
    }

public class ListViewData
{

    public string Name
    {
        get;
        set;
    }

    public string Class
    {
        get;
        set;
    }

    public string Designation
    {
        get;
        set;
    }
    public string About
    {
        get;
        set;
    }
}
}