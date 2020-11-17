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
        protected void Page_Load(object sender, EventArgs e)
        {

            AutoMedicine.DataSource = GetData();

        }

        public static List<Details> GetData()
        {
            List<Details> details = new List<Details>();
            for(var i=0; i<25000; i++)
            {
                details.Add(new Details() { ProductCode = 1+i, ProductName = i+"Apple", GenericName = i+"Fruits" });
            }
            return details;
        }

        }

    public class Details
    {
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public string GenericName { get; set; }
    }
}