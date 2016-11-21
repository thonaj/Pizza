using Piz.DataAccess;
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
         //foreach (var item in b.CustomersDAO)
         //{
         //   a.Customers.Add(CustomerMap.MapToCustomer(item));
         //}
         a.Id = b.Id;
         //foreach (var item in b.StoresDAO)
         //{
         //   a.Stores.Add(StoreMap.MapToStore(item));
         //}
         
         

         return a;
      }
      public static AddressDAO MapToAddressDAO(Address b)
      {
         var a = new AddressDAO();
         a.City = b.City;
         a.State = b.State;
         a.Street = b.Street;
         a.Zip = b.Zip;
         //foreach (var item in b.Customers)
         //{
         //   a.CustomersDAO.Add(CustomerMap.MapToCustomerDAO(item));
         //}
         a.Id = b.Id;
         //foreach (var item in b.Stores)
         //{
         //   a.StoresDAO.Add(StoreMap.MapToStoreDAO(item));
         //}
         return a;
      }
   }
}