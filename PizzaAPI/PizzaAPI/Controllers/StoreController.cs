using PizzaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaAPI.Controllers
{
    public class StoreController : ApiController
    {
      private PizzaServiceClient psc = new PizzaServiceClient();
      // GET: api/Store
      public HttpResponseMessage Get()
      {
         return Request.CreateResponse<List<StoreDTO>>(HttpStatusCode.OK, psc.getStore());
      }

      // GET: api/Store/5
      public HttpResponseMessage Get(string id)
      {
         var itm = psc.getStore().Where(i => i.LocationId == id).FirstOrDefault();
         return Request.CreateResponse<StoreDTO>(HttpStatusCode.OK, itm);
      }

      // POST: api/Store
     
      public void Post([FromBody]StoreDTO item)
      {
         psc.insertPhone(item.Phone);
         var newphone= psc.getPhones().Where(p => p.Number == item.Phone.Number).FirstOrDefault();
         item.Phone = newphone;
         psc.insertAddress(item.Address);
         var newaddress = psc.getAddresses().Where(a => string.Equals(a.ToString(), item.Address.ToString()));
         psc.insertStore(item);
      }

      // PUT: api/Store/5
      public void Put(int id, [FromBody]string value)
      {
      }

      // DELETE: api/Store/5
      public void Delete(int id)
      {
      }
    }
}
