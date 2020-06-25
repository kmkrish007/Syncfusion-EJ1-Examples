<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ComboBox._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <ej:ComboBox ID="Combo" runat="server" DataTextField="type"></ej:ComboBox>
    <%--<ej:Button ID="button" Text="Open Dialog" Type="Button" ClientSideOnClick="openDialog" runat="server"></ej:Button>

    <ej:Dialog ID="dialog" Title="Dialog" runat="server" EnableModal="true" ShowOnInit="false">

        <DialogContent>
             <p>This is a simple dialog</p>
             Giving to<br />
            <div style="height:35px;">
                <ej:ComboBox ID="givingTo" runat="server" AllowFiltering="true" AutoFill="true" Placeholder="Give To" DataTextField="Text" Width="100%">
                </ej:ComboBox>
            </div>
                  
            Type<br />

            <ej:ComboBox ID="type1" runat="server" Placeholder="Type" DataTextField="type" AutoFill="true" Width="100%" ActionFailureTemplate="The Request Failed" CssClass="" DataSourceCachingMode="None" Locale="en-US" NoRecordsTemplate="No Records Found" SortOrder="None">
            </ej:ComboBox>
            <div class="custom"></div>
            <div class="more">
                <ej:Button ID="add" CssClass="add" Text="Add More?" Type="Button" ClientSideOnClick="addCombo" runat="server"></ej:Button>
            </div>
           
            <br />
              Description (<span id="chars">120</span> Characters Remaining)
            <br />
 
              <textarea name="Description" runat="server" ID="smelly01" style="width: 100%; height: auto;" maxlength="100" placeholder="Enter Here" data-hint=""></textarea> 
         
              <br /><br />
            <ej:Button runat="server" ID="sub2HR" Text="Submit for HR Review"></ej:Button>  
        </DialogContent>

    </ej:Dialog>--%>


    <script type="text/javascript">
        //function openDialog() {
        //    $("#MainContent_dialog").ejDialog("open");
        //}
        //var i = 3;
        //var sportsData = [
        //    { id: 'level1', game: 'American Football' }, { id: 'level2', game: 'Badminton' },
        //    { id: 'level3', game: 'Basketball' }, { id: 'level4', game: 'Cricket' },
        //    { id: 'level5', game: 'Football' }, { id: 'level6', game: 'Golf' },
        //    { id: 'level7', game: 'Hockey' }, { id: 'level8', game: 'Rugby' },
        //    { id: 'level9', game: 'Snooker' }, { id: 'level10', game: 'Tennis' }
        //];
        //function addCombo() {
        //    // create input element
        //    ele = document.createElement('input');
        //    // adding id attribute
        //    ele.setAttribute("id", "Combo" + i);
        //    cus = document.querySelector(".custom");
        //    // append to already created div element
        //    cus.appendChild(ele)
        //    // render input as combobox
        //    $("#Combo" + i).ejComboBox({
        //        dataSource: sportsData,
        //        fields: { text: 'game', value: 'id' },
        //        width: "100%",
        //        cssClass: 'combo' 
        //    });
        //    i++;
        //}
    </script>

    <style type="text/css">
        .more{
            display: flex;
            justify-content: flex-end;
        }
        .add.e-button {
            border: none;
            color: red;
            background: white;
        }
        .combo {
            margin-top: 10px;
        }
    </style>
</asp:Content>
