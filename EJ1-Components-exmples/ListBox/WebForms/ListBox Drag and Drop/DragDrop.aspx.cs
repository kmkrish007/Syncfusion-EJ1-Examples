using System;

namespace WebApplication1
{
    public partial class DragDrop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ListBox1_ItemDrop(object sender, Syncfusion.JavaScript.Web.ListBoxEventArgs e)
        {
            Response.Redirect("http://www.google.com");
        }

        protected void ListBox2_ItemDrop(object sender, Syncfusion.JavaScript.Web.ListBoxEventArgs e)
        {
            Response.Redirect("http://www.google.com");
        }
    }
}