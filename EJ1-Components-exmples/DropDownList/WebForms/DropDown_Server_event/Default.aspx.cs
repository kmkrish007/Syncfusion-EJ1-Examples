using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DropDown_Event
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void dropdownlist_ValueSelect(object sender, Syncfusion.JavaScript.Web.DropdownListEventArgs e)
        {


            //e.EventType – Event Name

            //e.Arguments – Contain keys and values for IsChecked,Text,Value,SelectedText and ItemId

            //e.Text; //– Text value of selected node

            //e.Value – Value of selected node

            string text = e.SelectedText.ToString(); //– Text  of selected node

            System.Diagnostics.Debug.WriteLine(text);

            //e.ItemId – Index value of selected node

        }

        protected void dropdownlist_CheckedChange(object sender, Syncfusion.JavaScript.Web.DropdownListEventArgs e)
        {
            bool a = e.IsChecked; //– Status of Checkbox
            System.Diagnostics.Debug.WriteLine(a);
        }

        protected void dropdownlist_Cascade(object sender, Syncfusion.JavaScript.Web.DropdownListEventArgs e)
        {
            //e.CascadeValue - Get the cascaded DropDownList value
        }

        protected void dropdownlist_Search(object sender, Syncfusion.JavaScript.Web.DropdownListEventArgs e)
        {
            string txt = e.SearchString;
            // e.SearchString - Entered search string in textbox
            // e.SearchedListItems - Get the list of items searched
        }

        protected void list_Check(object sender, Syncfusion.JavaScript.Web.ListBoxEventArgs e)
        {
            bool chk = e.IsChecked;
        }

        protected void list_select(object sender, Syncfusion.JavaScript.Web.ListBoxEventArgs e)
        {
            string tt = e.Text;
        }

        protected void tree_check(object sender, Syncfusion.JavaScript.Web.TreeViewEventArgs e)
        {
            bool chk = e.Checked;
        }

        protected void tree_select(object sender, Syncfusion.JavaScript.Web.TreeViewEventArgs e)
        {
            string tt = e.NodeText;
        }
    }
}