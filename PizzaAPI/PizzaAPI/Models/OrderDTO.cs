using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaAPI.Models
{
   public class OrderDTO
   {
      
      public string Name { get; set; }
      public decimal Value { get; set; }
      public virtual StoreDTO Store { get; set; }
      public virtual ICollection<PizzaOrderDTO> PizzaOrders { get; set; }
   }
}