<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <ej:Autocomplete ID="Autocomplete1" runat="server"  DataTextField="Description" OnValueSelect="Autocomplete1_ValueSelect" DataUniqueKeyField="Product_ID" Width="100%" ShowPopupButton="true" ClientSideOnSelect="onSelect">
         <MultiColumnSettings Enable="true" ShowHeader="true" StringFormat="{1}">
             <Columns>
                <ej:Columns Field="Product_Group" HeaderText="Product_Group" />
                <ej:Columns Field="Description" HeaderText="Description" />
                 <ej:Columns Field="Products" HeaderText="Products" />
              </Columns>
         </MultiColumnSettings>
        </ej:Autocomplete>

    <script>
        function onSelect(args) {
            console.log(args.item);
        }
    </script>



</asp:Content>
