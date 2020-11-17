using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace UploadBox
{
    /// <summary>
    /// Summary description for removeFile
    /// </summary>
    public class removeFile : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            System.Collections.Specialized.NameValueCollection s = context.Request.Params;
            string fileName = s["fileNames"];
            string targetFolder = HttpContext.Current.Server.MapPath("uploadfiles");
            var customdata = context.Request.Params[0];
            if (Directory.Exists(targetFolder))
            {
                string physicalPath = targetFolder + "\\" + fileName;
                if (System.IO.File.Exists(physicalPath))
                {
                    System.IO.File.Delete(physicalPath);
                }
            }
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
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