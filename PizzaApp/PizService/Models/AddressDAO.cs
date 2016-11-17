using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PizService.Models
{
   //[DataContract]
   [DataContract]
   public class AddressDAO
   {
     
      [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
      public AddressDAO()
      {
         this.CustomersDAO = new HashSet<CustomerDAO>();
         this.StoresDAO = new HashSet<StoreDAO>();
      }
      [DataMember]
      public int Id { get; set; }
      [DataMember]
      public int Id { get; set; }
      [DataMember]
      public string Street { get; set; }
      [DataMember]
      public string City { get; set; }
      [DataMember]
      public string State { get; set; }
      [DataMember]
      public string Zip { get; set; }
      [DataMember]
      public bool Active { get; set; }
      [DataMember]
      [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
      public virtual ICollection<CustomerDAO> CustomersDAO { get; set; }
      [DataMember]
      [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
      public virtual ICollection<StoreDAO> StoresDAO { get; set; }
   }
}
