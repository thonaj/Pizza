using PizzaAPI.Models;
using PizzaAPI.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaAPI.Mappers
{
   public class ToppingMap
   {
      public static ToppingDTO MapToToppingDTO(ToppingDAO b)
      {
         var a = new ToppingDTO();
         a.Name = b.Name;
         a.Value = b.Value;
         return a;
      }
      public static ToppingDAO MapToToppingDAO(ToppingDTO b)
      {
         var a = new ToppingDAO();
         a.Name = b.Name;
         a.Value = b.Value;
         return a;
      }
   }
}