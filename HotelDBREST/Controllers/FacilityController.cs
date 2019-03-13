using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HotelDBREST.Controllers
{
    public class FacilityController : ApiController
    {
        // GET: api/Facility
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Facility/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Facility
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Facility/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Facility/5
        public void Delete(int id)
        {
        }
    }
}
