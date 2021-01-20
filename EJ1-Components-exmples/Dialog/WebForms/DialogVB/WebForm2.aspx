<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="Site.Master" CodeBehind="WebForm2.aspx.vb" Inherits="WebApplicationVB.WebForm2" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
       <style>
        body {
            overflow: hidden;
        }
        .e-headercell.customizes {

        }
        .e-rowcell.customizes {
            font-family: 'Segoe UI';
            padding: 2px 6px 2px 6px;
            font-size: 12px;
        }
    </style>
   <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                Select:<asp:DropDownList runat="server" id="Combo" AutoPostBack="true" ></asp:DropDownList>
                Selected Event:<input runat="server" id="Text"><br />
                 <div style="margin-top: 5%;">
                    <ej:Grid ID="Grid3"  height="360" runat="server">
                        <Columns>
                            <ej:Column Field="FirstName" HeaderText="Firs tName" Width="50" CssClass="customizes" />
                            <ej:Column Field="LastName" HeaderText="Last Name" Width="80" CssClass="customizes"/>
                            <ej:Column Field="Age" HeaderText="Age" Width="80"  CssClass="customizes"/>
                        </Columns>
                    </ej:Grid>
                </div>
            </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>