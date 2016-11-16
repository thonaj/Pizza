using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaAPI.Models
{
   public class PizzaOrderDTO
   {
      public virtual OrderDTO Order { get; set; }
      public virtual PizzaDTO Pizza { get; set; }
   }
}