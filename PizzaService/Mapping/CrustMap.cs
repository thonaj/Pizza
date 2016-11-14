using Pizza.DAL;
using PizzaService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaService.Mapping
{
   public static class CrustMap
   {
      public static Crust MapToCrust(CrustDAO b)
      {
         var a = new Crust();
         a.Name = b.Name;
         a.Value = b.Value;
         return a;
      }
      public static CrustDAO MapToCrustDAO(Crust b)
      {
         var a = new Crust();
         a.Name = b.Name;
         a.Value = b.Value;
         return a;
      }
   }
}