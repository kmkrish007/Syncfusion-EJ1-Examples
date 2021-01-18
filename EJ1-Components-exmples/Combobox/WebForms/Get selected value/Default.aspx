<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ComboBox._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <asp:Label runat="server" AssociatedControlID="txtCustID" CssClass="control-label" Style="font-size: 12px; color: black;">Customer Name</asp:Label>
     <ej:ComboBox ID="txtCustID" ClientIDMode="Static" runat="server" Width="100%"
           DataTextField="type" DataValueField="custid" ClientSideOnSelect="txtCustID_onSelect"  Placeholder="Select Customer">
 </ej:ComboBox>

    <script>
         function  txtCustID_onSelect(args) {
             var custid = args.value;
                alert(custid);
              return;
         }
    </script>
</asp:Content>
