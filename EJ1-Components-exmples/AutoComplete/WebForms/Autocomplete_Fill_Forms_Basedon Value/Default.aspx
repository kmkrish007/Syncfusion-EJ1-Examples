<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <label>Select ZipCode: </label>
    <ej:Autocomplete ID="Autocomplete1" runat="server"  DataTextField="ZipCode" DataUniqueKeyField="ID" Width="100%" ShowPopupButton="true" OnValueSelect="Autocomplete1_ValueSelect">
     </ej:Autocomplete>

    <label>City</label>
        <asp:TextBox ID="City" runat="server"></asp:TextBox>
    <label>State</label>
    <asp:TextBox ID="State"  runat="server"></asp:TextBox>


     <ej:Autocomplete ID="Autocomplete2" runat="server"  DataTextField="Description" DataUniqueKeyField="Product_ID" Width="100%" ShowPopupButton="true" OnValueSelect="Autocomplete2_ValueSelect">
         <MultiColumnSettings Enable="true" ShowHeader="true" StringFormat="{1}">
             <Columns>
                 <ej:Columns Field="Product_ID" HeaderText="Product_ID" />
                <ej:Columns Field="Product_Group" HeaderText="Product_Group" />
                <ej:Columns Field="Description" HeaderText="Description" />
              </Columns>
         </MultiColumnSettings>
        </ej:Autocomplete>
</asp:Content>
