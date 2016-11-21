using Piz.DataAccess;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PizService.Models
{
   [DataContract]
   public class StoreDAO
   {
      
      //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
      //public StoreDAO()
      //{
      //   this.Orders = new HashSet<OrderDAO>();
      //}
      [DataMember]
      public int Id { get; set; }
      [DataMember]
      public string LocationId { get; set; }
      [DataMember]
      public int AddressId { get; set; }
      [DataMember]
      public int PhoneId { get; set; }
      [DataMember]
      public virtual AddressDAO Address { get; set; }
      //[DataMember]
      //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
      //public virtual ICollection<OrderDAO> Orders { get; set; }
      //[DataMember]
      [DataMember]
      public virtual PhoneDAO Phone { get; set; }
   }
}
