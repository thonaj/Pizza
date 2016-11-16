using PizzaAPI.Models;
using PizzaAPI.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaAPI.Mappers
{
   public class SauceMap
   {
      public static SauceDTO MapToSauceDTO(SauceDAO b)
      {
         var a = new SauceDTO();
         a.Name = b.Name;
         a.Value = b.Value;
         return a;
      }
      public static SauceDAO MapToSauceDAO(SauceDTO b)
      {
         var a = new SauceDAO();
         a.Name = b.Name;
         a.Value = b.Value;
         return a;
      }
   }
}