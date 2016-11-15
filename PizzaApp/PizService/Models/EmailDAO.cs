using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PizService.Models
{
   [DataContract]
   public class EmailDAO
   {
      [DataMember]
      public string EmailString { get; set; }
   }
}
