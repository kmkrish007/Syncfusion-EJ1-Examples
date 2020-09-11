<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<div id="control">
    <div class="ctrllabel">Select a Tree</div>
    <ej:listbox id="listBoxSample" runat="server" DataTextField="Name" DataValueField="Id" ClientSideOnSelected="onChange" Width="240"></ej:listbox>
</div>

     <ej:TreeView runat="server" ID="tree" LoadOnDemand="true" DataIdField="ID" DataTextField="Text"
    DataHasChildField="HasChild" DataParentIdField="ParentID">
</ej:TreeView>
   
    <script>
        function onChange(args) {
            $.ajax({
                type: "POST",
                url: "Default.aspx/Data",
                data: '{id: "'+args.data.Id +'"}',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) { 
                    treeObj = $("#<%= tree.ClientID %>").data('ejTreeView');
                    treeObj.setModel({
                        fields: {
                            dataSource: response.d,
                            id: "ID",
                            parentId: "ParentID",
                            text: "Text",
                            expanded: "Expanded",
                            hasChild: "HasChild"
                        }
                    });
                },
                error: function (jqXHR, status, error) {
                    console.log(status + ": " + error);
                }
            });

        }
    </script>
</asp:Content>
