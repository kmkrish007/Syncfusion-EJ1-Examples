using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core_FE.Models;
using Syncfusion.JavaScript;
using Microsoft.AspNetCore.Hosting;

namespace Core_FE.Controllers
{
    public class HomeController : Controller
    {
        public FileExplorerOperations operation;
        public IActionResult Index()
        {
            return View();
        }
        public HomeController(IHostingEnvironment hostingEnvironment)
        {
            operation = new FileExplorerOperations(hostingEnvironment.ContentRootPath);
        }
        public ActionResult FileActionDefault([FromBody] FileExplorerParams args)
        {
            switch (args.ActionType)
            {
                case "Read":
                    return Json(operation.Read(args.Path, args.ExtensionsAllow));
                case "CreateFolder":
                    return Json(operation.CreateFolder(args.Path, args.Name));
                case "Paste":
                    return Json(operation.Paste(args.LocationFrom, args.LocationTo, args.Names, args.Action, args.CommonFiles));
                case "Remove":
                    return Json(operation.Remove(args.Names, args.Path, args.SelectedItems));
                case "Rename":
                    return Json(operation.Rename(args.Path, args.Name, args.NewName, args.CommonFiles));
                case "GetDetails":
                    return Json(operation.GetDetails(args.Path, args.Names));
                case "Search":
                    return Json(operation.Search(args.Path, args.ExtensionsAllow, args.SearchString, args.CaseSensitive));
            }
            return Json("");
        }

        public ActionResult Download(FileExplorerParams args)
        {
            return operation.Download(args.Path, args.Names);
        }

        public ActionResult Upload(FileExplorerParams args)
        {
            operation.Upload(args.FileUpload, args.Path);
            return Json("");
        }
        public ActionResult GetImage(FileExplorerParams args)
        {
            return operation.GetImage(args.Path);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
