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
        }
        [System.Web.Services.WebMethod]
        public static string GetCurrentItme(Dictionary<object, object> captchaModel)
        {
            return Syncfusion.JavaScript.Web.Captcha.GetModel(captchaModel).ExecuteResult();
        }

    }
}