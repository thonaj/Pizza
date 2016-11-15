using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizza.DAL;
using System.Data.Entity;

namespace Pizza.DAL
{
   public class PizzaDataAccess
   {
      PizzaDBEntities db = new PizzaDBEntities();


      #region get Model functions

      public List<Address> getAddresses()
      {
         return db.Addresses.ToList();
      }
      public List<Cheese> getCheeses()
      {
         return db.Cheese.ToList();
      }
      public List<Crust> getCrustss()
      {
         return db.Crusts.ToList();
      }
      public List<Customer> getCustomers()
      {
         return db.Customers.ToList();
      }
      public List<CustomerOrder> getCustomerOrders()
      {
         return db.CustomerOrders.ToList();
      }
      public List<Email> getEmails()
      {
         return db.Emails.ToList();
      }
      public List<Name> getNames()
      {
         return db.Names.ToList();
      }
      public List<Order> getOrders()
      {
         return db.Orders.ToList();
      }
      public List<Phone> getPhones()
      {
         return db.Phones.ToList();
      }
      public List<PizzaCheese> getPizzaCheese()
      {
         return db.PizzaCheese.ToList();
      }
      public List<Pizza> getPizzas()
      {
         return db.Pizzas.ToList();
      }
      public List<PizzaOrder> getPizzaOrders()
      {
         return db.PizzaOrders.ToList();
      }
      public List<PizzaTopping> getPizzaToppings()
      {
         return db.PizzaToppings.ToList();
      }
      public List<Sauce> getSauces()
      {
         return db.Sauces.ToList();
      }
      public List<Size> getSizes()
      {
         return db.Sizes.ToList();
      }
      public List<Store> getStores()
      {
         return db.Stores.ToList();
      }
      public List<Topping> getToppingss()
      {
         return db.Toppings.ToList();
      }



      #endregion

      #region Private Change Functions
      private bool changeAddress(Address itm, EntityState state)
      {
         var entry = db.Entry<Address>(itm);
         entry.State = state;
         return db.SaveChanges() > 0;
      }
      private bool changeCheese(Cheese itm, EntityState state)
      {
         var entry = db.Entry<Cheese>(itm);
         entry.State = state;
         return db.SaveChanges() > 0;
      }
      private bool changeCrust(Crust itm, EntityState state)
      {
         var entry = db.Entry<Crust>(itm);
         entry.State = state;
         return db.SaveChanges() > 0;
      }
      private bool changeCustomer(Customer itm, EntityState state)
      {
         var entry = db.Entry<Customer>(itm);
         entry.State = state;
         return db.SaveChanges() > 0;
      }
      private bool changeCustomerOrder(CustomerOrder itm, EntityState state)
      {
         var entry = db.Entry<CustomerOrder>(itm);
         entry.State = state;
         return db.SaveChanges() > 0;
      }
      private bool changeEmail(Email itm, EntityState state)
      {
         var entry = db.Entry<Email>(itm);
         entry.State = state;
         return db.SaveChanges() > 0;
      }
      private bool changeName(Name itm, EntityState state)
      {
         var entry = db.Entry<Name>(itm);
         entry.State = state;
         return db.SaveChanges() > 0;
      }
      private bool changeOrder(Order itm, EntityState state)
      {
         var entry = db.Entry<Order>(itm);
         entry.State = state;
         return db.SaveChanges() > 0;
      }
      private bool changePhone(Phone itm, EntityState state)
      {
         var entry = db.Entry<Phone>(itm);
         entry.State = state;
         return db.SaveChanges() > 0;
      }
      private bool changePizzaCheese(PizzaCheese itm, EntityState state)
      {
         var entry = db.Entry<PizzaCheese>(itm);
         entry.State = state;
         return db.SaveChanges() > 0;
      }
      private bool changePizza(Pizza itm, EntityState state)
      {
         var entry = db.Entry<Pizza>(itm);
         entry.State = state;
         return db.SaveChanges() > 0;
      }
      private bool changePizzaOrder(PizzaOrder itm, EntityState state)
      {
         var entry = db.Entry<PizzaOrder>(itm);
         entry.State = state;
         return db.SaveChanges() > 0;
      }
      private bool changePizzaTopping(PizzaTopping itm, EntityState state)
      {
         var entry = db.Entry<PizzaTopping>(itm);
         entry.State = state;
         return db.SaveChanges() > 0;
      }
      private bool changeSauce(Sauce itm, EntityState state)
      {
         var entry = db.Entry<Sauce>(itm);
         entry.State = state;
         return db.SaveChanges() > 0;
      }
      private bool changeSize(Size itm, EntityState state)
      {
         var entry = db.Entry<Size>(itm);
         entry.State = state;
         return db.SaveChanges() > 0;
      }
      private bool changeStore(Store itm, EntityState state)
      {
         var entry = db.Entry<Store>(itm);
         entry.State = state;
         return db.SaveChanges() > 0;
      }
      private bool changeTopping(Topping itm, EntityState state)
      {
         var entry = db.Entry<Topping>(itm);
         entry.State = state;
         return db.SaveChanges() > 0;
      }

