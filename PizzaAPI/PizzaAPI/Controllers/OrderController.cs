using PizzaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaAPI.Controllers
{
    public class OrderController : ApiController
    {
      private PizzaServiceClient psc = new PizzaServiceClient();
      // GET: api/Order
      public HttpResponseMessage Get()
      {
         return Request.CreateResponse<List<OrderDTO>>(HttpStatusCode.OK, psc.getOrders());
      }

      // GET: api/Order/5
      public HttpResponseMessage Get(string id)
      {
         var itm = psc.getOrders().Where(i => i.Name == id).FirstOrDefault();
         return Request.CreateResponse<OrderDTO>(HttpStatusCode.OK, itm);
      }

      // POST: api/Order
      public void Post([FromBody]string value)
      {
      }

      // PUT: api/Order/5
      public void Put(int id, [FromBody]string value)
      {
      }

      // DELETE: api/Order/5
      public void Delete(int id)
      {
      }
    }
}
