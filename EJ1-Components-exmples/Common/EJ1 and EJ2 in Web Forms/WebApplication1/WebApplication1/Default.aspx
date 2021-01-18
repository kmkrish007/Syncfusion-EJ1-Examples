<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>EJ1 DatePicker</h3>
        <ej:DatePicker ID="date" runat="server"></ej:DatePicker>

    <h3>EJ1 Grid</h3>
       <ej:Grid ID="FlatGrid" runat="server" AllowSorting="True" AllowPaging="True" IsResponsive="true">
            <Columns>
                <ej:Column Field="OrderID" HeaderText="Order ID" IsPrimaryKey="True" TextAlign="Right" Width="75" />
                <ej:Column Field="CustomerID" HeaderText="Customer ID" Width="80" />
                <ej:Column Field="EmployeeID" HeaderText="Employee ID" TextAlign="Right" Width="75" Priority="4" />
                <ej:Column Field="Freight" HeaderText="Freight" TextAlign="Right" Width="75" Format="{0:C}" Priority="3" />
                <ej:Column Field="OrderDate" HeaderText="Order Date" TextAlign="Right" Width="80" Format="{0:MM/dd/yyyy}" Priority="2" />
                <ej:Column Field="ShipCity" HeaderText="Ship City" Width="110" Priority="2" />
            </Columns>
        </ej:Grid>
     <h3>EJ2 Dropdownlist</h3>
    
    <input type="text" id='customers' />
    
         <script>
          var dropDownListObj = new ej.dropdowns.DropDownList({
              // bind the DataManager instance to dataSource property
              dataSource: new ej.data.DataManager({
                  url: 'https://ej2services.syncfusion.com/production/web-services/api/Employees',
                  adaptor: new ej.data.WebApiAdaptor(),
                  crossDomain: true
              }),
              // bind the Query instance to query property
              query: new ej.data.Query().select(['FirstName', 'EmployeeID']).take(10).requiresCount(),
              // map the appropriate columns to fields property
              fields: { text: 'FirstName', value: 'EmployeeID' },
              // sort the resulted items
              sortOrder: 'Ascending',
              // set the placeholder to DropDownList input element
              placeholder: 'Select a name',
              // set the height of the popup element
              popupHeight: '200px'
          });
          dropDownListObj.appendTo('#customers');
      </script>
</asp:Content>
