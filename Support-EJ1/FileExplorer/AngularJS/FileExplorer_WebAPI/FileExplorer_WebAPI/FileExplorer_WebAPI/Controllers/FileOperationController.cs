using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.Http;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Newtonsoft.Json.Linq;
using System.Text;


namespace Northwind
{

    public class FileOperationController : ApiController
    {        
        [HttpGet]
        [ActionName("doJSONPAction")]
        public object doJSONPAction(string callback, string json)
        {
            object Data = null;
            var serializer = new JavaScriptSerializer();            
            FileExplorerParams args = (FileExplorerParams) serializer.Deserialize(json, typeof(FileExplorerParams));
            try
            {
                if (args.ActionType != "Paste" && args.ActionType != "GetDetails")
                {
                    string FilePath = FileExplorerOperations.ToPhysicalPath(FileExplorerOperations.ToAbsolute(args.Path));                    
                }
                FileOperationController Rule = new FileOperationController();
                FileAccessOperations operation = new FileAccessOperations(Rule.GetRules());
                switch (args.ActionType)
                {
                    case "Read":
                        Data = operation.ReadData(args.Path, args.ExtensionsAllow);
                        break;
                    case "Search":
                        Data = operation.Search(args.Path, args.ExtensionsAllow, args.SearchString, args.CaseSensitive);
                        break;
                    case "CreateFolder":
                        Data = operation.NewFolder(args.Path, args.Name);
                        break;
                    case "Paste":
                        Data = operation.Paste(args.LocationFrom, args.LocationTo, args.Names, args.Action, args.CommonFiles);
                        break;
                    case "Remove":
                        Data = operation.Remove(args.Names, args.Path);
                        break;
                    case "Rename":
                        Data = operation.Rename(args.Path, args.Name, args.NewName, args.CommonFiles);
                        break;
                    case "GetDetails":
                        Data = operation.GetDetails(args.Path, args.Names);
                        break;
                }
                HttpContext.Current.Response.Write(string.Format("{0}({1});", callback, serializer.Serialize(Data)));
                return "";
            }
            catch (Exception e)
            {
                FileExplorerResponse Response = new FileExplorerResponse();
                Response.error = e.GetType().FullName + ", " + e.Message;
                HttpContext.Current.Response.Write(string.Format("{0}({1});", callback, serializer.Serialize(Response)));
                return "";
            }
        }       
        [HttpGet]
        [ActionName("GetRules")]
        public FileAccessInfo GetRules()
        {
            FileAccessInfo rules = new FileAccessInfo();
            List<AccessRule> accessRules = new List<AccessRule> {
                // For Default User
                new AccessRule { Path = "*.*", Role = "Default User", Read = Permission.Deny, Edit = Permission.Deny, Copy = Permission.Deny, Download = Permission.Deny },
                new AccessRule { Path = "*", Role = "Default User", Read = Permission.Deny, Edit = Permission.Deny, Copy = Permission.Deny, EditContents = Permission.Deny, Upload = Permission.Deny },
                new AccessRule { Path = "", Role = "Default User", Read = Permission.Allow, Edit = Permission.Deny, Copy = Permission.Deny, EditContents = Permission.Deny, Upload = Permission.Deny },
                // For Administrator
                new AccessRule { Path = "*.*", Role = "Administrator", Read = Permission.Allow, Edit = Permission.Allow, Copy = Permission.Allow, Download = Permission.Allow },
                new AccessRule { Path = "*", Role = "Administrator", Read = Permission.Allow, Edit = Permission.Allow, Copy = Permission.Allow, EditContents = Permission.Allow, Upload = Permission.Allow },
                new AccessRule { Path = "", Role = "Administrator", Read = Permission.Allow, Edit = Permission.Deny, Copy = Permission.Allow, EditContents = Permission.Allow, Upload = Permission.Allow },
                // For Document Manager
                new AccessRule { Path = "*.*", Role = "Document Manager", Read = Permission.Deny, Edit = Permission.Deny, Copy = Permission.Deny, Download = Permission.Deny },
                new AccessRule { Path = "Food/*.*", Role = "Document Manager", Read = Permission.Allow, Edit = Permission.Allow, Copy = Permission.Allow, Download = Permission.Allow },
                new AccessRule { Path = "*", Role = "Document Manager", Read = Permission.Deny, Edit = Permission.Deny, Copy = Permission.Deny, EditContents = Permission.Deny, Upload = Permission.Deny },
                new AccessRule { Path = "", Role = "Document Manager", Read = Permission.Allow, Edit = Permission.Deny, Copy = Permission.Deny, EditContents = Permission.Deny, Upload = Permission.Deny },
                new AccessRule { Path = "Food", Role = "Document Manager", Read = Permission.Allow, Edit = Permission.Deny, Copy = Permission.Allow, EditContents = Permission.Allow, Upload = Permission.Allow },
                new AccessRule { Path = "Food/*", Role = "Document Manager", Read = Permission.Allow, Edit = Permission.Allow, Copy = Permission.Allow, EditContents = Permission.Allow, Upload = Permission.Allow },
            };
            rules.Rules = accessRules;
            //Option to change the Role
            rules.Role = "Document Manager";
            rules.RootPath = "~/FileBrowser/";
            return rules;
        }
        [HttpPost]
        [ActionName("doJSONAction")]
        public object doJSONAction()
        {
            FileExplorerParams args = FileExplorerOperations.GetAjaxData(Request);
            if (args.ActionType == "Upload")
            {
                FileExplorerOperations.Upload(args.Files, args.Path);
                return new HttpResponseMessage() { Content = new StringContent("ok", Encoding.UTF8, "text/plain") };
            }
            try
            {
                if (args.ActionType != "Paste" && args.ActionType != "GetDetails")
                {
                    var FilePath = FileExplorerOperations.ToPhysicalPath(FileExplorerOperations.ToAbsolute(args.Path));                    
                }
                FileOperationController Rule = new FileOperationController();
                FileAccessOperations operation = new FileAccessOperations(Rule.GetRules());
                switch (args.ActionType)
                {
                    case "Read":
                         return operation.ReadData(args.Path, args.ExtensionsAllow);
                    case "Search":
                         return operation.Search(args.Path, args.ExtensionsAllow, args.SearchString, args.CaseSensitive);
                    case "CreateFolder":
                        return operation.NewFolder(args.Path, args.Name);
                    case "Paste":
                        return operation.Paste(args.LocationFrom, args.LocationTo, args.Names, args.Action, args.CommonFiles);
                    case "Remove":
                        return operation.Remove(args.Names, args.Path);
                    case "Rename":
                        return operation.Rename(args.Path, args.Name, args.NewName, args.CommonFiles);
                    case "GetDetails":
                        return operation.GetDetails(args.Path, args.Names);
                }
                return "";
            }
            catch (Exception e) {
                FileExplorerResponse Response = new FileExplorerResponse();
                Response.error = e.GetType().FullName + ", " + e.Message;
                return Response;
            }
        }

