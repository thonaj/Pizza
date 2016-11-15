using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PizService.Models
{
   [DataContract]
   public class AddressDAO
   {
      [DataMember]
      public string Street { get; set; }
      [DataMember]
      public string City { get; set; }
      [DataMember]
      public string State { get; set; }
      [DataMember]
      public string Zip { get; set; }
   }
}
