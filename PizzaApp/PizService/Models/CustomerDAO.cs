using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Runtime.Serialization;
using Piz.DataAccess;

namespace PizService.Models
{
   [DataContract(IsReference = true)]
   //[DataContract]
   public class CustomerDAO
   {
      [DataMember]
      public int Id { get; set; }
      [DataMember]
      public int NameId { get; set; }     
      [DataMember]
      public int AddressId { get; set; }
      [DataMember]
      public int PhoneId { get; set; }
      [DataMember]
      public int EmailId { get; set; }
      [DataMember]
      public virtual AddressDAO Address { get; set; }
      [DataMember]
      public virtual NameDAO Name { get; set; }
      [DataMember]
      public virtual EmailDAO Email { get; set; }
      [DataMember]
      public virtual PhoneDAO Phone { get; set; }
      [DataMember]
      [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
      public virtual ICollection<OrderDAO> Orders { get; set; }
   }
}
