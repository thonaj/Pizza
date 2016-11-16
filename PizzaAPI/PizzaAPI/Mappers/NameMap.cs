using PizzaAPI.Models;
using PizzaAPI.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaAPI.Mappers
{
   public static class NameMap
   {
      public static NameDTO MapToNameDTO(NameDAO b)
      {
         var a = new NameDTO();
         a.First = b.First;
         a.Last = b.Last;
         return a;
      }
      public static NameDAO MapToNameDAO(NameDTO b)
      {
         var a = new NameDAO();
         a.First = b.First;
         a.Last = b.Last;
         return a;
      }

   }
}