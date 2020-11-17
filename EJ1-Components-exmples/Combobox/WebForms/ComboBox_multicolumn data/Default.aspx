<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ComboBox._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    

 <ej:ComboBox ID="cboTerapija" runat="server"
        Width="100%"
        DataTextField="CompanyName"
        DataValueField="CustomerID"
        DataSourceID="SqlDataSourceTerapija"
        Placeholder="Odaberite terapiju"
        ClientSideOnChange="myFunctionOnChange"
        ItemTemplate="<span><span class='name'>${CustomerID}</span><span class ='city'>${CompanyName}</span><span class ='city'>${City}</span></span>">
</ej:ComboBox>

        <asp:SqlDataSource ID="SqlDataSourceTerapija" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT TOP 10 [CustomerID], [CompanyName], [City] FROM [Customers]" ></asp:SqlDataSource>


    <script type="text/javascript">

        function myFunctionOnChange(args) {
            console.log("Customer ID: " + args.itemData.CustomerID);
            console.log("CompanyName: " + args.itemData.CompanyName);
            console.log("City: " + args.itemData.City);
        }
        
    </script>


</asp:Content>
