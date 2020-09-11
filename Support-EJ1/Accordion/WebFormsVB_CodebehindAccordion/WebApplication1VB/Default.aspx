<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApplication1VB._Default" %>

<%@ Register assembly="Syncfusion.EJ.Web" namespace="Syncfusion.JavaScript.Web" tagprefix="ej" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<div style="width:700px">
    <asp:UpdatePanel ID="updpnlAudit" runat="server">
        <ContentTemplate>
            <table style="width:100%" >
                <tr>
                <td colspan="3" style="text-align:right">
                    <asp:Button ID="btnSave" runat="server" Text="Edit" />
                    <asp:Button ID="btnClose" runat="server" Text="Cancel" CausesValidation="false" />
                </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <ej:Accordion ID="sfaccdQuestion" runat="server" EnableMultipleOpen="true"></ej:Accordion>
                <%--<div id="divTest" runat="server"/>--%>
                       
                    </td>
                </tr>
        <%--<ej:Dialog runat="server" ID="sfDialog"></ej:Dialog>--%>
                <tr>
                    <td>
                        <asp:Label ID="lblResults" runat="server"></asp:Label>
                        <asp:Label ID="lblRecInfo" runat="server" ></asp:Label>
                    </td>
                </tr>
                 <ej:Tab runat="server" ID="sfTab"></ej:Tab>
            </table>
                
        <asp:HiddenField ID="pkPerfIndxId" runat="server" />

              
        </ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="btnSave"/>
            <%--<asp:AsyncPostBackTrigger ControlID="btnSave" />--%>
        </Triggers>
    </asp:UpdatePanel>
    </div>



     </asp:Content>
