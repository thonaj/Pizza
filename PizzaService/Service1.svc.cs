using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using PizzaService.Models;
using Pizza.DAL;

namespace PizzaService
{
   // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
   // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
   public class Service1 : IService1
   {
      PizzaDataAccess da = new PizzaDataAccess();

      #region deletes

      public bool DeleteAddress(AddressDAO itm)
      {
         return da.deleteAddress(Mapping.AddressMap.MapToAddress(itm));
      }

      public bool DeleteCheese(CheeseDAO itm)
      {
         return da.deleteCheese(Mapping.CheeseMap.MapToCheese(itm));
      }

      public bool DeleteCrust(CrustDAO itm)
      {
         return da.deleteCrust(Mapping.CrustMap.MapToCrust(itm));
      }

      public bool DeleteCustomer(CustomerDAO itm)
      {
         return da.deleteCustomer(Mapping.CustomerMap.MapToCustomer(itm));
      }

      public bool DeleteCustomerOrder(CustomerOrderDAO itm)
      {
         return da.deleteCustomerOrder(Mapping.CustomerOrderMap.MapToCustomerOrder(itm));
      }

      public bool DeleteEmail(EmailDAO itm)
      {
         return da.deleteEmail(Mapping.EmailMap.MapToEmail(itm));
      }

      public bool DeleteName(NameDAO itm)
      {
         return da.deleteName(Mapping.NameMap.MapToName(itm));
      }

      public bool DeleteOrder(OrderDAO itm)
      {
         return da.deleteOrder(Mapping.OrderMap.MapToOrder(itm));
      }

      public bool DeletePhone(PhoneDAO itm)
      {
         return da.deletePhone(Mapping.PhoneMap.MapToPhone(itm));
      }

      public bool DeletePizza(PizzaDAO itm)
      {
         return da.deletePizza(Mapping.PizzaMap.MapToPizza(itm));
      }

      public bool DeletePizzaCheese(PizzaCheeseDAO itm)
      {
         return da.deletePizzaCheese(Mapping.PizzaCheeseMap.MapToPizzaCheese(itm));
      }

      public bool DeletePizzaOrder(PizzaOrderDAO itm)
      {
         return da.deletePizzaOrder(Mapping.PizzaOrderMap.MapToPizzaOrder(itm));
      }

      public bool DeletePizzaTopping(PizzaToppingDAO itm)
      {
         return da.deletePizzaTopping(Mapping.PizzaToppingMap.MapToPizzaTopping(itm));
      }

      public bool DeleteSauce(SauceDAO itm)
      {
         return da.deleteSauce(Mapping.SauceMap.MapToSauce(itm));
      }

      public bool DeleteSize(SizeDAO itm)
      {
         return da.deleteSize(Mapping.SizeMap.MapToSize(itm));
      }

      public bool DeleteStore(StoreDAO itm)
      {
         return da.deleteStore(Mapping.StoreMap.MapToStore(itm));
      }

      public bool DeleteTopping(ToppingDAO itm)
      {
         return da.deleteTopping(Mapping.ToppingMap.MapToTopping(itm));
      }
      #endregion

      #region gets

      public List<AddressDAO> GetAddresses()
      {
         List<AddressDAO> list = new List<AddressDAO>();
         foreach (var item in da.getAddresses())
         {
            list.Add(Mapping.AddressMap.MapToAddressDAO(item));
         }
         return list;
      }

      public List<CheeseDAO> GetCheeses()
      {
         List<CheeseDAO> list = new List<CheeseDAO>();
         foreach (var item in da.getCheeses())
         {
            list.Add(Mapping.CheeseMap.MapToCheeseDAO(item));
         }
         return list;
      }

      public List<CrustDAO> GetCrusts()
      {
         List<CrustDAO> list = new List<CrustDAO>();
         foreach (var item in da.getCrustss())
         {
            list.Add(Mapping.CrustMap.MapToCrustDAO(item));
         }
         return list;
      }

      public List<CustomerOrderDAO> GetCustomerOrder()
      {
         List<CustomerOrderDAO> list = new List<CustomerOrderDAO>();
         foreach (var item in da.getCustomerOrders())
         {
            list.Add(Mapping.CustomerOrderMap.MapToCustomerOrderDAO(item));
         }
         return list;
      }

      public List<CustomerDAO> GetCustomers()
      {
         List<CustomerDAO> list = new List<CustomerDAO>();
         foreach (var item in da.getCustomers())
         {
            list.Add(Mapping.CustomerMap.MapToCustomerDAO(item));
         }
         return list;
      }

      public List<EmailDAO> GetEmails()
      {
         List<EmailDAO> list = new List<EmailDAO>();
         foreach (var item in da.getEmails())
         {
            list.Add(Mapping.EmailMap.MapToEmailDAO(item));
         }
         return list;
      }

