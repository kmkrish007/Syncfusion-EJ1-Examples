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
            Syncfusion.JavaScript.Web.ToggleButton toggle1 = (Syncfusion.JavaScript.Web.ToggleButton)Page.FindControl("ToggleButton2");

        }

        protected void SeverClick(object sender, Syncfusion.JavaScript.Web.ButtonEventArgs e)
        {
            Syncfusion.JavaScript.Web.ToggleButton toggle1 = (Syncfusion.JavaScript.Web.ToggleButton)Page.FindControl("ToggleButton2");
            Syncfusion.JavaScript.Web.ToggleButton toggle = (Syncfusion.JavaScript.Web.ToggleButton)Master.FindControl("ToggleButton1");
        }
    }
}