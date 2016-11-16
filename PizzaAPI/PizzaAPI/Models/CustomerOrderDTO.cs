using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaAPI.Models
{
   public class CustomerOrderDTO
   {
      public virtual CustomerDTO Customer { get; set; }
      
      public virtual OrderDTO Order { get; set; }
   }
}