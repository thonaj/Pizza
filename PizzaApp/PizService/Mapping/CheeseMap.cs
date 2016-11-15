using Piz.DataAccess;
using PizService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizService.Mapping
{
   public static class CheeseMap
   {
      public static Cheese MapToCheese(CheeseDAO b)
      {
         var a = new Cheese();
         a.Name = b.Name;
         a.Value = b.Value;
         return a;
      }
      public static CheeseDAO MapToCheeseDAO(Cheese b)
      {
         var a = new CheeseDAO();
         a.Name = b.Name;
         a.Value = b.Value;
         return a;
      }

   }
}