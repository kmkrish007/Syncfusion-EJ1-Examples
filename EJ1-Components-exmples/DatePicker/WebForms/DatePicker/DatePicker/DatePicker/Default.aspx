<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DatePicker._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2>Modify this template to jump-start your ASP.NET application.</h2>
            </hgroup>
            <p>
                To learn more about ASP.NET, visit <a href="http://asp.net" title="ASP.NET Website">http://asp.net</a>.
                The page features <mark>videos, tutorials, and samples</mark> to help you get the most from ASP.NET.
                If you have any questions about ASP.NET visit
                <a href="http://forums.asp.net/18.aspx" title="ASP.NET Forum">our forums</a>.
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <ej:DatePicker ID="dateformat" runat="server" Value="05/28/2018"></ej:DatePicker>

    <ej:DatePicker ID="datepick" runat="server" Value="<%# DateTime.Now %>"></ej:DatePicker> 

    <ej:DateTimePicker ID="DateTimePicker1" runat="server" Value="<%# DateTime.Now %>" Width="180px">

                        </ej:DateTimePicker>

    <%--<ej:TimePicker ID="TimePicker1" runat="server" Value="<%# DateTime.Now %>" Interval="60" />--%>
    <script>
        $(function (){
            var val = $("#MainContent_datepick").val();
            console.log(val);
        });
    </script>
</asp:Content>
