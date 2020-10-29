<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <ej:Autocomplete ID="AutoMedicine" runat="server" DataTextField="ProductName" FilterType="StartsWith" DataUniqueKeyField="TM_PRM_ID" Width="60%" ShowPopupButton="true" HighlightSearch="true" PopupHeight="200px" popupWidth="50%" ShowRoundedCorner="True"> 
        <MultiColumnSettings Enable="true" ShowHeader="true" StringFormat="{0}">
            <Columns>
             <ej:Columns Field="ProductCode" HeaderText="Product Code" />
             <ej:Columns Field="ProductName" HeaderText="Trade Name" />
             <ej:Columns Field="GenericName" HeaderText="Generic Name"/>
            </Columns>
        </MultiColumnSettings> 
     </ej:Autocomplete>




    <script>

    </script>



</asp:Content>
