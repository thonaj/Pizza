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
      public string LocationId { get; set; }
      [DataMember]
      public virtual Address Address { get; set; }
      [DataMember]
      public virtual ICollection<Order> Orders { get; set; }
      [DataMember]
      public virtual Phone Phone { get; set; }
   }
}
