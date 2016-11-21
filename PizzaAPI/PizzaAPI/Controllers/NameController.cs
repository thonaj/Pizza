using PizzaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaAPI.Controllers
{
    public class NameController : ApiController
    {
      private PizzaServiceClient psc = new PizzaServiceClient();
      // GET: api/Name
      public HttpResponseMessage Get()
      {
         return Request.CreateResponse<List<NameDTO>>(HttpStatusCode.OK, psc.getNames());
      }

      // GET: api/Name/5
      public HttpResponseMessage Get(string id)
      {
         var itm = psc.getNames().Where(i => i.ToString() == id).FirstOrDefault();
         return Request.CreateResponse<NameDTO>(HttpStatusCode.OK, itm);
      }

      // POST: api/Name
      public HttpResponseMessage Post([FromBody]NameDTO item)
      {
         psc.insertName(item);
         return Request.CreateResponse(HttpStatusCode.OK);
      }

      // PUT: api/Name/5
      public void Put(int id, [FromBody]string value)
      {
      }

      // DELETE: api/Name/5
      public void Delete(int id)
      {
      }
    }
}
