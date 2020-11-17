using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DatePicker
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var val = dateformat.Value;
            var val1 = datepick.Value;
            var dt = DateTimePicker1.Value;
            //var tp = TimePicker1.Value;
        }
    }
}