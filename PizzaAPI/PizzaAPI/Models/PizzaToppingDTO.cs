using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaAPI.Models
{
   public class PizzaToppingDTO
   {
      public virtual PizzaDTO Pizza { get; set; }
      public virtual ToppingDTO Topping { get; set; }
   }
}