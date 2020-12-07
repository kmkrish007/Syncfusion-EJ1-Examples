using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object Sender, Syncfusion.JavaScript.Web.ButtonEventArgs e)
        {
            HtmlGenericControl DivEle = new HtmlGenericControl("div");
            DivEle.InnerHtml = "<img src='Content/images/1.png' class='img' alt='first image' />";
            basicDialog.DialogContent = DivEle;
        }
    }
}