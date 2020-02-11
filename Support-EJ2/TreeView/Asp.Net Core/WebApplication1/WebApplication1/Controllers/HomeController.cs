using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using Syncfusion.EJ2.Base;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public JsonResult Data()
        {
            List<TreeViewData> treeData = new TreeViewData().GetTreeData();
            IEnumerable<TreeViewData> results;
            results = treeData;
            return Json(results);
        }
        public class TreeViewData
        {
            public int id { get; set; }
            public int? pid { get; set; }
            public string name { get; set; }
            public bool hasChild { get; set; }
            public bool expanded { get; set; }

            public List<TreeViewData> GetTreeData()
            {
                List<TreeViewData> load = new List<TreeViewData>();
                load.Add(new TreeViewData { id = 1, name = "User", hasChild = true });
                load.Add(new TreeViewData { id = 2, name = "Documents", hasChild = true });
                load.Add(new TreeViewData { id = 3, name = "Programs", hasChild = true });
                load.Add(new TreeViewData { id = 2, pid = 1, name = "Smith" });
                load.Add(new TreeViewData { id = 3, pid = 1, name = "Public" });
                load.Add(new TreeViewData { id = 4, pid = 1, name = "Pictures", hasChild = true });
                load.Add(new TreeViewData { id = 6, pid = 4, name = "Music" });
                load.Add(new TreeViewData { id = 7, pid = 4, name = "Movies" });

                load.Add(new TreeViewData { id = 9, pid = 2, name = "Personals", hasChild = true });
                load.Add(new TreeViewData { id = 10, pid = 9, name = "My photos" });
                load.Add(new TreeViewData { id = 11, pid = 9, name = "Rental document" });
                load.Add(new TreeViewData { id = 13, pid = 9, name = "pay slip.pdf" });

                load.Add(new TreeViewData { id = 16, pid = 3, name = "Projects" });
                load.Add(new TreeViewData { id = 17, pid = 3, name = "ASP application" });
                load.Add(new TreeViewData { id = 18, pid = 3, name = "React application" });
                load.Add(new TreeViewData { id = 19, pid = 3, name = "Angular application" });
                return load;
            }
        }
            public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
