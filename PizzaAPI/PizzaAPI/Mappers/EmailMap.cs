using PizzaAPI.Models;
using PizzaAPI.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaAPI.Mappers
{
   public class EmailMap
   {
      public static EmailDTO MapToEmailDTO(EmailDAO b)
      {
         var a = new EmailDTO();
         a.EmailString = b.EmailString;
         return a;
      }

      public static EmailDAO MapToEmailDAO(EmailDTO b)
      {
         var a = new EmailDAO();
         a.EmailString = b.EmailString;
         return a;
      }
   }
}