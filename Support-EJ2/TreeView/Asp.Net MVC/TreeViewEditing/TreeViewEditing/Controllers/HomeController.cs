using Syncfusion.EJ2.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TreeViewEditing.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();

        }
        public ActionResult initialData(DataManagerRequest dm)
        {
            List<loadondemand> results = loadondemand.GetTreeData();
            IEnumerable<loadondemand> DataSource = results;
            if (dm.Where == null)
            {
                //return the first level nodes
                DataSource = results.Where(item => item.parentId == null);
            }
            else
            {
                //return the nodes which has pid as we request
                DataSource = results.Where(s => s.parentId == Convert.ToInt32(dm.Where[0].value));
            }
            DataOperations operation = new DataOperations();
            List<string> str = new List<string>();
            if (dm.Search != null && dm.Search.Count > 0)
            {
                DataSource = operation.PerformSearching(DataSource, dm.Search);  //Search
            }
            if (dm.Sorted != null && dm.Sorted.Count > 0) //Sorting
            {
                DataSource = operation.PerformSorting(DataSource, dm.Sorted);
            }
            if (dm.Where != null && dm.Where.Count > 0) //Filtering
            {
                DataSource = operation.PerformFiltering(DataSource, dm.Where, dm.Where[0].Operator);
            }
            int count = DataSource.Cast<loadondemand>().Count();
            if (dm.Skip != 0)
            {
                DataSource = operation.PerformSkip(DataSource, dm.Skip);         //Paging
            }
            if (dm.Take != 0)
            {
                DataSource = operation.PerformTake(DataSource, dm.Take);
            }
            return dm.RequiresCounts ? Json(new { result = DataSource, count = count }) : Json(DataSource);
        }
        public ActionResult RenderTreeViewCrud(object value)
        {
            //just testing hit to the controller
            return Json(value);
        }

    }

    public class loadondemand
    {
        public static List<loadondemand> load = new List<loadondemand>();
        public static List<loadondemand> GetTreeData()
        {
            List<loadondemand> load = new List<loadondemand>();
            load.Add(new loadondemand { id = 1, name = "User", hasChild = true });
            load.Add(new loadondemand { id = 2, name = "Documents", hasChild = true });
            load.Add(new loadondemand { id = 3, name = "Programs", hasChild = true });
            load.Add(new loadondemand { id = 2, parentId = 1, name = "Smith" });
            load.Add(new loadondemand { id = 3, parentId = 1, name = "Public" });
            load.Add(new loadondemand { id = 4, parentId = 1, name = "Pictures", hasChild = true });
            load.Add(new loadondemand { id = 6, parentId = 4, name = "Music" });
            load.Add(new loadondemand { id = 7, parentId = 4, name = "Movies" });

            load.Add(new loadondemand { id = 9, parentId = 2, name = "Personals", hasChild = true });
            load.Add(new loadondemand { id = 10, parentId = 9, name = "My photos" });
            load.Add(new loadondemand { id = 11, parentId = 9, name = "Rental document" });
            load.Add(new loadondemand { id = 13, parentId = 9, name = "pay slip.pdf" });

            load.Add(new loadondemand { id = 16, parentId = 3, name = "Projects" });
            load.Add(new loadondemand { id = 17, parentId = 3, name = "ASP application" });
            load.Add(new loadondemand { id = 18, parentId = 3, name = "React application" });
            load.Add(new loadondemand { id = 19, parentId = 3, name = "Angular application" });
            return load;
        }


        public int id { get; set; }
        public int? parentId { get; set; }
        public string name { get; set; }
        public bool? hasChild { get; set; }
        public bool? expanded { get; set; }
        public bool? ischecked { get; set; }
        public bool? selected { get; set; }
        public string spriteCss { get; set; }

    }
    public class DataManager
    {
        public List<string> Select { get; set; }
        public List<WhereFilter> Where { get; set; }
    }
    public class WhereFilter
    {
        public string Field { get; set; }
        public bool IgnoreCase { get; set; }
        public bool IsComplex { get; set; }
        public string Operator { get; set; }
        public string Condition { get; set; }
        public object value { get; set; }
    }

}

