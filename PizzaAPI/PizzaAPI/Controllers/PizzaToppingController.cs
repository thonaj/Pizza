using PizzaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaAPI.Controllers
{
    public class PizzaToppingController : ApiController
    {
      private PizzaServiceClient psc = new PizzaServiceClient();
      // GET: api/PizzaTopping
      public HttpResponseMessage Get()
      {
         return Request.CreateResponse<List<PizzaToppingDTO>>(HttpStatusCode.OK, psc.getPizzaToppings());
      }

      // GET: api/PizzaTopping/5
      public HttpResponseMessage Get(string id)
      {
         var itm = psc.getPizzaToppings().Where(i => i.ToString() == id).FirstOrDefault();
         return Request.CreateResponse<PizzaToppingDTO>(HttpStatusCode.OK, itm);
      }

      // POST: api/PizzaTopping
      public void Post([FromBody]PizzaToppingDTO value)
      {
         psc.insertPizzaTopping(value);
      }

      // PUT: api/PizzaTopping/5
      public void Put(int id, [FromBody]string value)
      {
      }

      // DELETE: api/PizzaTopping/5
      public void Delete(int id)
      {
      }
    }
}
