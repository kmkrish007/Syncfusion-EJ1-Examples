using Microsoft.AspNetCore.Mvc;
using TreeViewSearch.Shared;
using Syncfusion.EJ2.Blazor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeViewSearch.Server.Controllers
{
    [Route("api/[controller]")]
    public class ChildController : Controller
    {

        List<ItemViewModel> childorder = new List<ItemViewModel>();

        [HttpGet("{ParentItemGuid}")]
        public IEnumerable<ItemViewModel> Get(Guid ParentItemGuid)
        {
            BindDataSource();

            var data = childorder.AsQueryable();

            var results = (data.Where(s => s.ParentItemGuid == ParentItemGuid));

            return results;
        }

        private void BindDataSource()
        {
            childorder.Add(new ItemViewModel(new Guid("fca52cc4-87ad-4d04-8cb3-6795d27ec5b3"), "Steven",   false, false, false, false, false, new Guid("eaa4c9db-d7bd-4aa9-a9b2-7ffeda58a8a5")));
            childorder.Add(new ItemViewModel(new Guid("fca52cc4-87ad-4d04-8cb3-6795d27ec5b2"), "Johan",    false, false, false, false, false, new Guid("eaa4c9db-d7bd-4aa9-a9b2-7ffeda58a8a5")));
            childorder.Add(new ItemViewModel(new Guid("fca52cc4-87ad-4d04-8cb3-6795d27ec5c1"), "Andrews",  false, false, false, false, false, new Guid("eaa4c9db-d7bd-4aa9-a9b2-7ffeda58a8a5")));
            childorder.Add(new ItemViewModel(new Guid("fca52cc4-87ad-4d04-8cb3-6795d27ec4b3"), "Michael",  false, false, false, false, false, new Guid("9b394303-64e3-4720-a710-9beff6ec669e")));
            childorder.Add(new ItemViewModel(new Guid("fca52cc4-87ad-4d04-8cb3-6795d27ec4b2"), "Robert",   false, false, false, false, false, new Guid("9b394303-64e3-4720-a710-9beff6ec669e")));
            childorder.Add(new ItemViewModel(new Guid("fca52cc4-87ad-4d04-8cb3-6795d27ec4c1"), "Margaret", false, false, false, false, false, new Guid("9b394303-64e3-4720-a710-9beff6ec669e")));
            childorder.Add(new ItemViewModel(new Guid("fca52cc4-87ad-4d04-8cb3-6795d27ec5c5"), "Andy",     false, false, false, false, false, new Guid("9b394303-64e3-4720-a710-9beff6ec669e")));
            childorder.Add(new ItemViewModel(new Guid("fca52cc4-87ad-4d04-8cb3-6795d27ec5c6"), "Anne",     false, false, false, false, false, new Guid("9b394303-64e3-4720-a710-9beff6ec669e")));
        }

    }
}
