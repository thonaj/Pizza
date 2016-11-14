using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.DAL.Models
{
   class PizzaToppingDAO
   {
      public virtual Pizza Pizza { get; set; }
      public virtual Topping Topping { get; set; }
   }
}
