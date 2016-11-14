//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pizza.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pizza
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pizza()
        {
            this.PizzaCheese = new HashSet<PizzaCheese>();
            this.PizzaOrders = new HashSet<PizzaOrder>();
            this.PizzaToppings = new HashSet<PizzaTopping>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public int CrustId { get; set; }
        public int SauceId { get; set; }
        public int SizeId { get; set; }
        public int PizzaCheeseId { get; set; }
        public int PizzaToppingId { get; set; }
    
        public virtual Crust Crust { get; set; }
        public virtual Sauce Sauce { get; set; }
        public virtual Size Size { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PizzaCheese> PizzaCheese { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PizzaOrder> PizzaOrders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PizzaTopping> PizzaToppings { get; set; }
    }
}