        [HttpPost]
        [ActionName("Upload")]
        public HttpResponseMessage Upload()
        {
            FileExplorerOperations.Upload(HttpContext.Current.Request.Files, HttpContext.Current.Request.QueryString.GetValues("Path")[0]);
            return new HttpResponseMessage() { Content = new StringContent("ok", Encoding.UTF8, "text/plain") };
        }
        // GET api/<controller>/<values>
        [HttpGet]
        [ActionName("Download")]
        public void Download(string Path)
        {
            if(HttpContext.Current.Request.QueryString.GetValues("Names")!=null)
                FileExplorerOperations.Download(Path, HttpContext.Current.Request.QueryString.GetValues("Names")); 
            else
                FileExplorerOperations.Download(Path);
        }
        [HttpGet]
        [ActionName("PerformAction")]
        public void PerformAction(string ActionType, string Path)
        {
            if (ActionType == "Download")
                FileExplorerOperations.Download(Path, HttpContext.Current.Request.QueryString.GetValues("Names"));   
            else if (ActionType == "GetImage")
                FileExplorerOperations.GetImage(Path);
        }
        [HttpPost]
        [ActionName("PerformJSONPAction")]
        public void PerformJSONPAction()
        {
            if (HttpContext.Current.Request.Files.Count > 0)
                FileExplorerOperations.Upload(HttpContext.Current.Request.Files, HttpContext.Current.Request.QueryString.GetValues("Path")[0]);
        }
        [HttpGet]
        [ActionName("PerformJSONPAction")]
        public void PerformJSONPAction(string ActionType, string Path, string SelectedItems)
        {
            PerformAction(ActionType, Path);
        }
        [HttpGet]
        [ActionName("doJSONAction")]
        public void doJSONAction(string ActionType, string Path)
        {
            PerformAction(ActionType, Path);
        }
        [HttpPost]
        [ActionName("doJSONPAction")]
        public void doJSONPAction()
        {
            PerformJSONPAction();
        }
        [HttpGet]
        [ActionName("doJSONPAction")]
        public void doJSONPAction(string ActionType, string Path, string SelectedItems)
        {
            PerformAction(ActionType, Path);
        }

    }
}