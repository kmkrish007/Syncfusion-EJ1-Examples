using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Services;
using System.Web.Services;
using Syncfusion.EJ.Export;
using Syncfusion.JavaScript;
using Syncfusion.JavaScript.DataSources;
using Syncfusion.JavaScript.Models;
using Syncfusion.JavaScript.Web;
using Syncfusion.Linq;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.XlsIO;
using System.Collections;
using System.Drawing;

namespace WebApplication1
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        public string updateAction = "U";
        public string addAction = "A";

        private string ExportFileName = "SMS_MasterDepartment_Report";
        private string ReportTitle = "Report: Master Department";
        private const string SKEY_PAGES = "_SMSFORMLIST";

        public static List<Orders> order = new List<Orders>();
        public static List<Orders> order2 = new List<Orders>();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (order.Count == 0)
            {
                BindDataSource();
            }
            var data = order;
            this.gvDepartment.DataSource = data;
            this.gvDepartment.DataBind();
            if (!IsPostBack)
            {
                int i = 0;
                foreach (Orders obj in data)
                {
                    if (i == 0)
                    {
                        txtDepartmentID.Text = obj.OrderID.ToString();
                        txtDepartmentName.Text = obj.CustomerID;

                        i++;
                    }
                }
                gvDepartment.SelectedRowIndex = 0;
                btnSave.Visible = false;
                btnCancel.Visible = false;
            }



        }
        protected void gvDepartment_ServerExcelExporting(object sender, Syncfusion.JavaScript.Web.GridEventArgs e)
        {
            try
            {
                ExcelExport exp = new ExcelExport();
                IWorkbook book = exp.Export(gvDepartment.Model, (IEnumerable)gvDepartment.DataSource, ExportFileName + ".xlsx", ExcelVersion.Excel2010, false, false, "flat-lime", true);

                //Creating a new style with cell back color, fill pattern and font attribute
                Syncfusion.XlsIO.IStyle headerStyle = book.Styles.Add("NewStyle");
                headerStyle.Font.Bold = true;
                headerStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;//set text alignment
                headerStyle.Color = Color.FromArgb(229, 255, 204);
                headerStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                headerStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                headerStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                headerStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;

                // Inserted new row for adding title
                book.ActiveSheet.InsertRow(1);

                // Merging the sheet from Range A1 to D1 for adding title space
                book.ActiveSheet.Range["A1:D1"].Merge();
                book.ActiveSheet.Range["E1:H1"].Merge();

                //Adding the title using Text property
                book.ActiveSheet.Range["A1"].Text = ReportTitle;
                book.ActiveSheet.Range["A1"].CellStyle = headerStyle;

                book.ActiveSheet.Range["E1"].Value = "Report Generated Date: " + DateTime.Now.ToString("dd-MMM-yyyy hh:mm tt");
                book.ActiveSheet.Range["E1"].CellStyle = headerStyle;

                book.ActiveSheet.Name = "Master Dept";

                //Adding footer using SetValue method
                book.SaveAs(ExportFileName + ".xlsx", ExcelSaveType.SaveAsXLS, System.Web.HttpContext.Current.Response, ExcelDownloadType.Open);
            }
            catch (Exception ex)
            {
                // CU.LogError(ex);
            }
        }

        protected void gvDepartment_ServerPdfExporting(object sender, Syncfusion.JavaScript.Web.GridEventArgs e)
        {
            try
            {
                PdfExport exp = new PdfExport();
                for (var i = 0; i < this.gvDepartment.Columns.Count(); i++)
                {
                    if (this.gvDepartment.Columns[i].HeaderText == "Action") // use the template column HeaderText here. 
                    {
                        gvDepartment.Model.Columns.RemoveAt(i); // remove the respective column 
                        i--;

                    }
                }
                PdfDocument doc = new PdfDocument();
                doc.PageSettings.Orientation = PdfPageOrientation.Landscape;
                doc.PageSettings.Size = PdfPageSize.A4;
                doc.PageSettings.Width = 750;

                RectangleF rect = new RectangleF(0, 0, doc.PageSettings.Width, 15);
                //create a header pager template
                PdfPageTemplateElement header = new PdfPageTemplateElement(rect);

                //create a footer pager template
                PdfPageTemplateElement footer = new PdfPageTemplateElement(rect);

                //Font f = new System.Drawing.Font("Helvetica", 10, FontStyle.Bold);

                // PdfFont font = new PdfTrueTypeFont(f, true);

                //   header.Graphics.DrawString(ReportTitle, font, PdfBrushes.Black, new Point(300, 0)); //Add custom text to the Header
                // doc.Template.Top = header; //Append custom template to the document           

                // footer.Graphics.DrawString("Report Generated Date: " + DateTime.Now.ToString("dd-MMM-yyyy hh:mm tt"), font, PdfBrushes.Gray, new Point(280, 0));//Add Custom text to footer
                doc.Template.Bottom = footer;//Add the footer template to document

                doc.DocumentInformation.Title = ReportTitle;
                doc.DocumentInformation.Keywords = "PDF";
                doc.DocumentInformation.Subject = ReportTitle;
                doc.DocumentInformation.Producer = "SMS";
                doc.DocumentInformation.CreationDate = DateTime.Now;
                //  doc.DocumentInformation.Author = CU.CurrentUserFullName;

                doc.ViewerPreferences.FitWindow = true;
                doc.ViewerPreferences.PageLayout = PdfPageLayout.SinglePage;
                doc.ViewerPreferences.PageScaling = PageScalingMode.AppDefault;
                exp.Export(gvDepartment.Model, (IEnumerable)gvDepartment.DataSource, ExportFileName + ".pdf", false, false, "flat-saffron", false, doc, "");
            }
            catch (Exception ex)
            {
                // CU.LogError(ex);
            }
        }
        protected void gvDepartment_ServerRowSelected(object sender, Syncfusion.JavaScript.Web.GridEventArgs e)
        {
            if (hlAction.Value == this.addAction)
            {
                gvDepartment.SelectedRowIndices.Clear();
                gvDepartment.SelectedRowIndex = -1;
            }
            else
            {
                GetSelectedRowValues(e.Arguments["data"]);
                hlAction.Value = this.updateAction;
            }
        }

        private void GetSelectedRowValues(object record)
        {
            Dictionary<string, object> KeyVal = record as Dictionary<string, object>;
            foreach (KeyValuePair<string, object> keyval in KeyVal)
            {

                if (keyval.Key == "OrderID")
                {
                    txtDepartmentID.Text = Convert.ToString(keyval.Value);
                }
                else if (keyval.Key == "CustomerID")
                {
                    txtDepartmentName.Text = Convert.ToString(keyval.Value);
                }
            }

        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = false;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
            btnSave.Visible = true;
            btnCancel.Visible = true;

            txtDepartmentID.Enabled = true;
            txtDepartmentName.Enabled = true;
            //rdoActive.Enabled = true;
            //rdoUnActive.Enabled = true;
            //rdoITDept.Enabled = true;
            //rdoNonITDept.Enabled = true;

            btnSave.Text = "Save";
            hlAction.Value = this.addAction;

            txtDepartmentID.Text = "";
            txtDepartmentName.Text = "";
            //rdoActive.Checked = true;
            //rdoUnActive.Checked = false;
            //rdoITDept.Checked = false;
            //rdoNonITDept.Checked = true;

            gvDepartment.SelectedRowIndices.Clear();
            gvDepartment.SelectedRowIndex = -1;
        }
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = false;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
            btnSave.Visible = true;
            btnCancel.Visible = true;

            txtDepartmentID.Enabled = false;
            txtDepartmentName.Enabled = true;
            //rdoActive.Enabled = true;
            //rdoUnActive.Enabled = true;
            //rdoITDept.Enabled = true;
            //rdoNonITDept.Enabled = true;

            btnSave.Text = "Update";
            hlAction.Value = this.updateAction;
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //to delete data
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {
                //to save the data
                btnAdd.Visible = true;
                btnEdit.Visible = true;
                btnDelete.Visible = true;
                btnSave.Visible = false;
                btnCancel.Visible = false;

                txtDepartmentID.Enabled = false;
                txtDepartmentName.Enabled = false;

                hlAction.Value = "";
            }
            else if (btnSave.Text == "Update")
            {
                //to update data
                btnAdd.Visible = true;
                btnEdit.Visible = true;
                btnDelete.Visible = true;
                btnSave.Visible = false;
                btnCancel.Visible = false;

                txtDepartmentID.Enabled = false;
                txtDepartmentName.Enabled = false;

                hlAction.Value = "";

            }
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = true;
            btnEdit.Visible = true;
            btnDelete.Visible = true;
            btnSave.Visible = false;
            btnCancel.Visible = false;

            txtDepartmentID.Enabled = false;
            txtDepartmentName.Enabled = false;
            //rdoActive.Enabled = false;
            //rdoUnActive.Enabled = false;
            //rdoITDept.Enabled = false;
            //rdoNonITDept.Enabled = false;
            txtDepartmentID.Text = "";
            txtDepartmentName.Text = "";

            //BindGrid();
            hlAction.Value = "";
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static object UrlUpdate(object value)
        {
            //do your stuff here
            return value;
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static object UrlInsert(Orders value)
        {
            //do your stuff here
            return order;
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static object UrlDelete(int key)
        {
            //do your stuff here
            return order;
        }

        private void BindDataSource()
        {
            int orderId = 10000;
            int empId = 0;
            for (int i = 1; i < 9; i++)
            {
                order.Add(new Orders(orderId + 1, "VINET", empId + 1, 32.38, new DateTime(2014, 12, 25), "qwer@gmail"));
                order.Add(new Orders(orderId + 2, "TOMSP", empId + 2, 11.61, new DateTime(2014, 12, 21), "wrwr@gmail"));
                order.Add(new Orders(orderId + 3, "ANATER", empId + 3, 45.34, new DateTime(2014, 10, 18), "cbdb@gmail"));
                order.Add(new Orders(orderId + 4, "ALFKI", empId + 4, 37.28, new DateTime(2014, 11, 23), "fbnenk@gmail"));
                order.Add(new Orders(orderId + 5, "FRGYE", empId + 5, null, new DateTime(2014, 05, 05), "nmk@gmail"));
                order.Add(new Orders(orderId + 6, "", empId + 6, 23.32, new DateTime(2014, 10, 18), "powe@gmail"));
                orderId += 6;
                empId += 6;
            }
            order2.Add(new Orders(1, "Finn", empId + 1, 32.38, new DateTime(2014, 12, 25), "Reims"));
            order2.Add(new Orders(2, "bellamy", empId + 2, 11.61, new DateTime(2014, 12, 21), "Munster"));
        }

        [Serializable]
        public class Orders
        {
            public Orders()
            {

            }

            public Orders(int orderId, string customerId, int empId, double? freight, DateTime orderDate, string shipCity)
            {
                this.OrderID = orderId;
                this.CustomerID = customerId;
                this.EmployeeID = empId;
                this.Freight = freight;
                this.OrderDate = orderDate;
                this.ShipCity = shipCity;
            }

            public int OrderID { get; set; }
            public string CustomerID { get; set; }
            public int EmployeeID { get; set; }
            public double? Freight { get; set; }
            public DateTime OrderDate { get; set; }
            public string ShipCity { get; set; }




        }
    }
}