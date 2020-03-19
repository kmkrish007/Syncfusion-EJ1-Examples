using Syncfusion.JavaScript;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage.Shared;
using System.Text.RegularExpressions;
using ICSharpCode.SharpZipLib.Zip;
using System.IO;

namespace SyncfusionASPNETApplication9
{
    public partial class FileExplorerFeatures : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        [System.Web.Services.WebMethod]
        public static object FileActionDefault(string ActionType, string Path, string ExtensionsAllow, string LocationFrom, string LocationTo, string Name, string[] Names, string NewName, string Action, bool CaseSensitive, string SearchString, IEnumerable<CommonFileDetails> CommonFiles, IEnumerable<HttpPostedFileBase> FileUpload)
        {
            //Please specify the path of azure blob
            string startPath = "https://filebrowsercontent.blob.core.windows.net/blob1/";

            if (Path != null)
                Path = Path.Replace(startPath, "");
            if (LocationFrom != null)
                LocationFrom = LocationFrom.Replace(startPath, "");
            if (LocationTo != null)
                LocationTo = LocationTo.Replace(startPath, "");

            //Here you have to specify the azure account name, key and blob name
            AzureFileOperations operation = new AzureFileOperations("filebrowsercontent", "rbAvmn82fmt7oZ7N/3SXQ9+d9MiQmW2i1FzwAtPfUJL9sb2gZ/+cC6Ei1mkwSbMA1iVSy9hzH1unWfL0fPny0A==", "blob1");
            switch (ActionType)
            {
                case "Read":
                    return (operation.Read(Path, ExtensionsAllow));
                case "CreateFolder":
                    return (operation.CreateFolder(Path, Name));
                case "Paste":
                    operation.Paste(LocationFrom, LocationTo, Names, Action, CommonFiles);
                    break;
                case "Remove":
                    operation.Remove(Names, Path);
                    break;
                case "Rename":
                    operation.Rename(Path, Name, NewName, CommonFiles);
                    break;
                case "GetDetails":
                    return (operation.GetDetails(Path, Names));
                case "Search":
                    return (operation.Search(Path, ExtensionsAllow, SearchString, CaseSensitive));
            }
            return "";
        }
    }
    public class AzureFileOperations : BasicFileOperations
    {
        List<FileExplorerDirectoryContent> Items = new List<FileExplorerDirectoryContent>();
        public CloudBlobContainer container;
        public AzureFileOperations(string accountName, string accountKey, string blobName)
        {
            StorageCredentials creds = new StorageCredentials(accountName, accountKey);
            CloudStorageAccount account = new CloudStorageAccount(creds, useHttps: true);
            CloudBlobClient client = account.CreateCloudBlobClient();
            container = client.GetContainerReference(blobName);
        }
        public override object Read(string path, string filter, IEnumerable<object> selectedItems = null)
        {
            AjaxFileExplorerResponse ReadResponse = new AjaxFileExplorerResponse();
            List<FileExplorerDirectoryContent> details = new List<FileExplorerDirectoryContent>();
            try
            {
                filter = filter.Replace(" ", "");
                var extensions = (filter ?? "*").Split(",|;".ToCharArray(), System.StringSplitOptions.RemoveEmptyEntries);
                CloudBlobDirectory sampleDirectory = container.GetDirectoryReference(path);
                IEnumerable<IListBlobItem> items = sampleDirectory.ListBlobs(false, BlobListingDetails.Metadata);

                foreach (IListBlobItem item in items)
                {
                    bool canAdd = false;
                    if (extensions[0].Equals("*.*") || extensions[0].Equals("*"))
                        canAdd = true;
                    else if (item.GetType() == typeof(CloudBlockBlob))
                    {
                        CloudBlockBlob file = (CloudBlockBlob)item;
                        var names = file.Name.ToString().Trim().Split('.');
                        if (Array.IndexOf(extensions, "*." + names[names.Count() - 1]) >= 0)
                            canAdd = true;
                        else canAdd = false;
                    }
                    else
                        canAdd = true;
                    if (canAdd)
                    {
                        if (item.GetType() == typeof(CloudBlockBlob))
                        {
                            CloudBlockBlob file = (CloudBlockBlob)item;
                            FileExplorerDirectoryContent entry = new FileExplorerDirectoryContent();
                            entry.name = file.Name.Replace(path, "").Replace("/", "");
                            entry.type = file.Properties.ContentType;
                            entry.isFile = true;
                            entry.size = file.Properties.Length;
                            entry.dateModified = file.Properties.LastModified.Value.LocalDateTime.ToString();
                            entry.hasChild = false;
                            entry.filterPath = "";
                            details.Add(entry);
                        }
                        else if (item.GetType() == typeof(CloudBlobDirectory))
                        {
                            CloudBlobDirectory directory = (CloudBlobDirectory)item;
                            FileExplorerDirectoryContent entry = new FileExplorerDirectoryContent();
                            entry.name = directory.Prefix.Replace(path, "").Replace("/", "");
                            entry.type = "Directory";
                            entry.isFile = false;
                            entry.size = 0;
                            //entry.dateModified = directory.Properties.LastModified.ToString();
                            entry.hasChild = HasChildDirectory(directory.Prefix);
                            entry.filterPath = "";
                            details.Add(entry);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                ReadResponse.error = e.GetType().FullName + ", " + e.Message;
                return ReadResponse;
            }
            ReadResponse.files = (IEnumerable<FileExplorerDirectoryContent>)details;
            return ReadResponse;
        }

        public virtual void getAllFiles(string path, AjaxFileExplorerResponse data, string filter)
        {
            AjaxFileExplorerResponse directoryList = new AjaxFileExplorerResponse();
            directoryList.files = (IEnumerable<FileExplorerDirectoryContent>)data.files.Where(item => item.isFile == false);
            for (int i = 0; i < directoryList.files.Count(); i++)
            {

                IEnumerable<FileExplorerDirectoryContent> selectedItem = new[] { directoryList.files.ElementAt(i) };
                AjaxFileExplorerResponse innerData = (AjaxFileExplorerResponse)Read(path + directoryList.files.ElementAt(i).name + "/", filter, selectedItem);
                innerData.files = innerData.files.Select(file => new FileExplorerDirectoryContent
                {
                    name = file.name,
                    type = file.type,
                    isFile = file.isFile,
                    size = file.size,
                    hasChild = file.hasChild,
                    filterPath = (directoryList.files.ElementAt(i).filterPath + directoryList.files.ElementAt(i).name + "\\")
                });
                Items.AddRange(innerData.files);
                getAllFiles(path + directoryList.files.ElementAt(i).name + "/", innerData, filter);
            }
        }

        private bool HasChildDirectory(string path)
        {
            CloudBlobDirectory sampleDirectory = container.GetDirectoryReference(path);
            var items = sampleDirectory.ListBlobs(false, BlobListingDetails.None);
            foreach (var item in items)
            {
                if (item.GetType() == typeof(CloudBlobDirectory))
                {
                    return true;
                }
            }
            return false;
        }

        public override object Search(string path, string filter, string searchString, bool caseSensitive, System.Collections.Generic.IEnumerable<object> selectedItems = null)
        {
            Items.Clear();
            AjaxFileExplorerResponse data = (AjaxFileExplorerResponse)Read(path, filter, selectedItems);
            Items.AddRange(data.files);
            getAllFiles(path, data, filter);
            data.files = Items.Where(item => new Regex(WildcardToRegex(searchString), (caseSensitive ? RegexOptions.None : RegexOptions.IgnoreCase)).IsMatch(item.name));
            return data;
        }

        public override object CreateFolder(string path, string name, IEnumerable<object> selectedItems = null)
        {
            CloudBlockBlob blob = container.GetBlockBlobReference(path + name + "/temp.$$$");
            blob.UploadText(".");
            AjaxFileExplorerResponse CreateResponse = new AjaxFileExplorerResponse();
            FileExplorerDirectoryContent content = new FileExplorerDirectoryContent();
            content.name = name;
            var directories = new[] { content };
            CreateResponse.files = (IEnumerable<FileExplorerDirectoryContent>)directories;
            return CreateResponse;
        }



        public override object GetDetails(string path, string[] names, IEnumerable<object> selectedItems = null)
        {
            AjaxFileExplorerResponse DetailsResponse = new AjaxFileExplorerResponse();
            try
            {
                bool isFile = false;
                AzureFileDetails[] fDetails = new AzureFileDetails[names.Length];
                AzureFileDetails fileDetails = new AzureFileDetails();
                if (selectedItems != null)
                {
                    foreach (FileExplorerDirectoryContent item in selectedItems)
                    {
                        isFile = item.isFile;
                        break;
                    }
                }
                if (isFile)
                {
                    CloudBlockBlob blockBlob = container.GetBlockBlobReference(path + names[0]);
                    blockBlob.FetchAttributes();
                    fileDetails.Name = blockBlob.Name;
                    fileDetails.Extension = blockBlob.Name.Split('.')[1];
                    fileDetails.FullName = blockBlob.Uri.ToString();
                    fileDetails.Format = blockBlob.Properties.ContentType.ToString();
                    fileDetails.Length = blockBlob.Properties.Length;
                    fileDetails.LastWriteTime = blockBlob.Properties.LastModified.Value.LocalDateTime.ToString();
                }
                else
                {
                    CloudBlobDirectory sampleDirectory = container.GetDirectoryReference(path);
                    fileDetails.Name = names[0];
                    fileDetails.FullName = sampleDirectory.Uri.ToString() + names[0];
                    fileDetails.Format = sampleDirectory.GetType().ToString();
                    fileDetails.Length = 0;
                }
                fDetails[0] = fileDetails;
                DetailsResponse.details = fDetails;
                return DetailsResponse;
            }
            catch (Exception ex) { throw ex; }
        }

        public override object Paste(string sourceDir, string targetDir, string[] names, string option, IEnumerable<CommonFileDetails> commonFiles, IEnumerable<object> selectedItems = null, IEnumerable<object> targetFolder = null)
        {
            foreach (string s_item in names)
            {
                if (s_item != "")
                {
                    string sourceDir1 = sourceDir + s_item;
                    CloudBlob existBlob = container.GetBlobReference(sourceDir1);
                    CloudBlob newBlob = container.GetBlobReference(targetDir + s_item);
                    newBlob.StartCopy(existBlob.Uri);
                    if (option == "move")
                        existBlob.DeleteIfExists();
                }
                else
                {
                    CloudBlobDirectory sampleDirectory = container.GetDirectoryReference(sourceDir + s_item);
                    var items = sampleDirectory.ListBlobs(true, BlobListingDetails.None);
                    foreach (var item in items)
                    {
                        string name = item.Uri.ToString().Replace(sampleDirectory.Uri.ToString(), "");
                        CloudBlob newBlob = container.GetBlobReference(targetDir + s_item + "/" + name);
                        newBlob.StartCopy(item.Uri);
                        if (option == "move")
                            container.GetBlobReference(sourceDir + s_item + "/" + name).Delete();
                    }
                }
            }
            return "success";
        }


        public override object Remove(string[] names, string path, IEnumerable<object> selectedItems = null)
        {
            CloudBlobDirectory sampleDirectory = container.GetDirectoryReference(path);
            foreach (string s_item in names)
            {
                if (s_item != "")
                {
                    CloudBlockBlob blockBlob = container.GetBlockBlobReference(path + s_item);
                    blockBlob.Delete();
                }
                else
                {
                    CloudBlobDirectory subDirectory = container.GetDirectoryReference(path + s_item);
                    var items = subDirectory.ListBlobs(true, BlobListingDetails.None);
                    foreach (var item in items)
                    {
                        CloudBlockBlob blockBlob = container.GetBlockBlobReference(path + s_item + "/" + item.Uri.ToString().Replace(subDirectory.Uri.ToString(), ""));
                        blockBlob.Delete();
                    }
                }
            }
            return "success";
        }

        public override object Rename(string path, string oldName, string newName, IEnumerable<CommonFileDetails> commonFiles, IEnumerable<object> selectedItems = null)
        {
            //bool isFile = false;
            //foreach (string item in newName)
            //{
            //    if(item != '')
            //    isFile = true;
            //    break;
            //}
            if (newName != "")
            {
                CloudBlob existBlob = container.GetBlobReference(path + oldName);
                CloudBlob newBlob = container.GetBlobReference(path + newName);
                newBlob.StartCopy(existBlob.Uri);
                existBlob.DeleteIfExists();
            }
            else
            {
                CloudBlobDirectory sampleDirectory = container.GetDirectoryReference(path + oldName);
                var items = sampleDirectory.ListBlobs(true, BlobListingDetails.Metadata);
                foreach (var item in items)
                {
                    string name = item.Uri.AbsolutePath.Replace(sampleDirectory.Uri.AbsolutePath, "");
                    CloudBlob newBlob = container.GetBlobReference(path + newName + "/" + name);
                    newBlob.StartCopy(item.Uri);
                    container.GetBlobReference(path + oldName + "/" + name).Delete();
                }

            }
            return "success";
        }

        public override void Download(string path, string[] names, IEnumerable<object> selectedItems = null)
        {
            throw new NotImplementedException();
        }
        public virtual void SaveFile(string path, MemoryStream fileStream)
        {
            try
            {
                CloudBlockBlob blob = container.GetBlockBlobReference(path);
                blob.UploadFromStream(fileStream);
            }
            catch (Exception ex) { throw ex; }
        }


        public override void GetImage(string path, IEnumerable<object> selectedItems = null)
        {
            throw new NotImplementedException();
        }

        public override void GetImage(string path, bool canCompress = false, ImageSize size = null, IEnumerable<object> selectedItems = null)
        {
            throw new NotImplementedException();
        }

        public override void Upload(IEnumerable<HttpPostedFileBase> files, string path, IEnumerable<object> selectedItems = null)
        {
            throw new NotImplementedException();
        }
    }
    public class AzureFileDetails
    {
        public string CreationTime { get; set; }
        public string Extension { get; set; }
        public string Format { get; set; }
        public string FullName { get; set; }
        public string LastAccessTime { get; set; }
        public string LastWriteTime { get; set; }
        public long Length { get; set; }
        public string Name { get; set; }
    }
    public class AjaxFileExplorerResponse
    {
        public FileExplorerDirectoryContent cwd { get; set; }
        public IEnumerable<FileExplorerDirectoryContent> files { get; set; }
        public IEnumerable<AzureFileDetails> details { get; set; }
        public object error { get; set; }
    }

    public class AzureFileExplorerParams
    {
        public string Action { get; set; }
        public string ActionType { get; set; }
        public bool CaseSensitive { get; set; }
        public IEnumerable<CommonFileDetails> CommonFiles { get; set; }
        public string ExtensionsAllow { get; set; }
        public IEnumerable<System.Web.HttpPostedFileBase> FileUpload { get; set; }
        public string LocationFrom { get; set; }
        public string LocationTo { get; set; }
        public string Name { get; set; }
        public string[] Names { get; set; }
        public string NewName { get; set; }
        public string Path { get; set; }
        public string PreviousName { get; set; }
        public string SearchString { get; set; }
        public IEnumerable<FileExplorerDirectoryContent> SelectedItems { get; set; }
        public IEnumerable<FileExplorerDirectoryContent> TargetFolder { get; set; }
    }
}