      #endregion

      #region update functions

      public bool updateAddress(Address itm)
      {
         return changeAddress(itm,EntityState.Modified);
      }
      public bool updateCheese(Cheese itm)
      {
         return changeCheese(itm, EntityState.Modified);
      }
      public bool updateCrust(Crust itm)
      {

         return changeCrust(itm, EntityState.Modified);
      }
      public bool updateCustomer(Customer itm)
      {
         
         return changeCustomer(itm,EntityState.Modified);
      }
      public bool updateCustomerOrder(CustomerOrder itm)
      {
         return changeCustomerOrder(itm, EntityState.Modified);
      }
      public bool updateEmail(Email itm)
      {
         return changeEmail(itm, EntityState.Modified);
      }
      public bool updateName(Name itm)
      {
         return changeName(itm, EntityState.Modified);
      }
      public bool updateOrder(Order itm)
      {
         return changeOrder(itm, EntityState.Modified);
      }
      public bool updatePhone(Phone itm)
      {
         return changePhone(itm, EntityState.Modified);
      }
      public bool updatePizzaCheese(PizzaCheese itm)
      {
         return changePizzaCheese(itm, EntityState.Modified);
      }
      public bool updatePizza(Pizza itm)
      {
         return changePizza(itm, EntityState.Modified);
      }
      public bool UpdatePizzaOrder(PizzaOrder itm)
      {
         return changePizzaOrder(itm, EntityState.Modified);
      }
      public bool updatePizzaTopping(PizzaTopping itm)
      {
         return changePizzaTopping(itm, EntityState.Modified);
      }
      public bool updateSauce(Sauce itm)
      {
         return changeSauce(itm, EntityState.Modified);
      }
      public bool updateSize(Size itm)
      {
         return changeSize(itm, EntityState.Modified);
      }
      public bool updateStore(Store itm)
      {
         return changeStore(itm, EntityState.Modified);
      }
      public bool updateTopping(Topping itm)
      {
         return changeTopping(itm, EntityState.Modified);
      }

      #endregion

      #region delete functions

