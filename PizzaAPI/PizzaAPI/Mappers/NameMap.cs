using PizzaAPI.Models;
using PizzaAPI.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaAPI.Mappers
{
   public static class NameMap
   {
      public static NameDTO MapToNameDTO(NameDAO b)
      {
         var a = new NameDTO();
         a.First = b.First;
         a.Last = b.Last;
         //foreach (var item in b.Customers)
         //{
         //   a.Customers.Add(CustomerMap.MapToCustomerDTO(item));
         //}
         //a.Id = b.Id;
         return a;
      }
      public static NameDAO MapToNameDAO(NameDTO b)
      {
         var a = new NameDAO();
         a.First = b.First;
         a.Last = b.Last;
         //for (int i=0;i< b.Customers.Count;i++)
         //{
         //   a.Customers[i]=(CustomerMap.MapToCustomerDAO(b.Customers.ElementAt(i)));
         //}
         //a.Id = b.Id;
         return a;
      }

   }
}