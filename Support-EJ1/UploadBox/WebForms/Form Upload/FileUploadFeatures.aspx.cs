using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace SyncfusionASPNETApplication2
{
    public partial class FileUploadFeatures : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void post_Click(object Sender, Syncfusion.JavaScript.Web.ButtonEventArgs e)
        {
            string targetFolder = HttpContext.Current.Server.MapPath("uploadfiles");
            if (!Directory.Exists(targetFolder))
            {
                Directory.CreateDirectory(targetFolder);
            }
            if (Upload1.HasFiles)
            {
                string UserName = Name.Text;
                string UserAge = Age.Text;
                for (int i = 0; i < Upload1.PostedFiles.Count; i++)
                {
                    string fileName = Upload1.PostedFiles[i].FileName;
                    int indx = fileName.LastIndexOf("\\");
                    if (indx > -1)
                    {
                        fileName = fileName.Substring(indx + 1);
                    }
                    Upload1.PostedFiles[i].SaveAs(targetFolder + "\\" + fileName);
                }
            }
        }

        protected void Upload1_Complete(object sender, Syncfusion.JavaScript.Web.UploadBoxCompleteEventArgs e)
        {

        }
   
       
    }
}
