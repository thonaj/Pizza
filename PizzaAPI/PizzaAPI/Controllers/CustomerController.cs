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
      public HttpResponseMessage Post([FromBody]CustomerDTO value)
      {
         
         //psc.insertAddress(value.Address);
         //psc.insertEmail(value.Email);
         //psc.insertName(value.Name);
         //psc.insertPhone(value.Phone);
         
         //var newaddress = psc.getAddresses().Where(a => string.Equals(a.ToString(), value.Address.ToString())).FirstOrDefault();
         //var newemail = psc.getEmails().Where(a => string.Equals(a.EmailString, value.Email.EmailString)).FirstOrDefault();
         //var newname = psc.getNames().Where(a => string.Equals(a.ToString(), value.Name.ToString())).FirstOrDefault();
         //var newpone = psc.getPhones().Where(a => string.Equals(a.Number, value.Phone.Number)).FirstOrDefault();
         psc.insertCustomer(value);
         return Request.CreateResponse(HttpStatusCode.OK);

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