      public bool deleteAddress(Address itm)
      {
         itm.Active = false;
         return changeAddress(itm, EntityState.Modified);
      }
      public bool deleteCheese(Cheese itm)
      {
         itm.Active = false;
         return changeCheese(itm, EntityState.Modified);
      }
      public bool deleteCrust(Crust itm)
      {
         itm.Active = false;
         return changeCrust(itm, EntityState.Modified);
      }
      public bool deleteCustomer(Customer itm)
      {
         itm.Active = false;
         return changeCustomer(itm, EntityState.Modified);
      }
      public bool deleteCustomerOrder(CustomerOrder itm)
      {
         itm.Active = false;
         return changeCustomerOrder(itm, EntityState.Modified);
      }
      public bool deleteEmail(Email itm)
      {
         itm.Active = false;
         return changeEmail(itm, EntityState.Modified);
      }
      public bool deleteName(Name itm)
      {
         itm.Active = false;
         return changeName(itm, EntityState.Modified);
      }
      public bool deleteOrder(Order itm)
      {
         itm.Active = false;
         return changeOrder(itm, EntityState.Modified);
      }
      public bool deletePhone(Phone itm)
      {
         itm.Active = false;
         return changePhone(itm, EntityState.Modified);
      }
      public bool deletePizzaCheese(PizzaCheese itm)
      {
         itm.Active = false;
         return changePizzaCheese(itm, EntityState.Modified);
      }
      public bool deletePizza(Pizza itm)
      {
         itm.Active = false;
         return changePizza(itm, EntityState.Modified);
      }
      public bool deletePizzaOrder(PizzaOrder itm)
      {
         itm.Active = false;
         return changePizzaOrder(itm, EntityState.Modified);
      }
      public bool deletePizzaTopping(PizzaTopping itm)
      {
         itm.Active = false;
         return changePizzaTopping(itm, EntityState.Modified);
      }
      public bool deleteSauce(Sauce itm)
      {
         itm.Active = false;
         return changeSauce(itm, EntityState.Modified);
      }
      public bool deleteSize(Size itm)
      {
         itm.Active = false;
         return changeSize(itm, EntityState.Modified);
      }
      public bool deleteStore(Store itm)
      {
         itm.Active = false;
         return changeStore(itm, EntityState.Modified);
      }
      public bool deleteTopping(Topping itm)
      {
         itm.Active = false;
         return changeTopping(itm, EntityState.Modified);
      }

      #endregion

      #region Insert Functions

      public bool InsertAddress(Address itm)
      {
         db.Addresses.Add(itm);
         return db.SaveChanges() > 0;
      }
      public bool InsertCheese(Cheese itm)
      {
         db.Cheese.Add(itm);
         return db.SaveChanges() > 0;
      }
      public bool InsertCrust(Crust itm)
      {
         db.Crusts.Add(itm);
         return db.SaveChanges() > 0;
      }
      public bool InsertCustomer(Customer itm)
      {
         db.Customers.Add(itm);
         return db.SaveChanges() > 0;
      }
      public bool InsertCustomerOrder(CustomerOrder itm)
      {
         db.CustomerOrders.Add(itm);
         return db.SaveChanges() > 0;
      }
      public bool InsertEmail(Email itm)
      {
         db.Emails.Add(itm);
         return db.SaveChanges() > 0;
      }
      public bool InsertName(Name itm)
      {
         db.Names.Add(itm);
         return db.SaveChanges() > 0;
      }
      public bool InsertOrder(Order itm)
      {
         db.Orders.Add(itm);
         return db.SaveChanges() > 0;
      }
      public bool InsertPhone(Phone itm)
      {
         db.Phones.Add(itm);
         return db.SaveChanges() > 0;
      }
      public bool InsertPizzaCheese(PizzaCheese itm)
      {
         db.PizzaCheese.Add(itm);
         return db.SaveChanges() > 0;
      }
      public bool InsertPizza(Pizza itm)
      {
         db.Pizzas.Add(itm);
         return db.SaveChanges() > 0;
      }
      public bool InsertPizzaOrder(PizzaOrder itm)
      {
         db.PizzaOrders.Add(itm);
         return db.SaveChanges() > 0;
      }
      public bool InsertPizzaTopping(PizzaTopping itm)
      {
         db.PizzaToppings.Add(itm);
         return db.SaveChanges() > 0;
      }
      public bool InsertSauce(Sauce itm)
      {
         db.Sauces.Add(itm);
         return db.SaveChanges() > 0;
      }
      public bool InsertSize(Size itm)
      {
         db.Sizes.Add(itm);
         return db.SaveChanges() > 0;
      }
      public bool InsertStore(Store itm)
      {
         db.Stores.Add(itm);
         return db.SaveChanges() > 0;
      }
      public bool InsertTopping(Topping itm)
      {
         db.Toppings.Add(itm);
         return db.SaveChanges() > 0;
      }

      #endregion
   }
}
