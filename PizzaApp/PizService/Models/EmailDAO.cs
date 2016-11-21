using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PizService.Models
{
   [DataContract(IsReference = true)]

   //[DataContract]
   public class EmailDAO
   {
      
      //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
      //public EmailDAO()
      //{
      //   this.Customers = new HashSet<CustomerDAO>();
      //}
      [DataMember]
      public int Id { get; set; }
      [DataMember]
      public string EmailString { get; set; }
      //[DataMember]
      //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
      //public virtual ICollection<CustomerDAO> Customers { get; set; }
   }
}
