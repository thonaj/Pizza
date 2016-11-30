using Piz.DataAccess;
using PizService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizService.Mapping
{
   public static class PhoneMap
   {
      public static Phone MapToPhone(PhoneDAO b)
      {
         var a = new Phone();
         a.Number = b.Number;
         a.Id = b.Id;
        
         return a;
      }

      public static PhoneDAO MapToPhoneDAO(Phone b)
      {
         var a = new PhoneDAO();
         a.Number = b.Number;
         a.Id = b.Id;
        
         return a;
      }
   }
}