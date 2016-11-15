using Pizza.DAL;
using PizzaService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaService.Mapping
{
   public static class EmailMap
   {
      public static Email MapToEmail(EmailDAO b)
      {
         var a = new Email();
         a.EmailString = b.EmailString;
         return a;
      }

      public static EmailDAO MapToEmailDAO(Email b)
      {
         var a = new EmailDAO();
         a.EmailString = b.EmailString;
         return a;
      }
   }
}