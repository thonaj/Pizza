using Pizza.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaService.Models
{
   public class PizzaToppingDAO
   {
      public virtual Pizza.DAL.Pizza Pizza { get; set; }
      public virtual Topping Topping { get; set; }
   }
}
