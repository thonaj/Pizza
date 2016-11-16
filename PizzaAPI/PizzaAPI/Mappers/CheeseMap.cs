using PizzaAPI.Models;
using PizzaAPI.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaAPI.Mappers
{
   public static class CheeseMap
   {
      public static CheeseDTO MapToCheeseDTO(CheeseDAO b)
      {
         var a = new CheeseDTO();
         a.Name = b.Name;
         a.Value = b.Value;
         return a;
      }
      public static CheeseDAO MapToCheeseDAO(CheeseDTO b)
      {
         var a = new CheeseDAO();
         a.Name = b.Name;
         a.Value = b.Value;
         return a;
      }
   }
}