using Pizza.DAL;
using PizzaService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaService.Mapping
{
   public static class PizzaToppingMap
   {
      public static PizzaTopping MapToPizzaTopping(PizzaToppingDAO b)
      {
         var a = new PizzaTopping();
         a.Pizza = b.Pizza;
         b.Topping = b.Topping;
         return a;
      }
      public static PizzaToppingDAO MapToPizzaToppingDAO(PizzaTopping b)
      {
         var a = new PizzaToppingDAO();
         a.Pizza = b.Pizza;
         b.Topping = b.Topping;
         return a;
      }
   }
}