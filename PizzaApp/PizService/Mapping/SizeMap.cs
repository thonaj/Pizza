using Piz.DataAccess;
using PizService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizService.Mapping
{
   public static class SizeMap
   {
      public static Size MapToSize(SizeDAO b)
      {
         var a = new Size();
         a.Name = b.Name;
         a.Value = b.Value;
         a.Id = b.Id;
         
         //foreach (var item in b.Pizzas)
         //{
         //   a.Pizzas.Add(PizzaMap.MapToPizza(item));
         //}
         return a;
      }
      public static SizeDAO MapToSizeDAO(Size b)
      {
         var a = new SizeDAO();
         a.Name = b.Name;
         a.Value = b.Value.GetValueOrDefault();
         a.Id = b.Id;
         //foreach (var item in b.Pizzas)
         //{
         //   a.Pizzas.Add(PizzaMap.MapToPizzaDAO(item));
         //}
         return a;
      }
   }
}