      public List<NameDAO> GetNames()
      {
         List<NameDAO> list = new List<NameDAO>();
         foreach (var item in da.getNames())
         {
            list.Add(Mapping.NameMap.MapToNameDAO(item));
         }
         return list;
      }

      public List<OrderDAO> GetOrders()
      {
         List<OrderDAO> list = new List<OrderDAO>();
         foreach (var item in da.getOrders())
         {
            list.Add(Mapping.OrderMap.MapToOrderDAO(item));
         }
         return list;
      }

      public List<PhoneDAO> GetPhones()
      {
         List<PhoneDAO> list = new List<PhoneDAO>();
         foreach (var item in da.getPhones())
         {
            list.Add(Mapping.PhoneMap.MapToPhoneDAO(item));
         }
         return list;
      }

      public List<PizzaCheeseDAO> GetPizzaCheeses()
      {
         List<PizzaCheeseDAO> list = new List<PizzaCheeseDAO>();
         foreach (var item in da.getPizzaCheese())
         {
            list.Add(Mapping.PizzaCheeseMap.MapToPizzaCheeseDAO(item));
         }
         return list;
      }

      public List<PizzaOrderDAO> GetPizzaOrders()
      {
         List<PizzaOrderDAO> list = new List<PizzaOrderDAO>();
         foreach (var item in da.getPizzaOrders())
         {
            list.Add(Mapping.PizzaOrderMap.MapToPizzaOrderDAO(item));
         }
         return list;
      }

      public List<PizzaDAO> GetPizzas()
      {
         List<PizzaDAO> list = new List<PizzaDAO>();
         foreach (var item in da.getPizzas())
         {
            list.Add(Mapping.PizzaMap.MapToPizzaDAO(item));
         }
         return list;
      }

      public List<PizzaToppingDAO> GetPizzaToppings()
      {
         List<PizzaToppingDAO> list = new List<PizzaToppingDAO>();
         foreach (var item in da.getPizzaToppings())
         {
            list.Add(Mapping.PizzaToppingMap.MapToPizzaToppingDAO(item));
         }
         return list;
      }

      public List<SauceDAO> GetSaucess()
      {
         List<SauceDAO> list = new List<SauceDAO>();
         foreach (var item in da.getSauces())
         {
            list.Add(Mapping.SauceMap.MapToSauceDAO(item));
         }
         return list;
      }

      public List<SizeDAO> GetSizes()
      {
         List<SizeDAO> list = new List<SizeDAO>();
         foreach (var item in da.getSizes())
         {
            list.Add(Mapping.SizeMap.MapToSizeDAO(item));
         }
         return list;
      }

      public List<StoreDAO> GetStores()
      {
         List<StoreDAO> list = new List<StoreDAO>();
         foreach (var item in da.getStores())
         {
            list.Add(Mapping.StoreMap.MapToStoreDAO(item));
         }
         return list;
      }

      public List<ToppingDAO> GetToppings()
      {
         List<ToppingDAO> list = new List<ToppingDAO>();
         foreach (var item in da.getToppingss())
         {
            list.Add(Mapping.ToppingMap.MapToToppingDAO(item));
         }
         return list;
      }

      #endregion

      #region inserts

      public bool InsertAddress(AddressDAO itm)
      {
         var a = Mapping.AddressMap.MapToAddress(itm);
         a.Active = true;

         return da.InsertAddress(a);
      }

      public bool InsertCheese(CheeseDAO itm)
      {
         var a = Mapping.CheeseMap.MapToCheese(itm);
         a.Active = true;
         return da.InsertCheese(a);
      }

      public bool InsertCrust(CrustDAO itm)
      {
         var a = Mapping.CrustMap.MapToCrust(itm);
         a.Active = true;
         return da.InsertCrust(a);
      }

      public bool InsertCustomer(CustomerDAO itm)
      {
         var a = Mapping.CustomerMap.MapToCustomer(itm);
         a.Active = true;
         return da.InsertCustomer(a);
      }

      public bool InsertCustomerOrder(CustomerOrderDAO itm)
      {
         var a = Mapping.CustomerOrderMap.MapToCustomerOrder(itm);
         a.Active = true;
         return da.InsertCustomerOrder(a);
      }

      public bool InsertEmail(EmailDAO itm)
      {
         var a = Mapping.EmailMap.MapToEmail(itm);
         a.Active = true;
         return da.InsertEmail(a);
      }

      public bool InsertName(NameDAO itm)
      {
         var a = Mapping.NameMap.MapToName(itm);
         a.Active = true;
         return da.InsertName(a);
      }

      public bool InsertOrder(OrderDAO itm)
      {
         var a = Mapping.OrderMap.MapToOrder(itm);
         a.Active = true;
         return da.InsertOrder(a);
      }

