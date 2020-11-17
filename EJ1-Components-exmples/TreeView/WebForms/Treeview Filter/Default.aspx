<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Treeview._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

 
  <div style="float: left; width: 200px;">
      <!-- TextBox Element -->
                <ej:MaskEdit
                    runat="server"
                    ID="inputBox"
                    Width="100%"
                    InputMode="Text"
                    MaskFormat=""
                    OnFocusOut="inputBox_FocusOut">
                </ej:MaskEdit>
            <ej:TreeView
                ID="treeViewDrag"
                runat="server"
                DataTextField="Text"
                DataIdField="Id"
                DataParentIdField="Parent"
                DataExpandedField="Expanded"
                ClientSideOnCreated="created">
            </ej:TreeView>
        </div>

    <script type="text/javascript">
        function created(args) {
            var treeObj = $("#MainContent_treeViewDrag").ejTreeView("instance");
            treeObj.expandAll();
        }
      
        
    </script>

</asp:Content>
