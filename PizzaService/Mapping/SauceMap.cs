using Pizza.DAL;
using PizzaService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaService.Mapping
{
   public static class SauceMap
   {
      public static Sauce MapToSauce(SauceDAO b)
      {
         var a = new Sauce();
         a.Name = b.Name;
         a.Value = b.Value;
         return a;
      }

      public static SauceDAO MapToSauceDAO(Sauce b)
      {
         var a = new SauceDAO();
         a.Name = b.Name;
         a.Value = b.Value;
         return a;
      }
   }
}