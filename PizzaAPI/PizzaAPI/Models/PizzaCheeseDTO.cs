using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaAPI.Models
{
   public class PizzaCheeseDTO
   {
      public virtual CheeseDTO Cheese { get; set; }
      public virtual PizzaDTO Pizza { get; set; }
   }
}