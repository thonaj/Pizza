using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaAPI.Models
{
   public class PizzaDTO
   {
      public virtual CrustDTO Crust { get; set; }
      public virtual SauceDTO Sauce { get; set; }
      public virtual SizeDTO Size { get; set; }
      public virtual ICollection<PizzaCheeseDTO> PizzaCheese { get; set; }
      public virtual ICollection<PizzaToppingDTO> PizzaToppings { get; set; }
   }
}