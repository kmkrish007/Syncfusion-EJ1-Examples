using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Newtonsoft.Json;
using Syncfusion.EJ2.FileManager.Base;
using Microsoft.AspNetCore.Cors;
using System.IO;
using Syncfusion.EJ2.FileManager.AzureFileProvider;
using Newtonsoft.Json.Serialization;



namespace Server_side.Controllers
{
    public class FileResponse
    {
        public DirectoryContent CWD { get; set; }
        public IEnumerable<DirectoryContent> Files { get; set; }

        public ErrorDetails Error { get; set; }

        public FileDetails Details { get; set; }

    }

    public class DirectoryContent
    {
        public string Path { get; set; }

        public string Action { get; set; }

        public string NewName { get; set; }

        public string[] Names { get; set; }
        public string Name { get; set; }

        public long Size { get; set; }

        public string PreviousName { get; set; }

        public DateTime DateModified { get; set; }

        public DateTime DateCreated { get; set; }

        public bool HasChild { get; set; }

        public bool IsFile { get; set; }

        public string Type { get; set; }

        public string Id { get; set; }

        public string FilterPath { get; set; }

        public string FilterId { get; set; }

        public string TargetPath { get; set; }

        public string[] RenameFiles { get; set; }

        public IList<IFormFile> UploadFiles { get; set; }

        public bool CaseSensitive { get; set; }

        public string Guid { get; set; }
        public string SearchString { get; set; }

        public bool ShowHiddenItems { get; set; }

        public FileManagerDirectoryContent[] Data { get; set; }

        public FileManagerDirectoryContent TargetData { get; set; }
    }
    [Route("api/[controller]")]
    [EnableCors("AllowAllOrigins")]
    public class SamplaDataController : Controller
    {
        public AzureFileProvider operation;

        [Obsolete]
        public SamplaDataController(IHostingEnvironment hostingEnvironment)
        {
            this.operation = new AzureFileProvider();
            
            //Replace your azure blob details in the parameters of below methods to access and load azure blob files in the EJ2 FileManager   
            this.operation.RegisterAzure("ej2syncfusionfilemanager", "J8AYWqCrrC2aD6ujEMZabjDnxzlWNbUFKBPJhW7rSfLelOXMqDiqoOl42LyJOpl4r/A0XCbvuIGfM0KvF2yRNA==", "files");
            this.operation.setBlobContainer("https://ej2syncfusionfilemanager.blob.core.windows.net/files/", "https://ej2syncfusionfilemanager.blob.core.windows.net/files/Files");
            //----------
            //for example 
            //this.operation.RegisterAzure("azure_service_account", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", "files");
            //this.operation.setBlobContainer("https://azure_service_account.blob.core.windows.net/files/", "https://azure_service_account.blob.core.windows.net/files/Files");
            //---------
        }
        public object getFiles(FileManagerDirectoryContent args)
        {
            FileResponse readResponse = new FileResponse();
            var value = this.operation.GetFiles(args.Path, args.Data);
            try
            {
                DirectoryContent cwd = new DirectoryContent();
                readResponse.CWD = JsonConvert.DeserializeObject<DirectoryContent>(JsonConvert.SerializeObject(value.CWD));
                readResponse.Files = JsonConvert.DeserializeObject<IEnumerable<DirectoryContent>>(JsonConvert.SerializeObject(value.Files));
                foreach (DirectoryContent file in readResponse.Files)
                {
                    file.Guid = file.Name;
                }
                readResponse.Details = value.Details;
                readResponse.Error = value.Error;
                return readResponse;
            }
            catch
            {
                readResponse.Error = value.Error;
                return readResponse;
            }
        }
    
