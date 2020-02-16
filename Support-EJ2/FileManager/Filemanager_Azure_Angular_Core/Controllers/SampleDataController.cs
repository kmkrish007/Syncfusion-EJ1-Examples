using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.EJ2.FileManager.AzureFileProvider;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using Syncfusion.EJ2.FileManager.Base;
using System;
using System.IO;
using Syncfusion.EJ2.DocumentEditor;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using System.Net;
using Syncfusion.EJ2.Spreadsheet;
using Syncfusion.XlsIO;

namespace Angular_with_Core.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        public AzureFileProvider operation;
        public CloudBlobContainer container = new CloudStorageAccount(new StorageCredentials("<--accountName-->", "<--accountKey-->"), useHttps: true).CreateCloudBlobClient().GetContainerReference("<--blobName-->");
        //for example 
        //public CloudBlobContainer container = new CloudStorageAccount(new StorageCredentials("azure_service_account", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"), useHttps: true).CreateCloudBlobClient().GetContainerReference("files");
        public SampleDataController(IHostingEnvironment hostingEnvironment)
        {
            this.operation = new AzureFileProvider();
            this.operation.RegisterAzure("<--accountName-->", "<--accountKey-->", "<--blobName-->");
            this.operation.SetBlobContainer("<--blobPath-->", "<--filePath-->");
            //----------
            //for example 
            //this.operation.RegisterAzure("azure_service_account", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", "files");
            //this.operation.setBlobContainer("https://azure_service_account.blob.core.windows.net/files/", "https://azure_service_account.blob.core.windows.net/files/Files");
            //---------
        }
        [Route("AzureFileOperations")]
        public object AzureFileOperations([FromBody] FileManagerDirectoryContent args)
        {
            if (args.Path != "")
            {
                string startPath = "<--blobPath-->";
                string originalPath = ("<--filePath-->").Replace(startPath, "");
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
                    return Json(this.ToCamelCase(this.operation.GetFiles(args.Path, args.Data)));
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
                string startPath = "<--blobPath-->";
                string originalPath = ("<--filePath-->").Replace(startPath, "");
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

        [Route("GetDocument")]
        public string GetDocument([FromBody] CustomParams param)
        {
            string orginalPath = "<--filePath-->";
            string path = orginalPath + (param.FileName);
            if (param.Action == "LoadPDF")
            {
                ////for PDF Files
                FileStreamResult fileStreamResult = new FileStreamResult(new MemoryStream(new WebClient().DownloadData(path)), "APPLICATION/octet-stream");
                var docBytes = ReadFully(fileStreamResult.FileStream);
                //we can convert the document stream to bytes then convert to base64
                string docBase64 = "data:application/pdf;base64," + Convert.ToBase64String(docBytes);
                return (docBase64);
            }
            else
            {
                //for Doc Files
                try
                {
                    var blockblob = container.GetBlockBlobReference(path);
                    FileStreamResult fileStreamResult = new FileStreamResult(new MemoryStream(new WebClient().DownloadData(path)), "APPLICATION/octet-stream");
                    int index = param.FileName.LastIndexOf('.');
                    string type = index > -1 && index < param.FileName.Length - 1 ?
                        param.FileName.Substring(index) : ".docx";
                    WordDocument document = WordDocument.Load(fileStreamResult.FileStream, GetFormatType(type.ToLower()));
                    string json = JsonConvert.SerializeObject(document);
                    document.Dispose();
                    return json;
                }
                catch
                {
                    return "Failure";
                }
            }
        }

        // Read All bytes for pdf
        public static byte[] ReadFully(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }

        internal static FormatType GetFormatType(string format)
        {
            if (string.IsNullOrEmpty(format))
            {
                throw new NotSupportedException("EJ2 DocumentEditor does not support this file format.");
            }

            switch (format.ToLower())
            {
                case ".dotx":
                case ".docx":
                case ".docm":
                case ".dotm":
                    return FormatType.Docx;
                case ".dot":
                case ".doc":
                    return FormatType.Doc;
                case ".rtf":
                    return FormatType.Rtf;
                case ".txt":
                    return FormatType.Txt;
                case ".xml":
                    return FormatType.WordML;
                case ".html":
                    return FormatType.Html;
                default:
                    throw new NotSupportedException("EJ2 DocumentEditor does not support this file format.");
            }
        }

        //For Excel Files
        [Route("GetExcel")]
        public IActionResult GetExcel(CustomParams param)
        {
            string orginalPath = "<--filePath-->";
            string path = orginalPath + (param.FileName);
            var blockblob = container.GetBlockBlobReference(path);
            FileStreamResult fileStreamResult = new FileStreamResult(new MemoryStream(new WebClient().DownloadData(path)), "APPLICATION/octet-stream");
            return fileStreamResult;
        }
        [Route("OpenExcel")]
        public IActionResult Open(IFormCollection openRequest)
        {
            ExcelEngine excelEngine = new ExcelEngine();
            Stream memStream = (openRequest.Files[0] as IFormFile).OpenReadStream();
            IFormFile formFile = new FormFile(memStream, 0, memStream.Length, "", openRequest.Files[0].FileName); // converting MemoryStream to IFormFile
            OpenRequest open = new OpenRequest();
            open.File = formFile;
            return Content(Workbook.Open(open));
        }
        [Route("SaveExcel")]
        public IActionResult Save(SaveSettings saveSettings)
        {
            return Workbook.Save(saveSettings);
        }

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }

        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }

            public int TemperatureF
            {
                get
                {
                    return 32 + (int)(TemperatureC / 0.5556);
                }
            }
        }
    }

    public class CustomParams
    {
        public string FileName { get; set; }
        public string Action { get; set; }
    }
}
