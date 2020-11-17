using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace UploadBox
{
    /// <summary>
    /// Summary description for SaveFile
    /// </summary>
    public class SaveFile : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string targetFolder = HttpContext.Current.Server.MapPath("uploadfiles");
            string dataFromClient = context.Request.Form["uploader_data"];
            if (!Directory.Exists(targetFolder))
            {
                Directory.CreateDirectory(targetFolder);
            }
            HttpRequest request = context.Request;
            HttpFileCollection uploadedFiles = context.Request.Files;
            if (uploadedFiles != null && uploadedFiles.Count > 0)
            {
                for (int i = 0; i < uploadedFiles.Count; i++)
                {
                    string fileName = uploadedFiles[i].FileName;
                    int indx = fileName.LastIndexOf("\\");
                    if (indx > -1)
                    {
                        fileName = fileName.Substring(indx + 1);
                    }
                    uploadedFiles[i].SaveAs(targetFolder + "\\" + fileName);
                }
            }
            else
            {

            }
            context.Response.ContentType = "text/plain";
            context.Response.Write("File has been received");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}