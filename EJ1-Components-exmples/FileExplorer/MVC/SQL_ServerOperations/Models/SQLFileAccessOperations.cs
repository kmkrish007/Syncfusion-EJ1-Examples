using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Data.SqlClient;

namespace Syncfusion.JavaScript
{
    /// <summary>
    /// Class FileAccessOperations helps to perform file operation in underlying machine's physical file system along with set of access rules and roles.
    /// </summary>
    public class SQLFileAccessOperations
    {

        
        /// <summary>
        /// The instance for access rules
        /// </summary>
        SQLFileAccessInfo AccessRules = new SQLFileAccessInfo();
        /// <summary>
        /// The instance for performing file operations
        /// </summary>
        SQLFileExplorerOperations operation;
        /// <summary>
        /// Initializes a new instance of the <see cref="FileAccessOperations"/> class.
        /// </summary>
        /// <param name="rule">The rule.</param>
        /// 
        public string connectionStr = "";
        SqlConnection Connection = new SqlConnection();
        String TableName = "";
        int RootNode = 1;
        List<SQLFileExplorerDirectoryContent> Items = new List<SQLFileExplorerDirectoryContent>();
        public SQLFileAccessOperations(string connectionString, string tableName,SQLFileAccessInfo rule, int rootNodeId = 1)
        {
            connectionStr = connectionString;
            AccessRules = rule;
            TableName = tableName;
            RootNode = rootNodeId;
            Connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings[connectionString].ConnectionString;
            Connection.Open();
            operation = new SQLFileExplorerOperations(connectionString, tableName);
        }
        /// <summary>
        /// Reads all immediate files and sub-folders from the specified path and it returns the matched type of files, which are specified in “filter” parameter.
        /// </summary>
        /// <param name="path">Path of the selected folder.</param>
        /// <param name="filter">File types to filter.</param>        
        /// <returns>System.Object.</returns>
        public virtual object Read(string path, string filter, IEnumerable<object> selectedItems = null)

