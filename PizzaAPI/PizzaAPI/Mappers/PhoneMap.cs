using PizzaAPI.Models;
using PizzaAPI.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaAPI.Mappers
{
   public class PhoneMap
   {
      public static PhoneDTO MapToPhoneDTO(PhoneDAO b)
      {
         var a = new PhoneDTO();
         a.Number = b.Number;
         return a;
      }

      public static PhoneDAO MapToPhoneDAO(PhoneDTO b)
      {
         var a = new PhoneDAO();
         a.Number = b.Number;
         return a;
      }
   }
}