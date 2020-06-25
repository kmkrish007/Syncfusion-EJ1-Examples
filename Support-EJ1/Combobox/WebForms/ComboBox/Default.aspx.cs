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
            List<Employee> Data = new List<Employee>();
            List<CarsList> car = new List<CarsList>();
            Data.Add(new Employee { Text = "Erik Linden" });
            Data.Add(new Employee { Text = "John Linden" });
            Data.Add(new Employee { Text = "Louis" });
            Data.Add(new Employee { Text = "Lawrence" });
           // givingTo.DataSource = Data;

            car.Add(new CarsList { type = "Audi S6" });
            car.Add(new CarsList { type = "Austin-Healey" });
            car.Add(new CarsList { type = "Alfa Romeo" });
            car.Add(new CarsList { type = "Aston Martin" });
            car.Add(new CarsList { type = "BMW 7" });
            car.Add(new CarsList { type = "Bentley Mulsanne" });
            car.Add(new CarsList { type = "Bugatti Veyron" });
            car.Add(new CarsList { type = "Chevrolet Camaro" });
            car.Add(new CarsList { type = "Cadillac" });
            car.Add(new CarsList { type = "Duesenberg J" });
            car.Add(new CarsList { type = "Dodge Sprinter" });
            car.Add(new CarsList { type = "Elantra" });
            Combo.DataSource = car;
        }

        protected void sub2HR_Click1(object sender, Syncfusion.JavaScript.Web.ButtonClickEventArgs e)
        {

        }
    }

    public class Employee
    {
        public string Text { get; set; }
        public string Role { get; set; }
        public string Country { get; set; }
    }

    public class CarsList
    {
        public string type { get; set; }
    }
}