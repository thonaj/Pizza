using PizzaAPI.Models;
using PizzaAPI.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaAPI.Mappers
{
   public class SizeMap
   {
      public static SizeDTO MapToSizeDTO(SizeDAO b)
      {
         var a = new SizeDTO();
         a.Name = b.Name;
         a.Value = b.Value;
         //a.Id = b.Id;

         //foreach (var item in b.Pizzas)
         //{
         //   a.Pizzas.Add(PizzaMap.MapToPizzaDTO(item));
         //}
         return a;
      }
      public static SizeDAO MapToSizeDAO(SizeDTO b)
      {
         var a = new SizeDAO();
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