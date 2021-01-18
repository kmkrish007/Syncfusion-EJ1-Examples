using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        public int TriggerId { get; set; }
        public int TriggerQuestionId { get; set; }
        public string content { get; set; }
        public string title { get; set; }


        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
            }
        }

        protected void lnkSave_Click(object sender, EventArgs e)
        {
        }
        protected void lnkCancel_Click(object sender, EventArgs e)
        {
        }
        protected void lnkReset_Click(object sender, EventArgs e)
        {
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Triggers.aspx");
        }



        protected void InitializeDialogBox(string content, string title, int triggerId)
        {
            Syncfusion.JavaScript.Web.Dialog test1 = new Syncfusion.JavaScript.Web.Dialog();
            test1.ShowOnInit = true;
            test1.IsResponsive = true;
            test1.Title = content;
            test1.ID = "TriggerSave_" + DateTime.Now.ToString("hhmmss");
            test1.ContentUrl = "Triggers.aspx?TriggerId=" + triggerId;
            test1.ContentType = "iframe";
            test1.ClientSideOnCreate = "Oncreate";
        }

        #region TriggerLogic

        protected void lnkAddNewTrigger_Click(object sender, EventArgs e)
        {
            Response.Redirect("Triggers.aspx?TriggerId=0");
        }
        public string triggerSpan = "<span class='serverEvent' style='display: inline-block;'>Grid <span class='eventTitle'>";


        #endregion

        protected void lnkAddTrigger_Click(object sender, EventArgs e)
        {

            lblTriggerEditStatus.Text = "";

            if (txtName.Value == null)
            {
                lblTriggerEditStatus.Text += "Missing name. ";
            }

            if (txtQuery.Value == "")
            {
                lblTriggerEditStatus.Text += "Missing query. ";
            }

            if (txtDescription.Value == null)
            {
                lblTriggerEditStatus.Text += "Missing description. ";
            }

            if (!rdoHigh.Checked && !rdoLow.Checked && !rdoMedium.Checked)
            {
                lblTriggerEditStatus.Text += "Missing priority. ";
            }

            if (txtSortOrder.Value == "")
            {
                lblTriggerEditStatus.Text += "Missing sort order. ";
            }

        }

        protected void lnkSaveTrigger_Click(object sender, EventArgs e)  //updating a trigger
        {
            //int rtn = -1;
            //ADTTriggers adtTr = new ADTTriggers();

            if (chxActive.Checked)
            {
                //adtTr.active = true;
            }
            else
            {
                //adtTr.active = false;
            }
            ClientScript.RegisterStartupScript(this.GetType(), "updateProgress", "updateProgress('" + chxActive.Checked + "');", true);

        }

        protected void lnkCancelTrigger_Click(object sender, EventArgs e)
        {
            Response.Redirect("Triggers.aspx");
        }
    }
}