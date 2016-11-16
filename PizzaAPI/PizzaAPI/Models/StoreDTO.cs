using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaAPI.Models
{
   public class StoreDTO
   {
      public string LocationId { get; set; }
      public virtual AddressDTO Address { get; set; }
      public virtual ICollection<OrderDTO> Orders { get; set; }
      public virtual PhoneDTO Phone { get; set; }
   }
}