using Piz.DataAccess;
using PizService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizService.Mapping
{
   public static class ToppingMap
   {
      public static Topping MapToTopping(ToppingDAO b)
      {
         var a = new Topping();
         a.Name = b.Name;
         a.Value = b.Value;
         a.Id = b.Id;
        
         //foreach (var item in b.PizzaToppings)
         //{
         //   a.PizzaToppings.Add(PizzaToppingMap.MapToPizzaTopping(item));
         //}


         return a;
      }
      public static ToppingDAO MapToToppingDAO(Topping b)
      {
         var a = new ToppingDAO();
         a.Name = b.Name;
         a.Value = b.Value;
         //foreach (var item in b.PizzaToppings)
         //{
         //   a.PizzaToppings.Add(PizzaToppingMap.MapToPizzaToppingDAO(item));
         //}

         return a;


      }
   }
}