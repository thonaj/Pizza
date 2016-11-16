using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaAPI.Models
{
   public class AddressDTO
   {
      public string Street { get; set; }
      
      public string City { get; set; }
     
      public string State { get; set; }
     
      public string Zip { get; set; }

      public override string ToString()
      {
         return string.Format("{0}_{1}_{2}_{3}", Street, City, State, Zip);
      }
   }
}