        [Route("AzureFileOperations")]
        public object AzureFileOperations([FromBody] FileManagerDirectoryContent args)
        {
            if (args.Path != "")
            {
                string startPath = "https://ej2syncfusionfilemanager.blob.core.windows.net/files/";
                string originalPath = ("https://ej2syncfusionfilemanager.blob.core.windows.net/files/Files/").Replace(startPath, "");

                //-----------------
                // for example
                //string startPath = "https://azure_service_account.blob.core.windows.net/files/";
                //string originalPath = ("https://azure_service_account.blob.core.windows.net/files/Files").Replace(startPath, "");
                //-------------------

                args.Path = (originalPath + args.Path).Replace("//", "/");
                args.TargetPath = (originalPath + args.TargetPath).Replace("//", "/");
            }
            switch (args.Action)
            {
                case "read":
                    // reads the file(s) or folder(s) from the given path.
                    return Json(this.ToCamelCase(this.getFiles(args)));
                case "delete":
                    // deletes the selected file(s) or folder(s) from the given path.
                    return this.ToCamelCase(this.operation.Delete(args.Path, args.Names, args.Data));
                case "details":
                    // gets the details of the selected file(s) or folder(s).
                    return this.ToCamelCase(this.operation.Details(args.Path, args.Names, args.Data));
                case "create":
                    // creates a new folder in a given path.
                    return this.ToCamelCase(this.operation.Create(args.Path, args.Name));
                case "search":
                    // gets the list of file(s) or folder(s) from a given path based on the searched key string.
                    return this.ToCamelCase(this.operation.Search(args.Path, args.SearchString, args.ShowHiddenItems, args.CaseSensitive, args.Data));
                case "rename":
                    // renames a file or folder.
                    return this.ToCamelCase(this.operation.Rename(args.Path, args.Name, args.NewName, false, args.Data));
                case "copy":
                    // copies the selected file(s) or folder(s) from a path and then pastes them into a given target path.
                    return this.ToCamelCase(this.operation.Copy(args.Path, args.TargetPath, args.Names, args.RenameFiles, args.TargetData, args.Data));
                case "move":
                    // cuts the selected file(s) or folder(s) from a path and then pastes them into a given target path.
                    return this.ToCamelCase(this.operation.Move(args.Path, args.TargetPath, args.Names, args.RenameFiles, args.TargetData, args.Data));

            }
            return null;
        }
        public string ToCamelCase(object userData)
        {
            return JsonConvert.SerializeObject(userData, new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new CamelCaseNamingStrategy()
                }
            });
        }

        // uploads the file(s) into a specified path
        [Route("AzureUpload")]
        public ActionResult AzureUpload(FileManagerDirectoryContent args)
        {
            if (args.Path != "")
            {
                string startPath = "https://ej2syncfusionfilemanager.blob.core.windows.net/files/";
                string originalPath = ("https://ej2syncfusionfilemanager.blob.core.windows.net/files/Files").Replace(startPath, "");
                args.Path = (originalPath + args.Path).Replace("//", "/");

                //----------------------
                //for example
                //string startPath = "https://azure_service_account.blob.core.windows.net/files/";
                //string originalPath = ("https://azure_service_account.blob.core.windows.net/files/Files").Replace(startPath, "");
                //args.Path = (originalPath + args.Path).Replace("//", "/");
                //----------------------
            }
            operation.Upload(args.Path, args.UploadFiles, args.Action, args.Data);
            return Json("");
        }

        // downloads the selected file(s) and folder(s)
        [Route("AzureDownload")]
        public object AzureDownload(string downloadInput)
        {
            FileManagerDirectoryContent args = JsonConvert.DeserializeObject<FileManagerDirectoryContent>(downloadInput);
            return operation.Download(args.Path, args.Names, args.Data);
        }

        // gets the image(s) from the given path
        [Route("AzureGetImage")]
        public IActionResult AzureGetImage(FileManagerDirectoryContent args)
        {
            return this.operation.GetImage(args.Path, args.Id, true, null, args.Data);
        }
        //WebAPI method from client side to save the input data into docx file in the root path

        public IActionResult Index()
        {
            return View();
        }
    }

    


}