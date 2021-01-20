<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EJDropDownList._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <div class="control">
        <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="OrderID" DataSourceID="SqlDataSource2">
                <Columns>
                    <asp:BoundField DataField="OrderID" HeaderText="OrderID" ReadOnly="True" SortExpression="OrderID" InsertVisible="False" />
                    <asp:TemplateField HeaderText="ShipCountry">
                        <ItemTemplate>
                             <ej:DropDownList runat="server" ID="ddTipoQualidade"  DataTextField="Nome" DataValueField="TipoQualidadeID"></ej:DropDownList>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <HeaderTemplate>
                              Qualidade
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label runat="server" ID="lbTipoQualidade" Text='<%# Eval("TipoQualidade") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                                    <ej:DropDownList runat="server" ID="Dropdown1"  DataTextField="Nome" DataValueField="TipoQualidadeID"></ej:DropDownList>
                        </EditItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings:ConnectionString2 %>' SelectCommand="SELECT TOP 10 [OrderID], [CustomerID], [EmployeeID], [ShipCountry] FROM [Orders] Where ShipCountry IS NOT NULL"></asp:SqlDataSource>
    </div>


</asp:Content>
