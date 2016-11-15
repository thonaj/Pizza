using Pizza.DAL;
using PizzaService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaService.Mapping
{
   public static class PizzaCheeseMap
   {
      public static PizzaCheese MapToPizzaCheese(PizzaCheeseDAO b)
      {
         var a = new PizzaCheese();
         a.Cheese = b.Cheese;
         a.Pizza = b.Pizza;
         return a;
      }

      public static PizzaCheeseDAO MapToPizzaCheeseDAO(PizzaCheese b)
      {
         var a = new PizzaCheeseDAO();
         a.Cheese = b.Cheese;
         a.Pizza = b.Pizza;
         return a;
      }
   }
}