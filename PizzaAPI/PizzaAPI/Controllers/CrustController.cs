using PizzaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PizzaAPI;

namespace PizzaAPI.Controllers
{
   
   
    public class CrustController : ApiController
    {
      private PizzaServiceClient psc = new PizzaServiceClient();

        // GET: api/Crust
        public HttpResponseMessage Get()
        {
         var itm = psc.getCrusts();
         return Request.CreateResponse<List<CrustDTO>>(HttpStatusCode.OK, itm);
        }

        // GET: api/Crust/thin
        public HttpResponseMessage Get(string id)
        {
         var itm = psc.getCrusts().Where(i => i.Name == id).FirstOrDefault();
         return Request.CreateResponse<CrustDTO>(HttpStatusCode.OK, itm);
        }

        // POST: api/Crust
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Crust/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Crust/5
        public void Delete(int id)
        {
        }
    }
}
