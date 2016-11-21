using PizzaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaAPI.Controllers
{
    public class PizzaCheeseController : ApiController
    {
      private PizzaServiceClient psc = new PizzaServiceClient();
      // GET: api/PizzaCheese
      public HttpResponseMessage Get()
      {
         return Request.CreateResponse<List<PizzaCheeseDTO>>(HttpStatusCode.OK, psc.getPizzaCheese());
      }

      // GET: api/PizzaCheese/5
      public HttpResponseMessage Get(string id)
      {
         var itm = psc.getPizzaCheese().Where(i => i.ToString() == id).FirstOrDefault();
         return Request.CreateResponse<PizzaCheeseDTO>(HttpStatusCode.OK, itm);
      }

      // POST: api/PizzaCheese
      public HttpResponseMessage Post([FromBody]PizzaCheeseDTO value)
      {
         psc.insertPizzaCheese(value);
         return Request.CreateResponse(HttpStatusCode.OK);
      }

      // PUT: api/PizzaCheese/5
      public void Put(int id, [FromBody]string value)
      {
      }

      // DELETE: api/PizzaCheese/5
      public void Delete(int id)
      {
      }
    }
}
