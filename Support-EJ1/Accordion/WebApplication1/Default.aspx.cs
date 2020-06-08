using Syncfusion.JavaScript.Web;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
                string sql = "SELECT * FROM Categories";
                SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
                SqlCommand cmd = new SqlCommand(sql, myConnection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    Label lbTitle;
                    Label lbContent;
                    AccordionItem acc;
                    int i = 0;

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        lbTitle = new Label();
                        lbContent = new Label();
                        lbTitle.Text = dr["CategoryName"].ToString();
                        lbContent.Text = dr["Description"].ToString();
                        acc = new AccordionItem();
                        acc.Text = lbTitle.Text;
                        acc.ID = "Pane" + i;
                        acc.ContentSection.Controls.Add(lbContent);
                        Accordion.Items.Add(acc);
                        ++i;
                    }
                }
        }
    }
}