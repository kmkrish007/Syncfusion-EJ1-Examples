<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <%--<script
      src="https://maps.googleapis.com/maps/api/js?key=AIzaSyBIwzALxUPNbatRBj3Xi1Uhp0fFzwWNBkE&callback=initMap&libraries=places&v=weekly"
      defer
    ></script>--%>
    <%--<script async defer src="https://maps.googleapis.com/maps/api/js?key=AIzaSyDieZ7uAY4DPdT3Z4fp4KtykHl6dWryYdw&callback=initMap"></script>--%>
    <%--<script type="text/javascript" src="https://maps.google.com/maps/api/js?sensor=false&callback=initMap"></script>--%>
     <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCuEcop1y_JzAvNq7hwb0XS2J6OZqP99xU&libraries=places&callback=initMap" async="async" defer="defer"></script>
    <button onclick="valuechange()">change value</button>
     <button type="submit" runat="server">Submit</button>
    <asp:TextBox ID="txtShipGoogle" runat="server" Width="300px" Height="40px" CssClass="form-control" placeholder="Google Search" />
    <ej:Autocomplete ID="auto" runat="server" Width="300px" DataTextField="Name" ShowPopupButton="true" DataUniqueKeyField="Role" Query="ej.Query().requiresCount()">
                 <DataManager URL="Default.aspx/Get" Adaptor="WebMethodAdaptor"  />
        <MultiColumnSettings Enable="true" ShowHeader="true" StringFormat="{0}">
        <Columns>
            <ej:Columns Field="Name" HeaderText="Name" FilterType="Contains" />
            <ej:Columns Field="Role" HeaderText="Role" FilterType="Contains" />
            <ej:Columns Field="Street" HeaderText="Street" FilterType="Contains" />
        </Columns>
    </MultiColumnSettings>
        <ValidationRule>
        <ej:KeyValue Key="required" Value="true"></ej:KeyValue>
    </ValidationRule>
    <ValidationMessage>
        <ej:KeyValue Key="required" Value="*Name Required*"></ej:KeyValue>
    </ValidationMessage>
      </ej:Autocomplete>

    <script>
        $.validator.setDefaults({
    //if we don’t set custom class, default “error” class will be added
    errorClass: 'e-validation-error',
    //it specifies the error message display position
    errorPlacement: function (error, element) {
        $(error).insertAfter(element.closest(".e-widget"));
    }
        });

        function valuechange(args) {
            var place = "chennai";
            $('#<%=auto.ClientID %>').ejAutocomplete({ value: place.toUpperCase() });
        }

        function initMap() {
            acShip = new google.maps.places.Autocomplete(document.getElementById('<%=txtShipGoogle.ClientID %>'), { region: 'EU' });
            acShip.addListener('place_changed', fillInShipAddress);
        };
        function fillInShipAddress() {
            var place = acShip.getPlace();
            if (place) {
                if (place.name) {
                    $('#<%=auto.ClientID %>').ejAutocomplete({ value: place.name.toUpperCase() });
                    document.getElementById('<%=txtShipGoogle.ClientID %>').value = "";
                };
            };
        };
        
    </script>

    

</asp:Content>
