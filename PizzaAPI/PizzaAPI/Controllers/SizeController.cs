using PizzaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaAPI.Controllers
{
    public class SizeController : ApiController
    {
      private PizzaServiceClient psc = new PizzaServiceClient();

      // GET: api/Size
      public HttpResponseMessage Get()
      {
         return Request.CreateResponse<List<SizeDTO>>(HttpStatusCode.OK, psc.getSizes());
      }

      // GET: api/Size/5
      public HttpResponseMessage Get(string id)
      {
         var itm = psc.getSizes().Where(i => i.Name == id).FirstOrDefault();
         return Request.CreateResponse<SizeDTO>(HttpStatusCode.OK, itm);
      }

      // POST: api/Size
      public void Post([FromBody]SizeDTO item)
      {
         psc.insertSize(item);
      }

      // PUT: api/Size/5
      public void Put(int id, [FromBody]string value)
      {
      }

      // DELETE: api/Size/5
      public void Delete(int id)
      {
      }
    }
}
