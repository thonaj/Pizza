using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.DAL.Models
{
   class OrderDAO
   {
      public string Name { get; set; }
      public decimal Value { get; set; }
      public virtual Store Store { get; set; }
      public virtual ICollection<PizzaOrder> PizzaOrders { get; set; }
   }
}
