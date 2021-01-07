using System;
using System.Web.Mvc;
using Syncfusion.JavaScript;
using System.Web.Script.Serialization;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ServerOperations
{
     public partial class FileExplorerController: Controller
     {
        [HttpPost]
        public ActionResult FileActionDefault(SQLFileExplorerParams args)
        {
            //Here "FileBrowserConnection" is an connection string name, which is defined in Web.config file. 
            //"Product" is an table name, which is defined in SQsL database
            SQLFileExplorerOperations sqlobj = new SQLFileExplorerOperations("FileExplorerConnection", "Product", "NameDetail");
            switch (args.ActionType)
            { 
                case "Read":
                    // Place your code here for the form is in valid state
                    return Json(sqlobj.Read(args.Path, args.ExtensionsAllow, args.SelectedItems));
                case "CreateFolder":
                    return Json(sqlobj.CreateFolder(args.Path, args.Name, args.SelectedItems));
                case "Paste":
                    sqlobj.Paste(args.LocationFrom, args.LocationTo, args.Names, args.Action, args.CommonFiles, args.SelectedItems, args.TargetFolder);
                    break;
                case "Remove":
                    sqlobj.Remove(args.Names, args.Path, args.SelectedItems);
                    break;
                case "Rename":
                    sqlobj.Rename(args.Path, args.Name, args.NewName, args.CommonFiles, args.SelectedItems);
                    break;
                case "GetDetails":
                    return Json(sqlobj.GetDetails(args.Path, args.Names, args.SelectedItems));
                case "Upload":
                    var serializer = new JavaScriptSerializer();
                    IEnumerable<SQLFileExplorerDirectoryContent> SelectedItems = (IEnumerable<SQLFileExplorerDirectoryContent>)serializer.Deserialize(HttpContext.Request.QueryString.GetValues("SelectedItems")[0], typeof(IEnumerable<SQLFileExplorerDirectoryContent>));
                    sqlobj.Upload(args.FileUpload, null, SelectedItems);
                    break;
                case "Search":
                    return Json(sqlobj.Search(args.Path, args.ExtensionsAllow, args.SearchString, args.CaseSensitive, args.SelectedItems));
            }
            return Json("");
        }
        [HttpGet]
        public ActionResult FileActionDefault(SQLFileExplorerGetParams args)
        {
            SQLFileExplorerOperations sqlobj = new SQLFileExplorerOperations("FileExplorerConnection", "Product", "NameDetail");
            IEnumerable<SQLFileExplorerDirectoryContent> SelectedItems = null;
            if (args.SelectedItems != null)
            {
                var serializer = new JavaScriptSerializer();
                SelectedItems = (IEnumerable<SQLFileExplorerDirectoryContent>)serializer.Deserialize(args.SelectedItems.ToString(), typeof(IEnumerable<SQLFileExplorerDirectoryContent>));
            }
            switch (args.ActionType)
            {
                case "Download":
                    sqlobj.Download(args.Path, args.Names, SelectedItems);
                    break;
                case "GetImage":
                    sqlobj.GetImage(args.Path, SelectedItems);
                    break;
            }
            return Json("");
        }


        public ActionResult GetImage(SQLFileExplorerGetParams args)
        {
            args.ActionType = "GetImage";
            return FileActionDefault(args);
        }
    }
}
