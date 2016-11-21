using PizzaAPI.Models;
using PizzaAPI.ServiceReference1;
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
         //foreach (var item in b.CustomersDAO)
         //{
         //   a.CustomersDAO.Add(CustomerMap.MapToCustomerDTO(item));
         //}
         //a.Id = b.Id;
         //foreach (var item in b.StoresDAO)
         //{
         //   a.StoresDAO.Add(StoreMap.MapToStoreDTO(item));
         //}
         return a;
      }

      public static AddressDAO MapToAddressDAO(AddressDTO b)
      {
         var a = new AddressDAO();
         a.City = b.City;
         a.State = b.State;
         a.Street = b.Street;
         a.Zip = b.Zip;
         //for (int i=0;i< b.CustomersDAO.Count;i++)
         //{
         //   a.CustomersDAO[i]=CustomerMap.MapToCustomerDAO(b.CustomersDAO.ElementAt(i));
         //}
         //a.Id = b.Id;
         //for (int x= 0;x< b.StoresDAO.Count;x++)
         //{
         //   a.StoresDAO[x]=StoreMap.MapToStoreDAO(b.StoresDAO.ElementAt(x));
         //}
         return a;
      }
   }
}