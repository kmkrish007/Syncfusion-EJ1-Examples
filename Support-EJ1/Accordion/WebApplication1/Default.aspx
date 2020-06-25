<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">    

    <ej:Accordion ID="BasicAccordion" runat="server" CssClass="customCss12">
    <Items>
        <ej:AccordionItem Text="Orubase">
            <contentsection>
                Orubase is the only mobile application development Framework built especially for developing complex line-of-business mobile applications targeting iOS, Android, and Windows Phone platforms in the shortest possible time frame. 
            </contentsection>
        </ej:AccordionItem>
        <ej:AccordionItem Text="WinRT XAML">
            <contentsection>
                Essential Studio for WinRT contains all the controls you need to build line-of-business tablet applications including grid, chart, map, tree map, SSRS report viewer, rich-text editor, PDF viewer, gauges, barcode, editors, and much more. It also includes a unique set of controls for reading and writing Excel, Word, and PDF documents in Windows store apps.
            </contentsection>
        </ej:AccordionItem>
        <ej:AccordionItem Text="Metro Studio">
            <contentsection>
                Syncfusion Metro Studio is a collection of over 2500 Metro-style icon templates that can be easily customized to create thousands of unique Metro icons. 
            </contentsection>
        </ej:AccordionItem>
    </Items>
    </ej:Accordion>
 <style>

       /*header background style*/ 
        .customCss12 h3 { 
            /*background-color: deepskyblue !important;*/ 
            color: #05487a !important;
            font-family: cursive;
            font-size: 2rem;
        } 
 
        /*content style*/ 
        .customCss12 .e-content{ 
            background-color: blue; 
            color:white; 
        } 
    </style>

</asp:Content>
