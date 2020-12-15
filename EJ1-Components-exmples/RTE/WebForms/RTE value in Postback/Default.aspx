<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<ej:Tab ID="dishtype" runat="server" Width="600px">
    <Items>
        <ej:TabItem ID="pizzatype" Text="Pizza Menu">
            <ContentSection>
                <p> Pizza cooked to perfection tossed with milk, vegetables, potatoes, poultry, 100% pure mutton, and cheese - and in creating nutritious and tasty meals to maintain good health.</p>
            </ContentSection>
        </ej:TabItem>
        <ej:TabItem ID="sandwichtype" Text="Sandwich Menu">
            <ContentSection>
                    <div>
                        <ej:RTE ID="RTE2" runat="server" Width="100%"></ej:RTE>
                    </div>
            </ContentSection>
        </ej:TabItem>
    </Items>
</ej:Tab>
    
</asp:Content>
