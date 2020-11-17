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
    }
    public class CarsList
    {
        public string type { get; set; }
    }
}