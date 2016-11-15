using PizService.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PizService
{
   // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService2" in both code and config file together.
   [ServiceContract]
   public interface IService2
   {
      #region get DAO's

      [OperationContract]
      List<AddressDAO> GetAddresses();
      [OperationContract]
      List<CheeseDAO> GetCheeses();
      [OperationContract]
      List<CrustDAO> GetCrusts();
      [OperationContract]
      List<CustomerDAO> GetCustomers();
      [OperationContract]
      List<CustomerOrderDAO> GetCustomerOrder();
      [OperationContract]
      List<EmailDAO> GetEmails();
      [OperationContract]
      List<NameDAO> GetNames();
      [OperationContract]
      List<OrderDAO> GetOrders();
      [OperationContract]
      List<PhoneDAO> GetPhones();
      [OperationContract]
      List<PizzaCheeseDAO> GetPizzaCheeses();
      [OperationContract]
      List<PizzaDAO> GetPizzas();
      [OperationContract]
      List<PizzaOrderDAO> GetPizzaOrders();
      [OperationContract]
      List<PizzaToppingDAO> GetPizzaToppings();
      [OperationContract]
      List<SauceDAO> GetSaucess();
      [OperationContract]
      List<SizeDAO> GetSizes();
      [OperationContract]
      List<StoreDAO> GetStores();
      [OperationContract]
      List<ToppingDAO> GetToppings();

      #endregion

      #region insert DAO

      [OperationContract]
      bool InsertAddress(AddressDAO itm);
      [OperationContract]
      bool InsertCheese(CheeseDAO itm);
      [OperationContract]
      bool InsertCrust(CrustDAO itm);
      [OperationContract]
      bool InsertCustomer(CustomerDAO itm);
      [OperationContract]
      bool InsertCustomerOrder(CustomerOrderDAO itm);
      [OperationContract]
      bool InsertEmail(EmailDAO itm);
      [OperationContract]
      bool InsertName(NameDAO itm);
      [OperationContract]
      bool InsertOrder(OrderDAO itm);
      [OperationContract]
      bool InsertPhone(PhoneDAO itm);
      [OperationContract]
      bool InsertPizzaCheese(PizzaCheeseDAO itm);
      [OperationContract]
      bool InsertPizza(PizzaDAO itm);
      [OperationContract]
      bool InsertPizzaOrder(PizzaOrderDAO itm);
      [OperationContract]
      bool InsertPizzaTopping(PizzaToppingDAO itm);
      [OperationContract]
      bool InsertSauce(SauceDAO itm);
      [OperationContract]
      bool InsertSize(SizeDAO itm);
      [OperationContract]
      bool InsertStore(StoreDAO itm);
      [OperationContract]
      bool InsertTopping(ToppingDAO itm);

      #endregion

      #region update DAO

      [OperationContract]
      bool UpdateAddress(AddressDAO itm);
      [OperationContract]
      bool UpdateCheese(CheeseDAO itm);
      [OperationContract]
      bool UpdateCrust(CrustDAO itm);
      [OperationContract]
      bool UpdateCustomer(CustomerDAO itm);
      [OperationContract]
      bool UpdateCustomerOrder(CustomerOrderDAO itm);
      [OperationContract]
      bool UpdateEmail(EmailDAO itm);
      [OperationContract]
      bool UpdateName(NameDAO itm);
      [OperationContract]
      bool UpdateOrder(OrderDAO itm);
      [OperationContract]
      bool UpdatePhone(PhoneDAO itm);
      [OperationContract]
      bool UpdatePizzaCheese(PizzaCheeseDAO itm);
      [OperationContract]
      bool UpdatePizza(PizzaDAO itm);
      [OperationContract]
      bool UpdatePizzaOrder(PizzaOrderDAO itm);
      [OperationContract]
      bool UpdatePizzaTopping(PizzaToppingDAO itm);
      [OperationContract]
      bool UpdateSauce(SauceDAO itm);
      [OperationContract]
      bool UpdateSize(SizeDAO itm);
      [OperationContract]
      bool UpdateStore(StoreDAO itm);
      [OperationContract]
      bool UpdateTopping(ToppingDAO itm);

      #endregion

      #region delete DAO

      [OperationContract]
      bool DeleteAddress(AddressDAO itm);
      [OperationContract]
      bool DeleteCheese(CheeseDAO itm);
      [OperationContract]
      bool DeleteCrust(CrustDAO itm);
      [OperationContract]
      bool DeleteCustomer(CustomerDAO itm);
      [OperationContract]
      bool DeleteCustomerOrder(CustomerOrderDAO itm);
      [OperationContract]
      bool DeleteEmail(EmailDAO itm);
      [OperationContract]
      bool DeleteName(NameDAO itm);
      [OperationContract]
      bool DeleteOrder(OrderDAO itm);
      [OperationContract]
      bool DeletePhone(PhoneDAO itm);
      [OperationContract]
      bool DeletePizzaCheese(PizzaCheeseDAO itm);
      [OperationContract]
      bool DeletePizza(PizzaDAO itm);
      [OperationContract]
      bool DeletePizzaOrder(PizzaOrderDAO itm);
      [OperationContract]
      bool DeletePizzaTopping(PizzaToppingDAO itm);
      [OperationContract]
      bool DeleteSauce(SauceDAO itm);
      [OperationContract]
      bool DeleteSize(SizeDAO itm);
      [OperationContract]
      bool DeleteStore(StoreDAO itm);
      [OperationContract]
      bool DeleteTopping(ToppingDAO itm);

      #endregion
   }
}
