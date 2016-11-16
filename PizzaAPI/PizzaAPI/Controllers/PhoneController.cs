using PizzaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaAPI.Controllers
{
    public class PhoneController : ApiController
    {
      private PizzaServiceClient psc = new PizzaServiceClient();
      // GET: api/Phone
      public HttpResponseMessage Get()
      {
         return Request.CreateResponse<List<PhoneDTO>>(HttpStatusCode.OK, psc.getPhones());
      }

      // GET: api/Phone/5
      public HttpResponseMessage Get(string id)
      {
         var itm = psc.getPhones().Where(i => i.Number == id).FirstOrDefault();
         return Request.CreateResponse<PhoneDTO>(HttpStatusCode.OK, itm);
      }

      // POST: api/Phone
      public void Post([FromBody]string value)
      {
      }

      // PUT: api/Phone/5
      public void Put(int id, [FromBody]string value)
      {
      }

      // DELETE: api/Phone/5
      public void Delete(int id)
      {
      }
    }
}
