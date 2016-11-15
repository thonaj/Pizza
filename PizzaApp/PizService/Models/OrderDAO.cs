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
   public class OrderDAO
   {
      [DataMember]
      public string Name { get; set; }
      [DataMember]
      public decimal Value { get; set; }
      [DataMember]
      public virtual Store Store { get; set; }
      [DataMember]
      public virtual ICollection<PizzaOrder> PizzaOrders { get; set; }
   }
}
