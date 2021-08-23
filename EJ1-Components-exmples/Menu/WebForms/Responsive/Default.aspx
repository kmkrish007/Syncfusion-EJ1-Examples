<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    
     <ej:Menu ID="Menu1" Width="800" runat="server" OpenOnClick="true">
        <Items>
            <ej:MenuItem Id="MenuItem1" Text="Products">
                <Items>
                    <ej:MenuItem Text="ASP.NET"></ej:MenuItem>
                </Items>
                <Items>
                    <ej:MenuItem Text="ASP.NET MVC"></ej:MenuItem>
                </Items>
                <Items>
                    <ej:MenuItem Text="Mobile MVC">
                    </ej:MenuItem>
                </Items>
                <Items>
                    <ej:MenuItem Text="Silverlight">
                    </ej:MenuItem>
                </Items>
                <Items>
                    <ej:MenuItem Text="Windows Forms">
                    </ej:MenuItem>
                </Items>
            </ej:MenuItem>
            <ej:MenuItem Id="MenuItem2" Text="Support">
                <Items>
                    <ej:MenuItem Text="Windows Phone">
                    </ej:MenuItem>
                </Items>
                <Items>
                    <ej:MenuItem Text="WinRT (XMAL)">
                    </ej:MenuItem>
                </Items>
                <Items>
                    <ej:MenuItem Text="WPF">
                    </ej:MenuItem>
                </Items>
                <Items>
                    <ej:MenuItem Text="Orubase Studio">
                    </ej:MenuItem>
                </Items>
            </ej:MenuItem>

            <ej:MenuItem Id="MenuItem3" Text="Purchase">

            </ej:MenuItem>

            <ej:MenuItem Id="MenuItem4" Text="Downloads">

                <Items>

                    <ej:MenuItem Text="Evaluation">

                    </ej:MenuItem>

                </Items>

                <Items>

                    <ej:MenuItem Text="Free E-Books">

                    </ej:MenuItem>

                </Items>

                <Items>

                    <ej:MenuItem Text="Metro Studio">

                    </ej:MenuItem>

                </Items>

            </ej:MenuItem>

            <ej:MenuItem Id="MenuItem5" Text="Resources">

                <Items>

                    <ej:MenuItem Text="Technology Resource Portal">

                    </ej:MenuItem>

                </Items>

                <Items>

                    <ej:MenuItem Text="Case Studies">

                    </ej:MenuItem>

                </Items>
            </ej:MenuItem>

        </Items>

    </ej:Menu>

    <style>
       /* show hamburger icon */
        .e-menu-res-wrap.e-menu-responsive .e-icon.e-check-wrap:before {
            content: "\e76b";
            font-size: 20px;
            width: 20px;
            height: 20px;
            margin-top: 5px;
            margin-bottom: 5px;
        }

        .e-menu.e-horizontal.e-menu-responsive>.e-list>a {
            line-height: 32px !important;
        }
        .e-menu.e-horizontal.e-menu-responsive li.e-list>a .e-icon
        {
            position: absolute;
            right: 8px;
        }
    .e-menu.e-menu-responsive .e-list > ul > .e-list > a span.e-arrows:before, .e-menu.e-menu-responsive .e-list > ul > .e-list > span span.e-arrows:before,.e-menu.e-vertical.e-menu-responsive > .e-list > a span.e-arrows:before, .e-menu.e-vertical.e-menu-responsive > .e-list > span span.e-arrows:before, .e-menu.e-menu-responsive .e-list > ul .e-list:hover > a span.e-arrows:before, .e-menu.e-menu-responsive .e-list > ul .e-list:hover > span span.e-arrows:before, .e-menu.e-menu-responsive > .e-list:hover > a span.e-arrows:before, .e-menu.e-menu-responsive > .e-list:hover > span span.e-arrows:before {
        content: "\e627" !important;
    }  
    .e-menu.e-horizontal.e-menu-responsive li.e-list ul,.e-menu.e-vertical.e-menu-responsive li.e-list ul {
        border:0 none;
    }
	.e-menu.e-separator.e-horizontal.e-menu-responsive > .e-list,.e-menu.e-separator.e-vertical.e-menu-responsive> .e-list {
        border: medium none;
    }
	.e-menu.e-menu-responsive{
	    border-top:none;
	}
    .e-menu-wrap.e-menu-responsive .e-hide {
        display: block;
        position: absolute;
    } 
    .e-menu.e-horizontal.e-menu-responsive,.e-menu.e-horizontal.e-menu-responsive.e-res-hide {
        display: none;
    }  
     .e-menu-res-wrap.e-menu-responsive,.e-menu.e-horizontal.e-menu-responsive.e-res-show,.e-menu-wrap.e-menu-responsive .e-res-title{
        display:block;
    }
   
        .e-menu.e-horizontal.e-menu-responsive li.e-list,.e-menu.e-vertical.e-menu-responsive,.e-menu.e-vertical.e-menu-responsive li.e-list  {
        display: block;
        }
        .e-menu.e-horizontal.e-menu-responsive li.e-list.e-hidden-item {
            display: none;
        }
    .e-menu.e-horizontal.e-menu-responsive li.e-list > ul, .e-menu.e-horizontal.e-menu-responsive  li.e-list,.e-menu.e-vertical.e-menu-responsive li.e-list > ul, .e-menu.e-vertical.e-menu-responsive  li.e-list  {
        position: static;
        }
    .e-menu.e-horizontal.e-menu-responsive> li.e-list > ul:after,.e-menu.e-vertical.e-menu-responsive > li.e-list > ul:after {
        content:none;
       }
    .e-menu.e-horizontal.e-menu-responsive>.e-list>a {
            line-height:32px !important;
        }
    .e-menu.e-horizontal.e-menu-responsive > .e-list > a > span {
        line-height:1 !important;
        top:35% !important;
        }
    .e-menu.e-horizontal.e-menu-responsive {
        height: initial !important;
    }
    .e-menu.e-vertical.e-menu-responsive>li.e-list >ul li.e-list > a, .e-menu.e-vertical.e-menu-responsive>li.e-list>ul li.e-list > span {
        line-height:27px;
       }
     .e-menu.e-menu-responsive li.e-list>ul li.e-list > a, .e-menu.e-menu-responsive li.e-list > ul li.e-list > span {
        padding: 0px 18px 0px 30px;
        line-height: 32px;
      }
    .e-menu-wrap.e-menu-responsive .e-menu.e-menu-responsive > li.e-separator {
        border:0;
        border-bottom:1px solid #c8c8c8;
    }
    .e-menu-wrap.e-menu-responsive .e-menu.e-horizontal.e-menu-responsive .e-list:hover {
        border-color:#c8c8c8;
    }
    </style>
</asp:Content>
