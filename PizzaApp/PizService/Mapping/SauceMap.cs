using Piz.DataAccess;
using PizService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizService.Mapping
{
   public static class SauceMap
   {
      public static Sauce MapToSauce(SauceDAO b)
      {
         var a = new Sauce();
         a.Name = b.Name;
         a.Value = b.Value;
         return a;
      }

      public static SauceDAO MapToSauceDAO(Sauce b)
      {
         var a = new SauceDAO();
         a.Name = b.Name;
         a.Value = b.Value;
         return a;
      }
   }
}