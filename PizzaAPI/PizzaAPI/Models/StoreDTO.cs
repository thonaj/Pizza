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
      
      public virtual PhoneDTO Phone { get; set; }
      public int AddressId { get; set; }
      public int PhoneId { get; set; }
      //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
      //public StoreDTO()
      //{
      //   this.Orders = new HashSet<OrderDTO>();
      //}
      //public int Id { get; set; }
     
      //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
      //public virtual ICollection<OrderDTO> Orders { get; set; }
      
   }
}