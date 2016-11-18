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
      

      #region gets
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
      public List<CustomerDTO> getCustomers()
      {
         var list = new List<CustomerDTO>();
         foreach (var item in sc.GetCustomers())
         {
            list.Add(Mappers.CustomerMap.MapToCustomerDTO(item));
         }
         return list;
      }

      public List<OrderDTO> getOrders()
      {
         var list = new List<OrderDTO>();
         foreach (var item in sc.GetOrders())
         {
            list.Add(Mappers.OrderMap.MapToOrderDTO(item));
         }
         return list;
      }

      public List<PizzaCheeseDTO> getPizzaCheese()
      {
         var list = new List<PizzaCheeseDTO>();
         foreach (var item in sc.GetPizzaCheeses())
         {
            list.Add(Mappers.PizzaCheeseMap.MapToPizzaCheeseDTO(item));
         }
         return list;
      }

      public List<PizzaDTO> getPizzas()
      {
         var list = new List<PizzaDTO>();
         foreach (var item in sc.GetPizzas())
         {
            list.Add(Mappers.PizzaMap.MapToPizzaDTO(item));
         }
         return list;
      }
      public List<PizzaToppingDTO> getPizzaToppings()
      {
         var list = new List<PizzaToppingDTO>();
         foreach (var item in sc.GetPizzaToppings())
         {
            list.Add(Mappers.PizzaToppingMap.MapToPizzaToppingDTO(item));
         }
         return list;
      }

      public List<StoreDTO> getStore()
      {
         var list = new List<StoreDTO>();
         foreach (var item in sc.GetStores())
         {
            list.Add(Mappers.StoreMap.MapToStoreDTO(item));
         }
         return list;
      }
      #endregion

      #region post
      public bool insertTopping(ToppingDTO t)
      {
         return sc.InsertTopping(Mappers.ToppingMap.MapToToppingDAO(t));
         
      }

      public bool insertSize(SizeDTO t)
      {
         return sc.InsertSize(Mappers.SizeMap.MapToSizeDAO(t));
      }

      public bool insertSauce(SauceDTO t)
      {
         return sc.InsertSauce(Mappers.SauceMap.MapToSauceDAO(t));
      }

      public bool insertPhone(PhoneDTO t)
      {
         return sc.InsertPhone(Mappers.PhoneMap.MapToPhoneDAO(t));
      }

      public bool insertName(NameDTO t)
      {
         return sc.InsertName(Mappers.NameMap.MapToNameDAO(t));
      }

      public bool insertEmail(EmailDTO t)
      {
         return sc.InsertEmail(Mappers.EmailMap.MapToEmailDAO(t));
      }

      public bool insertCheese(CheeseDTO t)
      {
         return sc.InsertCheese(Mappers.CheeseMap.MapToCheeseDAO(t));
      }

      public bool insertCrust(CrustDTO t)
      {
         return sc.InsertCrust(Mappers.CrustMap.MapToCrustDAO(t));
      }

      public bool insertAddress(AddressDTO t)
      {
         return sc.InsertAddress(Mappers.AddressMap.MapToAddressDAO(t));
      }

      public bool insertStore(StoreDTO t)
      {
         //sc.InsertPhone(Mappers.PhoneMap.MapToPhoneDAO(t.Phone));
         
         return sc.InsertStore(Mappers.StoreMap.MapToStoreDAO(t));
      }
      public bool insertCustomer(CustomerDTO t)
      {
         return sc.InsertCustomer(Mappers.CustomerMap.MapToCustomerDAO(t));
      }
      public bool insertPizza(PizzaDTO t)
      {
         return sc.InsertPizza(Mappers.PizzaMap.MapToPizzaDAO(t));
      }
      public bool insertOrder(OrderDTO t)
      {
         return sc.InsertOrder(Mappers.OrderMap.MapToOrderDAO(t));
      }
      public bool insertPizzaCheese(PizzaCheeseDTO t)
      {
         return sc.InsertPizzaCheese(Mappers.PizzaCheeseMap.MapToPizzaCheeseDAO(t));
      }
      public bool insertPizzaTopping(PizzaToppingDTO t)
      {
         return sc.InsertPizzaTopping(Mappers.PizzaToppingMap.MapToPizzaToppingDAO(t));
      }





      #endregion

      #region puts

      public bool updateTopping(ToppingDTO t)
      {
         return sc.UpdateTopping(Mappers.ToppingMap.MapToToppingDAO(t));
      }

      #endregion

      #region deletes
      public bool deleteTopping(ToppingDTO t)
      {
         return sc.DeleteTopping(Mappers.ToppingMap.MapToToppingDAO(t));
      }
      #endregion
   }
}