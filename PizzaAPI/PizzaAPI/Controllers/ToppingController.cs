using PizzaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaAPI.Controllers
{
    public class ToppingController : ApiController
    {
      private PizzaServiceClient psc = new PizzaServiceClient();

      // GET: api/Topping
      public HttpResponseMessage Get()
      {
         return Request.CreateResponse<List<ToppingDTO>>(HttpStatusCode.OK, psc.getToppings());
      }

      // GET: api/Topping/5
      public HttpResponseMessage Get(string id)
      {
         var itm = psc.getToppings().Where(i => i.Name == id).FirstOrDefault();
         return Request.CreateResponse<ToppingDTO>(HttpStatusCode.OK, itm);
      }

      // POST: api/Topping
      public void Post([FromBody]string value)
        {
        }

        // PUT: api/Topping/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Topping/5
        public void Delete(int id)
        {
        }
    }
}
