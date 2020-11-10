<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApplication1VB._Default" %>

<%@ Register assembly="Syncfusion.EJ.Web" namespace="Syncfusion.JavaScript.Web" tagprefix="ej" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

  <div class="frame">
        <div class="row">
             <div class="col-xs-8 col-sm-4">
                <span class="txt">Select Group</span>
                    <ej:DropDownList ID="ddlgroupsList" runat="server" DataTextField="text" DataValueField="parentId" CascadeTo="MainContent_ddlcountryList"></ej:DropDownList>
                </div>
              <div class="col-xs-8 col-sm-4">
                   <span class="txt">Select Country</span>
                      <ej:DropDownList ID="ddlcountryList" runat="server"></ej:DropDownList>
               </div>
           </div>
        </div>
   

    <style type="text/css">
        .frame {
            height: 100px;
            width: 50%;
        }

        .txt {
            display: block;
            margin-bottom: 12px;
        }
    </style>

</asp:Content>
