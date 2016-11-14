using Pizza.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaService.Models
{
   public class PizzaCheeseDAO
   {
      public virtual Cheese Cheese { get; set; }
      public virtual Pizza.DAL.Pizza Pizza { get; set; }
   }
}
