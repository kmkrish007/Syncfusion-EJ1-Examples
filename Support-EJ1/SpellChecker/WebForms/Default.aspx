<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <div class="content-container-fluid">
        <div class="row">
            <div>
                <div id="TextArea" contenteditable="true">
                    Facebook is annnn social networking servicehfbhu headquartered in Menlo Park, California. Its website was launched on February 4, 2004, by Mark Zuckerberg with his Harvard College roommates and fellow students Eduardo, Andrew McCollum, Dustin and Chris Hughes.
                    The fouders had initially limited the websites membrship to Harvard students, but later expanded it to collges in the Boston area, the Ivy League, and Stanford Univrsity. It graually added support for students at various other universities and later to high-school students.
                </div>
                <div>
                    <ej:Button ID="btn_Default" Type="Button" ClientSideOnClick="showInDialog" Text="Spell check using dialog" runat="server"></ej:Button>
                </div>
            </div>
        </div>
    </div>
    <ej:SpellCheck ID="SpellCheck" ClientIDMode="Static" runat="server" AjaxDataType="json" ActionBegin="onActionBegin" AjaxRequestType="POST"  ControlsToValidate="#TextArea">
        <DictionarySettings DictionaryUrl="/Default.aspx/CheckWords" CustomDictionaryUrl="/Default.aspx/AddToDictionary" />
    </ej:SpellCheck>  


    <script type="text/javascript">
        function showInDialog() {
            var spellObj = $("#SpellCheck").data("ejSpellCheck");
            spellObj.showInDialog();
        }
        function onActionBegin(e){
            e.webMethod = true;
        }
    </script>
    <style>
        #TextArea{
            padding-bottom:15px;
        }
        .fixedlayout.office-365 #SpellCheck{
            width:193px !important;
        }
    </style>

</asp:Content>
