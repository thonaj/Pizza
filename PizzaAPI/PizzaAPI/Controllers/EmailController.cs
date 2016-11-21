using PizzaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaAPI.Controllers
{
    public class EmailController : ApiController
    {
      private PizzaServiceClient psc = new PizzaServiceClient();
      // GET: api/Email
      public HttpResponseMessage Get()
      {
         return Request.CreateResponse<List<EmailDTO>>(HttpStatusCode.OK, psc.getEmails());
      }

      // GET: api/Email/5
      public HttpResponseMessage Get(string id)
      {
         var itm = psc.getEmails().Where(i => i.EmailString == id).FirstOrDefault();
         return Request.CreateResponse<EmailDTO>(HttpStatusCode.OK, itm);
      }

      // POST: api/Email
      public HttpResponseMessage Post([FromBody]EmailDTO item)
      {
         psc.insertEmail(item);
         return Request.CreateResponse(HttpStatusCode.OK);
      }

      // PUT: api/Email/5
      public void Put(int id, [FromBody]string value)
      {
      }

      // DELETE: api/Email/5
      public void Delete(int id)
      {
      }
    }
}
