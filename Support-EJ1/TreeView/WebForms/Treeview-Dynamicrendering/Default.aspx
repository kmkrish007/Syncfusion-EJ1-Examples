<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Treeview._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <ej:Button
            ID="add"
            Text="Render Tree"
            Type="Button"
            runat="server"
            ClientSideOnClick="createTree">
        </ej:Button>
    <div id="treeViewDB" runat="server" />

    <script type="text/javascript">

        window.treeData = [];

        function createTree() {
            CreateTreeData();
            bindData();
        }

        function bindData() {
            $("#<%= treeViewDB.ClientID %>").ejTreeView({
                    showCheckbox: false,
                    fields: {
                        dataSource: window.treeData,
                        id: "id",
                        text: "name",
                        expanded: "expanded",
                        htmlAttributes: { style: "float:left;width:100px" },
                        linkAttribute: "linkProperty",
                        imageAttribute: "imageProperty"
                    },
                    cssClass: 'custom',
                    htmlAttributes: { class: "borderer" },
                    width: '400px'
            });
        }

        function CreateTreeData() {
            var parent = 10, child = 10, child1 = 9, child2 = 10, treeData = [];
            for (let m = 1; m <= parent; m++) {
                  var childArray1 = [];
                  for (var n = 1; n <= child; n++) {
                      var childArray2 = [];
                      for (var o = 1; o <= child1; o++) {
                          var childArray3 = [];
                          for (var p = 1; p <= child2; p++) {
                              childArray3.push({ id: "d" + m + n + o + p, name: "Node" + m + n + o + p });
                          }
                          childArray2.push({ id: "c" + m + n + o, name: "Node" + m + n + o, child: childArray3, expanded: true });
                      }
                      childArray1.push({ id: "b" + m + n, name: "Node" + m + n, child: childArray2, expanded: true });
                  }
                  treeData.push({ id: "a" + m, name: "Node" + m, child: childArray1, expanded: true });
            }

            window.treeData = treeData;
        }
        
        
    </script>

</asp:Content>
