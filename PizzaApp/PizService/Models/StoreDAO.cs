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
      
      [DataMember]
      public virtual PhoneDAO Phone { get; set; }
   }
}
