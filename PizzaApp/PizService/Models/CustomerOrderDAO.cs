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
   public class CustomerOrderDAO
   {
      [DataMember]
      public virtual Customer Customer { get; set; }
      [DataMember]
      public virtual Order Order { get; set; }
   }
}
