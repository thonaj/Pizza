using PizzaAPI.Models;
using PizzaAPI.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaAPI.Mappers
{
   public class PizzaCheeseMap
   {
      public static PizzaCheeseDTO MapToPizzaCheeseDTO(PizzaCheeseDAO b)
      {
         var a = new PizzaCheeseDTO();
         a.Cheese = CheeseMap.MapToCheeseDTO(b.Cheese);
         a.CheeseId = b.CheeseId;
         a.PizzaId = b.PizzaId;
         //a.Id = b.Id;
         a.Pizza = PizzaMap.MapToPizzaDTO(b.Pizza);
         return a;
      }

      public static PizzaCheeseDAO MapToPizzaCheeseDAO(PizzaCheeseDTO b)
      {
         var a = new PizzaCheeseDAO();
         a.Cheese = CheeseMap.MapToCheeseDAO(b.Cheese);
         a.CheeseId = b.CheeseId;
         a.PizzaId = b.PizzaId;
         //a.Id = b.Id;
         a.Pizza = PizzaMap.MapToPizzaDAO(b.Pizza);
         return a;
      }
   }
}