using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Piz.DataAccess;
using Xunit;

namespace PizzaApp.test
{
   
    public class Class1
    {
      private EF.PizzaDataAccess da = new EF.PizzaDataAccess();
      [Fact]
      public void testGetAdresses()
      {
         List<Address> result = da.getAddresses();
         Assert.NotNull(result);
      }

      [Fact]
      public void testGetCheeses()
      {
         List<Cheese> result = da.getCheeses();
         Assert.NotNull(result);
      }

      [Fact]
      public void testGetCrusts()
      {
         List<Crust> result = da.getCrustss();
         Assert.NotNull(result);
      }

      [Fact]
      public void testGetCustomers()
      {
         List<Customer> result = da.getCustomers();
         Assert.NotNull(result);
      }
   }
}
