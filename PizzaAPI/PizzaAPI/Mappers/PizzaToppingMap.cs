﻿using PizzaAPI.Models;
using PizzaAPI.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaAPI.Mappers
{
   public class PizzaToppingMap
   {
      public static PizzaToppingDTO MapToPizzaToppingDTO(PizzaToppingDAO b)
      {
         var a = new PizzaToppingDTO();
         a.PizzaId = b.PizzaId;
         a.Topping = ToppingMap.MapToToppingDTO(b.Topping);
         a.ToppingId = b.ToppingId;
         //a.Id = b.Id;
         a.Pizza = PizzaMap.MapToPizzaDTO(b.Pizza);
         return a;
      }

      public static PizzaToppingDAO MapToPizzaToppingDAO(PizzaToppingDTO b)
      {
         var a = new PizzaToppingDAO();
         a.PizzaId = b.PizzaId;
         a.Topping = ToppingMap.MapToToppingDAO(b.Topping);
         a.ToppingId = b.ToppingId;
         //a.Id = b.Id;
         a.Pizza = PizzaMap.MapToPizzaDAO(b.Pizza);
         return a;
      }
   }
}