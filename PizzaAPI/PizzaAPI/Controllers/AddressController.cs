using PizzaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaAPI.Controllers
{
    public class AddressController : ApiController
   {
      private PizzaServiceClient psc = new PizzaServiceClient();

      // GET: api/Address
      public HttpResponseMessage Get()
      {
         return Request.CreateResponse<List<AddressDTO>>(HttpStatusCode.OK, psc.getAddresses());
      }

      // GET: api/Address/5
      public HttpResponseMessage Get(string id)
      {
         var itm = psc.getAddresses().Where(i => i.ToString() == id).FirstOrDefault();
         return Request.CreateResponse<AddressDTO>(HttpStatusCode.OK, itm);
      }

      // POST: api/Address
      public HttpResponseMessage Post([FromBody]AddressDTO item)
      {
         psc.insertAddress(item);
         return Request.CreateResponse(HttpStatusCode.OK);
      }

      // PUT: api/Address/5
      public void Put(int id, [FromBody]string value)
      {
      }

      // DELETE: api/Address/5
      public void Delete(int id)
      {
      }
    }
}
