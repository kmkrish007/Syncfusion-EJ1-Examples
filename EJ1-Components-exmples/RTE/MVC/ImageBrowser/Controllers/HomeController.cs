using Syncfusion.JavaScript;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FileActionMethods(FileExplorerParams args)
        {
            FileExplorerOperations opeartion = new FileExplorerOperations();
            switch (args.ActionType)
            {
                case "Read":
                    return Json(opeartion.Read(args.Path, args.ExtensionsAllow));
                case "CreateFolder":
                    return Json(opeartion.CreateFolder(args.Path, args.Name));
                case "Paste":
                    return Json(opeartion.Paste(args.LocationFrom, args.LocationTo, args.Names, args.Action, args.CommonFiles));
                case "Remove":
                    return Json(opeartion.Remove(args.Names, args.Path));
                case "Rename":
                    return Json(opeartion.Rename(args.Path, args.Name, args.NewName, args.CommonFiles));
                case "GetDetails":
                    return Json(opeartion.GetDetails(args.Path, args.Names));
                case "Download":
                    opeartion.Download(args.Path, args.Names);
                    break;
                case "Upload":
                    opeartion.Upload(args.FileUpload, args.Path);
                    break;
                case "Search":
                    return Json(opeartion.Search(args.Path, args.ExtensionsAllow, args.SearchString, args.CaseSensitive));
            }
            return Json("");
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