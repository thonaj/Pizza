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
    
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.CustomerOrders = new HashSet<CustomerOrder>();
        }
    
        public int Id { get; set; }
        public int NameId { get; set; }
        public bool Active { get; set; }
        public int AddressId { get; set; }
        public int PhoneId { get; set; }
        public int EmailId { get; set; }
        public Nullable<int> CustomerOrderId { get; set; }
    
        public virtual Address Address { get; set; }
        public virtual Name Name { get; set; }
        public virtual Email Email { get; set; }
        public virtual Phone Phone { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerOrder> CustomerOrders { get; set; }
    }
}
