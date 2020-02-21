using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace FileSelect
{
    /// <summary>
    /// Summary description for SaveFile
    /// </summary>
    public class SaveFile : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string targetFolder = HttpContext.Current.Server.MapPath("uploadfiles");

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

                    if (uploadedFiles[i].FileName != null && uploadedFiles[i].FileName != "")

                    {

                        string fileName = uploadedFiles[i].FileName;

                        int index = fileName.LastIndexOf("\\");

                        if (index > -1)

                        {

                            fileName = fileName.Substring(index + 1);

                        }

                        uploadedFiles[i].SaveAs(targetFolder + "\\" + fileName);

                    }

                }

            }
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