<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Treeview._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <ej:TreeView ID="treeViewDB" runat="server"></ej:TreeView>


    <script type="text/javascript">



        $(function () {

            var parent = 1000, child = 3, treeData = [];
            for (let m = 1; m <= parent; m++) {
              var childArray = [];
              for (var n = 1; n <= child; n++) {
                  childArray.push({ id: "b" + m + n, name: "Node" + m + n, expanded: true });
              }
              treeData.push({ id: "a" + m, name: "Node" + m, child: childArray, expanded: true });
            }

            $("#<%= treeViewDB.ClientID %>").ejTreeView({
                    showCheckbox: false,
                    fields: {
                        dataSource: treeData,
                        id: "id",
                        text: "name",
                        //parentId: "parentID",
                        htmlAttributes: { style: "float:left;width:100px" },
                        linkAttribute: "linkProperty",
                        imageAttribute: "imageProperty"
                    },
                    cssClass: 'custom',
                    htmlAttributes: { class: "borderer" },
                    width: '400px'
            });
        });
        
        
    </script>

</asp:Content>
