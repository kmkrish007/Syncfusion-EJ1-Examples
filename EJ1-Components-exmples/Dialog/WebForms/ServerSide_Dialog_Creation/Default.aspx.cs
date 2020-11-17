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
            Syncfusion.JavaScript.Web.Dialog dialog = new Syncfusion.JavaScript.Web.Dialog();
            dialog.ID = "dialog";
            dialog.ClientIDMode = ClientIDMode.Static;
            dialog.Title = "Confirmation dialog";
            dialog.ShowFooter = true;
            dialog.ClientSideOnClose = "onDialogClose";
            dialog.FooterTemplateId = "sample";
            ControlDIv.Controls.Add(dialog);
        }
    }
}