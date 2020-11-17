<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <ej:Tab ID="Tab1" runat="server" OnTabItemActive="Tab1_TabItemActive">
                    <Items>
                        <ej:TabItem ID="test1" Text="Test 1">
                            <ContentSection>
                                <ej:Grid ID="Grid1" runat='server'></ej:Grid>
                            </ContentSection>
                        </ej:TabItem>
                        <ej:TabItem ID="test2" Text="Test 2">
                            <ContentSection>
                                <ej:Grid ID="Grid2" runat='server'></ej:Grid>
                            </ContentSection>
                        </ej:TabItem>
                    </Items>
                </ej:Tab>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>

    </asp:Content>
