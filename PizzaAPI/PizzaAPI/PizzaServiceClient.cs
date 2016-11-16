using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PizzaAPI.ServiceReference;
using PizzaAPI.Models;

namespace PizzaAPI
{
   public class PizzaServiceClient
   {
      private Service2Client sc = new Service2Client();

      public List<CrustDTO> getCrusts()
      {
         var list = new List<CrustDTO>();
         foreach (var item in sc.GetCrusts())
         {
            list.Add(Mappers.CrustMap.MapToCrustDTO(item));
         }
         return list;
      }

      public List<CheeseDTO> getCheeses()
      {
         var list = new List<CheeseDTO>();
         foreach (var item in sc.GetCheeses())
         {
            list.Add(Mappers.CheeseMap.MapToCheeseDTO(item));
         }
         return list;
      }
      public List<SauceDTO> getSauces()
      {
         var list = new List<SauceDTO>();
         foreach (var item in sc.GetSaucess())
         {
            list.Add(Mappers.SauceMap.MapToSauceDTO(item));
         }
         return list;
      }
      public List<SizeDTO> getSizes()
      {
         var list = new List<SizeDTO>();
         foreach (var item in sc.GetSizes())
         {
            list.Add(Mappers.SizeMap.MapToSizeDTO(item));
         }
         return list;
      }
      public List<ToppingDTO> getToppings()
      {
         var list = new List<ToppingDTO>();
         foreach (var item in sc.GetToppings())
         {
            list.Add(Mappers.ToppingMap.MapToToppingDTO(item));
         }
         return list;
      }

      public List<AddressDTO> getAddresses()
      {
         var list = new List<AddressDTO>();
         foreach (var item in sc.GetAddresses())
         {
            list.Add(Mappers.AddressMap.MapToAddressDTO(item));
         }
         return list;
      }

      public List<EmailDTO> getEmails()
      {
         var list = new List<EmailDTO>();
         foreach (var item in sc.GetEmails())
         {
            list.Add(Mappers.EmailMap.MapToEmailDTO(item));
         }
         return list;
      }

      public List<NameDTO> getNames()
      {
         var list = new List<NameDTO>();
         foreach (var item in sc.GetNames())
         {
            list.Add(Mappers.NameMap.MapToNameDTO(item));
         }
         return list;
      }

      public List<PhoneDTO> getPhones()
      {
         var list = new List<PhoneDTO>();
         foreach (var item in sc.GetPhones())
         {
            list.Add(Mappers.PhoneMap.MapToPhoneDTO(item));
         }
         return list;
      }
   }
}