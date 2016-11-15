using Pizza.DAL;
using PizzaService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaService.Mapping
{
   public static class AddressMap
   {
      public static Address MapToAddress(AddressDAO b)
      {
         var a = new Address();
         a.City = b.City;
         a.State = b.State;
         a.Street = b.Street;
         a.Zip = b.Zip;

         return a;
      }
      public static AddressDAO MapToAddressDAO(Address b)
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