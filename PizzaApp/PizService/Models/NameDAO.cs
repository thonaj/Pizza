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
   public class NameDAO
   {
      
      //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
      //public NameDAO()
      //{
      //   this.Customers = new HashSet<CustomerDAO>();
      //}
      [DataMember]
      public int Id { get; set; }
      [DataMember]
      public string First { get; set; }
      [DataMember]
      public string Last { get; set; }
      //[DataMember]
      //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
      //public virtual ICollection<CustomerDAO> Customers { get; set; }
   }
}
