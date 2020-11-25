<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <ej:Rotator ID="Rotator1" runat="server"
        FrameSpace="0px"
        DisplayItemCount="1"
        NavigateSteps="1"
        EnableResize="True"
        ShowPager="true"
        Enabled="true"
        ShowCaption="False"
        AllowKeyboardNavigation="true"
        ShowPlayButton="false"
        IsResponsive="true"
        AnimationType="slide"
        EnableAutoPlay="True"
        AnimationSpeed="200"
        Delay="2000"
        >
    <Items>
    <ej:RotatorItem Caption="Palm trees, Sanibel Lighthouse, Thomas Edison Winter Estate" Url="Content/Rotator_img/bird.jpg" ></ej:RotatorItem>
    <ej:RotatorItem Caption="Constitutional Complex" Url="Content/Rotator_img/snow.jpg" ></ej:RotatorItem>
    </Items>
    </ej:Rotator>

    <script>
        window.onresize = function() {
            var winHeight = $(window).height() + "px";
            var rtObj = $("#<%=Rotator1.ClientID%>").ejRotator("instance");
            rtObj.setModel({ slideHeight: winHeight });
        }
    </script>
</asp:Content>
