using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.DAL.Models
{
   class PizzaDAO
   {
      public virtual Crust Crust { get; set; }
      public virtual Sauce Sauce { get; set; }
      public virtual Size Size { get; set; }
      public virtual ICollection<PizzaCheese> PizzaCheese { get; set; }
      public virtual ICollection<PizzaTopping> PizzaToppings { get; set; }
   }
}
