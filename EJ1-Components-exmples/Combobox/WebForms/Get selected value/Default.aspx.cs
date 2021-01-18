using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComboBox
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<CarsList> car = new List<CarsList>();
            car.Add(new CarsList { type = "Audi S6", custid="1" });
            car.Add(new CarsList { type = "Austin-Healey", custid = "2" });
            car.Add(new CarsList { type = "Alfa Romeo", custid = "3" });
            car.Add(new CarsList { type = "Aston Martin", custid = "4" });
            car.Add(new CarsList { type = "BMW 7", custid = "5" });
            car.Add(new CarsList { type = "Bentley Mulsanne", custid = "6" });
            car.Add(new CarsList { type = "Bugatti Veyron", custid = "7" });
            car.Add(new CarsList { type = "Chevrolet Camaro", custid = "8" });
            car.Add(new CarsList { type = "Cadillac", custid = "9" });
            car.Add(new CarsList { type = "Duesenberg J", custid = "10" });
            car.Add(new CarsList { type = "Dodge Sprinter", custid = "11" });
            car.Add(new CarsList { type = "Elantra", custid = "12" });
            txtCustID.DataSource = car;
        }
    }
    public class CarsList
    {
        public string type { get; set; }
        public string custid { get; set; }
    }
}