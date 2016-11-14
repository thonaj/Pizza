using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.DAL.Models
{
   class PizzaCheeseDAO
   {
      public virtual Cheese Cheese { get; set; }
      public virtual Pizza Pizza { get; set; }
   }
}
