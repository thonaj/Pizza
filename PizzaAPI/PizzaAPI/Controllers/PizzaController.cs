using PizzaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaAPI.Controllers
{
    public class PizzaController : ApiController
    {
      private PizzaServiceClient psc = new PizzaServiceClient();
      // GET: api/Pizza
      public HttpResponseMessage Get()
      {
         return Request.CreateResponse<List<PizzaDTO>>(HttpStatusCode.OK, psc.getPizzas());
      }

      // GET: api/Pizza/5
      public HttpResponseMessage Get(string id)
      {
         var itm = psc.getPizzas().Where(i => i.Name == id).FirstOrDefault();
         return Request.CreateResponse<PizzaDTO>(HttpStatusCode.OK, itm);
      }

      // POST: api/Pizza
      public HttpResponseMessage Post([FromBody]PizzaDTO value)
      {
         psc.insertPizza(value);
         return Request.CreateResponse(HttpStatusCode.OK);
      }

      // PUT: api/Pizza/5
      public void Put(int id, [FromBody]PizzaDTO value)
      {
         //value.Crust
         //value.Sauce
         //value.Size
         //value.
      }

      // DELETE: api/Pizza/5
      public void Delete(int id)
      {
      }
    }
}
