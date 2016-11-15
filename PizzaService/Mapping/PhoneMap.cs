using Pizza.DAL;
using PizzaService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaService.Mapping
{
   public static class PhoneMap
   {
      public static Phone MapToPhone(PhoneDAO b)
      {
         var a = new Phone();
         a.Number = b.Number;
         return a;
      }

      public static PhoneDAO MapToPhoneDAO(Phone b)
      {
         var a = new PhoneDAO();
         a.Number = b.Number;
         return a;
      }
   }
}