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
   public class PhoneDAO
   {
      [DataMember]
      public string Number { get; set; }
      [DataMember]
      public int Id { get; set; }
   }
}
