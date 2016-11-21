using PizzaAPI.Models;
using PizzaAPI.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaAPI.Mappers
{
   public class ToppingMap
   {
      public static ToppingDTO MapToToppingDTO(ToppingDAO b)
      {
         var a = new ToppingDTO();
         a.Name = b.Name;
         a.Value = b.Value;
         //a.Id = b.Id;

         //foreach (var item in b.PizzaToppings)
         //{
         //   a.PizzaToppings.Add(PizzaToppingMap.MapToPizzaToppingDTO(item));
         //}
         return a;
      }
      public static ToppingDAO MapToToppingDAO(ToppingDTO b)
      {
         var a = new ToppingDAO();
         a.Name = b.Name;
         a.Value = b.Value;
         //for (int i=0;i< b.PizzaToppings.Count;i++)
         //{
         //   a.PizzaToppings[i]=(PizzaToppingMap.MapToPizzaToppingDAO(b.PizzaToppings.ElementAt(i)));
         //}
         return a;
      }
   }
}