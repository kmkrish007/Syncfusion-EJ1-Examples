<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
            <div class="col-md-3 form-group">
            <ej:ListBox ID="ListBox1" runat="server" AllowDragAndDrop="True" AllowDrag="true" AllowDrop="true" OnItemDrop="ListBox1_ItemDrop">
                <Items>
                    <ej:ListBoxItems Text="First" />
                    <ej:ListBoxItems Text="Second" />
                    <ej:ListBoxItems Text="Third" />
                </Items>
            </ej:ListBox>
        </div>
        <div class="col-md-3 form-group">
            <ej:ListBox ID="ListBox2" runat="server" AllowDragAndDrop="True" AllowDrag="true" AllowDrop="true" OnItemDrop="ListBox2_ItemDrop">
                <Items>
                    <ej:ListBoxItems Text="Fourth" />
                    <ej:ListBoxItems Text="Fifth" />
                    <ej:ListBoxItems Text="Sixth" />
                </Items>
            </ej:ListBox>
        </div>
        </div>

    <div class="row">
        <div class="col-md-3 form-group">
            <ej:listbox id="listBoxSample" runat="server" DataTextField="Name" DataValueField="Name"  Width="240" AllowDragAndDrop="true" OnItemDrop="listBoxSample_ItemDrop"></ej:listbox>
        </div>
        <div class="col-md-3 form-group">
            <ej:listbox id="listBox3" runat="server" DataTextField="Name" DataValueField="Name"  Width="240" AllowDragAndDrop="true" OnItemDrop="listBox3_ItemDrop"></ej:listbox>
        </div>
    </div>

    <div style="display: table">
        <div style="float: left">
            <span class="treeCaption">TREEVIEW - 1</span>
            <ej:TreeView ID="treeview" runat="server" Height="100%" Width="250px" AllowDragAndDrop="true" 
                         AllowDropChild="true" AllowDropSibling="true" AllowDragAndDropAcrossControl="true" OnNodeDropped="treeview_NodeDropped">
                <Nodes>
                    <ej:TreeViewNode Expanded="True" Text="Artwork">
                        <Nodes>
                            <ej:TreeViewNode Text="Abstract">
                                <Nodes>
                                    <ej:TreeViewNode Text="2 Acrylic Mediums"></ej:TreeViewNode>
                                    <ej:TreeViewNode Text="Creative Acrylic"></ej:TreeViewNode>
                                    <ej:TreeViewNode Text="Modern Painting"></ej:TreeViewNode>
                                    <ej:TreeViewNode Text="Canvas Art"></ej:TreeViewNode>
                                    <ej:TreeViewNode Text="Black white"></ej:TreeViewNode>
                                </Nodes>
                            </ej:TreeViewNode>
                            <ej:TreeViewNode Text="Children">
                                <Nodes>
                                    <ej:TreeViewNode Text="Preschool Crafts"></ej:TreeViewNode>
                                    <ej:TreeViewNode Text="School-age Crafts"></ej:TreeViewNode>
                                    <ej:TreeViewNode Text="Fabulous Toddler"></ej:TreeViewNode>
                                </Nodes>
                            </ej:TreeViewNode>
                            <ej:TreeViewNode Text="Comic / Cartoon">
                                <Nodes>
                                    <ej:TreeViewNode Text="Batman"></ej:TreeViewNode>
                                    <ej:TreeViewNode Text="Adventures of Superman"></ej:TreeViewNode>
                                    <ej:TreeViewNode Text="Super boy"></ej:TreeViewNode>
                                </Nodes>
                            </ej:TreeViewNode>
                        </Nodes>
                    </ej:TreeViewNode>
                    <ej:TreeViewNode Expanded="True" Text="Books">
                        <Nodes>
                            <ej:TreeViewNode Text="Comics">
                                <Nodes>
                                    <ej:TreeViewNode Text="The Flash"></ej:TreeViewNode>
                                    <ej:TreeViewNode Text="Human Target"></ej:TreeViewNode>
                                    <ej:TreeViewNode Text="Birds of Prey"></ej:TreeViewNode>
                                    <ej:TreeViewNode Text="Canvas Art"></ej:TreeViewNode>
                                    <ej:TreeViewNode Text="Black white"></ej:TreeViewNode>
                                </Nodes>
                            </ej:TreeViewNode>
                            <ej:TreeViewNode Text="Entertaining"></ej:TreeViewNode>
                            <ej:TreeViewNode Text="Design"></ej:TreeViewNode>
                        </Nodes>
                    </ej:TreeViewNode>
                    <ej:TreeViewNode Text="Music">
                        <Nodes>
                            <ej:TreeViewNode Text="Classical">
                                <Nodes>
                                    <ej:TreeViewNode Text="Avant-Garde"></ej:TreeViewNode>
                                    <ej:TreeViewNode Text="Medieval"></ej:TreeViewNode>
                                    <ej:TreeViewNode Text="Orchestral"></ej:TreeViewNode>
                                </Nodes>
                            </ej:TreeViewNode>
                            <ej:TreeViewNode Text="Mass"></ej:TreeViewNode>
                            <ej:TreeViewNode Text="Folk"></ej:TreeViewNode>
                        </Nodes>
                    </ej:TreeViewNode>
                </Nodes>
            </ej:TreeView>
        </div>
        <div style="float: left">
            <span class="treeCaption">TREEVIEW - 2</span>
            <ej:TreeView ID="treeview2" runat="server" Height="100%" Width="250px" AllowDragAndDrop="true" AllowDropChild="true" 
                         AllowDropSibling="true" AllowDragAndDropAcrossControl="true" OnNodeDropped="treeview2_NodeDropped">
                <Nodes>
                    <ej:TreeViewNode Expanded="True" Text="Artwork">
                        <Nodes>
                            <ej:TreeViewNode Text="Abstract">
                                <Nodes>
                                    <ej:TreeViewNode Text="2 Acrylic Mediums"></ej:TreeViewNode>
                                    <ej:TreeViewNode Text="Creative Acrylic"></ej:TreeViewNode>
                                    <ej:TreeViewNode Text="Modern Painting"></ej:TreeViewNode>
                                    <ej:TreeViewNode Text="Canvas Art"></ej:TreeViewNode>
                                    <ej:TreeViewNode Text="Black white"></ej:TreeViewNode>
                                </Nodes>
                            </ej:TreeViewNode>
                            <ej:TreeViewNode Text="Children">
                                <Nodes>
                                    <ej:TreeViewNode Text="Preschool Crafts"></ej:TreeViewNode>
                                    <ej:TreeViewNode Text="School-age Crafts"></ej:TreeViewNode>
                                    <ej:TreeViewNode Text="Fabulous Toddler"></ej:TreeViewNode>
                                </Nodes>
                            </ej:TreeViewNode>
                            <ej:TreeViewNode Text="Comic / Cartoon">
                                <Nodes>
                                    <ej:TreeViewNode Text="Batman"></ej:TreeViewNode>
                                    <ej:TreeViewNode Text="Adventures of Superman"></ej:TreeViewNode>
                                    <ej:TreeViewNode Text="Super boy"></ej:TreeViewNode>
                                </Nodes>
                            </ej:TreeViewNode>
                        </Nodes>
                    </ej:TreeViewNode>
                    <ej:TreeViewNode Expanded="True" Text="Books">
                        <Nodes>
                            <ej:TreeViewNode Text="Comics">
                                <Nodes>
                                    <ej:TreeViewNode Text="The Flash"></ej:TreeViewNode>
                                    <ej:TreeViewNode Text="Human Target"></ej:TreeViewNode>
                                    <ej:TreeViewNode Text="Birds of Prey"></ej:TreeViewNode>
                                    <ej:TreeViewNode Text="Canvas Art"></ej:TreeViewNode>
                                    <ej:TreeViewNode Text="Black white"></ej:TreeViewNode>
                                </Nodes>
                            </ej:TreeViewNode>
                            <ej:TreeViewNode Text="Entertaining"></ej:TreeViewNode>
                            <ej:TreeViewNode Text="Design"></ej:TreeViewNode>
                        </Nodes>
                    </ej:TreeViewNode>
                    <ej:TreeViewNode Text="Music">
                        <Nodes>
                            <ej:TreeViewNode Text="Classical">
                                <Nodes>
                                    <ej:TreeViewNode Text="Avant-Garde"></ej:TreeViewNode>
                                    <ej:TreeViewNode Text="Medieval"></ej:TreeViewNode>
                                    <ej:TreeViewNode Text="Orchestral"></ej:TreeViewNode>
                                </Nodes>
                            </ej:TreeViewNode>
                            <ej:TreeViewNode Text="Mass"></ej:TreeViewNode>
                            <ej:TreeViewNode Text="Folk"></ej:TreeViewNode>
                        </Nodes>
                    </ej:TreeViewNode>
                </Nodes>
            </ej:TreeView>
        </div>
    </div>

</asp:Content>
