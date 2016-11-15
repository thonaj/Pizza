using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaService.Models;
using Pizza.DAL;
using System.Runtime.Serialization;

namespace PizzaService.Models
{
   [DataContract]
   public class CustomerDAO
   {
      [DataMember]
      public virtual Address Address { get; set; }
      [DataMember]
      public virtual Name Name { get; set; }
      [DataMember]
      public virtual Email Email { get; set; }
      [DataMember]
      public virtual Phone Phone { get; set; }
      [DataMember]
      public virtual ICollection<CustomerOrder> CustomerOrders { get; set; }
   }
}
