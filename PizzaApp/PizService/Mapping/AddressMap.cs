﻿using Piz.DataAccess;
using PizService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizService.Mapping
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
        
         a.Id = b.Id;
        
         return a;
      }
      public static AddressDAO MapToAddressDAO(Address b)
      {
         var a = new AddressDAO();
         a.City = b.City;
         a.State = b.State;
         a.Street = b.Street;
         a.Zip = b.Zip;
         
         a.Id = b.Id;
        
         return a;
      }
   }
}