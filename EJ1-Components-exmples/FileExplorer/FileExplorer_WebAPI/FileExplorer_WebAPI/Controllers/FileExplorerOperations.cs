using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.IO.Packaging;
using System.Web.Script.Serialization;
using System.Text.RegularExpressions;

namespace Northwind
{
    public class FileExplorerOperations 
    {
        public static IEnumerable<DirectoryContent> Read(string path, string filter)
        {
            try
            {
                var directory = new DirectoryInfo(ToPhysicalPath(ToAbsolute(path)));
                filter = filter.Replace(" ", "");
                var extensions = (filter ?? "*").Split(",|;".ToCharArray(), System.StringSplitOptions.RemoveEmptyEntries);
                var files = extensions.SelectMany(directory.GetFiles)
                    .Select(file => new DirectoryContent
                    {
                        name = file.Name,
                        isFile = true,
                        size = file.Length,
                        type = "File",
                        dateModified = file.LastWriteTime.ToString(),
                        hasChild = false
                    });

                var directories = directory.GetDirectories().Select(subDirectory => new DirectoryContent
                {
                    name = subDirectory.Name,
                    size = 0,
                    type = "Directory",
                    isFile = false,
                    dateModified = subDirectory.LastWriteTime.ToString(),
                    hasChild = subDirectory.GetDirectories().Length > 0 ? true : false
                });

                return files.Concat(directories);
            }
            catch (Exception ex) { throw ex; }
        }
        public static FileExplorerResponse ReadData(string path, string filter)
        {
            FileExplorerResponse ReadResponse = new FileExplorerResponse();
            try
            {
                var directory = new DirectoryInfo(ToPhysicalPath(ToAbsolute(path)));
                DirectoryContent cwd = new DirectoryContent();
                cwd.name = directory.Name;
                cwd.size = 0;
                cwd.type = "Directory";
                cwd.isFile = false;
                cwd.dateModified = directory.LastWriteTime.ToString();
                cwd.hasChild = directory.GetDirectories().Length > 0 ? true : false;
                ReadResponse.cwd = cwd;
                filter = filter.Replace(" ", "");
                var extensions = (filter ?? "*").Split(",|;".ToCharArray(), System.StringSplitOptions.RemoveEmptyEntries);
                var files= extensions.SelectMany(directory.GetFiles)
                    .Select(file => new DirectoryContent
                    {
                        name = file.Name,
                        isFile = true,
                        size = file.Length,
                        type = "File",
                        dateModified = file.LastWriteTime.ToString(),
                        hasChild = false
                    });

                var directories= directory.GetDirectories().Select(subDirectory => new DirectoryContent
                {
                    name = subDirectory.Name,
                    size = 0,
                    type = "Directory",
                    isFile = false,
                    dateModified = subDirectory.LastWriteTime.ToString(),
                    hasChild = subDirectory.GetDirectories().Length > 0 ? true : false
                });
                object fileDetails = files.Concat(directories);
                ReadResponse.files = (IEnumerable<DirectoryContent>)fileDetails;
                return ReadResponse;
            }
            catch (Exception e) {
                ReadResponse.error = e.GetType().FullName + ", " + e.Message;
                return ReadResponse;
            }
        }
        public static string WildcardToRegex(string pattern)
        {            
            return "^" + Regex.Escape(pattern)
                              .Replace(@"\*", ".*")
                              .Replace(@"\?", ".")
                       + "$";
        }
        public static FileExplorerResponse Search(string path, string filter, string searchString, bool caseSensitive)
        {
            FileExplorerResponse ReadResponse = new FileExplorerResponse();
            try
            {
                var directory = new DirectoryInfo(ToPhysicalPath(ToAbsolute(path)));
                filter = filter.Replace(" ", "");
                var filterItems = directory.GetFiles(searchString, SearchOption.AllDirectories);
                var extensions = (filter ?? "*").Split(",|;".ToCharArray(), System.StringSplitOptions.RemoveEmptyEntries);
                var filteredList = directory.GetFiles(searchString, SearchOption.AllDirectories)
                    .Select(file => new DirectoryContent
                    {
                        name = file.Name,
                        isFile = true,
                        size = file.Length,
                        type = "File",
                        dateModified = file.LastWriteTime.ToString(),
                        hasChild = false,
                        filterPath = file.FullName.Replace(directory.FullName, "").Replace(file.Name, "")
                    }).
                    Where(item => new Regex(WildcardToRegex(searchString), (caseSensitive ? RegexOptions.None : RegexOptions.IgnoreCase)).IsMatch(item.name));

                var files = extensions.SelectMany(extention => filteredList.Where(a =>
                new Regex(WildcardToRegex(extention), (caseSensitive ? RegexOptions.None : RegexOptions.IgnoreCase)).IsMatch(a.name)));
                files = files.Where(item => new Regex(WildcardToRegex(searchString), (caseSensitive ? RegexOptions.None : RegexOptions.IgnoreCase)).IsMatch(item.name));
                var directories = directory.GetDirectories(searchString, SearchOption.AllDirectories).Select(subDirectory => new DirectoryContent
                {
                    name = subDirectory.Name,
                    size = 0,
                    type = "Directory",
                    isFile = false,
                    dateModified = subDirectory.LastWriteTime.ToString(),
                    hasChild = subDirectory.GetDirectories().Length > 0 ? true : false,
                    filterPath = subDirectory.FullName.Replace(directory.FullName, "").Replace(subDirectory.Name, "")
                }).
                Where(item => new Regex(WildcardToRegex(searchString), (caseSensitive ? RegexOptions.None : RegexOptions.IgnoreCase)).IsMatch(item.name));
                object fileDetails = files.Concat(directories);
                ReadResponse.files = (IEnumerable<DirectoryContent>)fileDetails;
                return ReadResponse;
            }
            catch (Exception e) {
                ReadResponse.error = e.GetType().FullName + ", " + e.Message;
                return ReadResponse;
            }
        }
        public static string CreateFolder(string path, string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                try
                {
                    var physicalPath = Path.Combine(ToPhysicalPath(ToAbsolute(path)), name);
                    int directoryCount = 0;
                    while (System.IO.Directory.Exists(physicalPath + (directoryCount > 0 ? "(" + directoryCount.ToString() + ")" : "")))
                        directoryCount++;
                    physicalPath = physicalPath + (directoryCount > 0 ? "(" + directoryCount.ToString() + ")" : "");
                    if (!Directory.Exists(physicalPath))
                    {
                        name = name + (directoryCount > 0 ? "(" + directoryCount.ToString() + ")" : "");
                        Directory.CreateDirectory(physicalPath);
                        return name;
                    }
                    else return null;
                }
                catch (Exception ex) { throw ex; }
            }
            else throw new ArgumentNullException("name should not be null");
        }
        public static FileExplorerResponse NewFolder(string path, string name)
        {
            FileExplorerResponse CreateResponse = new FileExplorerResponse();
            try
            {
                if (!string.IsNullOrEmpty(name))
                {
                    var physicalPath = Path.Combine(ToPhysicalPath(ToAbsolute(path)), name);
                    int directoryCount = 0;
                    while (System.IO.Directory.Exists(physicalPath + (directoryCount > 0 ? "(" + directoryCount.ToString() + ")" : "")))                        
                            directoryCount++;                        
                    physicalPath = physicalPath + (directoryCount > 0 ? "(" + directoryCount.ToString() + ")" : "");                    
                    if (!Directory.Exists(physicalPath))
                    {
                        name = name + (directoryCount > 0 ? "(" + directoryCount.ToString() + ")" : "");                    
                        Directory.CreateDirectory(physicalPath);
                        var directories = new[]{
                            GetFileDetails(physicalPath)
                        };
                        CreateResponse.files = directories;
                        return CreateResponse;
                    }
                    else throw new ArgumentException();
                }
                else throw new ArgumentNullException("name should not be null");
            }
            catch (Exception e) {
                CreateResponse.error = e.GetType().FullName + ", " + e.Message;
                return CreateResponse;
            }
        }
        public static FileExplorerResponse Delete(string[] names, string path)
        {
           return Remove(names, path);
        }
        public static FileExplorerResponse Remove(string[] names, string path)
        {
            FileExplorerResponse DeleteResponse = new FileExplorerResponse();
            try
            {
                DirectoryContent[] removedFiles = new DirectoryContent[names.Length];
                for (int i = 0; i < names.Length; i++)
                {
                    var fullPath = CombinePaths(ToAbsolute(path), names[i]);
                    if (!string.IsNullOrEmpty(names[i]))
                    {
                        var physicalPath = ToPhysicalPath(fullPath);
                        removedFiles[i] = GetFileDetails(physicalPath);
                        FileAttributes attr = File.GetAttributes(physicalPath);
                        //detect whether its a directory or file
                        if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                            DeleteDirectory(physicalPath);
                        else
                            System.IO.File.Delete(physicalPath);
                    }
                    else
                        throw new ArgumentNullException("name should not be null");
                }
                DeleteResponse.files = removedFiles;
                return DeleteResponse;
            }
            catch (Exception e)
            {
                DeleteResponse.error = e.GetType().FullName + ", " + e.Message;
                return DeleteResponse;
            }
        }
        public static void DeleteDirectory(string physicalPath)
        {
            string[] files = Directory.GetFiles(physicalPath);
            string[] dirs = Directory.GetDirectories(physicalPath);
            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }
            foreach (string dir in dirs)
            {
                DeleteDirectory(dir);
            }
            try
            {
                Thread.Sleep(20);
                Directory.Delete(physicalPath, true);
            }
            catch (IOException)
            {
                Thread.Sleep(20);
                Directory.Delete(physicalPath, true);
            }
        }
        public static FileExplorerResponse Rename(string path, string oldname, string newname, IEnumerable<CommonFileDetails> commonFiles)
        {
            FileExplorerResponse RenameResponse = new FileExplorerResponse();
            try
            {
                if (commonFiles != null)
                {
                    foreach (var file in commonFiles)
                    {
                        file.Path = ToPhysicalPath(ToAbsolute(file.Path));
                    }
                }
                string oldpath = "", newpath = "", temppath = "", tempname = "Syncfusion_TempFolder";
                path = ToAbsolute(path);
                if (!string.IsNullOrEmpty(oldname) && !string.IsNullOrEmpty(newname))
                {
                    oldpath = ToPhysicalPath(CombinePaths(path, oldname));
                    newpath = ToPhysicalPath(CombinePaths(path, newname));
                    temppath = ToPhysicalPath(CombinePaths(path, tempname));
                    FileInfo info = new FileInfo(oldpath);
                    var isFile = (info.Extension != "") ? true : false;
                    if (isFile)
                        info.MoveTo(newpath);
                    else
                    {
                        if (oldname.Equals(newname, StringComparison.OrdinalIgnoreCase))
                        {
                            MoveDirectory(oldpath, temppath, commonFiles, true);
                            MoveDirectory(temppath, newpath, commonFiles, true);
                        }
                        else
                            MoveDirectory(oldpath, newpath, commonFiles, true);
                    }
                    var addedData = new[]{
                        GetFileDetails(newpath)
                    };
                    RenameResponse.files = addedData;
                    return RenameResponse;
                }
                else
                    throw new ArgumentNullException("name should not be null");
            }
            catch (Exception e)
            {
                RenameResponse.error = e.GetType().FullName + ", " + e.Message;
                return RenameResponse;
            }
        }
        public static void MoveDirectory(string source, string target, IEnumerable<CommonFileDetails> commonFiles, bool makeDuplicate)
        {           
            var stack = new Stack<Folders>();
            var duplicateStack = new Stack<Folders>();
            stack.Push(new Folders(source, target));
            duplicateStack.Push(new Folders(source, target));
            while (stack.Count > 0)
            {
                var folders = stack.Pop();
                Directory.CreateDirectory(folders.Target);
                foreach (var file in Directory.GetFiles(folders.Source, "*.*"))
                {
                    string targetFile = Path.Combine(folders.Target, Path.GetFileName(file));
                    if (canReplace(targetFile, commonFiles))
                    {
                        if (File.Exists(targetFile))
                        {
                            if (makeDuplicate)
                            {
                                int fileExtPos = targetFile.LastIndexOf(".");
                                if (fileExtPos >= 0)
                                    targetFile = targetFile.Substring(0, fileExtPos);
                                int fileCount = 0;
                                while (System.IO.File.Exists(targetFile + (fileCount > 0 ? "(" + fileCount.ToString() + ")" + Path.GetExtension(file) : Path.GetExtension(file))))
                                {
                                    fileCount++;
                                }
                                targetFile = targetFile + (fileCount > 0 ? "(" + fileCount.ToString() + ")" : "") + Path.GetExtension(file);
                            }
                            else
                            {
                                File.Delete(targetFile);
                            }
                        }
                        File.Move(file, targetFile);
                    }                    
                }

                foreach (var folder in Directory.GetDirectories(folders.Source))
                {
                    string targetFolder = Path.Combine(folders.Target, Path.GetFileName(folder));
                    if (canReplace(targetFolder+"\\", commonFiles))
                    {
                        stack.Push(new Folders(folder, targetFolder));
                        duplicateStack.Push(new Folders(folder, targetFolder));
                    }                        
                }
            }
            while (duplicateStack.Count > 0)
            {
                var folders = duplicateStack.Pop();
                if (Directory.GetDirectories(folders.Source).Count() == 0 && Directory.GetFiles(folders.Source).Count() == 0)
                    Directory.Delete(folders.Source, true);
            }
            
        }
        public static bool canReplace(string path, IEnumerable<CommonFileDetails> commonFiles)
        {
            if (commonFiles != null)
            {
                foreach (var file in commonFiles)
                {
                    if (file.Path == path)
                        return file.IsReplace;
                }
            }
            
             return true;
        }
        
        public static FileExplorerResponse Paste(string sourceDir, string backupDir, string[] fNames, string option, IEnumerable<CommonFileDetails> commonFiles)
        {
            FileExplorerResponse PasteResponse = new FileExplorerResponse();
            try
            {
                if (commonFiles != null)
                {
                    foreach (var file in commonFiles)
                    {
                        file.Path = ToPhysicalPath(ToAbsolute(file.Path));
                    }
                }
                string[] copiedFiles = PasteOperataion(sourceDir, backupDir, fNames, option, commonFiles);
                PasteResponse.files = GetAllFileDetails(backupDir, copiedFiles);
                return PasteResponse;
            }
            catch (Exception e)
            {
                PasteResponse.error = e.GetType().FullName + ", " + e.Message;
                return PasteResponse;
            }
        }
        private static string[] PasteOperataion(string sourceDir, string backupDir, string[] fNames, string option, IEnumerable<CommonFileDetails> commonFiles)
        {
            string sourcePath, targetPath, fileName, destFile, virtualPath1, virtualPath2, type;
            List<string> fileNames = new List<string>();
            for (int i = 0; i < fNames.Length; i++)
            {
                string[] nodes = fNames[i].Split('/');
                fileNames.Add(nodes[nodes.Length - 1]);
            }
            string[] fileList, newFileList = new string[fileNames.Count];
            Array.Copy(fileNames.ToArray(), newFileList, fileNames.Count);
            for (int i = 0; i < fNames.Length; i++)
            {
                try
                {                   
                    sourcePath = ToAbsolute(sourceDir);
                    targetPath = ToAbsolute(backupDir);                    
                    sourcePath = CombinePaths(sourcePath, fNames[i]);                    
                    if (sourcePath == targetPath || sourcePath + "/" == targetPath)
                        continue;
                    if (targetPath != null && fileNames[i] != "")
                        targetPath = CombinePaths(targetPath, fileNames[i]);
                    sourcePath = ToPhysicalPath(sourcePath);
                    targetPath = ToPhysicalPath(targetPath);
                    FileAttributes attr = File.GetAttributes(sourcePath);
                    //detect whether its a directory or file
                    if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                        type = "Directory";
                    else
                        type = "File";    

                    if (type == "File")
                    {
                        if (option == "move")
                        {
                            if (sourcePath.CompareTo(targetPath) != 0 && canReplace(targetPath, commonFiles))
                            {
                                if (File.Exists(targetPath))
                                    File.Delete(targetPath);
                                System.IO.File.Move(sourcePath, targetPath);                                                            
                            }
                        }
                        else
                        {
                            if (sourcePath == targetPath)
                            {
                                int fileExtPos = targetPath.LastIndexOf(".");
                                if (fileExtPos >= 0)
                                    targetPath = targetPath.Substring(0, fileExtPos);
                                int fileCount = 0;
                                while (System.IO.File.Exists(targetPath + (fileCount > 0 ? "(" + fileCount.ToString() + ")" + Path.GetExtension(fNames[i]) : Path.GetExtension(fNames[i]))))
                                {
                                    fileCount++;
                                }
                                targetPath = targetPath + (fileCount > 0 ? "(" + fileCount.ToString() + ")" : "") + Path.GetExtension(fNames[i]);
                                int fileNamePos = targetPath.LastIndexOf("\\");
                                string newFileName = "";
                                if (fileNamePos >= 0)
                                    newFileName = targetPath.Substring(fileNamePos + 1);
                                newFileList[i] = newFileName;
                            }
                            if (canReplace(targetPath, commonFiles))
                                System.IO.File.Copy(sourcePath, targetPath, true);
                            else
                            {
                                newFileList = newFileList.Where(w => w != fileNames[i]).ToArray();
                            }
                        }
                    }
                    else if (type == "Directory")
                    {                        
                        if (System.IO.Directory.Exists(sourcePath))
                        {
                            if (option == "move")
                            {
                                if (sourcePath.CompareTo(targetPath + "\\") != 0 && canReplace(targetPath, commonFiles))
                                {                                    
                                    MoveDirectory(sourcePath, targetPath, commonFiles, false);
                                }
                            }
                            else if (canReplace(targetPath + "\\", commonFiles))
                            {
                                int directoryCount = 0;
                                if (sourcePath == targetPath )
                                {
                                    while (System.IO.Directory.Exists(targetPath + (directoryCount > 0 ? "(" + directoryCount.ToString() + ")" : "")))
                                    {
                                        directoryCount++;
                                    }
                                    targetPath = targetPath + (directoryCount > 0 ? "(" + directoryCount.ToString() + ")" : "");
                                    int fileNamePos = targetPath.LastIndexOf("\\");
                                    string newFileName = "";
                                    if (fileNamePos >= 0)
                                        newFileName = targetPath.Substring(fileNamePos + 1);
                                    newFileList[i] = newFileName;
                                }
                                Directory.CreateDirectory(targetPath);
                                string[] files = System.IO.Directory.GetFiles(sourcePath);
                                // Copy the files and overwrite destination files if they already exist. 
                                foreach (string s in files)
                                {
                                    // Use static Path methods to extract only the file name from the path.
                                    fileName = System.IO.Path.GetFileName(s);
                                    destFile = System.IO.Path.Combine(targetPath, fileName);
                                    if (canReplace(destFile, commonFiles))
                                        System.IO.File.Copy(s, destFile, true);
                                }
                                string[] directories = System.IO.Directory.GetDirectories(sourcePath);
                                virtualPath1 = System.IO.Path.Combine(sourceDir, fNames[i]);
                                virtualPath2 = System.IO.Path.Combine(backupDir, fileNames[i]);
                                virtualPath2 = virtualPath2 + (directoryCount > 0 ? "(" + directoryCount.ToString() + ")" : "");
                                foreach (string s in directories)
                                {
                                    // Use static Path methods to extract only the file name from the path.
                                    fileName = System.IO.Path.GetFileName(s);
                                    fileList = new string[] { fileName };
                                    string[] childFiles = PasteOperataion(virtualPath1, virtualPath2, fileList, option, commonFiles);
                                }
                            }
                            else
                            {
                                newFileList = newFileList.Where(w => w != fileNames[i]).ToArray();
                            }
                        }
                    }
                }
                catch (Exception ex) { throw ex; }
            }
            return newFileList;
        }

        public static void Upload(HttpFileCollection files, string path)
        {
            try
            {                
                for (int i=0 ; i< files.Count; i++)
                {
                    var fileName = Path.GetFileName(files[i].FileName);
                    //var newFilename = fileName.Replace("&", "");
                    var destinationPath = Path.Combine(ToPhysicalPath(ToAbsolute(path)), fileName);
                    files[i].SaveAs(destinationPath);
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private static void AddFileToZip(string zipFilename, string fileToAdd)
        {
            using (Package zip = System.IO.Packaging.Package.Open(zipFilename, FileMode.OpenOrCreate))
            {
               string destFilename = ".\\" + Path.GetFileName(fileToAdd);
                Uri uri = PackUriHelper.CreatePartUri(new Uri(destFilename, UriKind.Relative));
                if (zip.PartExists(uri))                
                    zip.DeletePart(uri);                
                PackagePart pkgPart = zip.CreatePart(uri, System.Net.Mime.MediaTypeNames.Application.Zip, CompressionOption.Normal);               
                Byte[] bites = System.IO.File.ReadAllBytes(fileToAdd);
                pkgPart.GetStream().Write(bites, 0, bites.Length);
                zip.Close();
            }            
        }
        public static void Download(string path, string[] names)
        {            
            if (names.Length > 1)
            {
                DownloadZip(path, names);
            }
            else
            {
                path = ToAbsolute(Path.Combine(path, names[0]));
                if (!string.IsNullOrEmpty(path))
                {
                    try
                    {
                        HttpResponse response = HttpContext.Current.Response;                        
                        var physicalPath = ToPhysicalPath(path);
                        physicalPath = physicalPath.Replace("\\ ", "/");
                        System.Net.WebClient net = new System.Net.WebClient();
                        string link = physicalPath;
                        response.ClearHeaders();
                        response.Clear();
                        response.Expires = 0;
                        response.Buffer = true;
                        response.AddHeader("Content-Disposition", "Attachment;FileName=" + names[0]);
                        response.ContentType = "APPLICATION/octet-stream";
                        response.BinaryWrite(net.DownloadData(link));
                        response.End();
                    }
                    catch (Exception ex) { throw ex; }
                }
                else throw new ArgumentNullException("name should not be null");
            }
        }
        public static void Download(string path)
        {
            path = ToAbsolute(path);
            if (!string.IsNullOrEmpty(path))
            {
                try
                {
                    HttpResponse response = HttpContext.Current.Response;
                    var splitpath = path.Split('/');
                    var physicalPath = ToPhysicalPath(path);
                    physicalPath = physicalPath.Replace("\\ ", "/");
                    System.Net.WebClient net = new System.Net.WebClient();
                    string link = physicalPath;
                    response.ClearHeaders();
                    response.Clear();
                    response.Expires = 0;
                    response.Buffer = true;
                    response.AddHeader("Content-Disposition", "Attachment;FileName=" + splitpath[splitpath.Length - 1]);
                    response.ContentType = "APPLICATION/octet-stream";
                    response.BinaryWrite(net.DownloadData(link));
                    response.End();
                }
                catch (Exception ex) { throw ex; }
            }
            else throw new ArgumentNullException("name should not be null");
        }
        public static void DownloadZip(string path, string[] names)
        {
            HttpResponse response = HttpContext.Current.Response;
            string tempPath = ToAbsolute(path + "temp.zip");
            tempPath = ToPhysicalPath(tempPath).Replace("\\ ", "/");
            for (int i = 0; i < names.Count(); i++)
            {
                string fullPath = ToAbsolute(path + names[i]);
                if (!string.IsNullOrEmpty(fullPath))
                {
                    try
                    {
                        var physicalPath = ToPhysicalPath(fullPath);
                        physicalPath = physicalPath.Replace("\\ ", "/");
                        AddFileToZip(tempPath, physicalPath);
                    }
                    catch (Exception ex) { throw ex; }
                }
                else throw new ArgumentNullException("name should not be null");
            }
                try
                {
                    System.Net.WebClient net = new System.Net.WebClient();
                    response.ClearHeaders();
                    response.Clear();
                    response.Expires = 0;
                    response.Buffer = true;
                    response.AddHeader("Content-Disposition", "Attachment;FileName=Files.zip");
                    response.ContentType = "application/zip";
                    response.BinaryWrite(net.DownloadData(tempPath));
                    response.End();
                    if (System.IO.File.Exists(tempPath))
                        System.IO.File.Delete(tempPath);
                }
                catch (Exception ex) { throw ex; }            
        }

        public static FileDetails GetDetails(string path, string name, string type)
        {
            path = ToAbsolute(path);
            path = CombinePaths(path, name);
            try
            {
                var physicalPath = ToPhysicalPath(path);
                FileInfo info = new FileInfo(physicalPath);
                FileDetails fileDetails = new FileDetails();
                fileDetails.Name = info.Name;
                fileDetails.Type = (info.Extension == "") ? "File Folder" : info.Extension; // Has period
                fileDetails.Location = info.FullName;
                fileDetails.Size = type == "File" ? info.Length : new DirectoryInfo(physicalPath).EnumerateFiles("*", SearchOption.AllDirectories).Sum(file => file.Length); ;
                fileDetails.Created = info.CreationTime.ToString();
                fileDetails.Modified = info.LastWriteTime.ToString();
                return fileDetails;
            }
            catch (Exception ex) { throw ex; }
        }

        public static FileExplorerResponse GetDetails(string path, string[] names)
        {
            FileExplorerResponse DetailsResponse = new FileExplorerResponse();
            try
            {
                FileDetails[] fDetails = new FileDetails[names.Length];
                for (int i = 0; i < names.Length; i++)
                {
                    var absolutePath = ToAbsolute(path);
                    absolutePath = CombinePaths(absolutePath, names[i]);
                    var physicalPath = ToPhysicalPath(absolutePath);
                    FileInfo info = new FileInfo(physicalPath);
                    FileDetails fileDetails = new FileDetails();
                    fileDetails.Name = info.Name;
                    fileDetails.Type = (info.Extension == "") ? "File Folder" : info.Extension; // Has period
                    fileDetails.Location = info.FullName;
                    fileDetails.Size = (info.Extension != "") ? info.Length : new DirectoryInfo(physicalPath).EnumerateFiles("*", SearchOption.AllDirectories).Sum(file => file.Length); ;
                    fileDetails.Created = info.CreationTime.ToString();
                    fileDetails.Modified = info.LastWriteTime.ToString();
                    fDetails[i] = fileDetails;
                }
                DetailsResponse.details = fDetails;
                return DetailsResponse;
            }
            catch (Exception e)
            {
                DetailsResponse.error = e.GetType().FullName + ", " + e.Message;
                return DetailsResponse;
            }
        }

        public static void GetImage(string path)
        {
            path = ToPhysicalPath(ToAbsolute(path));
            HttpResponse response = HttpContext.Current.Response;
            response.Buffer = true;
            response.Clear();
            response.ContentType = "APPLICATION/octet-stream";
            string extension = System.IO.Path.GetExtension(path);
            if (extension != ".htm" && extension != ".html" && extension != ".xml")
                response.AddHeader("content-disposition", "attachment; filename=" + System.IO.Path.GetFileName(path));
            response.WriteFile(path);
            response.Flush();
            response.End();
        }
        public static FileExplorerParams GetAjaxData(HttpRequestMessage request)
        {
            FileExplorerParams args= new FileExplorerParams();
            if (HttpContext.Current.Request.Files.Count > 0)
            {
               args.Files= HttpContext.Current.Request.Files; 
               args.Path = HttpContext.Current.Request.QueryString.GetValues("Path")[0];
               args.ActionType = "Upload";
            }
            else
            {
                var serializer = new JavaScriptSerializer();
                args = (FileExplorerParams)serializer.Deserialize(request.Content.ReadAsStringAsync().Result, typeof(FileExplorerParams));
            }
            return args;
        }
        public static string CombinePaths(string basePath, string relativePath)
        {
            return Path.GetPathRoot(basePath).Contains(':') ? Path.Combine(basePath, relativePath) : VirtualPathUtility.Combine(VirtualPathUtility.AppendTrailingSlash(basePath), relativePath);
        }

        internal static string ToAbsolute(string virtualPath)
        {
            if (Path.GetPathRoot(virtualPath).Contains(':'))
                return virtualPath;
            if (string.IsNullOrEmpty(virtualPath))
            {
                return null;
            }
            string url = HttpContext.Current.Request.Url.ToString();
            url = url.Replace(HttpContext.Current.Request.Url.AbsolutePath, "").Split('?')[0];
            if (virtualPath.Contains(url))
            {
                virtualPath = virtualPath.Replace(url, "");
            }
            return VirtualPathUtility.ToAbsolute(virtualPath);            
        }
        internal static string ToPhysicalPath(string virtualPath)
        {
            return Path.GetPathRoot(virtualPath).Contains(':') ? virtualPath : HttpContext.Current.Server.MapPath(virtualPath);
        }
        public static DirectoryContent GetFileDetails(string path)
        {
            FileInfo info = new FileInfo(path);
            FileAttributes attr = File.GetAttributes(path);
            var isFile = ((attr & FileAttributes.Directory) == FileAttributes.Directory) ? false : true;
            return new DirectoryContent
            {
                name = info.Name,
                size = isFile ? info.Length : 0,
                type = isFile ? "File" : "Directory",
                isFile = isFile,
                dateModified = info.LastWriteTime.ToString(),
                hasChild = isFile ? false : (info.Directory.GetDirectories().Length > 0 ? true : false),
            };
        }
        public static DirectoryContent[] GetAllFileDetails(string path, string[] fNames)
        {
            DirectoryContent[] fDetails = new DirectoryContent[fNames.Length];
            for (int i = 0; i < fNames.Length; i++)
            {
                var targetPath = ToAbsolute(path);
                if (targetPath != null && fNames[i] != "")
                    targetPath = CombinePaths(targetPath, fNames[i]);
                targetPath = ToPhysicalPath(targetPath);
                fDetails[i] = GetFileDetails(targetPath);
            }
            return fDetails;
        }
    }


    public class FileDetails
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public long Size { get; set; }
        public string Created { get; set; }
        public string Modified { get; set; }
        public FileAccessRules Permission { get; set; }
    }
    public class DirectoryContent
    {
        public string name { get; set; }
        public string type { get; set; }
        public long size { get; set; }
        public string dateModified { get; set; }
        public bool hasChild { get; set; }
        public bool isFile { get; set; }
        public string filterPath { get; set; }
        public FileAccessRules permission { get; set; }
    }
    public class CommonFileDetails
    {
        public string Name{get; set;}
        public string Path { get; set; }
        public bool IsReplace{get; set;}
    }
    public class Folders
    {
        public string Source { get; private set; }
        public string Target { get; private set; }

        public Folders(string source, string target)
        {
            Source = source;
            Target = target;
        }
    }
    public class FileExplorerParams
    {
        public string Name { get; set; }
        public string[] Names { get; set; }
        public string ActionType { get; set; }
        public string Path { get; set; }
        public string ExtensionsAllow { get; set; }
        public string Type { get; set; }
        public string LocationFrom { get; set; }
        public string LocationTo { get; set; }
        public string Action { get; set; }
        public string PreviousName { get; set; }              
        public string NewName { get; set; }              
        public IEnumerable<CommonFileDetails> CommonFiles{get; set;}         
        public HttpFileCollection Files { get; set; }
        public string SearchString { get; set; }
        public bool CaseSensitive { get; set; }
    }
    public class FileExplorerResponse
    {
        public DirectoryContent cwd { get; set; }
        public IEnumerable<DirectoryContent> files { get; set; }
        public IEnumerable<FileDetails> details { get; set; }
        public object error { get; set; }
    }
    public class FileAccessRules
    {
        public bool Copy = true;
        public bool Download = true;
        public bool Edit = true;
        public bool EditContents = true;
        public bool Read = true;
        public bool Upload = true;
    }
}