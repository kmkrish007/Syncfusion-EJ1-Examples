using System;
using System.Collections.Generic;
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
           // RTE_Custom_Welcome_Text.Value = "Welcome to the section of the CE Portal for Sample Memorial Hospital.  This is the one spot where you can find upcoming events, download course materials, take online evaluations, and login to get your CE certificates and transcripts. <br><br> This portal is a collaboration between Sample Memorial Hospital and the education documentation system, eeds.  As a result, some links make take you away from this portal and <span style=\"color: rgb(149, 55, 52); \"><b>to the eeds website to access more information.</b></span>";
        }

        protected void Sub_Click(object sender, EventArgs e)
        {
            //Response.Redirect($"Default.aspx");
            Response.Redirect($"about.aspx");
        }
    }
}