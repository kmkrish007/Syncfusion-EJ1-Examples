using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
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
                switch (args.ActionType)
                {
                    case "Read":
                        Data = FileExplorerOperations.ReadData(args.Path, args.ExtensionsAllow);
                        break;
                    case "Search":
                        Data = FileExplorerOperations.Search(args.Path, args.ExtensionsAllow, args.SearchString, args.CaseSensitive);
                        break;
                    case "CreateFolder":
                        Data = FileExplorerOperations.NewFolder(args.Path, args.Name);
                        break;
                    case "Paste":
                        Data = FileExplorerOperations.Paste(args.LocationFrom, args.LocationTo, args.Names, args.Action, args.CommonFiles);
                        break;
                    case "Remove":
                        Data = FileExplorerOperations.Remove(args.Names, args.Path);
                        break;
                    case "Rename":
                        Data = FileExplorerOperations.Rename(args.Path, args.Name, args.NewName, args.CommonFiles);
                        break;
                    case "GetDetails":
                        Data = FileExplorerOperations.GetDetails(args.Path, args.Names);
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
                switch (args.ActionType)
                {
                    case "Read":
                         return FileExplorerOperations.ReadData(args.Path, args.ExtensionsAllow);
                    case "Search":
                         return FileExplorerOperations.Search(args.Path, args.ExtensionsAllow, args.SearchString, args.CaseSensitive);
                    case "CreateFolder":
                        return FileExplorerOperations.NewFolder(args.Path, args.Name);
                    case "Paste":
                        return FileExplorerOperations.Paste(args.LocationFrom, args.LocationTo, args.Names, args.Action, args.CommonFiles);
                    case "Remove":
                        return FileExplorerOperations.Remove(args.Names, args.Path);
                    case "Rename":
                        return FileExplorerOperations.Rename(args.Path, args.Name, args.NewName, args.CommonFiles);
                    case "GetDetails":
                        return FileExplorerOperations.GetDetails(args.Path, args.Names);
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