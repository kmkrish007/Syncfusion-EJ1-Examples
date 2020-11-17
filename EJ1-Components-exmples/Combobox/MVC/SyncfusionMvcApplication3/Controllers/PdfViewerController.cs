using System;
using System.Web.Mvc;
using Syncfusion.JavaScript;
using System.Linq;
using System.Collections.Generic;
namespace SyncfusionMvcApplication3
{
     public partial class PdfViewerController: Controller
     {
	//
        // GET: /PdfViewer/
        public ActionResult PdfViewerFeatures()
        {
            List<DataUser> datas = new List<DataUser>();
            DataUser data = new DataUser();
            data.User = "mks01";
            data.Name = "agi br";
            datas.Add(data);
            ViewBag.DS = datas;
            return View();
        }

        public ActionResult PdfViewerFeaturesForm()
        {
            List<DataUser> datas = new List<DataUser>();
            DataUser data = new DataUser();
            data.User = "mks01";
            data.Name = "agi br";
            datas.Add(data);
            ViewBag.DS = datas;
            return View();
        }

         public class DataUser
         {
             public string User { get; set; }
             public string Name { get; set; }
         }
     }   
}
