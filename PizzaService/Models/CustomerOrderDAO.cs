using Pizza.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaService.Models
{
   public class CustomerOrderDAO
   {
      public virtual Customer Customer { get; set; }
      public virtual Order Order { get; set; }
   }
}
