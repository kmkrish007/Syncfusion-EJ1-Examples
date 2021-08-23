<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApplicationVB._Default" %>

<%@ Register assembly="Syncfusion.EJ.Web" namespace="Syncfusion.JavaScript.Web" tagprefix="ej" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="MainContent">
    
    <ej:Button Type="Button" Text="Hide Item" ClientSideOnClick="click" runat="server"></ej:Button>
    <ej:Button ID="Hide" Type="Button" Text="Hide Server" runat="server" OnClick="Hide_Click"></ej:Button>

<div class="frame">

    <ej:Menu ID="MenuCtrl" Width="515" runat="server">
        <Items>
            <ej:MenuItem Id="MenuItem1" Text="Products">
                <Items>
                    <ej:MenuItem Id="ASPNET" Text="ASP.NET">
                    </ej:MenuItem>
                </Items>
                <Items>
                    <ej:MenuItem Text="ASP.NET MVC">
                    </ej:MenuItem>
                </Items>
                <Items>
                    <ej:MenuItem Text="Mobile MVC">
                    </ej:MenuItem>
                </Items>
                <Items>
                    <ej:MenuItem Id="Silver" Text="Silverlight">
                    </ej:MenuItem>
                </Items>
            </ej:MenuItem>
            <ej:MenuItem Id="MenuItem2" Text="Support">
                <Items>
                    <ej:MenuItem Text="Direct-Trac Support">
                    </ej:MenuItem>
                </Items>
                <Items>
                    <ej:MenuItem Text="Community Forums">
                    </ej:MenuItem>
                </Items>
                <Items>
                    <ej:MenuItem Text="Knowledge Base">
                    </ej:MenuItem>
                </Items>
                <Items>
                    <ej:MenuItem Text="Online Documentation">
                    </ej:MenuItem>
                </Items>
            </ej:MenuItem>
            <ej:MenuItem Id="MenuItem3" Text="Purchase">
            </ej:MenuItem>
        </Items>
    </ej:Menu>
</div>

    <script>
        function click() {
            debugger;
            var menuObj = $("#<%= MenuCtrl.ClientID%>").ejMenu("instance");
            menuObj.hideItems(["#ASPNET"]);
        }
    </script>
</asp:Content>

