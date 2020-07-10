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
    public class FileAccessOperations
    {
        FileAccessInfo AccessRules = new FileAccessInfo();
        public FileAccessOperations(FileAccessInfo rule)
        {
            AccessRules = rule;
        }
        public FileExplorerResponse ReadData(string path, string filter)
        {
            FileExplorerResponse ReadResponse = new FileExplorerResponse();
            try
            {
                ReadResponse = FileExplorerOperations.ReadData(path, filter);
                string physicalPath = GetPath(path);
                ReadResponse.cwd.permission = GetPathPermission(path);
                if (!ReadResponse.cwd.permission.Read)
                {
                    DirectoryContent[] fileDetails = new DirectoryContent[0];
                    ReadResponse.files = fileDetails;
                    return ReadResponse;
                }
                var items = ReadResponse.files.ToArray();
                for (int i = 0; i < items.Length; i++)
                {
                    items[i].permission = GetFilePermission(physicalPath, items[i].name, items[i].isFile);
                    if (items[i].isFile)
                    {
                        items[i].permission.EditContents = ReadResponse.cwd.permission.EditContents;
                        items[i].permission.Upload = ReadResponse.cwd.permission.Upload;
                    }
                }
                ReadResponse.files = items;
                return ReadResponse;
            }
            catch (Exception e)
            {
                ReadResponse.error = e.GetType().FullName + ", " + e.Message;
                return ReadResponse;
            }
        }
        public FileExplorerResponse Search(string path, string filter, string searchString, bool caseSensitive)
        {
            FileExplorerResponse SearchResponse = new FileExplorerResponse();
            try
            {
                string physicalPath = GetPath(path);
                FileAccessRules RootPermission = GetPathPermission(path);
                if (!RootPermission.Read)
                    throw new ArgumentException("'" + path + "' is not accessible. Access is denied.");
                SearchResponse = FileExplorerOperations.Search(path, filter, searchString, caseSensitive);
                var items = SearchResponse.files.ToArray();
                for (int i = 0; i < items.Length; i++)
                {
                    FileAccessRules PathPermission = GetPathPermission(path + items[i].filterPath.Replace("\\", "/"));
                    if (!PathPermission.Read)
                    {
                        items = items.Where((val, idx) => idx != i).ToArray();
                        i--;
                        continue;
                    }
                    items[i].permission = GetFilePermission(physicalPath + items[i].filterPath, items[i].name, items[i].isFile);
                    if (items[i].isFile)
                    {
                        items[i].permission.EditContents = PathPermission.EditContents;
                        items[i].permission.Upload = PathPermission.Upload;
                    }
                }
                SearchResponse.files = items;
                return SearchResponse;
            }
            catch (Exception e)
            {
                SearchResponse.error = e.GetType().FullName + ", " + e.Message;
                return SearchResponse;
            }
        }
        public FileExplorerResponse NewFolder(string path, string name)
        {
            FileExplorerResponse CreateResponse = new FileExplorerResponse();
            try
            {
                FileAccessRules PathPermission = GetPathPermission(path);
                if (!PathPermission.Read || !PathPermission.EditContents)
                    throw new ArgumentException("'" + path + "' is not accessible. Access is denied.");
                CreateResponse = FileExplorerOperations.NewFolder(path, name);
                CreateResponse.files = SetPermission(path, CreateResponse.files);
                return CreateResponse;
            }
            catch (Exception e)
            {
                CreateResponse.error = e.GetType().FullName + ", " + e.Message;
                return CreateResponse;
            }
        }
        public FileExplorerResponse Paste(string sourceDir, string backupDir, string[] names, string option, IEnumerable<CommonFileDetails> commonFiles)
        {
            FileExplorerResponse PasteResponse = new FileExplorerResponse();
            try
            {
                string phyPath = GetPath(sourceDir);
                for (int i = 0; i < names.Length; i++)
                {
                    FileAccessRules FilePermission = GetFilePermission(phyPath, names[i], IsFile(CombineRelativePath(sourceDir, names[i])));
                    if (!FilePermission.Read || !FilePermission.Copy)
                        throw new ArgumentException("'" + sourceDir + names[i] + "' is not accessible. Access is denied.");
                }
                FileAccessRules PathPermission = GetPathPermission(backupDir);
                if (!PathPermission.Read || !PathPermission.EditContents)
                    throw new ArgumentException("'" + backupDir + "' is not accessible. Access is denied.");
                PasteResponse = FileExplorerOperations.Paste(sourceDir, backupDir, names, option, commonFiles);
                PasteResponse.files = SetPermission(backupDir, PasteResponse.files);
                return PasteResponse;
            }
            catch (Exception e)
            {
                PasteResponse.error = e.GetType().FullName + ", " + e.Message;
                return PasteResponse;
            }
        }
        public FileExplorerResponse Remove(string[] names, string path)
        {
            FileExplorerResponse DeleteResponse = new FileExplorerResponse();
            try
            {
                string physicalPath = GetPath(path);
                List<FileAccessRules> FilesPermission = new List<FileAccessRules>();
                for (int i = 0; i < names.Length; i++)
                {
                    FileAccessRules permission = GetFilePermission(physicalPath, names[i], IsFile(CombineRelativePath(path, names[i])));
                    if (!permission.Read || !permission.Edit)
                        throw new ArgumentException("'" + path + names[i] + "' is not accessible. Access is denied.");
                    FilesPermission.Add(permission);
                }
                DeleteResponse = FileExplorerOperations.Remove(names, path);
                var items = DeleteResponse.files.ToArray();
                for (int i = 0; i < items.Length; i++)
                {
                    items[i].permission = FilesPermission[i];
                }
                DeleteResponse.files = items;
                return DeleteResponse;
            }
            catch (Exception e)
            {
                DeleteResponse.error = e.GetType().FullName + ", " + e.Message;
                return DeleteResponse;
            }
        }
        public FileExplorerResponse Rename(string path, string oldName, string newName, IEnumerable<CommonFileDetails> commonFiles)
        {
            FileExplorerResponse RenameResponse = new FileExplorerResponse();
            try
            {
                FileAccessRules FilePermission = GetFilePermission(GetPath(path), oldName, IsFile(CombineRelativePath(path, oldName)));
                if (!FilePermission.Read || !FilePermission.Edit)
                    throw new ArgumentException("'" + path + oldName + "' is not accessible. Access is denied.");
                RenameResponse = FileExplorerOperations.Rename(path, oldName, newName, commonFiles);
                RenameResponse.files = SetPermission(path, RenameResponse.files);
                return RenameResponse;
            }
            catch (Exception e)
            {
                RenameResponse.error = e.GetType().FullName + ", " + e.Message;
                return RenameResponse;
            }
        }
        public FileExplorerResponse GetDetails(string path, string[] names)
        {
            FileExplorerResponse DetailsResponse = new FileExplorerResponse();
            try
            {
                DetailsResponse = FileExplorerOperations.GetDetails(path, names);
                string physicalPath = GetPath(path);
                var items = DetailsResponse.details.ToArray();
                for (int i = 0; i < items.Length; i++)
                {
                    items[i].Permission = GetFilePermission(physicalPath, items[i].Name, items[i].Type != "File Folder");
                }
                DetailsResponse.details = items;
                return DetailsResponse;
            }
            catch (Exception e)
            {
                DetailsResponse.error = e.GetType().FullName + ", " + e.Message;
                return DetailsResponse;
            }
        }
        public void Upload(HttpFileCollection files, string path)
        {
            FileAccessRules PathPermission = GetPathPermission(path);
            if (!PathPermission.Read || !PathPermission.Upload)
                throw new ArgumentNullException("'" + path + "' is not accessible. Access is denied.");
            FileExplorerOperations.Upload(files, path);
        }
        public void Download(string path, string[] names)
        {
            string physicalPath = GetPath(path);
            for (int i = 0; i < names.Length; i++)
            {
                FileAccessRules FilePermission = GetFilePermission(physicalPath, names[i], true);
                if (!FilePermission.Read || !FilePermission.Download)
                    throw new ArgumentNullException("'" + path + names[i] + "' is not accessible. Access is denied.");
            }
            FileExplorerOperations.Download(path, names);
        }
        public string[] GetFolderDetails(string path)
        {
            string[] str_array = path.Split('/'), fileDetails = new string[2];
            string parentPath = "";
            for (var i = 0; i < str_array.Length - 2; i++)
            {
                parentPath += str_array[i] + "/";
            }
            fileDetails[0] = parentPath;
            fileDetails[1] = str_array[str_array.Length - 2];
            return fileDetails;
        }
        public FileAccessRules GetPathPermission(string path)
        {
            string[] fileDetails = GetFolderDetails(path);
            return GetFilePermission(GetPath(fileDetails[0]), fileDetails[1], false);
        }
        public DirectoryContent[] SetPermission(string path, IEnumerable<DirectoryContent> files)
        {
            var items = files.ToArray();
            string physicalPath = GetPath(path);
            for (int i = 0; i < items.Length; i++)
            {
                items[i].permission = GetFilePermission(physicalPath, items[i].name, items[i].isFile);
            }
            return items;
        }
        public string CombineRelativePath(string path, string name)
        {
            string absolutePath = FileExplorerOperations.ToAbsolute(path);
            string fullPath = FileExplorerOperations.CombinePaths(absolutePath, name);
            return FileExplorerOperations.ToPhysicalPath(fullPath);
        }
        public bool IsFile(string path)
        {
            FileAttributes Attribute = File.GetAttributes(path);
            return (Attribute & FileAttributes.Directory) == FileAttributes.Directory ? false : true;
        }
        public bool HasPermission(Permission rule)
        {
            return rule == Permission.Allow ? true : false;
        }
        public string GetPath(string path)
        {
            return FileExplorerOperations.ToPhysicalPath(FileExplorerOperations.ToAbsolute(path));
        }
        public FileAccessRules UpdateFolderRules(FileAccessRules filePermission, AccessRule folderRule)
        {
            filePermission.Copy = HasPermission(folderRule.Copy);
            filePermission.Edit = HasPermission(folderRule.Edit);
            filePermission.EditContents = HasPermission(folderRule.EditContents);
            filePermission.Read = HasPermission(folderRule.Read);
            filePermission.Upload = HasPermission(folderRule.Upload);
            return filePermission;
        }
        public FileAccessRules UpdateFileRules(FileAccessRules filePermission, AccessRule fileRule)
        {
            filePermission.Copy = HasPermission(fileRule.Copy);
            filePermission.Download = HasPermission(fileRule.Download);
            filePermission.Edit = HasPermission(fileRule.Edit);
            filePermission.Read = HasPermission(fileRule.Read);
            return filePermission;
        }
        public FileAccessRules GetFilePermission(string location, string name, bool isFile)
        {
            FileAccessRules FilePermission = new FileAccessRules();
            if (isFile)
            {
                string nameExtension = Path.GetExtension(name).ToLower();
                foreach (AccessRule fileRule in AccessRules.Rules)
                {
                    if (!string.IsNullOrEmpty(fileRule.Path) && Path.HasExtension(fileRule.Path) && (fileRule.Role == null || fileRule.Role == AccessRules.Role))
                    {
                        var pathExtension = Path.GetExtension(fileRule.Path).ToLower();
                        if (fileRule.Path.IndexOf("*.*") > -1)
                        {
                            string parentPath = fileRule.Path.Substring(0, fileRule.Path.IndexOf("*.*"));
                            if (location.IndexOf(GetPath(AccessRules.RootPath + parentPath)) == 0 || parentPath == "")
                            {
                                FilePermission = UpdateFileRules(FilePermission, fileRule);
                            }
                        }
                        else if (fileRule.Path.IndexOf("*.") > -1)
                        {
                            string parentPath = fileRule.Path.Substring(0, fileRule.Path.IndexOf("*."));
                            if ((GetPath(AccessRules.RootPath + parentPath) == location || parentPath == "") && nameExtension == pathExtension)
                            {
                                FilePermission = UpdateFileRules(FilePermission, fileRule);
                            }
                        }
                        else if (GetPath(AccessRules.RootPath + fileRule.Path) == (location + name))
                        {
                            FilePermission = UpdateFileRules(FilePermission, fileRule);
                        }
                    }
                }
                return FilePermission;
            }
            else
            {
                foreach (AccessRule folderRule in AccessRules.Rules)
                {
                    if (folderRule.Path != null && !Path.HasExtension(folderRule.Path) && (folderRule.Role == null || folderRule.Role == AccessRules.Role))
                    {
                        if (folderRule.Path.IndexOf("*") > -1)
                        {
                            string parentPath = folderRule.Path.Substring(0, folderRule.Path.IndexOf("*"));
                            if ((location + name).IndexOf(GetPath(AccessRules.RootPath + parentPath)) == 0 || parentPath == "")
                            {
                                FilePermission = UpdateFolderRules(FilePermission, folderRule);
                            }
                        }
                        else if (GetPath(AccessRules.RootPath + folderRule.Path) == (location + name) || GetPath(AccessRules.RootPath + folderRule.Path) == (location + name + "\\"))
                        {
                            FilePermission = UpdateFolderRules(FilePermission, folderRule);
                        }
                        else if ((location + name).IndexOf(GetPath(AccessRules.RootPath + folderRule.Path)) == 0)
                        {
                            FilePermission.Edit = HasPermission(folderRule.EditContents);
                            FilePermission.EditContents = HasPermission(folderRule.EditContents);
                        }
                    }
                }
                FilePermission.Download = false;
                return FilePermission;
            }
        }
    }
    public class FileAccessInfo
    {
        public string Role { get; set; }
        public IEnumerable<AccessRule> Rules { get; set; }
        public string RootPath { get; set; }
    }
    public class AccessRule
    {
        public Permission Copy { get; set; }
        public Permission Download { get; set; }
        public Permission Edit { get; set; }
        public Permission EditContents { get; set; }
        public string Path { get; set; }
        public Permission Read { get; set; }
        public string Role { get; set; }
        public Permission Upload { get; set; }
    }
    public enum Permission
    {
        Allow,
        Deny
    }
}