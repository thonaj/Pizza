using Pizza.DAL;
using PizzaService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaService.Mapping
{
   public static class OrderMap
   {
      public static Order MapToOrder(OrderDAO b)
      {
         var a = new Order();
         a.Name = b.Name;
         a.Value = b.Value;
         a.Store = b.Store;
         return a;
      }

      public static OrderDAO MapToOrderDAO(Order b)
      {
         var a = new OrderDAO();
         a.Name = b.Name;
         a.Value = b.Value;
         a.Store = b.Store;
         return a;
      }
   }
}