<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApplicationVB._Default" %>

<%@ Register assembly="Syncfusion.EJ.Web" namespace="Syncfusion.JavaScript.Web" tagprefix="ej" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="MainContent">
    
    <ej:Accordion ID="Accordion1" runat="server">
        <Items>
            <ej:AccordionItem ID="AccordionItem1" runat="server" Text="ASP.NET Web Forms">
                <ContentSection>
                    <asp:Button ID="Button1" Text="Remove" runat="server" />
                    <asp:Button ID="Button2"  Text="add" runat="server" OnClick="AddButtonClick"/>
                </ContentSection>
            </ej:AccordionItem>
        </Items>
    </ej:Accordion>
    
</asp:Content>

