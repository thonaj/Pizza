using PizzaService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaService.Mapping
{
   public static class PizzaMap
   {
      public static Pizza.DAL.Pizza MapToPizza(PizzaDAO b)
      {
         var a = new Pizza.DAL.Pizza();
         a.Crust = b.Crust;
         a.Sauce = b.Sauce;
         a.Size = b.Size;
         return a;
      }

      public static PizzaDAO MapToPizzaDAO(Pizza.DAL.Pizza b)
      {
         var a = new PizzaDAO();
         a.Crust = b.Crust;
         a.Sauce = b.Sauce;
         a.Size = b.Size;
         return a;
      }
   }
}