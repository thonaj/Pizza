using Pizza.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaService.Models
{
   public class StoreDAO
   {
      public string LocationId { get; set; }
      public virtual Address Address { get; set; }
      public virtual ICollection<Order> Orders { get; set; }
      public virtual Phone Phone { get; set; }
   }
}
