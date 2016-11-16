using PizzaAPI.Models;
using PizzaAPI.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaAPI.Mappers
{
   public static class CrustMap
   {
       public static CrustDTO MapToCrustDTO(CrustDAO b)
      {
         var a = new CrustDTO();
         a.Name = b.Name;
         a.Value = b.Value;
         return a;
      }
      public static CrustDAO MapToCrustDAO(CrustDTO b)
      {
         var a = new CrustDAO();
         a.Name = b.Name;
         a.Value = b.Value;
         return a;
      }

   }
}