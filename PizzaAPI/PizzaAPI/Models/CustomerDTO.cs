﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaAPI.Models
{
   public class CustomerDTO
   {

      public int NameId { get; set; }
      public int AddressId { get; set; }
      public int PhoneId { get; set; }
      public int EmailId { get; set; }
      public virtual AddressDTO Address { get; set; }
      public virtual NameDTO Name { get; set; }
      public virtual EmailDTO Email { get; set; }
      public virtual PhoneDTO Phone { get; set; }
      [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
      public virtual ICollection<OrderDTO> Orders { get; set; }

      

   }
}