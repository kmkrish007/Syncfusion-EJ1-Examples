<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <ej:Autocomplete ID="Autocomplete1" runat="server"  DataTextField="Description" DataUniqueKeyField="Product_ID" Width="100%" ShowPopupButton="true" OnValueSelect="Autocomplete1_ValueSelect">
         <MultiColumnSettings Enable="true" ShowHeader="true" StringFormat="{1}">
             <Columns>
                 <ej:Columns Field="Product_ID" HeaderText="Product_ID" />
                <ej:Columns Field="Product_Group" HeaderText="Product_Group" />
                <ej:Columns Field="Description" HeaderText="Description" />
              </Columns>
         </MultiColumnSettings>
        </ej:Autocomplete>

    <ej:Autocomplete ID="Autocomplete2" ShowPopupButton="true" Width="100%" runat="server"> 
        <MultiColumnSettings Enable="true" ShowHeader="true" StringFormat="{0}">
            <Columns>
            <ej:Columns Field="Details_ID" HeaderText="Details_ID" />
            <ej:Columns Field="Product_ID" HeaderText="Product_ID" />
            <ej:Columns Field="Products" HeaderText="Products" />
            </Columns>
        </MultiColumnSettings> 
     </ej:Autocomplete>




    <script>

    </script>



</asp:Content>
