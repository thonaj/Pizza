using PizzaAPI.Models;
using PizzaAPI.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaAPI.Mappers
{
   public class SauceMap
   {
      public static SauceDTO MapToSauceDTO(SauceDAO b)
      {
         var a = new SauceDTO();
         a.Name = b.Name;
         a.Value = b.Value;
         //a.Id = b.Id;
         //foreach (var item in b.Pizzas)
         //{
         //   a.Pizzas.Add(PizzaMap.MapToPizzaDTO(item));
         //}
         return a;
      }
      public static SauceDAO MapToSauceDAO(SauceDTO b)
      {
         var a = new SauceDAO();
         a.Name = b.Name;
         a.Value = b.Value;
         //a.Id = b.Id;
         //for (int i=0;i< b.Pizzas.Count;i++)
         //{
         //   a.Pizzas[i]=(PizzaMap.MapToPizzaDAO(b.Pizzas.ElementAt(i)));
         //}
         return a;
      }
   }
}