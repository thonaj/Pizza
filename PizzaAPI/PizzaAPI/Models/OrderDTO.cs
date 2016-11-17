using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaAPI.Models
{
   public class OrderDTO
   {

      [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
      public OrderDTO()
      {
         this.Pizzas = new HashSet<PizzaDTO>();
      }

      public string Name { get; set; }
      public decimal Value { get; set; }
      public int StoreId { get; set; }
      public int CustomerId { get; set; }

      public virtual CustomerDTO Customer { get; set; }
      public virtual StoreDTO Store { get; set; }
      [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
      public virtual ICollection<PizzaDTO> Pizzas { get; set; }
   }
}