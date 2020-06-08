#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Newtonsoft.Json;
using Syncfusion.EJ.PdfViewer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace SyncfusionMvcApplication3.Controllers
{
    public class PdfViewerController : ApiController
    {
	    PdfViewerHelper helper = new PdfViewerHelper();
        public object Load(Dictionary<string, string> jsonResult)
        {
            //load the multiple document from client side 
            if (jsonResult.ContainsKey("newFileName"))
            {
                var name = jsonResult["newFileName"];
                var pdfName = name.ToString();
                helper.Load(Helper.GetFilePath("" + pdfName));
            }
            else
            {
                //Initially load the PDF document from the data folder.
				if (jsonResult.ContainsKey("isInitialLoading"))
                {
                    if (jsonResult.ContainsKey("file"))
                    {
                        var name = jsonResult["file"];
                        helper.Load(name);
                    }
                    else
                    {
                        helper.Load(Helper.GetFilePath("HTTP Succinctly.pdf"));
                    }
                } 
            }
            return JsonConvert.SerializeObject(helper.ProcessPdf(jsonResult));
        }
		 public object FileUpload(Dictionary<string, string> jsonResult)
        {
            if (jsonResult.ContainsKey("uploadedFile"))
            {
                var fileurl = jsonResult["uploadedFile"];
                byte[] byteArray = Convert.FromBase64String(fileurl);
                MemoryStream stream = new MemoryStream(byteArray);
                helper.Load(stream);
            }
            string output = JsonConvert.SerializeObject(helper.ProcessPdf(jsonResult));
            return output;
        }
		 public object Download(Dictionary<string, string> jsonResult)
        {
            return (helper.GetDocumentData(jsonResult));
        }	
    }

    public class Helper
    {
        public static string GetFilePath(string path)
        {
            string _dataPath = GetCommonFolder(new DirectoryInfo(HttpContext.Current.Request.PhysicalApplicationPath));
            _dataPath += @"\" + path;
            return _dataPath;
        }

        static string GetCommonFolder(DirectoryInfo dtInfo)
        {
            var _folderNames = dtInfo.GetDirectories("Data/PdfViewer");
            if (_folderNames.Length > 0)
            {
                return _folderNames[0].FullName;
            }

            return dtInfo.Parent != null ? GetCommonFolder(dtInfo.Parent) : string.Empty;
        }
    }
}