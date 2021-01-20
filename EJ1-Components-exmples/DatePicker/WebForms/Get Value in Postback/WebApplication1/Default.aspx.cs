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
            if (IsPostBack)
            {
                var val = datep.Value;
                var rteval = RTE2.Value;
                var txt = ToggleButtonLarge.ActiveText;
            }
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                var val = datep.Value;
                var rteval = RTE2.Value;
                var txt = ToggleButtonLarge.ActiveText;
            }
        }
    }
}