using PizzaAPI.Models;
using PizzaAPI.ServiceReference;
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
         return a;
      }
      public static SizeDAO MapToSizeDAO(SizeDTO b)
      {
         var a = new SizeDAO();
         a.Name = b.Name;
         a.Value = b.Value;
         return a;
      }
   }
}