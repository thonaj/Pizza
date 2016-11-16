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
      [DataMember]
      public string First { get; set; }
      [DataMember]
      public string Last { get; set; }
      
      public override string ToString()
      {
         return string.Format("{0} {1}", First, Last);
      }
   }
}
