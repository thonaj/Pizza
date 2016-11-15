using Pizza.DAL;
using PizzaService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaService.Mapping
{
   public static class CustomerMap
   {
      public static Customer MapToCustomer(CustomerDAO b)
      {
         var a = new Customer();
         a.Address = b.Address;
         a.Email = b.Email;
         a.Name = b.Name;
         a.Phone = b.Phone;
         return a;

      }

      public static CustomerDAO MapToCustomerDAO(Customer b)
      {
         var a = new CustomerDAO();
         a.Address = b.Address;
         a.Email = b.Email;
         a.Name = b.Name;
         a.Phone = b.Phone;
         return a;

      }
   }
}