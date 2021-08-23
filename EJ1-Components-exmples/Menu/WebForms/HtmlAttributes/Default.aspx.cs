using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Menu
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Syncfusion.JavaScript.Web.MenuItem items = new Syncfusion.JavaScript.Web.MenuItem();
            items.Id = "01";
            items.Text = "New";
            items.HtmlAttributes = "class='e-disabled-item'";
            MenuCtrl.Items.Add(items);
        }
    }
}