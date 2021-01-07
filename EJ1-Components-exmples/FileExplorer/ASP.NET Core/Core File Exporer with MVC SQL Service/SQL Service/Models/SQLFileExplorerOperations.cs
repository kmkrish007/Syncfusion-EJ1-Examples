using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;


namespace Syncfusion.JavaScript
{
    //create new custom class by inheriting the abstarct class BasicFileOperations
    public class SQLFileExplorerOperations : BasicFileOperations   {
        SqlConnection Connection = new SqlConnection();
        String TableName = "";
        int RootNode = 1;
        List<SQLFileExplorerDirectoryContent> Items = new List<SQLFileExplorerDirectoryContent>();        
        
        public SQLFileExplorerOperations(string connectionString, string tableName, int rootNodeId = 1)
        {
            TableName = tableName;
            RootNode = rootNodeId;
            Connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings[connectionString].ConnectionString;
            Connection.Open();
        }

        public virtual bool HasChildDirectory(int id)
        {
            SqlCommand myCommand = new SqlCommand("select * from " + TableName + " where ParentId =" + id + " AND IsFile= 0", Connection);
            SqlDataReader myReader = myCommand.ExecuteReader();
            if (myReader.Read())
            {
                myReader.Close();
                return true;
            }
            else
            {
                myReader.Close();
                return false;
            }
        }
        public virtual void AddFolder(IEnumerable<object> selectedItems, string name, string mimeType, byte[] content)
        {
            int parentID = RootNode;
            if (selectedItems != null)
            {
                foreach (SQLFileExplorerDirectoryContent item in selectedItems)
                {
                    parentID = item.itemId;
                    break;
                }
            }
            SqlCommand command = new SqlCommand("INSERT INTO " + TableName + " ( Name, ParentId, IsFile) VALUES ( @Name, @ParentId, @IsFile)", Connection);
            command.Parameters.Add(new SqlParameter("@Name", name));
            command.Parameters.Add(new SqlParameter("@IsFile", false));
            command.Parameters.Add(new SqlParameter("@ParentId", parentID));
            command.ExecuteNonQuery();
        }
        public virtual void AddItem(string name, bool isFile, long size, int parentId, string mimeType, byte[] content)
        {
            SqlCommand command = new SqlCommand("INSERT INTO " + TableName + " ( Name, ParentId, IsFile, Size, MimeType, Content ) VALUES ( @Name, @ParentId, @IsFile, @Size, @MimeType, @Content)", Connection);
            command.Parameters.Add(new SqlParameter("@Name", name));
            command.Parameters.Add(new SqlParameter("@IsFile", isFile));
            command.Parameters.Add(new SqlParameter("@Size", size));
            command.Parameters.Add(new SqlParameter("@ParentId", parentId));
            command.Parameters.Add(new SqlParameter("@MimeType", mimeType));
            command.Parameters.Add(new SqlParameter("@Content", content));
            command.ExecuteNonQuery();
        }
        public virtual object ReadDetails(int itemId)
        {
            SQLFileExplorerResponse CreateResponse = new SQLFileExplorerResponse();
            SqlCommand myCommand = new SqlCommand("select * from " + TableName + " where ItemId =" + itemId, Connection);
            SqlDataReader myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                SQLFileDetails entry = new SQLFileDetails();
                entry.Name = myReader["Name"].ToString().Trim();
                entry.Type = myReader["IsFile"].ToString() == "True" ? myReader["MimeType"].ToString() : "Directory";
                entry.Size = (myReader["Size"].ToString() != "" ? (long)myReader["Size"] : 0);
                entry.ParentID = (int)myReader["ParentID"];
                myReader.Close();
                var details = new[] { entry };
                CreateResponse.details = (IEnumerable<SQLFileDetails>)details;
                return CreateResponse;
            }
            return null;
        }
        public virtual void RemoveDirectory(int id)
        {
            List<int> ids = new List<int>();
            SqlCommand readCmd = new SqlCommand("select * from " + TableName + " where ParentId =" + id, Connection);
            SqlDataReader reader = readCmd.ExecuteReader();
            while (reader.Read())
            {
                int childID = (int)reader["ItemId"];
                ids.Add(childID);
            }
            reader.Close();
            foreach (int childID in ids)
            {
                RemoveDirectory(childID);
            }
            SqlCommand deleteCommand = new SqlCommand("delete from " + TableName + " where ItemId =" + id, Connection);
            deleteCommand.ExecuteNonQuery();
        }
        public virtual int CanReplace(string name, IEnumerable<CommonFileDetails> commonFiles)
        {
            if (commonFiles != null)
            {
                foreach (var file in commonFiles)
                {
                    if (file.Name == name)
                        return file.IsReplace == true ? 1 : 2;
                }
            }

            return 0;
        }

