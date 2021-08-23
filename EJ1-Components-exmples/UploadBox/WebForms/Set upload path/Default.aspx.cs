using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UploadBox
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void upload_Complete(object sender, Syncfusion.JavaScript.Web.UploadBoxCompleteEventArgs e)
        {
            var directory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            var filterItems = directory.GetFiles(e.Name, SearchOption.AllDirectories);
            string path = filterItems[0].FullName;
        }
    }
}