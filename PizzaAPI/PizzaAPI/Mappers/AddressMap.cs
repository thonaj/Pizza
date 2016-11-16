using PizzaAPI.Models;
using PizzaAPI.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaAPI.Mappers
{
   public static class AddressMap
   {
      public static AddressDTO MapToAddressDTO(AddressDAO b)
      {
         var a = new AddressDTO();
         a.City = b.City;
         a.State = b.State;
         a.Street = b.Street;
         a.Zip = b.Zip;
         return a;
      }

      public static AddressDAO MapToAddressDAO(AddressDTO b)
      {
         var a = new AddressDAO();
         a.City = b.City;
         a.State = b.State;
         a.Street = b.Street;
         a.Zip = b.Zip;
         return a;
      }
   }
}