        public override object CreateFolder(string path = null, string name = null, IEnumerable<object> selectedItems = null)
        {
            AddFolder(selectedItems, name, String.Empty, null);
            SQLFileExplorerResponse CreateResponse = new SQLFileExplorerResponse();
            SQLFileExplorerDirectoryContent content = new SQLFileExplorerDirectoryContent();
            content.name = name;
            var directories = new[]{content};
            CreateResponse.files = (IEnumerable<SQLFileExplorerDirectoryContent>) directories;
            return CreateResponse;            
        }

        public override void Download(string path = null, string[] names = null, IEnumerable<object> selectedItems = null)
        {
            if (selectedItems != null)
            {
                foreach (SQLFileExplorerDirectoryContent item in selectedItems)
                {
                    byte[] fileContent;
                    SqlCommand myCommand = new SqlCommand("select * from " + TableName + " where ItemId =" + item.itemId, Connection);
                    SqlDataReader myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        fileContent = (byte[])myReader["Content"];
                        try
                        {
                            HttpResponse response = HttpContext.Current.Response;
                            response.ClearHeaders();
                            response.Clear();
                            response.Expires = 0;
                            response.Buffer = true;
                            response.AddHeader("Content-Disposition", "Attachment;FileName=" + myReader["Name"].ToString());
                            response.ContentType = "APPLICATION/octet-stream";
                            response.BinaryWrite(fileContent);
                            response.End();
                        }
                        catch (Exception ex) { throw ex; }
                    }
                    break;
                }
            }

        }

        public override object GetDetails(string path = null, string[] names = null, IEnumerable<object> selectedItems = null)
        {
            try
            {
                if (selectedItems != null)
                {
                    foreach (SQLFileExplorerDirectoryContent item in selectedItems)
                    {
                        return ReadDetails(item.itemId);                        
                    }
                    return null;
                }
                else
                    return ReadDetails(RootNode);                                        
            }
            catch (Exception ex) { throw ex; }
        }

        public override void GetImage(string path = null, IEnumerable<object> selectedItems = null)
        {
            Download(null, null, selectedItems);
        }

        public override object Paste(string sourceDir = null, string targetDir = null, string[] names = null, string option = null, IEnumerable<CommonFileDetails> commonFiles = null, IEnumerable<object> selectedItems = null, IEnumerable<object> targetFolder = null)
        {
            int CurrentID = RootNode;
            string targetName;
            if (targetFolder != null) {
                foreach (SQLFileExplorerDirectoryContent item in targetFolder)
                {
                    CurrentID = item.itemId;
                    break;
                }
            }
            foreach (SQLFileExplorerDirectoryContent item in selectedItems)
            {
                var state= CanReplace(item.name, commonFiles);
                if (state != 2)
                {
                    if (state == 1 && CurrentID != item.parentID)
                    {
                        SqlCommand deleteCommand = new SqlCommand("delete from " + TableName + " where Name = '" + item.name + "' AND ParentId =" + CurrentID, Connection);
                        deleteCommand.ExecuteNonQuery();
                    }
                    if (option == "move")
                    {
                        SqlCommand moveCommand = new SqlCommand("UPDATE " + TableName + " SET ParentId=@ParentId where ItemId =" + item.itemId, Connection);
                        moveCommand.Parameters.Add(new SqlParameter("@ParentId", CurrentID));
                        moveCommand.ExecuteNonQuery();
                    }
                    else if (CurrentID != item.parentID)
                    {
                        SqlCommand copyCommand = null;
                        copyCommand = new SqlCommand("INSERT INTO " + TableName + " (Name, IsFile, ParentId, Size, MimeType, Content ) (SELECT Name, IsFile," + CurrentID + ", Size, MimeType, Content FROM " + TableName + " WHERE ItemId = " + item.itemId + ")", Connection);
                        copyCommand.ExecuteNonQuery();
                    }
                    else
                    {
                        int fileExtPos = item.name.LastIndexOf(".");
                        if (fileExtPos >= 0)
                            targetName = item.name.Substring(0, fileExtPos) + "(" + new Random().Next(1, 15) + ")" + item.name.Substring(fileExtPos);
                        else targetName = item.name + "(" + new Random().Next(1, 15) + ")";
                        SqlCommand copyCommand1 = null;
                        copyCommand1 = new SqlCommand("INSERT INTO " + TableName + " (Name, IsFile, ParentId, Size, MimeType, Content ) (SELECT '" + targetName + "', IsFile," + CurrentID + ", Size, MimeType, Content FROM " + TableName + " WHERE ItemId = " + item.itemId + ")", Connection);
                        copyCommand1.ExecuteNonQuery();
                    }
                }
            }
            return null;
        }

        public override object Read(string path = null, string filter = null, IEnumerable<object> selectedItems = null)
        {
            try
            {
                List<SQLFileExplorerDirectoryContent> details = new List<SQLFileExplorerDirectoryContent>();
                SqlDataReader myReader = null,myReader1 = null;
                int ID = RootNode;
                filter = filter.Replace(" ", "");
                var extensions = (filter ?? "*").Split(",|;".ToCharArray(), System.StringSplitOptions.RemoveEmptyEntries);
                if (selectedItems != null)
                {
                    foreach (SQLFileExplorerDirectoryContent item in selectedItems)
                    {
                        ID = item.itemId;
                        break;
                    }
                }
                SqlCommand myCommand = new SqlCommand("select * from " + TableName + " where ParentId =" + ID, Connection);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    bool canAdd = false;
                    if (extensions[0].Equals("*.*") || extensions[0].Equals("*"))
                        canAdd = true;
                    else if(myReader["IsFile"].ToString() == "True" ){
                        var names= myReader["Name"].ToString().Trim().Split('.');
                        if (Array.IndexOf(extensions, "*." + names[names.Count() - 1]) >= 0)                        
                            canAdd = true;
                        else canAdd = false;
                    }
                    else                    
                        canAdd = true;                    
                    if (canAdd)
                    {
                        SQLFileExplorerDirectoryContent entry = new SQLFileExplorerDirectoryContent();
                        entry.itemId = (int)myReader["ItemId"];
                        entry.name = myReader["Name"].ToString().Trim();
                        entry.type = myReader["IsFile"].ToString() == "True" ? myReader["MimeType"].ToString() : "Directory";
                        entry.isFile = (bool)myReader["IsFile"];
                        entry.size = (myReader["Size"].ToString() != "" ? (long)myReader["Size"] : 0);
                        entry.parentID = (int)myReader["ParentId"];
                        entry.hasChild = false;
                        entry.filterPath = "";
                        details.Add(entry);
                    }                    
                }
                myReader.Close();
                for (int i = 0; i < details.Count; i++)
                {
                    details[i].hasChild = HasChildDirectory(details[i].itemId);
                }

                SQLFileExplorerResponse ReadResponse = new SQLFileExplorerResponse();                                
                ReadResponse.files = (IEnumerable<SQLFileExplorerDirectoryContent>) details;
                SQLFileExplorerDirectoryContent cwd = new SQLFileExplorerDirectoryContent();
                SqlCommand myCommand1 = new SqlCommand("select * from " + TableName + " where ItemId =" + ID, Connection);
                myReader1 = myCommand1.ExecuteReader();
                while (myReader1.Read())
                {
                    cwd.itemId = (int)myReader1["ItemId"];
                    cwd.name = myReader1["Name"].ToString().Trim();
                    cwd.type = myReader1["IsFile"].ToString() == "True" ? myReader1["MimeType"].ToString() : "Directory";
                    cwd.isFile = (bool)myReader1["IsFile"];
                    cwd.size = (myReader1["Size"].ToString() != "" ? (long)myReader1["Size"] : 0);
                    cwd.parentID = (int)myReader1["ParentId"];
                    cwd.hasChild = false;
                    cwd.filterPath = "";
                    ReadResponse.cwd = cwd;
                }
                return ReadResponse;                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return null;
        }

        public override object Remove(string[] names = null, string path = null, IEnumerable<object> selectedItems = null)
        {
            foreach (SQLFileExplorerDirectoryContent item in selectedItems)
            {
                if (!item.isFile)
                {
                    RemoveDirectory(item.itemId);                    
                }
                else
                {
                    SqlCommand deleteCommand = new SqlCommand("delete from " + TableName + " where ItemId =" + item.itemId, Connection);
                    deleteCommand.ExecuteNonQuery();
                }                
            }
            return null;
        }               

        public override object Rename(string path = null, string oldName = null, string newName = null, IEnumerable<CommonFileDetails> commonFiles = null, IEnumerable<object> selectedItems = null)
        {
            foreach (SQLFileExplorerDirectoryContent item in selectedItems)
            {
                SqlCommand renameCommand = new SqlCommand(string.Format("UPDATE " + TableName + " SET Name='{0}' where ItemId ='{1}'", newName, item.itemId), Connection);
                renameCommand.ExecuteNonQuery();
                break;                                
            }
            return null;
        }
        public override object Search(string path = null, string filter = null, string searchString = null, bool caseSensitive = false, IEnumerable<object> selectedItems = null)
        {
            Items.Clear();
            SQLFileExplorerResponse data = (SQLFileExplorerResponse) Read(path, filter, selectedItems);            
            Items.AddRange(data.files);
            getAllFiles(data, filter);
            data.files  = Items.Where(item => new Regex(WildcardToRegex(searchString), (caseSensitive ? RegexOptions.None : RegexOptions.IgnoreCase)).IsMatch(item.name));            
            return data;
        }
        public virtual void getAllFiles(SQLFileExplorerResponse data, string filter)
        {            
            SQLFileExplorerResponse directoryList= new SQLFileExplorerResponse();
            directoryList.files= (IEnumerable<SQLFileExplorerDirectoryContent>)data.files.Where(item=> item.isFile == false);
            for (int i = 0; i < directoryList.files.Count(); i++ )
            {
                IEnumerable<SQLFileExplorerDirectoryContent> selectedItem = new[] { directoryList.files.ElementAt(i) };
                SQLFileExplorerResponse innerData = (SQLFileExplorerResponse)Read("", filter, selectedItem);
                innerData.files = innerData.files.Select(file => new SQLFileExplorerDirectoryContent
                {
                        itemId = file.itemId,
                        name = file.name,
                        type = file.type,
                        isFile = file.isFile,
                        size = file.size,
                        parentID = file.parentID,
                        hasChild = file.hasChild,                        
                        filterPath = (directoryList.files.ElementAt(i).filterPath + directoryList.files.ElementAt(i).name + "\\")
                });                 
                Items.AddRange(innerData.files);
                getAllFiles(innerData, filter);
            }
         }

        public override void Upload(IEnumerable<HttpPostedFileBase> files = null, string path = null, IEnumerable<object> selectedItems = null)
        {
            int ID = RootNode;
            if (selectedItems != null)
            {
                foreach (SQLFileExplorerDirectoryContent item in selectedItems)
                {
                    ID = item.itemId;
                    break;
                }
            }
            foreach (HttpPostedFileBase file in files)
            {
                byte[] fileData = new byte[file.ContentLength];
                file.InputStream.Read(fileData, 0, file.ContentLength);
                AddItem(file.FileName, true, file.ContentLength, ID, file.ContentType, fileData);
            }
        }

        public override void GetImage(string path, bool canCompress = false, ImageSize size = null, IEnumerable<object> selectedItems = null)
        {
            throw new NotImplementedException();
        }
    }    
    public class SQLFileExplorerDirectoryContent
    {
        public int itemId { get; set; }
        public string dateModified { get; set; }
        public bool hasChild { get; set; }
        public bool isFile { get; set; }
        public string name { get; set; }
        public object size { get; set; }
        public string type { get; set; }
        public int parentID { get; set; }
        public string filterPath { get; set; }
    }

    public class SQLFileExplorerParams
    {
        public string Action { get; set; }
        public string ActionType { get; set; }
        public string ExtensionsAllow { get; set; }
        public IEnumerable<System.Web.HttpPostedFileBase> FileUpload { get; set; }
        public string LocationFrom { get; set; }
        public string LocationTo { get; set; }
        public string Name { get; set; }
        public string[] Names { get; set; }
        public string NewName { get; set; }
        public string Path { get; set; }
        public string SearchString { get; set; }
        public bool CaseSensitive { get; set; }
        public IEnumerable<SQLFileExplorerDirectoryContent> SelectedItems { get; set; }
        public IEnumerable<SQLFileExplorerDirectoryContent> TargetFolder { get; set; }
        public IEnumerable<CommonFileDetails> CommonFiles { get; set; }
    }
    public class SQLFileExplorerGetParams
    {
        public string Action { get; set; }
        public string ActionType { get; set; }
        public string Name { get; set; }
        public string[] Names { get; set; }
        public string Path { get; set; }
        public string Type { get; set; }
        public string SelectedItems { get; set; }
    }
    public class SQLFileDetails
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public object Size { get; set; }
        public int ParentID { get; set; }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        /// <value>The location.</value>
        public string Location { get; set; }
        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>The created date.</value>
        public string Created { get; set; }
        /// <summary>
        /// Gets or sets the modified date.
        /// </summary>
        /// <value>The modified date.</value>
        public string Modified { get; set; }

    }
    public class SQLFileExplorerResponse
    {
        public IEnumerable<SQLFileExplorerDirectoryContent> files { get; set; }
        public IEnumerable<SQLFileDetails> details { get; set; }
        public object error { get; set; }

        public SQLFileExplorerDirectoryContent cwd { get; set; }


    }    
}