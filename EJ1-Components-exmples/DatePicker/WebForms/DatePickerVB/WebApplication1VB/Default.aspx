<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApplication1VB._Default" %>

<%@ Register assembly="Syncfusion.EJ.Web" namespace="Syncfusion.JavaScript.Web" tagprefix="ej" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <asp:UpdatePanel ID="UpdatePanel1" runat="server">
         <ContentTemplate>
             <table style="width:100%" >
        <tr>
            <td>Template Names</td>
            <td><ej:ComboBox ID="cboTemplate" runat="server" DataTextField="tmpltname" DataValueField="template_id" Placeholder="Select an item"></ej:ComboBox> </td>
            <td><ej:DatePicker runat="server"  ID="dtpDtTest"></ej:DatePicker></td> 
        </tr>
        <tr>
            <td colspan="3">
                 <ajaxToolkit:Accordion ID="accdTemplate" runat="server">
                </ajaxToolkit:Accordion>
                   
            </td>
        </tr>
        <tr>
            <td colspan="3">
                
               
                
            </td>
        </tr>
        <tr>
            <td colspan="3" style="text-align:right">
                <asp:Button ID="btnSave" runat="server" Text="Save" />
                <asp:Button ID="btnClose" runat="server" Text="Cancel" />
            </td>
        </tr>
        
        <tr>
            <td>
                <asp:Label ID="lblResults" runat="server"></asp:Label></td>
        </tr>
    </table>
         </ContentTemplate>
     </asp:UpdatePanel>

     </asp:Content>
