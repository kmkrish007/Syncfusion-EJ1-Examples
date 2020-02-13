using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DropDown_Value
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<SeasonData> DropdownData = new List<SeasonData>();
            DataTable dts = new DataTable();

            dts.Columns.Add("CalenderName");
            DataRow dr = null;

            for (int i = 0; i < 10; i++)
            {
                dr = dts.NewRow(); // have new row on each iteration
                dr["CalenderName"] = "SFCalander - " + i.ToString();
                dts.Rows.Add(dr);
            }
            foreach (DataRow drs in dts.Rows)
            {
                DropdownData.Add(new SeasonData { Text = drs["CalenderName"].ToString() });
            }
            DropDownList1.DataSource = DropdownData;
        }

        public class SeasonData
        {
            public string Text { get; set; }
        }
    }
}