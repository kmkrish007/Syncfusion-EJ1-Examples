<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <ej:DropDownList ID="ddlMGDL" runat="server" DataTextField="Text"
                    DataValueField="Id"
                    EnableIncrementalSearch="true"
                    EnableFilterSearch="true"
                    CaseSensitiveSearch="true"
                    EnableRTL="true"
                    FilterType="Contains"
                    Width="250px"
                    ViewStateMode="Enabled"
                    ShowCheckbox="true"
                    AllowVirtualScrolling="true"
                    MultiSelectMode="VisualMode">
     </ej:DropDownList><br />

  <ej:ToggleButton runat="server" ID="ToggleButton1" Width="110px" DefaultText="CHECKALL" ActiveText="UNCHECKALL" ClientSideOnChange="onCheckUncheckAll2"></ej:ToggleButton>

                <br />

    <ej:Button Type="Submit" runat="server" Text="Submit"></ej:Button>

<script type="text/javascript">
               var target2;
               $(function () {
                   target2 = $('#<%=ddlMGDL.ClientID%>').data("ejDropDownList");
               });

               function onCheckUncheckAll2(args) {
                   if (args.isChecked) {
                       if (target2) target2.checkAll();
                   }
                   else
                       if (target2) target2.unCheckAll();
               }
    </script>
</asp:Content>
