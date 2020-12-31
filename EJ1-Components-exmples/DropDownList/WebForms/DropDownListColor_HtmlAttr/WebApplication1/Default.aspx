<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <ej:Tab ID="DishType" runat="server" Width="800px" ClientSideOnActive="onTabActive">
            <Items>
                <ej:TabItem Id="PizzaType" Text="Pizza Menu">
                    <ContentSection>
                         <ej:DropDownList ID="ddl_ContactType" runat="server" Width="300px" DataTextField="Text" DataValueField="Id" DataHtmlAttributesField="HtmlAttr" WatermarkText="Select Contact Type"></ej:DropDownList>
                    </ContentSection>
                </ej:TabItem>

                <ej:TabItem Id="SandwichType" Text="Sandwich Menu">
                    <ContentSection>
                       <div id="div1" runat="server">
                        </div>
                    </ContentSection>
                </ej:TabItem>
            </Items>
        </ej:Tab>
    <ej:Button runat="server" ID="DropBtn" OnClick="DropBtn_Click" Text="ChnageColor"></ej:Button>
</asp:Content>
