using Piz.DataAccess;
using PizService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizService.Mapping
{
   public static class NameMap
   {
      public static Name MapToName(NameDAO b)
      {
         var a = new Name();
         a.First = b.First;
         a.Last = b.Last;
         //foreach (var item in b.Customers)
         //{
         //   a.Customers.Add(CustomerMap.MapToCustomer(item));
         //}
         a.Id = b.Id;
         return a;
      }

      public static NameDAO MapToNameDAO(Name b)
      {
         var a = new NameDAO();
         a.First = b.First;
         a.Last = b.Last;
         //foreach (var item in b.Customers)
         //{
         //   a.Customers.Add(CustomerMap.MapToCustomerDAO(item));
         //}
         a.Id = b.Id;
         return a;
      }
   }
}