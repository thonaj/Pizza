using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PizService.Models
{
   [DataContract]
    public class SizeDAO
   {
      [DataMember]
      public string Name { get; set; }
      [DataMember]
      public decimal Value { get; set; }
   }
}
