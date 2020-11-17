<%@ Page Language="C#" MasterPageFile="~/Site.Master" Title="Menu" AutoEventWireup="true" CodeBehind="MenuFeatures.aspx.cs" Inherits="MenuSqlSample.MenuFeatures" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h2>Menu Features:</h2>
<br />
<li> Menu Types - Center Menu</li>
<li> RTL</li>
<li> Theme - Flat-Azure</li>
<br/>
<div>
<div id = "ControlRegion">
          <ej:Menu ID="JobSearch" runat="server" EnableCenterAlign="true" SubMenuDirection="left" EnableRTL="true">
        <Items>
            <ej:MenuItem Id="Home" Text="Home"></ej:MenuItem>
            <ej:MenuItem Text="Search Jobs">
                <Items>
                    <ej:MenuItem Text="Advanced Search"></ej:MenuItem>
                    <ej:MenuItem Text="Jobs by Company"></ej:MenuItem>
                    <ej:MenuItem Text="Jobs by Category"></ej:MenuItem>
                    <ej:MenuItem Text="Jobs by Location"></ej:MenuItem>
                    <ej:MenuItem Text="Jobs by Skills"></ej:MenuItem>
                    <ej:MenuItem Text="Jobs by Designation"></ej:MenuItem>
                </Items>
            </ej:MenuItem>
            <ej:MenuItem Id="PostResume" Text="Post Resume"></ej:MenuItem>
            <ej:MenuItem Id="JobSeeker" Text="JobSeeker Login"></ej:MenuItem>
            <ej:MenuItem Id="FastForward" Text="Fast Forward">
                <Items>
                    <ej:MenuItem Text="Resume writing"></ej:MenuItem>
                    <ej:MenuItem Text="Certification"></ej:MenuItem>
                    <ej:MenuItem Text="Resume Spotlight"></ej:MenuItem>
                    <ej:MenuItem Text="Jobs4u"></ej:MenuItem>
                </Items>
            </ej:MenuItem>
            <ej:MenuItem Id="More" Text="More">
                <Items>
                    <ej:MenuItem Text="Mobile"></ej:MenuItem>
                    <ej:MenuItem Text="Pay check"></ej:MenuItem>
                    <ej:MenuItem Text="Blog"></ej:MenuItem>
                </Items>
            </ej:MenuItem>
        </Items>
    </ej:Menu>
</div>
</div>
</asp:Content>
