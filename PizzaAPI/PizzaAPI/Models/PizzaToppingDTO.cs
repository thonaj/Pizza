using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaAPI.Models
{
   public class PizzaToppingDTO
   {
      public int ToppingId { get; set; }
      public int PizzaId { get; set; }
      public virtual ToppingDTO Topping { get; set; }

      public override string ToString()
      {
         return string.Format("{0}_{1}", PizzaId, ToppingId);
      }
   }
}