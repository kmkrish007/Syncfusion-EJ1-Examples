using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DropDown_Text
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.DataSource = "http://mvc.syncfusion.com/Services/Northwnd.svc/Orders";

        }
    }
}