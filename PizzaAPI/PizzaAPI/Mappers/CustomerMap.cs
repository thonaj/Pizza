using PizzaAPI.Models;
using PizzaAPI.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaAPI.Mappers
{
   public static class CustomerMap
   {
      public static CustomerDTO MapToCustomerDTO(CustomerDAO b)
      {
         var a = new CustomerDTO();
         a.Address = AddressMap.MapToAddressDTO(b.Address);
         a.AddressId = b.AddressId;
         a.Email = EmailMap.MapToEmailDTO(b.Email);
         a.EmailId = b.EmailId;
         a.Name = NameMap.MapToNameDTO(b.Name);
         a.NameId = b.NameId;
         a.Phone = PhoneMap.MapToPhoneDTO(b.Phone);
         a.PhoneId = b.PhoneId;
         if(b.Orders!=null)
         {
            foreach (var item in b.Orders)
            {
               a.Orders.Add(OrderMap.MapToOrderDTO(item));
            }
         }
         
         return a;
      }

      public static CustomerDAO MapToCustomerDAO(CustomerDTO b)
      {
         var a = new CustomerDAO();
         a.Address = AddressMap.MapToAddressDAO(b.Address);
         a.AddressId = b.AddressId;
         a.Email = EmailMap.MapToEmailDAO(b.Email);
         a.EmailId = b.EmailId;
         a.Name = NameMap.MapToNameDAO(b.Name);
         a.NameId = b.NameId;
         a.Phone = PhoneMap.MapToPhoneDAO(b.Phone);
         a.PhoneId = b.PhoneId;

         
         
         return a;
      }
   }
}