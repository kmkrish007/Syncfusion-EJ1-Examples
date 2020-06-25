using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Treeview
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Template> templateData = new List<Template>();
            templateData.Add(new Template
            {
                Id = 1,
                FirstName = "Derek",
                LastName = "Hale",
                HasChild = true,
                Expanded = true
            });
            templateData.Add(new Template
            {
                Id = 2,
                PId = 1,
                FirstName = "Steven",
                LastName = "John"
            });
            templateData.Add(new Template
            {
                Id = 3,
                FirstName = "Oliver",
                LastName = "Queen",
                HasChild = true,
                Expanded = true
            });
            templateData.Add(new Template
            {
                Id = 5,
                PId = 3,
                FirstName = "Scott",
                LastName = "McCall"
            });
            templateData.Add(new Template
            {
                Id = 4,
                PId = 3,
                FirstName = "Steves",
                LastName = "Stelenski"
            });
            templateData.Add(new Template
            {
                Id = 6,
                FirstName = "Henry",
                LastName = "Cavil"
            });
            templateData.Add(new Template
            {
                Id = 7,
                PId = 6,
                FirstName = "Anya",
                LastName = "Chalotra"
            });
            templateData.Add(new Template
            {
                Id = 8,
                PId = 6,
                FirstName = "Freya",
                LastName = "Allen"
            });
            templateData.Add(new Template
            {
                Id = 9,
                PId = 6,
                FirstName = "Joey",
                LastName = "Batey"
            });
            treeview.DataSource = templateData;
        }
    }

    public class Template
    {
        public int Id { get; set; }
        public int PId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool HasChild { get; set; }
        public bool Expanded { get; set; }
    }
}