        {
            SQLFileExplorerResponse ReadResponse = new SQLFileExplorerResponse();
            try
            {
                object ReadRes = operation.Read(path, filter, selectedItems);
                ReadResponse = (SQLFileExplorerResponse)ReadRes;
                string physicalPath = GetPath(path);
                ReadResponse.cwd.permission = GetPathPermission(path);
                if (!ReadResponse.cwd.permission.Read)
                {
                    SQLFileExplorerDirectoryContent[] fileDetails = new SQLFileExplorerDirectoryContent[0];
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
        /// <summary>
        /// Searches the matched files and sub-folders in the given folder path using search string.
        /// </summary>
        /// <param name="path">Directory path.</param>
        /// <param name="filter">File types to filter.</param>
        /// <param name="searchString">The search string.</param>
        /// <param name="caseSensitive">If set to <c>true</c> [case sensitive].</param>
        /// <returns>System.Object.</returns>
        /// <exception cref="ArgumentException">' + path + ' is not accessible. Access is denied.</exception>
        public virtual object Search(string path = null, string filter = null, string searchString = null, bool caseSensitive = false, IEnumerable<object> selectedItems = null)
        {
            SQLFileExplorerOperations sqlObj = new SQLFileExplorerOperations(connectionStr, TableName, RootNode);
            return sqlObj.Search(path, filter, searchString, caseSensitive, selectedItems);
        }
        /// <summary>
        /// Creates a new folder in given path with specified name.
        /// </summary>
        /// <param name="path">Parent folder path.</param>
        /// <param name="name">Name of the new folder.</param>
        /// <returns>System.Object.</returns>
        /// <exception cref="ArgumentException">' + path + ' is not accessible. Access is denied.</exception>
        public virtual object CreateFolder(string path = null, string name = null, IEnumerable<object> selectedItems = null)
        {
            SQLFileExplorerOperations sqlObj = new SQLFileExplorerOperations(connectionStr, TableName, RootNode);
            return sqlObj.CreateFolder(path, name, selectedItems);
        }
        /// <summary>
        /// Copy or moves the specified files/ directories from one location to another location.
        /// </summary>
        /// <param name="sourceDir">Source directory path.</param>
        /// <param name="backupDir">Target directory path.</param>
        /// <param name="names">Name of file/ folders, which are going to be pasted in destination folder.</param>
        /// <param name="option">Operation type “move” or “copy”.</param>
        /// <param name="commonFiles">Existing files list, which contains same name, type and parent path as given in new file.</param>
        /// <returns>System.Object.</returns>
        /// <exception cref="ArgumentException">' + sourceDir + names[i] + ' is not accessible. Access is denied.
        /// or
        /// ' + backupDir + ' is not accessible. Access is denied.</exception>
        public virtual object Paste(string sourceDir = null, string backupDir = null, string[] names = null, string option = null, IEnumerable<CommonFileDetails> commonFiles = null, IEnumerable<object> selectedItems = null, IEnumerable<object> targetFolder = null, string locationFrom = null, string locationTo = null )
        {
            SQLFileExplorerOperations sqlObj = new SQLFileExplorerOperations(connectionStr, TableName, RootNode);
            sqlObj.Paste(sourceDir,backupDir,names,option,commonFiles, selectedItems,targetFolder);
            return null;
        }
        /// <summary>
        /// Removes the specified items from given path.
        /// </summary>
        /// <param name="names">Removable item names.</param>
        /// <param name="path">Parent folder path of removable items.</param>
        /// <returns>System.Object.</returns>
        /// <exception cref="ArgumentException">' + path + names[i] + ' is not accessible. Access is denied.</exception>
        public virtual object Remove(string[] names = null, string path = null, IEnumerable<object> selectedItems = null)
        {
            SQLFileExplorerOperations sqlObj = new SQLFileExplorerOperations(connectionStr, TableName, RootNode);
            sqlObj.Remove(names, path, selectedItems);
            return null;
        }
        /// <summary>
        /// Renames the specified file/folder, which is available in given path.
        /// </summary>
        /// <param name="path">Parent folder path of renaming item.</param>
        /// <param name="oldName">Existing name.</param>
        /// <param name="newName">New name.</param>
        /// <param name="commonFiles">Specifies existing files list, which contains same name, type and parent path as given in new file</param>
        /// <returns>System.Object.</returns>
        /// <exception cref="ArgumentException">' + path + oldName + ' is not accessible. Access is denied.</exception>
        public virtual object Rename(string path = null, string oldName = null, string newName = null, IEnumerable<CommonFileDetails> commonFiles = null, IEnumerable<object> selectedItems = null)
        {
            SQLFileExplorerOperations sqlObj = new SQLFileExplorerOperations(connectionStr, TableName, RootNode);
            sqlObj.Rename(path, oldName, newName, commonFiles, selectedItems);
            return null;
        }
        /// <summary>
        /// Gets the details about specified file or directory.
        /// </summary>
        /// <param name="path">Parent directory path of selected file.</param>
        /// <param name="names">File or folder name.</param>
        /// <returns>System.Object.</returns>
        public virtual object GetDetails(string path = null, string[] names = null, IEnumerable<object> selectedItems = null)
        {
          SQLFileExplorerOperations sqlObj = new SQLFileExplorerOperations(connectionStr, TableName, RootNode);
          return sqlObj.GetDetails(path, names, selectedItems);
        }
        /// <summary>
        /// Uploads the specified files to given path.
        /// </summary>
        /// <param name="files">Uploading file details.</param>
        /// <param name="path">Path of destination directory, where the files need to be uploaded.</param>
        /// <exception cref="ArgumentNullException">' + path + ' is not accessible. Access is denied.</exception>
        public virtual void Upload(IEnumerable<HttpPostedFileBase> files = null, string path = null, IEnumerable<object> selectedItems = null)
        {
            SQLFileExplorerOperations sqlObj = new SQLFileExplorerOperations(connectionStr, TableName, RootNode);
            sqlObj.Upload(files, path, selectedItems);
        }
        /// <summary>
        /// Downloads the specified files.
        /// </summary>
        /// <param name="path">Parent directory path of selected files, which is going to be download.</param>
        /// <param name="names">Name of files that is need to be downloaded.</param>
        /// <exception cref="ArgumentNullException">' + path + names[i] + ' is not accessible. Access is denied.</exception>
        public virtual void Download(string path, string[] names)
        {
            SQLFileExplorerOperations sqlObj = new SQLFileExplorerOperations(connectionStr, TableName, RootNode); ;
            sqlObj.Download(path, names);
        }
        /// <summary>
        /// Gets the folder details for given path.
        /// </summary>
        /// <param name="path">The folder path.</param>
        /// <returns>System.String[].</returns>
        public virtual string[] GetFolderDetails(string path)
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
        /// <summary>
        /// Gets the path permission for given path.
        /// </summary>
        /// <param name="path">The folder/ file path.</param>
        /// <returns>FileAccessRules.</returns>
        public virtual SQLFileAccessRules GetPathPermission(string path)
        {
            string[] fileDetails = GetFolderDetails(path);
            return GetFilePermission(GetPath(fileDetails[0]), fileDetails[1], false);
        }
        /// <summary>
        /// Sets the permission for files.
        /// </summary>
        /// <param name="path">The parent path of the file.</param>
        /// <param name="files">The files.</param>
        /// <returns>FileExplorerDirectoryContent[].</returns>
        public virtual SQLFileExplorerDirectoryContent[] SetPermission(string path, IEnumerable<SQLFileExplorerDirectoryContent> files)
        {
            var items = files.ToArray();
            string physicalPath = GetPath(path);
            for (int i = 0; i < items.Length; i++)
            {
                items[i].permission = GetFilePermission(physicalPath, items[i].name, items[i].isFile);
            }
            return items;
        }
        /// <summary>
        /// Combines the relative path.
        /// </summary>
        /// <param name="path">The relative path.</param>
        /// <param name="name">The name.</param>
        /// <returns>System.String.</returns>
        public virtual string CombineRelativePath(string path, string name)
        {
            string absolutePath = operation.ToAbsolute(path);
            string fullPath = operation.CombinePaths(absolutePath, name);
            return operation.GetPhysicalPath(fullPath);
        }
        /// <summary>
        /// Determines whether the specified item is file.
        /// </summary>
        /// <param name="path">The path of the item.</param>
        /// <returns><c>true</c> if the specified path is file; otherwise, <c>false</c>.</returns>
        public virtual bool IsFile(string path)
        {
            FileAttributes Attribute = File.GetAttributes(path);
            return (Attribute & FileAttributes.Directory) == FileAttributes.Directory ? false : true;
        }
        /// <summary>
        /// Determines whether the specified rule has permission.
        /// </summary>
        /// <param name="rule">The rule.</param>
        /// <returns><c>true</c> if the specified rule has permission; otherwise, <c>false</c>.</returns>
        public virtual bool HasPermission(Permission rule)
        {
            return rule == Permission.Allow ? true : false;
        }
        /// <summary>
        /// Gets the physical path.
        /// </summary>
        /// <param name="path">The relative path.</param>
        /// <returns>System.String.</returns>
        public virtual string GetPath(string path)
        {
            return operation.GetPhysicalPath(operation.ToAbsolute(path));
        }
        public virtual void GetImage(string path)
        {
            if (!string.IsNullOrEmpty(path))
            {
                try
                {
                    path = operation.GetPhysicalPath(operation.ToAbsolute(path));
                    HttpResponse response = HttpContext.Current.Response;
                    response.Buffer = true;
                    response.Clear();
                    response.ContentType = "APPLICATION/octet-stream";
                    string extension = System.IO.Path.GetExtension(path);
                    response.AddHeader("content-disposition", "attachment; filename=" + System.IO.Path.GetFileName(path));
                    response.WriteFile(path);
                    response.Flush();
                    response.End();
                }
                catch (Exception ex) { throw ex; }
            }
            else throw new ArgumentNullException("name should not be null");
        }
        
        #if !SyncfusionFramework3_5
        public virtual void GetImage(string path, bool canCompress = false, ImageSize size = null, IEnumerable<object> selectedItems = null)
        {
            path = operation.GetPhysicalPath(operation.ToAbsolute(path));
            if (canCompress)
            {
                if (size == null)
                {
                    size = new ImageSize { Height = 104, Width = 116 };
                }
                operation.CompressImage(path, size);
            }
            else
                operation.GetFile(path, selectedItems);
        }
        #else
        public void GetImage(string path, bool canCompress, ImageSize size)
        {
            path = operation.GetPhysicalPath(operation.ToAbsolute(path));
            if (canCompress)
            {
                if (size == null)
                {
                    size = new ImageSize { Height = 104, Width = 116 };
                }
                operation.CompressImage(path, size);
            }
        }
        #endif

        
        /// <summary>
        /// Updates the folder rules.
        /// </summary>
        /// <param name="filePermission">The file access permission.</param>
        /// <param name="folderRule">The folder rule.</param>
        /// <returns>FileAccessRules.</returns>
        public virtual SQLFileAccessRules UpdateFolderRules(SQLFileAccessRules filePermission, SQLAccessRule folderRule)
        {
            filePermission.Copy = HasPermission(folderRule.Copy);
            filePermission.Edit = HasPermission(folderRule.Edit);
            filePermission.EditContents = HasPermission(folderRule.EditContents);
            filePermission.Read = HasPermission(folderRule.Read);
            filePermission.Upload = HasPermission(folderRule.Upload);
            return filePermission;
        }
        /// <summary>
        /// Updates the file rules.
        /// </summary>
        /// <param name="filePermission">The file access permission.</param>
        /// <param name="fileRule">The file rule.</param>
        /// <returns>FileAccessRules.</returns>
        public virtual SQLFileAccessRules UpdateFileRules(SQLFileAccessRules filePermission, SQLAccessRule fileRule)
        {
            filePermission.Copy = HasPermission(fileRule.Copy);
            filePermission.Download = HasPermission(fileRule.Download);
            filePermission.Edit = HasPermission(fileRule.Edit);
            filePermission.Read = HasPermission(fileRule.Read);
            return filePermission;
        }
        /// <summary>
        /// Gets the file permission details for specified file/ folder.
        /// </summary>
        /// <param name="location">The path.</param>
        /// <param name="name">The name.</param>
        /// <param name="isFile">if set to <c>true</c> [is file].</param>
        /// <returns>FileAccessRules.</returns>
        public virtual SQLFileAccessRules GetFilePermission(string location, string name, bool isFile)
        {
            SQLFileAccessRules FilePermission = new SQLFileAccessRules();
            if (isFile)
            {
                string nameExtension = Path.GetExtension(name).ToLower();
                foreach (SQLAccessRule fileRule in AccessRules.Rules)
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
                foreach (SQLAccessRule folderRule in AccessRules.Rules)
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

    /// <summary>
    /// Class FileExplorerResponse specifies the Ajax response parameter details.
    /// </summary>
    public class SQLFileExplorerResponses
    {
        /// <summary>
        /// Gets or sets the current working directory details.
        /// </summary>
        /// <value>The Current Working Directory content.</value>
        public FileExplorerDirectoryContent cwd { get; set; }
        /// <summary>
        /// Gets or sets the files/ folders list.
        /// </summary>
        /// <value>The files.</value>
        public IEnumerable<FileExplorerDirectoryContent> files { get; set; }
        /// <summary>
        /// Gets or sets the file/ folder details.
        /// </summary>
        /// <value>The details.</value>
        public IEnumerable<FileDetails> details { get; set; }
        /// <summary>
        /// Gets or sets the error details.
        /// </summary>
        /// <value>The error detail.</value>
        public object error { get; set; }
    }


    ///// <summary>
    ///// Class FileExplorerDirectoryContent specifies the directory content details.
    ///// </summary>
    //public class SQLFileExplorerDirectoryContents
    //{
    //    /// <summary>
    //    /// Gets or sets the name.
    //    /// </summary>
    //    /// <value>The name.</value>
    //    public string name { get; set; }
    //    /// <summary>
    //    /// Gets or sets the type.
    //    /// </summary>
    //    /// <value>The type.</value>
    //    public string type { get; set; }
    //    /// <summary>
    //    /// Gets or sets the size.
    //    /// </summary>
    //    /// <value>The size.</value>
    //    public long size { get; set; }
    //    /// <summary>
    //    /// Gets or sets the modified date.
    //    /// </summary>
    //    /// <value>The modified date.</value>
    //    public string dateModified { get; set; }
    //    /// <summary>
    //    /// Gets or sets a value indicating whether this instance has child.
    //    /// </summary>
    //    /// <value><c>true</c> if this instance has child; otherwise, <c>false</c>.</value>
    //    public bool hasChild { get; set; }
    //    /// <summary>
    //    /// Gets or sets a value indicating whether this instance is file.
    //    /// </summary>
    //    /// <value><c>true</c> if this instance is file; otherwise, <c>false</c>.</value>
    //    public bool isFile { get; set; }
    //    /// <summary>
    //    /// Gets or sets the filter path.
    //    /// </summary>
    //    /// <value>The filter path.</value>
    //    public string filterPath { get; set; }
    //    /// <summary>
    //    /// Gets or sets the access permission.
    //    /// </summary>
    //    /// <value>The access rule.</value>
    //    public SQLFileAccessRules permission { get; set; }
    //}
    public class SQLFileAccessRules
    {
        /// <summary>
        /// Permission for copy
        /// </summary>
        public bool Copy = true;
        /// <summary>
        /// Permission for download
        /// </summary>
        public bool Download = true;
        /// <summary>
        /// Permission for edit
        /// </summary>
        public bool Edit = true;
        /// <summary>
        /// Permission for editing the child contents
        /// </summary>
        public bool EditContents = true;
        /// <summary>
        /// Permission for read
        /// </summary>
        public bool Read = true;
        /// <summary>
        /// Permission for upload
        /// </summary>
        public bool Upload = true;
    }


    /// <summary>
    /// Class FileAccessInfo.
    /// </summary>
    public class SQLFileAccessInfo : FileAccessInfo
    {
        ///// <summary>
        ///// Gets or sets the role.
        ///// </summary>
        ///// <value>The role details.</value>
        //public string Role { get; set; }
        ///// <summary>
        ///// Gets or sets the collection of rules for folder and files.
        ///// </summary>
        ///// <value>The rules.</value>
        //public IEnumerable<SQLAccessRule> Rules { get; set; }
        ///// <summary>
        ///// Gets or sets the root path of the folder’s which want to be secure.
        ///// </summary>
        ///// <value>The root path.</value>
        //public string RootPath { get; set; }
    }
    /// <summary>
    /// Class AccessRule specifies rule for file/ folder.
    /// </summary>
    public class SQLAccessRule: AccessRule
    {
        ///// <summary>
        ///// Gets or sets the permission for edit.
        ///// </summary>
        ///// <value>The permission for edit.</value>
        //public Permission Edit { get; set; }
        /// <summary>
        /// Gets or sets the permission for editing its child contents.
        /// </summary>
        /// <value>The permission for editing contents.</value>
        //public Permission EditContents { get; set; }
        ///// <summary>
        ///// Gets or sets the path to apply the rules which are defined.
        ///// </summary>
        ///// <value>The path.</value>
        //public string Path { get; set; }
        ///// <summary>
        ///// Gets or sets the permission for read.
        ///// </summary>
        ///// <value>The permission for read.</value>
        //public Permission Read { get; set; }
        ///// <summary>
        ///// Gets or sets the role to which the rule is applied.
        ///// </summary>
        ///// <value>The role.</value>
        //public string Role { get; set; }
        ///// <summary>
        ///// Gets or sets the permission for upload.
        ///// </summary>
        ///// <value>The permission for upload.</value>
        //public Permission Upload { get; set; }
    }

    public class SQLCommonFileDetails
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        /// <value>The path.</value>
        public string Path { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this file is replace.
        /// </summary>
        /// <value><c>true</c> if this instance is replace; otherwise, <c>false</c>.</value>
        public bool IsReplace { get; set; }
    }

    /// <summary>
    /// Enum Permission
    /// </summary>
    //public enum Permission : Permission
    //{
    //    /// <summary>
    //    /// The allow
    //    /// </summary>
    //    Allow,
    //    /// <summary>
    //    /// The deny
    //    /// </summary>
    //    Deny
    //}
}