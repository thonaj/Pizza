using PizzaAPI.Models;
using PizzaAPI.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaAPI.Mappers
{
   public static class OrderMap
   {
      public static OrderDTO MapToOrderDTO(OrderDAO b)
      {
         var a = new OrderDTO();
         a.Name = b.Name;
         a.Store = StoreMap.MapToStoreDTO(b.Store);
         a.StoreId = b.StoreId;
         a.Value = b.Value;
         a.Customer = CustomerMap.MapToCustomerDTO(b.Customer);
         
         foreach (var item in b.Pizzas)
         {
            a.Pizzas.Add(PizzaMap.MapToPizzaDTO(item));
         }
         return a;
      }

      public static OrderDAO MapToOrderDAO(OrderDTO b)
      {
         var a = new OrderDAO();
         a.Name = b.Name;
         a.Store = StoreMap.MapToStoreDAO(b.Store);
         a.StoreId = b.StoreId;
         a.Value = b.Value;
         a.Customer = CustomerMap.MapToCustomerDAO(b.Customer);
         
         
         return a;
      }
   }
}