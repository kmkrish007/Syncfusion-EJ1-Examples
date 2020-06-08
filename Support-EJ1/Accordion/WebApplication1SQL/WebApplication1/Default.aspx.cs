using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Syncfusion.JavaScript.Web;
using Syncfusion.JavaScript.Models;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadAcc();

            }
        }

        private void LoadAcc()
        {
             string sql = "select * from tbl_Contents";
             SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnectionString"].ToString());
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
                     lbTitle.Text = dr["Title"].ToString();
                     lbContent.Text = dr["Detail"].ToString();
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