using Pizza.DAL;
using PizzaService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaService.Mapping
{
   public static class CustomerOrderMap
   {
      public static CustomerOrder MapToCustomerOrder(CustomerOrderDAO b)
      {
         var a = new CustomerOrder();
         a.Customer = b.Customer;
         a.Order = b.Order;
         return a;
      }

      public static CustomerOrderDAO MapToCustomerOrderDAO(CustomerOrder b)
      {
         var a = new CustomerOrderDAO();
         a.Customer = b.Customer;
         a.Order = b.Order;
         return a;
      }
   }
}