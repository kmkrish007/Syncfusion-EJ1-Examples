<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="MenuSqlSample._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>ComboBoxSQL Data</h2>

    <ej:ComboBox ID="givingTo" runat="server" Placeholder="Give To" Query="new ej.Query().take(10)" DataSourceID="SqlDataSource7" DataTextField="TerritoryDescription" Width="100%" AllowFiltering="true" ClientSideOnFiltering="onFiltering">
    </ej:ComboBox>
    <asp:SqlDataSource ID="SqlDataSource7" runat="server" ConnectionString="<%$ ConnectionStrings:SQLConnectionString %>" SelectCommand="SELECT TOP 8 TerritoryDescription  FROM [Territories]" ></asp:SqlDataSource>
 
    <script type="text/javascript">
        function onFiltering(e) {
             var query = new ej.Query().select(['TerritoryDescription','TerritoryID']);
         query = (e.text != "") ? query.where("TerritoryDescription", "contains", e.text, true) : query;
            e.updateData(this.model.dataSource, query);
        }
       
    </script>
</asp:Content>
