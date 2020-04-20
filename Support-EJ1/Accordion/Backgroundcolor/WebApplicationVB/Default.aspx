<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApplicationVB._Default" %>

<%@ Register assembly="Syncfusion.EJ.Web" namespace="Syncfusion.JavaScript.Web" tagprefix="ej" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="MainContent">
    


    <ej:Accordion ID="BasicAccordion" runat="server">
        <Items>
            <ej:AccordionItem Text="Orubase">
                <ContentSection>
                     Orubase is the only mobile application development Framework built especially for developing complex line-of-business mobile applications targeting iOS, Android, and Windows Phone platforms in the shortest possible time frame. 
                </ContentSection>
            </ej:AccordionItem>
            <ej:AccordionItem Text="WinRT XAML">
                <ContentSection>
                    Essential Studio for WinRT contains all the controls you need to build line-of-business tablet applications including grid, chart, map, tree map, SSRS report viewer, rich-text editor, PDF viewer, gauges, barcode, editors, and much more. It also includes a unique set of controls for reading and writing Excel, Word, and PDF documents in Windows store apps.
                </ContentSection>
            </ej:AccordionItem>
            <ej:AccordionItem Text="Metro Studio">
                <ContentSection>
                    Syncfusion Metro Studio is a collection of over 2500 Metro-style icon templates that can be easily customized to create thousands of unique Metro icons. 
                </ContentSection>
            </ej:AccordionItem>
        </Items>
    </ej:Accordion>

    <style>

     
    </style>
</asp:Content>

