using PizzaAPI.Models;
using PizzaAPI.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaAPI.Mappers
{
   public class PhoneMap
   {
      public static PhoneDTO MapToPhoneDTO(PhoneDAO b)
      {
         var a = new PhoneDTO();
         a.Number = b.Number;
         //a.Id = b.Id;
         //foreach (var item in b.Customers)
         //{
         //   a.Customers.Add(CustomerMap.MapToCustomerDTO(item));
         //}
         //foreach (var item in b.Stores)
         //{
         //   a.Stores.Add(StoreMap.MapToStoreDTO(item));
         //}
         return a;
      }

      public static PhoneDAO MapToPhoneDAO(PhoneDTO b)
      {
         var a = new PhoneDAO();
         a.Number = b.Number;
         //a.Id = b.Id;
         //for (int i=0;i< b.Customers.Count;i++)
         //{
         //   a.Customers[i]=(CustomerMap.MapToCustomerDAO(b.Customers.ElementAt(i)));
         //}
         //for (int i=0;i< b.Stores.Count;i++)
         //{
         //   a.Stores[i]=(StoreMap.MapToStoreDAO(b.Stores.ElementAt(i)));
         //}
         return a;
      }
   }
}