using Piz.DataAccess;
using PizService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizService.Mapping
{
   public static class EmailMap
   {
      public static Email MapToEmail(EmailDAO b)
      {
         var a = new Email();
         a.EmailString = b.EmailString;
         //foreach (var item in b.Customers)
         //{
         //   a.Customers.Add(CustomerMap.MapToCustomer(item));
         //}
         a.Id = b.Id;
         return a;
      }

      public static EmailDAO MapToEmailDAO(Email b)
      {
         var a = new EmailDAO();
         a.EmailString = b.EmailString;
         //foreach (var item in b.Customers)
         //{
         //   a.Customers.Add(CustomerMap.MapToCustomerDAO(item));
         //}
         a.Id = b.Id;
         return a;
      }
   }
}