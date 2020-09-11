<%@ Page Title="About" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.vb" Inherits="WebApplication1VB.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <p>Your app description page.</p>
    <p>Use this area to provide additional information.</p>
    <asp:UpdatePanel ID="updpnlAudit" runat="server">
        <ContentTemplate>
            <table style="width:100%" >
       <div id="divTest" runat="server"/>
                <tr>
            <td colspan="3" style="text-align:right">
                <asp:Button ID="btnSave" runat="server" Text="Edit" />
                <asp:Button ID="btnClose" runat="server" Text="Cancel" CausesValidation="false" />
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <ej:Accordion ID="sfaccdQuestion" runat="server" EnableMultipleOpen="true"></ej:Accordion>
                
            </td>
        </tr>
        
        <tr>
            <td>
                <asp:Label ID="lblResults" runat="server"></asp:Label>
                <asp:Label ID="lblRecInfo" runat="server" ></asp:Label>
            </td>
        </tr>
    </table>
    <asp:HiddenField ID="pkPerfIndxId" runat="server" />
  </ContentTemplate>
    <Triggers>
       <asp:PostBackTrigger ControlID="btnSave" />
       
    </Triggers>
            

    </asp:UpdatePanel>
</asp:Content>
