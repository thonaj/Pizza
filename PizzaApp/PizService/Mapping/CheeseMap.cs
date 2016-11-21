using Piz.DataAccess;
using PizService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizService.Mapping
{
   public static class CheeseMap
   {
      public static Cheese MapToCheese(CheeseDAO b)
      {
         var a = new Cheese();
         a.Name = b.Name;
         a.Value = b.Value;
         a.Id = b.Id;
         //foreach (var item in b.PizzaCheeseDAO)
         //{
         //   a.PizzaCheese.Add(PizzaCheeseMap.MapToPizzaCheese(item));
         //}
         
         return a;
      }
      public static CheeseDAO MapToCheeseDAO(Cheese b)
      {
         var a = new CheeseDAO();
         a.Name = b.Name;
         a.Value = b.Value;
         a.Id = b.Id;
         //foreach (var item in b.PizzaCheese)
         //{
         //   a.PizzaCheeseDAO.Add(PizzaCheeseMap.MapToPizzaCheeseDAO(item));
         //}
         return a;
      }

   }
}