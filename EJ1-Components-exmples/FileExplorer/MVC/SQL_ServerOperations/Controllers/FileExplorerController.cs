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
        public bool isLocal = false;
         public ActionResult FileExplorerFeatures(string selectRole)
        {
            if (selectRole == null)
                Session["Role"] = "Administrator";
            else
                Session["Role"] = selectRole;
            ViewBag.Role = Session["Role"];
              return View();
        }

        public ActionResult AccessControl()
        {

            return View("FileExplorer");
        }

        [HttpPost]
        public ActionResult FileActionDefault(SQLFileExplorerParams args)
        {
            //Here "FileBrowserConnection" is an connection string name, which is defined in Web.config file. 
            //"Product" is an table name, which is defined in SQsL database
            SQLFileAccessOperations sqlobj = new SQLFileAccessOperations("FileExplorerConnection", "Product",SQLGetRules());
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
            SQLFileExplorerOperations sqlobj = new SQLFileExplorerOperations("FileExplorerConnection", "Product");
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

        public SQLFileAccessInfo SQLGetRules()
        {
            SQLFileAccessInfo rules = new SQLFileAccessInfo();
            SqlDataReader myReader = null;
            string connectionString = "FileExplorerConnection";
            SqlConnection Connection = new SqlConnection();
            Connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings[connectionString].ConnectionString;
            Connection.Open();
            SqlCommand myCommand = new SqlCommand("select * from Permission", Connection);
            myReader = myCommand.ExecuteReader();
            List<SQLAccessRule> datas = new List<SQLAccessRule>();
            while (myReader.Read())
            {
                SQLAccessRule data = new SQLAccessRule();
                data.Copy = (Permission)Enum.Parse(typeof(Permission), myReader["Copy"].ToString(), true);  
                if (!string.IsNullOrEmpty(myReader["Download"].ToString()))
                {
                    data.Download = (Permission)Enum.Parse(typeof(Permission), myReader["Download"].ToString(), true);
                }
                data.Edit = (Permission)Enum.Parse(typeof(Permission), myReader["Edit"].ToString(), true);
                data.Read = (Permission)Enum.Parse(typeof(Permission), myReader["Read"].ToString(), true);
                if (!string.IsNullOrEmpty(myReader["EditContents"].ToString()))
                {
                   data.EditContents = (Permission)Enum.Parse(typeof(Permission), myReader["EditContents"].ToString(), true);
                }
                if (!string.IsNullOrEmpty(myReader["Upload"].ToString()))
                {
                    data.Upload = (Permission)Enum.Parse(typeof(Permission), myReader["Upload"].ToString(), true);
                }
                data.Path = myReader["Path"].ToString();
                data.Role = myReader["Role"].ToString();
                datas.Add(data);
            }
            rules.Rules = datas;
            rules.Role = Session["Role"].ToString();
            if (isLocal) rules.RootPath = "~/localFolder/";
            else rules.RootPath = "~/Products/";
            return rules;
        }


        public ActionResult GetImage(SQLFileExplorerGetParams args)
        {
            args.ActionType = "GetImage";
            return FileActionDefault(args);
        }
    }
}
