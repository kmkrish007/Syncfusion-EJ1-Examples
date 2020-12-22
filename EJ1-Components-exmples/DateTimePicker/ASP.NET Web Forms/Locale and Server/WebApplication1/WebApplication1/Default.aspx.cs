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
            this.DateTimePicker1.DateTimePickerButtonText = new Syncfusion.JavaScript.Models.ButtonText() { Today = "σήμερα", Done= "Ολοκληρώθηκε", TimeNow= "Ώρα τώρα", TimeTitle= "Τίτλος ώρας" };
        }

        protected void ejBtn_Click(object Sender, Syncfusion.JavaScript.Web.ButtonEventArgs e)
        {
            this.DateTimePicker1.Value = new DateTime(2020, 10, 20);
        }
    }
}