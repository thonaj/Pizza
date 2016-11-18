using Piz.DataAccess;
using PizService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizService.Mapping
{
   public static class CustomerMap
   {
      public static Customer MapToCustomer(CustomerDAO b)
      {
         var a = new Customer();
         a.Address = AddressMap.MapToAddress(b.Address);
         a.Email = EmailMap.MapToEmail(b.Email);
         a.Name = NameMap.MapToName(b.Name);
         a.Phone = PhoneMap.MapToPhone(b.Phone);
         a.AddressId = b.AddressId;         
         a.EmailId = b.EmailId;
         a.NameId = b.NameId;
         a.PhoneId = b.PhoneId;
         if(b.Orders!=null)
         {
            foreach (var item in b.Orders)
            {
               a.Orders.Add(OrderMap.MapToOrder(item));
            }

         }
             
         
         return a;

      }

      public static CustomerDAO MapToCustomerDAO(Customer b)
      {
         var a = new CustomerDAO();
         a.Address = AddressMap.MapToAddressDAO(b.Address);
         a.Email = EmailMap.MapToEmailDAO(b.Email);
         a.Name = NameMap.MapToNameDAO(b.Name);
         a.Phone = PhoneMap.MapToPhoneDAO(b.Phone);
         a.AddressId = b.AddressId;
         a.EmailId = b.EmailId;
         a.NameId = b.NameId;
         a.PhoneId = b.PhoneId;
         foreach (var item in b.Orders)
         {
            a.Orders.Add(OrderMap.MapToOrderDAO(item));
         }
         return a;

      }
   }
}