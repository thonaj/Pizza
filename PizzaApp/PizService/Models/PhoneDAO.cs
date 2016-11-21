using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PizService.Models
{
   //[DataContract]
   [DataContract(IsReference = true)]
   public class PhoneDAO
   {
      [DataMember]
      public string Number { get; set; }
      [DataMember]
      public int Id { get; set; }
      //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
      //public PhoneDAO()
      //{
      //   this.Customers = new HashSet<CustomerDAO>();
      //   this.Stores = new HashSet<StoreDAO>();
      //}
      [DataMember]
      public bool Active { get; set; }
      //[DataMember]
      //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
      //public virtual ICollection<CustomerDAO> Customers { get; set; }
      //[DataMember]
      //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
      //public virtual ICollection<StoreDAO> Stores { get; set; }
   }
}
