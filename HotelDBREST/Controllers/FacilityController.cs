using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HotelDBREST.DBUtil;
using ModelLib.model;

namespace HotelDBREST.Controllers
{
    public class FacilityController : ApiController
    {
        private static IManage<Facility> manager = new ManageFacility();


        // GET: api/Hotels
        public IEnumerable<Facility> Get()
        {
            return manager.Get();
        }

        // GET: api/Hotels/5
        public Facility Get(int id)
        {
            return manager.Get(id);
        }

        // POST: api/Hotels
        public bool Post([FromBody]Facility facility)
        {
            return manager.Post(facility);

        }

        // PUT: api/Hotels/5
        public bool Put(int id, [FromBody]Facility facility)
        {
            return manager.Put(id, facility);
        }

        // DELETE: api/Hotels/5
        public bool Delete(int id)
        {
            return manager.Delete(id);
        }
    }
}
