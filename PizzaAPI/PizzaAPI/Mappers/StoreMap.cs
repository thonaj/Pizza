using PizzaAPI.Models;
using PizzaAPI.ServiceReference;
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
         if(b.Orders!=null)
         {
            foreach (var item in b.Orders)
            {
               a.Orders.Add(OrderMap.MapToOrderDTO(item));
            }
         }
         
         

         return a;
      }

      public static StoreDAO MapToStoreDAO(StoreDTO b)
      {
         var a = new StoreDAO();
         a.Address = AddressMap.MapToAddressDAO(b.Address);
         a.LocationId = b.LocationId;
         a.Phone = PhoneMap.MapToPhoneDAO(b.Phone);

         


         return a;
      }
   }
}