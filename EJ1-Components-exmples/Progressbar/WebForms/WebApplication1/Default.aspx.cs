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
            Syncfusion.JavaScript.Web.ProgressBar Progress = new Syncfusion.JavaScript.Web.ProgressBar();
            Progress.Percentage = 70;
            Progress.Text = "70 %";
            Progress.MaxValue = 100;
            Progress.Height = "25px";
            Progress.Width = "500px";
            ControlDIv.Controls.Add(Progress);
        }
    }
}