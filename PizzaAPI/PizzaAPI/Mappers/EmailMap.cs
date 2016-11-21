using PizzaAPI.Models;
using PizzaAPI.ServiceReference1;
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
         //foreach (var item in b.Customers)
         //{
         //   a.Customers.Add(CustomerMap.MapToCustomerDTO(item));
         //}
         //a.Id = b.Id;
         return a;
      }

      public static EmailDAO MapToEmailDAO(EmailDTO b)
      {
         var a = new EmailDAO();
         a.EmailString = b.EmailString;
         //for (int i=0;i< b.Customers.Count;i++)
         //{
         //   a.Customers[i]=(CustomerMap.MapToCustomerDAO(b.Customers.ElementAt(i)));
         //}
         //a.Id = b.Id;
         return a;
      }
   }
}