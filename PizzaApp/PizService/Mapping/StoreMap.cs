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
         a.Address = b.Address;
         a.Phone = b.Phone;
         a.LocationId = b.LocationId;
         return a;
      }
      public static StoreDAO MapToStoreDAO(Store b)
      {
         var a = new StoreDAO();
         a.Address = b.Address;
         a.Phone = b.Phone;
         a.LocationId = b.LocationId;
         return a;
      }
   }
}