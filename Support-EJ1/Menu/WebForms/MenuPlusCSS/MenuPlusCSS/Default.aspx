<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MenuPlusCSS._Default" %>

<%@ Register Assembly="Syncfusion.EJ.Web, Version=18.1460.0.52, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89" Namespace="Syncfusion.JavaScript.Web" TagPrefix="ej" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap-menu/unmin/ej.web.all.css" rel="stylesheet" />
    <link href="//cdn.syncfusion.com/17.3.0.19/js/web/responsive-css/ej.responsive.css" rel="stylesheet" />
    <script src='//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js' type="text/javascript"></script>
    <script src='//cdn.syncfusion.com/17.3.0.19/js/web/ej.web.all.min.js' type="text/javascript"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div style="position:relative;">
            <ej:Menu ID="syncfusionProducts" runat="server" IsResponsive="true" OpenOnClick="true">
            <Items>
                <ej:MenuItem Id="Products" Text="BUY">
                    <Items>
                        <ej:MenuItem Text="CORE LABEL"></ej:MenuItem>
                    </Items>
                    <Items>
                        <ej:MenuItem Text="EVENT LABEL"></ej:MenuItem>
                    </Items>
                    <Items>
                        <ej:MenuItem Text="PILOT LABEL"></ej:MenuItem>
                    </Items>
                </ej:MenuItem>
                <ej:MenuItem Id="Support" Text="TASTE">
                    <Items>
                        <ej:MenuItem Text="CORE LABEL"></ej:MenuItem>
                    </Items>
                    <Items>
                        <ej:MenuItem Text="TASTE EXPERIENCE"></ej:MenuItem>
                    </Items>
                    <Items>
                        <ej:MenuItem Text="TASTE COMMUNICATOR"></ej:MenuItem>
                    </Items>
                    <Items>
                        <ej:MenuItem Text="KNOW HOW"></ej:MenuItem>
                    </Items>
                    <Items>
                        <ej:MenuItem Text="Services">
                            <Items>
                                <ej:MenuItem Text="Consulting"></ej:MenuItem>
                            </Items>
                            <Items>
                                <ej:MenuItem Text="Taining"></ej:MenuItem>
                            </Items>
                        </ej:MenuItem>
                    </Items>
                    <Items>
                        <ej:MenuItem Text="Community Forums"></ej:MenuItem>
                    </Items>
                </ej:MenuItem>
                <ej:MenuItem Id="Purchase" Text="SERVE">
                    <Items>
                        <ej:MenuItem Text="EVENT LABEL"></ej:MenuItem>
                    </Items>
                    <Items>
                        <ej:MenuItem Text="BEER COMMISIONS"></ej:MenuItem>
                    </Items>
                    <Items>
                        <ej:MenuItem Text="BEER STYLER"></ej:MenuItem>
                    </Items>
                </ej:MenuItem>
                <ej:MenuItem Id="Downloads" Text="DESIGN">
                    <Items>
                        <ej:MenuItem Text="PILOT LABEL"></ej:MenuItem>
                    </Items>
                    <Items>
                        <ej:MenuItem Text="DESIGN EXPERIENCE"></ej:MenuItem>
                    </Items>
                    <Items>
                        <ej:MenuItem Text="LICENSED RECIPES"></ej:MenuItem>
                    </Items>
                    <Items>
                        <ej:MenuItem Text="RECIPE DESIGNER"></ej:MenuItem>
                    </Items>
                </ej:MenuItem>
                <ej:MenuItem Id="Resources" Text="SCALE">
                    <Items>
                        <ej:MenuItem Text="PROJECT MANAGEMENT">
                        </ej:MenuItem>
                    </Items>
                    <Items>
                        <ej:MenuItem Text="CONTRACT BREWING"></ej:MenuItem>
                    </Items>
                    <Items>
                        <ej:MenuItem Text="KNOW HOW"></ej:MenuItem>
                    </Items>
                </ej:MenuItem>
                <ej:MenuItem Id="Company" Text="INVEST">
                    <Items>
                        <ej:MenuItem Text="INVEST IN BRIGHTBEER"></ej:MenuItem>
                    </Items>
                    <Items>
                        <ej:MenuItem Text="FOUNDER"></ej:MenuItem>
                    </Items>
                    <Items>
                        <ej:MenuItem Text="ABOUT BRIGHTBEER"></ej:MenuItem>
                    </Items>
                </ej:MenuItem>
            </Items>
        </ej:Menu>


    <style>
        body{
            background: gray;
        }

        /*change border based on requirements*/
        .e-menu {
            border: none;
        }

        /*root level menu*/
        ul.e-menu > li.e-list {
            width: 178px;
            text-align: center !important;

        }

        /*second level menu*/
        ul.e-menu > li.e-list > ul > li {
            text-align:left !important;
        }

        .e-menu .e-list>.e-menulink {
            /*second level items left padding*/
            padding-left: 16px;
            /*second level items right padding*/
            padding-right: 16px;
        }

        /*responsive mode hamburger*/
        .e-menu-res-wrap .e-menu-res-in-wrap .e-check-wrap{
            color: #ffffff;
        }

        /*responsive mode menu width*/
        @media (max-width : 767px) {
            ul.e-menu > li.e-list {
                width: 100%;
            }
        }

    </style>

        </div>
    </form>

</body>
</html>
