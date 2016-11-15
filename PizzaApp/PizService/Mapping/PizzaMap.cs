using PizService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Piz.DataAccess;

namespace PizService.Mapping
{
   public static class PizzaMap
   {
      public static Pizza MapToPizza(PizzaDAO b)
      {
         var a = new Pizza();
         a.Crust = b.Crust;
         a.Sauce = b.Sauce;
         a.Size = b.Size;
         return a;
      }

      public static PizzaDAO MapToPizzaDAO(Pizza b)
      {
         var a = new PizzaDAO();
         a.Crust = b.Crust;
         a.Sauce = b.Sauce;
         a.Size = b.Size;
         return a;
      }
   }
}