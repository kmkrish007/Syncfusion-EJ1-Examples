using Microsoft.AspNetCore.Mvc;
using TreeViewSearch.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeViewSearch.Server.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        List<ItemViewModel> order = new List<ItemViewModel>();

        [HttpGet("[action]")]
        public IEnumerable<ItemViewModel> Get()
        {
            
            BindDataSource();

            var data = order.AsQueryable();

            return data;
        }
        private void BindDataSource()
        {
            order.Add(new ItemViewModel(new Guid("32b13d3e-3d82-4264-9f9e-51a77f62f672"), "Root", true, true,false, false, false, null));
            order.Add(new ItemViewModel(new Guid("2eb4e29c-8ad3-4590-8650-3785d5a3b301"), "Item 1", true, true, false, false, false, new Guid("32b13d3e-3d82-4264-9f9e-51a77f62f672")));
            order.Add(new ItemViewModel(new Guid("9b394303-64e3-4720-a710-9beff6ec669e"), "Item 2", false, true, false, false, false, new Guid("32b13d3e-3d82-4264-9f9e-51a77f62f672")));
            order.Add(new ItemViewModel(new Guid("eaa4c9db-d7bd-4aa9-a9b2-7ffeda58a8a5"), "Sub-Item 1", false, true, true, false, false, new Guid("2eb4e29c-8ad3-4590-8650-3785d5a3b301")));
            order.Add(new ItemViewModel(new Guid("50f2bad5-6899-4833-8df3-3cec49285b13"), "Sub-Item 2", false, false, false, false, false, new Guid("2eb4e29c-8ad3-4590-8650-3785d5a3b301")));
            order.Add(new ItemViewModel(new Guid("50f2bad5-6899-4833-8df3-3cec49285b13"), "Sub-Item 3", false, false, false, false, false, new Guid("2eb4e29c-8ad3-4590-8650-3785d5a3b301")));
        }
    }
}