      public bool InsertPhone(PhoneDAO itm)
      {
         var a = Mapping.PhoneMap.MapToPhone(itm);
         a.Active = true;
         return da.InsertPhone(a);
      }

      public bool InsertPizza(PizzaDAO itm)
      {
         var a = Mapping.PizzaMap.MapToPizza(itm);
         a.Active = true;
         return da.InsertPizza(a);
      }

      public bool InsertPizzaCheese(PizzaCheeseDAO itm)
      {
         var a = Mapping.PizzaCheeseMap.MapToPizzaCheese(itm);
         a.Active = true;
         return da.InsertPizzaCheese(a);
      }

      public bool InsertPizzaOrder(PizzaOrderDAO itm)
      {
         var a = Mapping.PizzaOrderMap.MapToPizzaOrder(itm);
         a.Active = true;
         return da.InsertPizzaOrder(a);
      }

      public bool InsertPizzaTopping(PizzaToppingDAO itm)
      {
         var a = Mapping.PizzaToppingMap.MapToPizzaTopping(itm);
         a.Active = true;
         return da.InsertPizzaTopping(a);
      }

      public bool InsertSauce(SauceDAO itm)
      {
         var a = Mapping.SauceMap.MapToSauce(itm);
         a.Active = true;
         return da.InsertSauce(a);
      }

      public bool InsertSize(SizeDAO itm)
      {
         var a = Mapping.SizeMap.MapToSize(itm);
         a.Active = true;
         return da.InsertSize(a);
      }

      public bool InsertStore(StoreDAO itm)
      {
         var a = Mapping.StoreMap.MapToStore(itm);
         a.Active = true;
         return da.InsertStore(a);
      }

      public bool InsertTopping(ToppingDAO itm)
      {
         var a = Mapping.ToppingMap.MapToTopping(itm);
         a.Active = true;
         return da.InsertTopping(a);
      }

      #endregion

      #region updates

      public bool UpdateAddress(AddressDAO itm)
      {
         return da.updateAddress(Mapping.AddressMap.MapToAddress(itm));
      }

      public bool UpdateCheese(CheeseDAO itm)
      {
         return da.updateCheese(Mapping.CheeseMap.MapToCheese(itm));
      }

      public bool UpdateCrust(CrustDAO itm)
      {
         return da.updateCrust(Mapping.CrustMap.MapToCrust(itm));
      }

      public bool UpdateCustomer(CustomerDAO itm)
      {
         return da.updateCustomer(Mapping.CustomerMap.MapToCustomer(itm));
      }

      public bool UpdateCustomerOrder(CustomerOrderDAO itm)
      {
         return da.updateCustomerOrder(Mapping.CustomerOrderMap.MapToCustomerOrder(itm));
      }

      public bool UpdateEmail(EmailDAO itm)
      {
         return da.updateEmail(Mapping.EmailMap.MapToEmail(itm));
      }

      public bool UpdateName(NameDAO itm)
      {
         return da.updateName(Mapping.NameMap.MapToName(itm));
      }

      public bool UpdateOrder(OrderDAO itm)
      {
         return da.updateOrder(Mapping.OrderMap.MapToOrder(itm));
      }

      public bool UpdatePhone(PhoneDAO itm)
      {
         return da.updatePhone(Mapping.PhoneMap.MapToPhone(itm));
      }

      public bool UpdatePizza(PizzaDAO itm)
      {
         return da.updatePizza(Mapping.PizzaMap.MapToPizza(itm));
      }

      public bool UpdatePizzaCheese(PizzaCheeseDAO itm)
      {
         return da.updatePizzaCheese(Mapping.PizzaCheeseMap.MapToPizzaCheese(itm));
      }

      public bool UpdatePizzaOrder(PizzaOrderDAO itm)
      {
         return da.UpdatePizzaOrder(Mapping.PizzaOrderMap.MapToPizzaOrder(itm));
      }

      public bool UpdatePizzaTopping(PizzaToppingDAO itm)
      {
         return da.updatePizzaTopping(Mapping.PizzaToppingMap.MapToPizzaTopping(itm));
      }

      public bool UpdateSauce(SauceDAO itm)
      {
         return da.updateSauce(Mapping.SauceMap.MapToSauce(itm));
      }

      public bool UpdateSize(SizeDAO itm)
      {
         return da.updateSize(Mapping.SizeMap.MapToSize(itm));
      }

      public bool UpdateStore(StoreDAO itm)
      {
         return da.updateStore(Mapping.StoreMap.MapToStore(itm));
      }

      public bool UpdateTopping(ToppingDAO itm)
      {
         return da.updateTopping(Mapping.ToppingMap.MapToTopping(itm));
      }
      #endregion
   }
}
