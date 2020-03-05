using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Entity.Models;

namespace Entity
{
    public class EntityDataController : ApiController
    {
        ModelMovieContainer db = new ModelMovieContainer();
        // GET api/<controller>
        [ActionName("GetData")]
        public IEnumerable<Movie> Get()
        {
            var dataset = db.Customers.Select(x => new Movie
            {
                ID = x.CustomerID,
                Name = x.ContactName
            }).ToList();
            return dataset;
        }
    }

    public class Movie
    {
        public string ID { get; set; }
        public string Name { get; set; }
    }
}