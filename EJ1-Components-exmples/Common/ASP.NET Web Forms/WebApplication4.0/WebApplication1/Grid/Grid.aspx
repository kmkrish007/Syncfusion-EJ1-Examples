<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Grid.aspx.cs" Inherits="WebApplication1.Grid.Grid" %>


<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

   <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <ej:Grid ID="FlatGrid" runat="server" AllowSorting="True" OnServerWordExporting="FlatGrid_ServerWordExporting" OnServerPdfExporting="FlatGrid_ServerPdfExporting" OnServerExcelExporting="FlatGrid_ServerExcelExporting" OnServerEditRow="EditEvents_ServerEditRow"
                OnServerAddRow="EditEvents_ServerAddRow" OnServerDeleteRow="EditEvents_ServerDeleteRow" AllowPaging="True">
            <ToolbarSettings ShowToolbar="true" ToolbarItems="excelExport,wordExport,pdfExport,add,edit,delete,update,cancel"></ToolbarSettings>
          <Columns>
                        <ej:Column Field="OrderID" HeaderText="Order ID" IsPrimaryKey="true" TextAlign="Right" Width="80">
                            <ValidationRule>
                                <ej:KeyValue Key="required" Value="true" />
                                <ej:KeyValue Key="number" Value="true" />
                            </ValidationRule>
                        </ej:Column>
                        <ej:Column Field="CustomerID" HeaderText="Customer ID" Width="80">
                            <ValidationRule>
                                <ej:KeyValue Key="required" Value="true" />
                                <ej:KeyValue Key="minlength" Value="3" />
                            </ValidationRule>
                        </ej:Column>
                        <ej:Column Field="EmployeeID" HeaderText="Employee ID" TextAlign="Right" EditType="Dropdown" Width="80" />
                        <ej:Column Field="Freight" HeaderText="Freight" TextAlign="Right" Width="80" Format="{0:C}" EditType="Numeric">
                            <NumericEditOptions DecimalPlaces="2"></NumericEditOptions>
                        </ej:Column>
                        <ej:Column Field="ShipCountry" HeaderText="ShipCountry" Width="90" EditType="Dropdown" />
                        <ej:Column Field="ShipName" HeaderText="ShipName" Width="180" />
                        
                    </Columns>
                    <EditSettings AllowEditing="True" AllowAdding="True" AllowDeleting="True"></EditSettings>

        </ej:Grid>
        </ContentTemplate>

        <Triggers>
            <asp:PostBackTrigger ControlID="FlatGrid" />
        </Triggers>
    </asp:UpdatePanel>

</asp:Content>
