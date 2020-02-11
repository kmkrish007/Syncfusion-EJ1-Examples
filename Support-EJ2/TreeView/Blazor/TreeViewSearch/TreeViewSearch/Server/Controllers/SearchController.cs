using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SearchTreeSampleApp.Server.Controllers
{
    [Route("api/[controller]")]
    public class SearchController : Controller
    {

        [HttpGet("{SearchText}")]
        public IEnumerable<IEnumerable<string>> Search(string searchText)
        {
            var results = new List<List<string>>();

            var firstMatch = new List<string>
            {
                "32b13d3e-3d82-4264-9f9e-51a77f62f672",
                "2eb4e29c-8ad3-4590-8650-3785d5a3b301",
                "eaa4c9db-d7bd-4aa9-a9b2-7ffeda58a8a5",
                "fca52cc4-87ad-4d04-8cb3-6795d27ec5c1" // Andrew
            };

            results.Add(firstMatch);

            var secondMatch = new List<string>
            {
                "32b13d3e-3d82-4264-9f9e-51a77f62f672",
                "9b394303-64e3-4720-a710-9beff6ec669e",
                "fca52cc4-87ad-4d04-8cb3-6795d27ec5c5" // Andy
            };

            results.Add(secondMatch);

            var thirdMatch = new List<string>
            {
                "32b13d3e-3d82-4264-9f9e-51a77f62f672",
                "9b394303-64e3-4720-a710-9beff6ec669e",
                "fca52cc4-87ad-4d04-8cb3-6795d27ec5c6" // Anne
            };

            results.Add(thirdMatch);

            return results;
        }

    }
}
