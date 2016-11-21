using PizzaAPI.Models;
using PizzaAPI.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaAPI.Mappers
{
   public static class CheeseMap
   {
      public static CheeseDTO MapToCheeseDTO(CheeseDAO b)
      {
         var a = new CheeseDTO();
         a.Name = b.Name;
         a.Value = b.Value;
         //a.Id = b.Id;
         //foreach (var item in b.PizzaCheeseDAO)
         //{
         //   a.PizzaCheeseDAO.Add(PizzaCheeseMap.MapToPizzaCheeseDTO(item));
         //}
         return a;
      }
      public static CheeseDAO MapToCheeseDAO(CheeseDTO b)
      {
         var a = new CheeseDAO();
         a.Name = b.Name;
         a.Value = b.Value;
         //a.Id = b.Id;
         //for (int i=0; i<b.PizzaCheeseDAO.Count;i++)
         //{
         //   a.PizzaCheeseDAO[i]=PizzaCheeseMap.MapToPizzaCheeseDAO(b.PizzaCheeseDAO.ElementAt(i));
         //}
         return a;
      }
   }
}