using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.DAL.Models
{
   class CustomerDAO
   {
      
      public virtual Address Address { get; set; }
      public virtual Name Name { get; set; }
      public virtual Email Email { get; set; }
      public virtual Phone Phone { get; set; }
      public virtual ICollection<CustomerOrder> CustomerOrders { get; set; }
   }
}
