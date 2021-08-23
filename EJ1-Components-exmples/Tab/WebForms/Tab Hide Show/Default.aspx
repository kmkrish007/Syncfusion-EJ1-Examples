<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<%@ Register TagPrefix="ej" Namespace="Syncfusion.JavaScript.Web" Assembly="Syncfusion.EJ.Web" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <ej:Button runat="server" Type="Button" ClientSideOnClick="hideTab" Text="HideTab"></ej:Button>
    <ej:Button runat="server" Type="Button" ClientSideOnClick="showTab" Text="Show Tab"></ej:Button>
<ej:Tab ID="Tab" runat="server">
        <Items>
            <ej:TabItem ID="steelman" Text="Man Of Steel">
                <ContentSection>
                    <div class="row">
                            <div class="col-xs-10 col-sm-4 col-md-6">
                                <div>
                                    <span class="movie-header">Man of Steel</span><br />
                                    <span>Movie Info:</span>
                                    <p>
                                        A young boy learns that he has extraordinary powers and is not of this Earth.
                                    </p>
                                </div>
                            </div>
                        </div>
                </ContentSection>
            </ej:TabItem>
            <ej:TabItem ID="woldwar" Text="World War Z">
                <ContentSection>
                    <div class="row">
                            <div class="col-xs-10 col-sm-4 col-md-6">
                                <div>
                                    <span class="movie-header">World War Z</span><br />
                                    <br />
                                    <span>Movie Info:</span>
                                    <p>
                                        The story revolves around United Nations employee Gerry Lane (Pitt).
                                    </p>
                               </div>
                            </div>
                        </div>
                </ContentSection>
            </ej:TabItem>
            <ej:TabItem ID="university" Text="Monsters University">
                <ContentSection>
                     <div class="row">
                            <div class="col-xs-10 col-sm-4 col-md-6">
                                <div>
                                    <span class="movie-header">Monsters University</span><br />
                                    <br />
                                    <span>Movie Info:</span>
                                    <p>
                                        Mike Wazowski and James P. Sullivan are an inseparable pair, but that wasn't always
                                    the case.
                                    </p>
                              </div>
                            </div>
                        </div>
                </ContentSection>
            </ej:TabItem>
        </Items>
    </ej:Tab>

    <script>
        function hideTab(args) {
            var TabObj = $("#<%= Tab.ClientID %>").ejTab("instance");
            TabObj.setModel({ hiddenItemIndex: [1] });
        }

        function showTab(args) {
            var TabObj = $("#<%= Tab.ClientID %>").ejTab("instance");
            TabObj.setModel({ hiddenItemIndex: [] });
        }
    </script>
</asp:Content>
