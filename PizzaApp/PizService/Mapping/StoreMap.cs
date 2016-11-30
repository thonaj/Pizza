using Piz.DataAccess;
using PizService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizService.Mapping
{
   public static class StoreMap
   {
      public static Store MapToStore(StoreDAO b)
      {
         var a = new Store();
         a.Address = AddressMap.MapToAddress(b.Address);
         a.Phone = PhoneMap.MapToPhone(b.Phone);
         a.LocationId = b.LocationId;
         a.AddressId = b.AddressId;
         a.PhoneId = b.PhoneId;
         a.Id = b.Id;

         return a;
      }
      public static StoreDAO MapToStoreDAO(Store b)
      {
         var a = new StoreDAO();
         a.Address = AddressMap.MapToAddressDAO(b.Address);
         a.Phone = PhoneMap.MapToPhoneDAO(b.Phone);
         a.LocationId = b.LocationId;
         a.AddressId = b.AddressId;
         a.PhoneId = b.PhoneId;
         a.Id = b.Id;
       
         return a;
      }
   }
}