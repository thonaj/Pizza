using PizzaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaAPI.Controllers
{
    public class SauceController : ApiController
    {
      private PizzaServiceClient psc = new PizzaServiceClient();

      // GET: api/Sauce
      public HttpResponseMessage Get()
      {
         return Request.CreateResponse<List<SauceDTO>>(HttpStatusCode.OK, psc.getSauces());
      }

      // GET: api/Sauce/5
      public HttpResponseMessage Get(string id)
      {
         var itm = psc.getSauces().Where(i => i.Name == id).FirstOrDefault();
         return Request.CreateResponse<SauceDTO>(HttpStatusCode.OK, itm);
      }

      // POST: api/Sauce
      public void Post([FromBody]string value)
        {
        }

        // PUT: api/Sauce/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Sauce/5
        public void Delete(int id)
        {
        }
    }
}
