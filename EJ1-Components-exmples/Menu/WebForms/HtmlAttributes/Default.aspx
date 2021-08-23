<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Menu._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

      <ej:Menu ID="MenuCtrl" runat="server">
            <Items>
                <ej:MenuItem Id="Products" Text="Products" HtmlAttributes="class=onet">
                </ej:MenuItem>
                <ej:MenuItem Id="Support" Text="Support" HtmlAttributes="style=background-color:blue">
                </ej:MenuItem>
                <ej:MenuItem Id="Purchase" Text="Purchase">
                </ej:MenuItem>
                <ej:MenuItem Id="Downloads" Text="Downloads">
                </ej:MenuItem>
                <ej:MenuItem Id="Resources" Text="Resources">
                </ej:MenuItem>
            </Items>

        </ej:Menu>

    <ej:DropDownList ID="DropDownList1" runat="server">
                <Items>
                    <ej:DropDownListItem ID="DropDownListItem1" runat="server" Text="ListItem 1" Value="item1">
                    </ej:DropDownListItem>
                    <ej:DropDownListItem ID="DropDownListItem2" runat="server" Text="ListItem 2" Value="item2">
                    </ej:DropDownListItem>
                    <ej:DropDownListItem ID="DropDownListItem3" runat="server" Text="ListItem 3" Value="item3">
                    </ej:DropDownListItem>
                </Items>
        </ej:DropDownList>

</asp:Content>
