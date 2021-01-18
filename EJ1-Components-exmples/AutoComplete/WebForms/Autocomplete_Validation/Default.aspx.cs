using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        [System.Web.Services.WebMethod]
        public static object Get()
        {

            List<Employee> EmpData = new List<Employee>();
            EmpData.Add(new Employee
            {
                Name = "Erik Linden",
                Role = "Executive",
                Street = "2nd st"

            });
            EmpData.Add(new Employee
            {
                Name = "John Linden",
                Role = "Representative",
                Street = "1st st"

            });
            EmpData.Add(new Employee
            {
                Name = "Louis",
                Role = "Representative",
                Street = "4th st"

            });
            EmpData.Add(new Employee
            {
                Name = "Lawrence",
                Role = "Executive",
                Street = "12th st"

            });
            dynamic count = EmpData.Count;
            return new
            {
                result = EmpData,
                count = count
            };

        }
        

    }

    public class Employee
    {
        public string Name { get; set; }
        public string Role { get; set; }

        public string Street { get; set; }

    }
}