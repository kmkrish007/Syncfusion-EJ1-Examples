using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
	protected void Page_Load(object sender, EventArgs e)
    {
        List<GridData> DataForGrid1 = new List<GridData>();
        List<GridData> DataForGrid2 = new List<GridData>();
        DataForGrid1.Add(new GridData("First1", 35));
        DataForGrid1.Add(new GridData("Second1", 36));

        DataForGrid2.Add(new GridData("First2", 37));
        DataForGrid2.Add(new GridData("Second2", 38));

        Grid1.DataSource = DataForGrid1;
        Grid1.DataBind();
        Grid2.DataSource = DataForGrid2;
        Grid2.DataBind();
        //     if (!IsPostBack)
        //     {
        //         DataForGrid1.Add(new GridData("First1", 35));
        //DataForGrid1.Add(new GridData("Second1", 36));


        //DataForGrid2.Add(new GridData("First2", 37));
        //DataForGrid2.Add(new GridData("Second2", 38));

        //Grid1.DataSource = DataForGrid1;
        //Grid1.DataBind();
        //Grid2.DataSource = DataForGrid2;
        //Grid2.DataBind();
        //     }
        //     else
        //     {
        //         DataForGrid1.Add(new GridData("First1", 35));
        //DataForGrid1.Add(new GridData("Second1", 36));


        //DataForGrid2.Add(new GridData("First2", 37));
        //DataForGrid2.Add(new GridData("Second2", 38));

        //Grid1.DataSource = DataForGrid1;
        //Grid1.DataBind();
        //Grid2.DataSource = DataForGrid2;
        //Grid2.DataBind();
        //     }
    }




	[Serializable]
	
	public class GridData
	{
		public GridData()
		{

		}
		public GridData(string name, decimal value)
		{
			this.Value = value;
			this.Name = name;
		}
		public decimal Value { get; set; }
		public string  Name { get; set; }
	}


	protected void Tab1_TabItemActive(object sender, Syncfusion.JavaScript.Web.TabEventArgs e)
	{

	}
}