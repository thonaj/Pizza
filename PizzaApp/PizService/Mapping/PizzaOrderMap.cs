using Piz.DataAccess;
using PizService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizService.Mapping
{
   public static class PizzaOrderMap
   {
      public static PizzaOrder MapToPizzaOrder(PizzaOrderDAO b)
      {
         var a = new PizzaOrder();
         a.Order = b.Order;
         a.Pizza = b.Pizza;
         return a;
      }

      public static PizzaOrderDAO MapToPizzaOrderDAO(PizzaOrder b)
      {
         var a = new PizzaOrderDAO();
         a.Order = b.Order;
         a.Pizza = b.Pizza;
         return a;
      }
   }
}