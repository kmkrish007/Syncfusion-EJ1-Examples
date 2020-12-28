using Syncfusion.JavaScript;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileExp
{
    /// <summary>
    /// Summary description for downloadFile
    /// </summary>
    public class downloadFile : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            HttpRequest request = context.Request;
            string path = request.QueryString["Path"];
            string[] names = request.QueryString.GetValues("Names");
            FileExplorerOperations operation = new FileExplorerOperations();
            operation.Download(path, names);
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