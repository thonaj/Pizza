using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaAPI.Models
{
   public class CustomerDTO
   {
      
      public virtual AddressDTO Address { get; set; }
      
      public virtual NameDTO Name { get; set; }
      
      public virtual EmailDTO Email { get; set; }
      
      public virtual PhoneDTO Phone { get; set; }
      
      public virtual ICollection<CustomerOrderDTO> CustomerOrders { get; set; }
   }
}