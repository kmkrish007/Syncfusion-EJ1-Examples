using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace UploadBox
{
    /// <summary>
    /// Summary description for SaveFile
    /// </summary>
    public class SaveFile : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            // get data from client side
            string dataFromClient = context.Request.Form["upload_data"];
            var custompath = JsonConvert.DeserializeObject(dataFromClient);
            // target folder
            string targetFolder = HttpContext.Current.Server.MapPath(custompath.ToString());

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
            // pass target path to client side
            context.Response.Write(targetFolder);
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