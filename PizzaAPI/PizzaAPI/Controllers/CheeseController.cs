using PizzaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaAPI.Controllers
{
    public class CheeseController : ApiController
    {
      private PizzaServiceClient psc = new PizzaServiceClient();
      // GET: api/Cheese
      public HttpResponseMessage Get()
        {
         return Request.CreateResponse<List<CheeseDTO>>(HttpStatusCode.OK, psc.getCheeses());
        }

        // GET: api/Cheese/5
        public HttpResponseMessage Get(string id)
        {
         var itm = psc.getCheeses().Where(i => i.Name == id).FirstOrDefault();
         return Request.CreateResponse<CheeseDTO>(HttpStatusCode.OK, itm);
      }

        // POST: api/Cheese
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Cheese/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Cheese/5
        public void Delete(int id)
        {
        }
    }
}
