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
            Syncfusion.JavaScript.Web.Signature sign = new Syncfusion.JavaScript.Web.Signature();
            sign.StrokeWidth = 3;
            sign.Height = "400px";
            sign.IsResponsive = true;
            ControlDIv.Controls.Add(sign);
        }
    }
}