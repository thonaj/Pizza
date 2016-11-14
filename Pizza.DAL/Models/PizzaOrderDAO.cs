using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.DAL.Models
{
   class PizzaOrderDAO
   {
      public virtual Order Order { get; set; }
      public virtual Pizza Pizza { get; set; }
   }
}
