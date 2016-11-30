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
      
   }
}
