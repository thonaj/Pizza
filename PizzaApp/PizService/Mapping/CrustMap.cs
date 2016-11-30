using Piz.DataAccess;
using PizService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizService.Mapping
{
   public static class CrustMap
   {
      public static Crust MapToCrust(CrustDAO b)
      {
         var a = new Crust();
         a.Name = b.Name;
         a.Value = b.Value;
         a.Id = b.Id;
         
         return a;
      }
      public static CrustDAO MapToCrustDAO(Crust b)
      {
         var a = new CrustDAO();
         a.Name = b.Name;
         a.Value = b.Value;
         a.Id = b.Id;
        
         return a;
      }
   }
}