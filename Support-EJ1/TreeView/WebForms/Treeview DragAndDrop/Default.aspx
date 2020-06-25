<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Treeview._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

 
  <div style="float: left; width: 200px;">
            <ej:TreeView
                ID="treeViewDrag"
                runat="server"
                DataTextField="Text"
                DataIdField="Id"
                DataParentIdField="Parent"
                DataExpandedField="Expanded"
                AllowDragAndDrop="true"
                AllowDropChild="true"
                AllowDropSibling="true"
                AllowDragAndDropAcrossControl="true"
                ClientSideOnNodeDropped="Dropped">
            </ej:TreeView>
        </div>
        <div style="float: left; width: 200px;">
            <ej:TreeView
                ID="treeViewDrop"
                runat="server"
                DataTextField="Text"
                DataIdField="Id"
                DataParentIdField="Parent"
                DataExpandedField="Expanded"
                AllowDragAndDrop="true"
                AllowDropChild="true"
                AllowDropSibling="true"
                AllowDragAndDropAcrossControl="true"
                ClientSideOnNodeDropped="Dropped">
            </ej:TreeView>
        </div>

    <script type="text/javascript">

        function Dropped(args) {
            var droppedTreeID = args.droppedElement.closest(".e-treeview")[0].id;
            console.log(droppedTreeID);
        }
        
    </script>

</asp:Content>
