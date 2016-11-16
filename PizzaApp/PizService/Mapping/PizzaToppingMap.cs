using Piz.DataAccess;
using PizService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizService.Mapping
{
   public static class PizzaToppingMap
   {
      public static PizzaTopping MapToPizzaTopping(PizzaToppingDAO b)
      {
         var a = new PizzaTopping();
         a.PizzaId = b.PizzaId;
         a.ToppingId = b.ToppingId;
         a.Topping = ToppingMap.MapToTopping(b.Topping);
         return a;
      }
      public static PizzaToppingDAO MapToPizzaToppingDAO(PizzaTopping b)
      {
         var a = new PizzaToppingDAO();
         a.PizzaId = b.PizzaId;
         a.ToppingId = b.ToppingId;
         b.Topping = b.Topping;
         return a;
      }
   }
}