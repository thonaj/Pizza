using PizzaAPI.Models;
using PizzaAPI.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaAPI.Mappers
{
   public class StoreMap
   {
      public static StoreDTO MapToStoreDTO(StoreDAO b)
      {
         var a = new StoreDTO();
         a.Address = AddressMap.MapToAddressDTO(b.Address);
         a.LocationId = b.LocationId;
         a.Phone = PhoneMap.MapToPhoneDTO(b.Phone);
         a.AddressId = a.AddressId;
         a.PhoneId = b.PhoneId;
         //if(b.Orders!=null)
         //{
         //   foreach (var item in b.Orders)
         //   {
         //      a.Orders.Add(OrderMap.MapToOrderDTO(item));
         //   }
         //}
         //a.Id = b.Id;


         return a;
      }

      public static StoreDAO MapToStoreDAO(StoreDTO b)
      {
         var a = new StoreDAO();
         a.Address = AddressMap.MapToAddressDAO(b.Address);
         a.LocationId = b.LocationId;
         a.Phone = PhoneMap.MapToPhoneDAO(b.Phone);
         a.AddressId = a.AddressId;
         a.PhoneId = b.PhoneId;
         //a.Id = b.Id;
         //for (int i=0;i< b.Orders.Count;i++)
         //{
         //   a.Orders[i]=(OrderMap.MapToOrderDAO(b.Orders.ElementAt(i)));
         //}


         return a;
      }
   }
}