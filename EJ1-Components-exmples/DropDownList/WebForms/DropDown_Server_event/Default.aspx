<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DropDown_Event._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <div>
            <ej:DropDownList ID="DropDownList1" runat="server" OnCheckedChange="dropdownlist_CheckedChange" OnValueSelect="dropdownlist_ValueSelect" ShowCheckbox="true" EnableFilterSearch="true" OnCascade="dropdownlist_Cascade" OnSearch="dropdownlist_Search" >
            <Items>
                <ej:DropDownListItem ID="DropDownListItem1" runat="server" Text="ListItem 1" Value="item1">
                </ej:DropDownListItem>
                <ej:DropDownListItem ID="DropDownListItem2" runat="server" Text="ListItem 2" Value="item2">
                </ej:DropDownListItem>
                <ej:DropDownListItem ID="DropDownListItem3" runat="server" Text="ListItem 3" Value="item3">
                </ej:DropDownListItem>
                <ej:DropDownListItem ID="DropDownListItem4" runat="server" Text="ListItem 4" Value="item4">
                </ej:DropDownListItem>
                <ej:DropDownListItem ID="DropDownListItem5" runat="server" Text="ListItem 5" Value="item5">
                </ej:DropDownListItem>
            </Items>
        </ej:DropDownList>
        <br />
        <asp:Label runat="server" ID="Label1"></asp:Label>


        </div>

    <ej:ListBox ID="ListBox" runat="server" OnValueSelect="list_select" OnCheckChange="list_Check" ShowCheckbox="true" ClientSideOnCheckChange="check" ClientSideOnSelect="select">
        <Items>
            <ej:ListBoxItems Text="Audi A4"></ej:ListBoxItems>
            <ej:ListBoxItems Text="Audi A5"></ej:ListBoxItems>
            <ej:ListBoxItems Text="Audi A6"></ej:ListBoxItems>
            <ej:ListBoxItems Text="Audi A7"></ej:ListBoxItems>
            <ej:ListBoxItems Text="Audi A8"></ej:ListBoxItems>
            <ej:ListBoxItems Text="BMW 501"></ej:ListBoxItems>
            <ej:ListBoxItems Text="BMW 502"></ej:ListBoxItems>
            <ej:ListBoxItems Text="BMW 503"></ej:ListBoxItems>
            <ej:ListBoxItems Text="Batch"></ej:ListBoxItems>
            <ej:ListBoxItems Text="BMW 507"></ej:ListBoxItems>
        </Items>
    </ej:ListBox>

    <ej:TreeView ID="treeview" runat="server" Width="400px" ShowCheckbox="true" OnNodeChecked="tree_check" OnNodeSelected="tree_select" ClientSideOnNodeSelected="select" ClientSideOnNodeChecked="check" >
            <Nodes>
                <ej:TreeViewNode Expanded="True" Text="Item 1">
                    <Nodes>
                        <ej:TreeViewNode Text="Item 1.1">
                            <Nodes>
                                <ej:TreeViewNode Text="Item 1.1.1"></ej:TreeViewNode>
                                <ej:TreeViewNode Text="Item 1.1.2"></ej:TreeViewNode>
                            </Nodes>
                        </ej:TreeViewNode>
                        <ej:TreeViewNode Text="Item 1.2">
                        </ej:TreeViewNode>
                    </Nodes>
                </ej:TreeViewNode>
    
                <ej:TreeViewNode Text="Item 2"></ej:TreeViewNode>
    
                <ej:TreeViewNode Text="Item 3"></ej:TreeViewNode>
            </Nodes>
        </ej:TreeView>

    <script type="text/javascript">
        function select() {
            console.log("select event");
        }

        function check() {
            console.log("checked event");
        }
    </script>
</asp:Content>
