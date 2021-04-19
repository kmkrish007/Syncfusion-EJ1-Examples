<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="frame">
        <div class="control">
            <ej:DropDownList ID="selectFolder" runat="server" WatermarkText="Select any value" Width="100%" ClientSideOnCreate="dropdownOnCreate">
                <Items>
                    <ej:DropDownListItem>
                        <ContentTemplate>
                            <ej:TreeView ID="Treeview" runat="server" DataTextField="Text" DataIdField="ID" DataParentIdField="ParentID" 
                                DataHasChildField="HasChild" ShowCheckbox="true">
                            </ej:TreeView>
                        </ContentTemplate>
                    </ej:DropDownListItem>
                </Items>
            </ej:DropDownList>
        </div>
    </div>

    <ej:TreeView 
            ID="Treeview1" 
            runat="server" 
            DataTextField="Text" 
            DataIdField="Id" 
        ShowCheckbox="true" 
            DataParentIdField="Parent" 
            DataExpandedField="Expanded">
        </ej:TreeView>

    <ej:Button ID="TreeCheck" runat="server" OnClick="TreeCheck_Click" Text="GetCheckedNodes"></ej:Button>

<script type="text/javascript">

    ej.DropDownList.prototype._OnMouseClick = function (e) { }
          ej.DropDownList.prototype._OnMouseEnter = function (e) { }
          ej.DropDownList.prototype._OnMouseLeave = function (e) { }
          ej.DropDownList.prototype._OnKeyUp = function (e) { }
          ej.DropDownList.prototype._OnKeyDown = function (e) { }

    function dropdownOnCreate(args) {
        drpdwnobj = this;
    }
    function treeViewOnCreate(args) {
        treeobj = this;
    }
// check & uncheck the checkbox when click on text
$(function () {
    $("body").on("click", ".e-treeview ul li a.e-text", function (e) {
        if (!$(e.target).siblings(".e-chkbox-wrap").children("input.nodecheckbox")[0].checked)
            treeobj.checkNode($(e.target).closest("li"));
        else
            treeobj.uncheckNode($(e.target).closest("li"));
    });
});

//Function triggers while check the checkbox in tree view and it adds the checked item text to dropdownlist value
function checkScroll(args) {
    var scrolpos = drpdwnobj.scrollerObj.model.scrollTop;
    drpdwnobj._refreshScroller();
    drpdwnobj.popupList.css("display", "block");
    drpdwnobj.scrollerObj.setModel({ "scrollTop": scrolpos });
}

function onNodeCheck(args) {
    if (args.currentCheckedNodes != null) {
        var checkeditems = args.currentCheckedNodes;
        for (var i = 0; i < checkeditems.length; i++) {
            if ((checkeditems[i] != null) && !isContains(checkeditems[i].text))
                addOrRemoveItem(checkeditems[i].text, true);
        }
    }
}
//Function triggers while uncheck the checkbox in tree view and it removes the unchecked item text from dropdownlist value
function onNodeUnCheck(args) {
    if (args.currentUncheckedNodes != null) {
        var uncheckeditems = args.currentUncheckedNodes;
        for (var i = 0; i < uncheckeditems.length; i++) {
            if (uncheckeditems[i] != null && isContains(uncheckeditems[i].text))
                addOrRemoveItem(uncheckeditems[i].text);
        }
    }
    ensureRootCheck(args);
}

function ensureRootCheck(args) {
    var rootEle = $(args.currentElement).parents("ul.e-treeview-ul");
    for (var i = 0; i < rootEle.length; i++) {
        if ($(rootEle[i]).parent("li").length) {
            if (isContains($(rootEle[i]).siblings("[role=presentation]").text()))
                addOrRemoveItem($(rootEle[i]).siblings("[role=presentation]").text());
        }
    }
}

function addOrRemoveItem(currentValue, isAdd) {
    drpdwnobj._hiddenValue = currentValue;
    isAdd ? drpdwnobj._addText(currentValue) : removeText(currentValue);
    drpdwnobj.model.value = drpdwnobj.model.text = drpdwnobj.element.val();
}

function removeText(currentValue) {
    var eleVal = drpdwnobj.element[0].value.split(drpdwnobj.model.delimiterChar), hidVal = drpdwnobj._visibleInput[0].value.split(drpdwnobj.model.delimiterChar),
        index = $.inArray(currentValue, eleVal);
    if (index >= 0) {
        eleVal.splice(index, 1);
        hidVal.splice(index, 1);
        drpdwnobj._valueContainer.splice(index, 1);
        drpdwnobj._textContainer.splice(index, 1);
    }
    drpdwnobj.element[0].value = eleVal.join(drpdwnobj.model.delimiterChar);
    drpdwnobj._visibleInput[0].value = hidVal.join(drpdwnobj.model.delimiterChar);
}
function isContains(val) {
    var data = drpdwnobj.getValue().split(","), matched;
    for (k = 0; k < data.length; k++) {
        if (data[k] == val) {
            matched = 1;
            break;
        }
    }
    return matched;
}

</script>

    <style type="text/css">
        .desig {
            font-weight: normal;
            padding-left: 5px;
        }

        .cont {
            font-size: 10px;
            font-weight: normal;
            padding-left: 5px;
        }

        .eimg {
            margin: 0;
            padding: 2px;
            float: left;
            border: 0 none;
            width: 50px;
            height: 50px;
        }

        .ename {
            padding-left: 5px;
            font-weight: bold;
        }
        .e-treeview > ul {
            margin-left: 0 !important;
        }

        .e-ddl-popup div > ul li .e-chkbox-wrap {
            padding-right: 2px;
        }

        .e-ddl-popup div > ul .e-ghead {
            display: none !important;
        }

        .frame {
            width: 30%;
        }
    </style>
</asp:Content>
