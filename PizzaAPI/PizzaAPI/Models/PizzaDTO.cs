using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaAPI.Models
{
   public class PizzaDTO
   {
      public string Name { get; set; }
      public int CrustId { get; set; }
      public int SauceId { get; set; }
      public int SizeId { get; set; }
      public Nullable<int> OrderId { get; set; }
      public virtual CrustDTO Crust { get; set; }
      public virtual OrderDTO Order { get; set; }
      public virtual SauceDTO Sauce { get; set; }
      public virtual SizeDTO Size { get; set; }
      public List<ToppingDTO> toppings { get; set; }
      public List<CheeseDTO> cheeses { get; set; }
      //public int Id { get; set; }


      //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
      //public virtual ICollection<PizzaCheeseDTO> PizzaCheese { get; set; }
      //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
      //public virtual ICollection<PizzaToppingDTO> PizzaToppings { get; set; }
   }
}