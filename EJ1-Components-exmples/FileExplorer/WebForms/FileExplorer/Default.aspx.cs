using Syncfusion.JavaScript;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComboBox
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //fexplore.AllowDragAndDrop = false;
        }

        [System.Web.Services.WebMethod]
        public static object FileActionDefault(string ActionType, string Path, string ExtensionsAllow, string LocationFrom, string LocationTo, string Name, string[] Names, string NewName, string Action, bool CaseSensitive, string SearchString, IEnumerable<CommonFileDetails> CommonFiles)
        {
            FileExplorerOperations operation = new FileExplorerOperations();
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
}