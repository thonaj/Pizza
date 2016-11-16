using Piz.DataAccess;
using PizService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizService.Mapping
{
   public static class OrderMap
   {
      public static Order MapToOrder(OrderDAO b)
      {
         var a = new Order();
         a.Name = b.Name;
         a.Value = b.Value;
         a.Store = StoreMap.MapToStore(b.Store);
         a.Customer = CustomerMap.MapToCustomer(b.Customer);
         a.CustomerId = b.CustomerId;         
         a.StoreId = b.StoreId;
         foreach (var item in b.Pizzas)
         {
            a.Pizzas.Add(PizzaMap.MapToPizza(item));
         }
         return a;
      }

      public static OrderDAO MapToOrderDAO(Order b)
      {
         var a = new OrderDAO();
         a.Name = b.Name;
         a.Value = b.Value;
         a.Store = StoreMap.MapToStoreDAO(b.Store);
         a.Customer = CustomerMap.MapToCustomerDAO(b.Customer);
         a.CustomerId = b.CustomerId;
         foreach (var item in b.Pizzas)
         {
            a.Pizzas.Add(PizzaMap.MapToPizzaDAO(item));
         }
         a.StoreId = b.StoreId;

         return a;
      }
   }
}