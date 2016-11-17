using PizzaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaAPI.Controllers
{
    public class CustomerController : ApiController
    {
      private PizzaServiceClient psc = new PizzaServiceClient();
      // GET: api/Customer
      public HttpResponseMessage Get()
      {
         return Request.CreateResponse<List<CustomerDTO>>(HttpStatusCode.OK, psc.getCustomers());
      }

      // GET: api/Customer/5
      public HttpResponseMessage Get(int id)
      {
         var itm = psc.getCustomers().Where(i => i.NameId == id).FirstOrDefault();
         return Request.CreateResponse<CustomerDTO>(HttpStatusCode.OK, itm);
      }

      // POST: api/Customer
      public void Post([FromBody]string value)
      {
      }

      // PUT: api/Customer/5
      public void Put(int id, [FromBody]string value)
      {
      }

      // DELETE: api/Customer/5
      public void Delete(int id)
      {
      }
    }
}
