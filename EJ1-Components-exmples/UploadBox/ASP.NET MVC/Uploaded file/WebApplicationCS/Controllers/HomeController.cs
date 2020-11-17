using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationCS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SaveDefault(IEnumerable<HttpPostedFileBase> UploadDefault)
        {
            foreach (var file in UploadDefault)
            {
                var fileName = Path.GetFileName(file.FileName);
                
                var destinationPath = Path.Combine(Server.MapPath("~/App_Data"), fileName);
                var stream = new FileStream(destinationPath, FileMode.Create);
                file.SaveAs(destinationPath);
            }
            return Content("");
        }

        public ActionResult RemoveDefault(string[] fileNames)
        {
            foreach (var fullName in fileNames)
           
            {

                var fileName = Path.GetFileName(fullName);

                var physicalPath = Path.Combine(Server.MapPath("~/App_Data"), fileName);

                if (System.IO.File.Exists(physicalPath))

                {

                    System.IO.File.Delete(physicalPath);

                }

            }

            return Content("");

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}