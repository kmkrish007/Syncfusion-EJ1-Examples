using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Entity
{
    public class EntityDataController : ApiController
    {
        ModelMovieContainer db = new ModelMovieContainer();
        // GET api/<controller>
        public IEnumerable<Movie> Get()
        {
            var dataset = db.Customers.Select(x => new Movie
            {
                ID = x.CustomerID,
                Name = x.ContactName
            }).ToList();

            return dataset;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }

    public class Movie
    {
        public string ID { get; set; }
        public string Name { get; set; }
    }
}